using BlazorApp.Data;
using BlazorApp.Service;
using BlazorApp.Store;
using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<ICounterService, CounterService>();
builder.Services.AddSingleton<GlobalStateService>();
builder.Services.AddScoped<AppState>();
// 注册 HttpClient
builder.Services.AddHttpClient();
// 注册 Fluxor - 这是关键！
builder.Services.AddFluxor(options =>
{
    options.ScanAssemblies(typeof(Program).Assembly);
    // 或者明确指定包含状态的程序集
    options.ScanAssemblies(typeof(CounterReducers).Assembly);
    // 对于 Blazor Server，使用同步启动
    options.UseRouting();

#if DEBUG
    options.UseReduxDevTools();
#endif
});


// Program.cs 中的路由配置
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;    // 将 URL 转换为小写
    options.LowercaseQueryStrings = true;    // 将查询字符串转换为小写
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
