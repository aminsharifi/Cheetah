using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;
using KristofferStrube.Blazor.DOM;
using KristofferStrube.Blazor.FileAPI;
using KristofferStrube.Blazor.MediaCaptureStreams;
using KristofferStrube.Blazor.MediaStreamRecording;
using KristofferStrube.Blazor.WebIDL.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Pages;

public class AudioPage_Code : MyComponentBase
{
    public string? deviceLabel;
    public string? error;
    [Inject] public IMediaDevicesService MediaDevicesService { get; set; } = default!;

    public async Task Open()
    {
        try
        {
            MediaDevices mediaDevices = await MediaDevicesService.GetMediaDevicesAsync();
            MediaStream mediaStream = await mediaDevices.GetUserMediaAsync(new MediaStreamConstraints() { Audio = true });
            MediaStreamTrack[] audioTracks = await mediaStream.GetAudioTracksAsync();
            deviceLabel = await audioTracks.First().GetLabelAsync();

            // List to collect each recording part.
            List<Blob> blobsRecorded = new();

            // Create new MediaRecorder from some existing MediaStream.
            await using MediaRecorder recorder = await MediaRecorder.CreateAsync(_JSRuntime, mediaStream);

            // Add event listener for when each data part is available.
            await using var dataAvailableEventListener =
                await EventListener<BlobEvent>.CreateAsync(_JSRuntime, async (BlobEvent e) =>
                {
                    Blob blob = await e.GetDataAsync();
                    blobsRecorded.Add(blob);
                });
            await recorder.AddOnDataAvailableEventListenerAsync(dataAvailableEventListener);

            // Starts Recording
            await recorder.StartAsync();

            // Records for 5 seconds.
            await Task.Delay(3000);

            // Stops recording
            await recorder.StopAsync();

            // Combines and collects the total audio data.
            Blob combinedBlob = await Blob.CreateAsync(_JSRuntime, [.. blobsRecorded]);
            byte[] audioData = await combinedBlob.ArrayBufferAsync();
            await combinedBlob.JSReference.DisposeAsync();

            // Dispose of blob parts created while recording.
            foreach (Blob blob in blobsRecorded)
                await blob.JSReference.DisposeAsync();

            deviceLabel = "Ok!";
        }
        catch (WebIDLException ex)
        {
            error = $"{ex.GetType().Name}: {ex.Message}";
            deviceLabel = error;
        }
    }
    public async Task Save()
    {
      
    }
}
