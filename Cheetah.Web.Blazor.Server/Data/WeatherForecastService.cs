namespace Cheetah.Web.Blazor.Server.Data;

public class WeatherForecastService
{
    private static readonly string[] ProcessNames = new[]
    {
        "درخواست کالا", "درخواست وجه", "درخواست مرخصی", "درخواست ماموریت", "درخواست وام", "مدریت تعمیر و نگهداری", "مدیریت دارایی ها", "انتقادات و پیشنهادات", "تسویه حساب", "درخواست تعمیر ضروری"
    };
    private static readonly string[] Creators = new[]
    {
        "محمدامین شریفی","محمدامیر شریفی","محمدامین حسینی","محمد شریفی","امین شریفی"
    };

    private static readonly string[] TaskNames = new[]
    {
        "ثبت درخواست","بررسی کارشناسی","بررسی مدیریت"
    };
    public Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            CreateDate = startDate.AddDays(index),
            RadNumber = Random.Shared.Next(2500, 3000).ToString(),
            Creator = Creators[Random.Shared.Next(Creators.Length)],
            ProcessName = ProcessNames[Random.Shared.Next(ProcessNames.Length)],
            TaskName = TaskNames[Random.Shared.Next(TaskNames.Length)]
        }).AsEnumerable<WeatherForecast>());
    }
}