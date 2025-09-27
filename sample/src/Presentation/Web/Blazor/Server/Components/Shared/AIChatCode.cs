using Cheetah.Sample.Presentation.Web.Blazor.Server.AI;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;
using Markdig;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.AudioToText;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.InMemory;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Embeddings;
using Microsoft.SemanticKernel.TextToAudio;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Shared;

public class AIChatCode : MyComponentBase
{
    [Parameter]
    public int UserGuideId { get; set; } = 0;
    protected bool isRecording = false;
    protected string audioUrl;
    protected string audioData; // This will hold the base64 string
    protected string result = string.Empty;
    protected string AvashoToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzeXN0ZW0iOiJzYWhhYiIsImNyZWF0ZVRpbWUiOiIxNDAzMDkxMzEzMjkxOTUzOCIsInVuaXF1ZUZpZWxkcyI6eyJ1c2VybmFtZSI6Ijk1YjYwNDQyLWQ1ODgtNDg2NC04ODY1LTJiNjFiMzg5NjNkZiJ9LCJkYXRhIjp7InNlcnZpY2VJRCI6ImRmNTNhNzgwLTIxNTgtNDUyNC05MjQ3LWM2ZjBiYWQzZTc3MCIsInJhbmRvbVRleHQiOiI1ZlQzQyJ9LCJncm91cE5hbWUiOiI4MzM3ZjhmOGE5MjUyOWY0YTIwNmFmMzI4MTYzOTYyYyJ9.glBuR7NC--H-JqmVxuHsizkFmlgXJd0ZZ36lRlzTULE";
    protected string AvanegarToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzeXN0ZW0iOiJzYWhhYiIsImNyZWF0ZVRpbWUiOiIxNDAzMTIxNzE0MzgwMDM0MCIsInVuaXF1ZUZpZWxkcyI6eyJ1c2VybmFtZSI6Ijk1YjYwNDQyLWQ1ODgtNDg2NC04ODY1LTJiNjFiMzg5NjNkZiJ9LCJkYXRhIjp7InNlcnZpY2VJRCI6IjlmMjE1NjVjLTcxZmEtNDViMy1hZDQwLTM4ZmY2YTZjNWM2OCIsInJhbmRvbVRleHQiOiJXVjVFQSJ9LCJncm91cE5hbWUiOiI3ZWVmZGZkMjk4ZGNlYTRjNjY1YTM2ZDA1NTQ4MjhkYSJ9.ShiqUN5zC1Xkmp9JSJ9lqE0ppayEEyKlq38w-DLPyIg";
    protected string avalAi = "aa-2GJjxrO08MEOCCTbdwFQikmMN3WaBPDaW9oN0hVLARCrx39N";
    protected string avalAIAddress = "https://api.avalai.ir/v1";
    protected string vts = "whisper-1";
    protected async Task StartRecording()
    {
        try
        {
            isRecording = true;
            await _JSRuntime.InvokeVoidAsync("startRecording");
            result = "started";
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error starting recording: {ex.Message}");
            result = ex.Message;
            StateHasChanged();
        }
    }
    protected async Task<string> Avasho()
    {
        string text = _aIResponse.Replace("#", string.Empty);
        _chathistory.AddAssistantMessage(_aIResponse);
        using (var client = new HttpClient())
        {
            // Set the base address
            var _uri = new Uri("https://partai.gw.isahab.ir/TextToSpeech/v1/speech-synthesys");

            // Set request headers
            client.DefaultRequestHeaders.Add("gateway-token", AvashoToken); // Add your token here

            // Create the JSON body
            var body = new
            {
                data = text,
                filePath = true,
                base64 = "0",
                checksum = "1",
                speaker = "3"
            };

            // Serialize the body to JSON
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // Send the POST request
                var response = await client.PostAsync(_uri, content);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the response content
                var responseContent = await response.Content.ReadAsStringAsync();
                // Parse the JSON response to extract filePath
                using (JsonDocument doc = JsonDocument.Parse(responseContent))
                {
                    // Navigate to the filePath
                    var filePath = doc.RootElement
                        .GetProperty("data")
                        .GetProperty("data")
                        .GetProperty("filePath")
                        .GetString();

                    return @"https://" + filePath;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
        return string.Empty;
    }
    protected async Task<string> Datacula()
    {
        // Define the text and model name
        string text = _aIResponse;
        string modelName = "گنجی";

        // Encode the text and model name for the URL
        string encodedText = Uri.EscapeDataString(text);
        string encodedModelName = Uri.EscapeDataString(modelName);

        // Create the request URL
        string url = $"https://tts.datacula.com/api/tts?text={encodedText}&model_name={encodedModelName}";

        // Create an instance of HttpClient
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send the GET request
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the response as a byte array (audio data)
                byte[] audioData = await response.Content.ReadAsByteArrayAsync();

                // Save the audio data to a file
                //System.IO.File.WriteAllBytes("output.wav", audioData);

                _chathistory.AddAssistantMessage(_aIResponse);
                var _inputVoice = _aIResponse;

                // Save audio content to file
                string outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\AudioOutputs");
                Directory.CreateDirectory(outputFolder); // Create directory if it doesn't exist

                string audioFileName = $"{DateTime.Now:yyyyMMddHHmmssfff}.wav"; // Unique filename based on timestamp
                string audioFilePath = Path.Combine(outputFolder, audioFileName);

                // Write the audio data to a file
                await File.WriteAllBytesAsync(audioFilePath, audioData);

                Console.WriteLine("Audio has been saved as output.wav");

                return $@"AudioOutputs\{audioFileName}";


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return encodedModelName;
            }
        }
    }
    protected async Task<string> tts()
    {
#pragma warning disable SKEXP0001
#pragma warning disable CS1929
#pragma warning disable SKEXP0010

        var _kernel2 = Kernel.CreateBuilder()
              .AddOpenAITextToAudio(modelId: "tts-1",
              apiKey: "aa-2GJjxrO08MEOCCTbdwFQikmMN3WaBPDaW9oN0hVLARCrx39N",
              httpClient: new HttpClient { BaseAddress = new Uri("https://api.avalai.ir/v1") })
              .Build();

        // new HttpClient { BaseAddress = new Uri("https://api.avalai.ir/v1")) }

        var texttoAudio = _kernel2.GetRequiredService<ITextToAudioService>();

        OpenAITextToAudioExecutionSettings openAITextToAudioExecutionSettings = new()
        {
            Voice = "Onyx", // The voice to use when generating the audio.
                            // Supported voices are alloy, echo, fable, onyx, nova, and shimmer.
            ResponseFormat = "wav", // The format to audio in.
                                    // Supported formats are mp3, opus, aac, and flac.
            Speed = 1.1f // The speed of the generated audio.
                         // Select a value from 0.25 to 4.0. 1.0 is the default.
        };

        // _hTMLResponse = Markdown.ToHtml(_aIResponse, pipeline);
        // StateHasChanged();
        _chathistory.AddAssistantMessage(_aIResponse);
        var _inputVoice = _aIResponse;

        var _audio = await texttoAudio.GetAudioContentAsync(_inputVoice, openAITextToAudioExecutionSettings);

        // Save audio content to file
        string outputFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\AudioOutputs");
        Directory.CreateDirectory(outputFolder); // Create directory if it doesn't exist

        string audioFileName = $"{DateTime.Now:yyyy-MMddHHmmssfff}.wav"; // Unique filename based on timestamp
        string audioFilePath = Path.Combine(outputFolder, audioFileName);

        // Write the audio data to a file
        await File.WriteAllBytesAsync(audioFilePath, _audio.Data.Value.ToArray());

        return $@"AudioOutputs\{audioFileName}";

    }
    protected async Task<string> AvanegarVTT(string inputContent)
    {
        //return inputContent;
        try
        {
            using (var client = new HttpClient())
            {
                // Set the base address
                var _uri = new Uri("https://partai.gw.isahab.ir/speechRecognition/v1/base64");

                // Set request headers
                client.DefaultRequestHeaders.Add("gateway-token", AvanegarToken); // Add your token here

                // Create the JSON body
                var body = new
                {
                    language = "fa",
                    data = inputContent,
                    model = "telephony"
                };

                // Serialize the body to JSON
                var json = JsonSerializer.Serialize(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync(_uri, content);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the response content
                var responseContent = await response.Content.ReadAsStringAsync();
                // Parse the JSON response to extract filePath
                using (JsonDocument doc = JsonDocument.Parse(responseContent))
                {
                    // Navigate to the filePath
                    var textData = doc.RootElement
                        .GetProperty("data")
                        .GetProperty("data")
                        .GetProperty("result")
                        .GetString();

                    return textData;
                }
            }
        }
        catch (HttpRequestException e)
        {
            return $"Request error: {e.Message}";
        }
    }
    protected async Task<string> OpenAIVTT(byte[] inputContent)
    {
#pragma warning disable SKEXP0001
#pragma warning disable CS1929
#pragma warning disable SKEXP0010

        var audiokernel = Kernel.CreateBuilder()
         .AddOpenAIAudioToText(modelId: vts,
          apiKey: avalAi,
          httpClient: new HttpClient { BaseAddress = new Uri(avalAIAddress) })
         .Build();

        var audioToTextService = audiokernel.GetRequiredService<IAudioToTextService>();

        // Set execution settings (optional)
        OpenAIAudioToTextExecutionSettings _audioexecutionSettings = new OpenAIAudioToTextExecutionSettings()
        {
            Language = "fa", // The language of the audio data as two-letter ISO-639-1 language code (e.g. 'en' or 'es').
            Prompt = "زبان فارسی معیار ایران", // An optional text to guide the model's style or continue a previous audio segment.
                                               //                                                 // The prompt should match the audio language.
            ResponseFormat = "json", // The format to return the transcribed text in.
                                     // Supported formats are json, text, srt, verbose_json, or vtt. Default is 'json'.
            Temperature = 0.3f, // The randomness of the generated text.
                                // Select a value from 0.0 to 1.0. 0 is the default.
        };

        // Step 2: Create an instance of AudioContent
        string mimeType = "audio/wav"; // MIME type for WAV files

        var audioContent = new AudioContent(inputContent, mimeType);

        var textContent = await audioToTextService.GetTextContentAsync(audioContent, _audioexecutionSettings);

        return textContent.Text!;
    }
    protected async Task StopRecording()
    {
        try
        {
            isRecording = false;
            audioData = await _JSRuntime.InvokeAsync<string>("stopRecording");
            // Extract only the Base64 part
            string base64Data = audioData.Substring(audioData.IndexOf(",") + 1);
            // Decode the base64 string into a byte array
            byte[] inputContent = Convert.FromBase64String(base64Data);
            //var textContent = await OpenAIVTT(inputContent);
            var textContent = await AvanegarVTT(base64Data);

            // Output the transcribed text
            userInput = textContent;
            await SendMessage(nameof(Avasho));
            StateHasChanged();

            Console.WriteLine("Recording stopped successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error stopping recording: {ex.Message}");

        }
    }

    protected string userInput = string.Empty;
    protected string question = string.Empty;
    protected ChatHistory _chathistory = new();
    protected string _aIResponse = string.Empty;
    protected string _hTMLResponse = string.Empty;
    protected bool disableSubmit = false;
    protected List<UserGuideItem>? items = new();
    protected MudTextField<string> _MudTextField = new();
    protected async Task InputTextChanged(string value)
    {
        /*

        var kernel = Kernel.CreateBuilder()
        .AddOpenAIAudioToText("aa-2GJjxrO08MEOCCTbdwFQikmMN3WaBPDaW9oN0hVLARCrx39N", "whisper-1", "https://api.avalai.ir/v1")
    .Build();

    var audioToTextService = kernel.GetRequiredService<IAudioToTextService>();

    // Set execution settings (optional)
    OpenAIAudioToTextExecutionSettings executionSettings = new OpenAIAudioToTextExecutionSettings()
            {
            Language = "fa", // The language of the audio data as two-letter ISO-639-1 language code (e.g. 'en' or 'es').
            Prompt = "sample prompt", // An optional text to guide the model's style or continue a previous audio segment.
            // The prompt should match the audio language.
            ResponseFormat = "json", // The format to return the transcribed text in.
                                     // Supported formats are json, text, srt, verbose_json, or vtt. Default is 'json'.
            Temperature = 0.3f, // The randomness of the generated text.
        // Select a value from 0.0 to 1.0. 0 is the default.
    };

    var baseUri = navigationManager.BaseUri + "AI_WISPER.wav";


    byte[] audioData = File.ReadAllBytes(baseUri);

    // Step 2: Create an instance of AudioContent
    string mimeType = "audio/wav"; // MIME type for WAV files

    var audioContent = new Microsoft.SemanticKernel.AudioContent(audioData, mimeType);
    var textContent = await audioToTextService.GetTextContentAsync(audioContent, executionSettings);

    // Output the transcribed text
    Console.WriteLine(textContent.Text);

    #pragma warning restore SKEXP0010
           #pragma warning restore SKEXP0001
    ////////////////////////

           */

        if (!string.IsNullOrEmpty(value) && value.TrimEnd().EndsWith("ارسال"))
        {
            await SendMessage(nameof(Avasho));
            await _MudTextField.Clear();
            await _MudTextField.FocusAsync();
        }
    }

    OpenAIPromptExecutionSettings executionSettings = new OpenAIPromptExecutionSettings
    {
        //Temperature = 0.0,
        //TopP = 1,
        //Seed = 0
    };
    protected async Task HandleKeyDown(KeyboardEventArgs e)
    {
        // Check if the Enter key was pressed
        if (e.Key == "Enter")
        {
            await AccurateSearch();
            await _MudTextField.Clear();
            await _MudTextField.FocusAsync();
        }
    }
    IVectorStoreRecordCollection<long, UserGuideItem> collection;

    protected ReadOnlyMemory<float> GetVector(byte[] inputByte)
    {
        float[] array = new float[inputByte.Length / sizeof(float)];
        Buffer.BlockCopy(inputByte, 0, array, 0, inputByte.Length);
        return new ReadOnlyMemory<float>(array);
    }
    public async Task<ReadOnlyMemory<float>> TextEmbedding(string Text)
    {
#pragma warning disable SKEXP0001
        var _embedingText = _kernel.GetRequiredService<ITextEmbeddingGenerationService>();

        IList<ReadOnlyMemory<float>> embeddings =
            await _embedingText.GenerateEmbeddingsAsync(
                [
                    Text
                ]);
        return embeddings[0];
    }
    List<UserGuideItem> _UserGuideItem = new();
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await _JSRuntime.InvokeVoidAsync("startHints");
            items = (await GetAllItems()).ToList();
#pragma warning disable CS0029
            collection = new InMemoryVectorStoreRecordCollection<long, UserGuideItem>("userguideiItems");
            // Create the collection if it doesn't exist yet.
            await collection.CreateCollectionIfNotExistsAsync();
            foreach (var item in items)
            {
                item.FloatVectorBody = GetVector(item.VectorBody);
                await collection.UpsertAsync(item);

                //_chathistory.AddSystemMessage(nameof(item.JsonData) + ":" +
                //item.JsonData + "\n" +
                //nameof(item.Body) + ":" + item.Body + "\n"
                //);
            }

            _chathistory.AddSystemMessage("Limit responses to 300 characters.");

            // StateHasChanged();
        }
        await _MudTextField.FocusAsync();
    }
    protected async Task AccurateSearch()
    {
        executionSettings = new OpenAIPromptExecutionSettings
        {
            Temperature = 0.0,
            TopP = 1,
            Seed = 0
        };

        if (UserGuideId == 0)
        {
            StringBuilder _systemMessage = new();

            _systemMessage.AppendLine("Only respond using the information from my previous system messages.");
            _systemMessage.AppendLine("Your answers should be highly accurate and focus solely on that information.");
            _systemMessage.AppendLine("Inform the user that you can only address the topics listed below, show all topics to user: ");

            foreach (var item in items.Select(x => x.JsonData))
            {
                _systemMessage.AppendLine(item);
            }
            _chathistory.AddSystemMessage(_systemMessage.ToString());
        }

        await SendMessage(nameof(Avasho));
    }
    protected async Task StandardSearch()
    {
        executionSettings = new OpenAIPromptExecutionSettings
        {
            //Temperature = 0.0,
            //TopP = 1,
            //Seed = 0
        };
        _chathistory.AddSystemMessage("خیلی ادبی پاسخ بده");
        await SendMessage(nameof(Datacula));
    }
    protected async Task SendMessage()
    {
        await SendMessage(nameof(Avasho));
    }
    protected async Task SendMessage(string Narrator)
    {
        if (!string.IsNullOrWhiteSpace(userInput))
        {
            userInput = userInput.TrimEnd("ارسال".ToCharArray());
            question = userInput;
            disableSubmit = true;
            _aIResponse = string.Empty;

            if (UserGuideId == 0)
            {
                // Generate a vector for your search text, using your chosen embedding generation implementation.
                ReadOnlyMemory<float> searchVector = await TextEmbedding(question);

                // Do the search
                var searchResult = await collection.VectorizedSearchAsync(searchVector, new() { Top = 3 });

                // Inspect the returned hotel.
                await foreach (var record in searchResult.Results)
                {
                    if (!_UserGuideItem.Any(x => x.Id == record.Record.Id) && record.Score < 0.6)
                    {
                        _UserGuideItem.Add(record.Record);
                        _chathistory.AddSystemMessage(nameof(record.Record.JsonData) + ":" +
                        record.Record.JsonData + "\n" +
                        nameof(record.Record.Body) + ":" + record.Record.Body + "\n");
                    }
                }
            }
            else if (_UserGuideItem.Count == 0)
            {
                var record = items.Where(x => x.Id == UserGuideId).SingleOrDefault();
                _UserGuideItem.Add(record);
                _chathistory.AddSystemMessage(nameof(record.JsonData) + ":" +
                    record.JsonData + "\n" +
                    nameof(record.Body) + ":" + record.Body + "\n");

                _chathistory.AddSystemMessage("Response based on the above System Message");
            }

            _chathistory.AddUserMessage(question.Replace("voice", string.Empty));

            question = userInput;

            var pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions() // This includes the table extension
            .Build();

            var wholeResponse = await ChatCompletionService.GetChatMessageContentsAsync(
                chatHistory: _chathistory,
                executionSettings: executionSettings);

            foreach (var response in wholeResponse)
            {
                _aIResponse += response;
                _hTMLResponse = Markdown.ToHtml(_aIResponse, pipeline);
                StateHasChanged();
            }

            

            /*
            var response = ChatCompletionService
            .GetStreamingChatMessageContentsAsync(
                chatHistory: _chathistory,
                executionSettings: executionSettings
            );


            await foreach (var chunk in response)
            {
                _aIResponse += chunk;
                _hTMLResponse = Markdown.ToHtml(_aIResponse, pipeline);
                // Sanitize the HTML
                // var sanitizer = new HtmlSanitizer();
                // _hTMLResponse = sanitizer.Sanitize(html);
                StateHasChanged();
            }
            */

            string _filePath = string.Empty;
            switch (Narrator)
            {
                case nameof(Datacula):
                    _filePath = await Datacula();
                    break;
                case nameof(Avasho):
                    _filePath = await Avasho();
                    break;
                default:
                    break;
            }

            //var _filePath = await tts();

            await _JSRuntime.InvokeVoidAsync("changeMusic", _filePath);

            _aIResponse = "";
            userInput = string.Empty;
            disableSubmit = false;
            StateHasChanged();
        }
    }
    protected async Task<IEnumerable<UserGuideItem>?> GetAllItems()
    {
        items = await httpClient
        .GetFromJsonAsync<List<UserGuideItem>>("AI/Queries/ListUserGuides");
        var _items = items.Take(1000);
        return _items;
    }
}
