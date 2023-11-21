using AI050LabAlternate.Components;
using Azure.AI.OpenAI;
using AI050LabAlternate.Data;
using AI050LabAlternate.Grid;
using Azure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register factory and configure the options


var openAIConfig = new OpenAIConfig
{
    DeploymentName = builder.Configuration["OpenAI:DeploymentName"] ?? throw new Exception("Did not find OpenAI:DeploymentName in configuration"),
    Version = builder.Configuration["OpenAI:Version"] ?? ""
};

builder.Services.AddSingleton(openAIConfig);


var uri = builder.Configuration["OpenAI:Uri"] ?? throw new Exception("Did not find OpenAI:Uri in configuration");
var key = builder.Configuration["OpenAI:Key"] ?? throw new Exception("Did not find OpenAI:Key in configuration");

builder.Services.AddSingleton(new OpenAIClient(new Uri(uri), new AzureKeyCredential(key)));

// Pager
builder.Services.AddScoped<IPageHelper, PageHelper>();

// Filters
builder.Services.AddScoped<IContactFilters, GridControls>();


// Service to communicate success on edit between pages
builder.Services.AddScoped<EditSuccess>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
