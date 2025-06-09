using DotNetMaui.Shared.Services;
using DotNetMaui.Web.Client.Components; // We will create this component next
using DotNetMaui.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add this line to tell Blazor where the app starts
builder.RootComponents.Add<App>("#app");

// Add this line to register the device-specific service
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();