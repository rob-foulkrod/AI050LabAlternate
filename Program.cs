using AI050LabAlternate.Components;
using Azure.AI.OpenAI;
using AI050LabAlternate.Data;
using Azure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register factory and configure the options


var openAIConfig = new OpenAIConfig
{
    OpenAIURI = builder.Configuration["OpenAI:Uri"] ?? OpenAIConfig.AzureOpenAIEndpointDefault,
    OpenAIKey = builder.Configuration["OpenAI:Key"] ?? OpenAIConfig.AzureOpenAIKeyDefault,
    DeploymentName = builder.Configuration["OpenAI:DeploymentName"] ?? "",
    Version = builder.Configuration["OpenAI:Version"] ?? "",
    SearchEndpoint = builder.Configuration["OpenAI:SearchEndpoint"] ?? "",
    SearchKey = builder.Configuration["OpenAI:SearchKey"] ?? "",
    SearchIndexName = builder.Configuration["OpenAI:SearchIndexName"] ?? ""
};

builder.Services.AddSingleton(openAIConfig);

builder.Services.AddSingleton(new OpenAIClient(new Uri(openAIConfig.OpenAIURI), new AzureKeyCredential(openAIConfig.OpenAIKey)));


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
