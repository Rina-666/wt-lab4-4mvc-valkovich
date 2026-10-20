using Microsoft.AspNetCore.StaticFiles; // <-- ВАЖНО: Добавляем это!

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ContentRootPath = Directory.GetCurrentDirectory(),
    WebRootPath = "wwwroot"
});

// Указываем серверу, как правильно отдавать видеофайлы
builder.Services.Configure<StaticFileOptions>(options =>
{
    options.ServeUnknownFileTypes = true;
    options.DefaultContentType = "application/octet-stream";
});

var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".mp4"] = "video/mp4";
provider.Mappings[".webm"] = "video/webm";
builder.Services.AddSingleton<IContentTypeProvider>(provider);

// Добавляем поддержку Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// Подключаем статические файлы
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Включаем маршрутизацию Razor Pages
app.MapRazorPages();

// Настройка для Render (порт)
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Run($"http://0.0.0.0:{port}");