using Gotorz.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authentication;
using Gotorz.Auth;
using Gotorz.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Add authentication and authorization services
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

Console.WriteLine($"[DEBUG] Environment: {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}");
Console.WriteLine($"[DEBUG] Current Environment: {builder.Environment.EnvironmentName}");

// Pulls the BaseURL from the AuthAndUserAPI and registers the service
var apiBaseUrl = builder.Configuration["AuthAndUserAPI:BaseUrl"];
Console.WriteLine($"[DEBUG] AuthAndUserAPIUrl: {apiBaseUrl}");
Console.WriteLine($"[DEBUG] TravelAPI Url: {builder.Configuration["TravelApi:BaseUrl"]}");



builder.Services.AddHttpClient("AuthAndUserAPI", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});


builder.Services.AddScoped(sp =>
{
    var nav = sp.GetRequiredService<NavigationManager>();
    return new HttpClient { BaseAddress = new Uri(nav.BaseUri) };
});

builder.Services.AddScoped<ITravelService, TravelService>();

builder.Services.AddScoped<JwtAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<JwtAuthenticationStateProvider>());


builder.Services.AddAuthorizationCore();

// Dummy authservice to ensure that AuthorizeView works in razor components
builder.Services.AddAuthentication("DummyScheme")
    .AddScheme<AuthenticationSchemeOptions, DummyAuthHandler>("DummyScheme", options => { });



builder.Services.AddAntiforgery();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting(); // enables endpoint routing
app.UseAuthentication();
app.UseAuthorization(); 
app.UseAntiforgery();




app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Gotorz.Client._Imports).Assembly);

app.Run();
