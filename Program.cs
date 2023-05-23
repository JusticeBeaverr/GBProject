using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using GadgetBlitzPZ;
using GadgetBlitzPZ.Services.NavigationService;
using GadgetBlitzPZ.Services.Smartphone;
using GadgetBlitzPZ.ViewModels.Smartphone;
using GadgetBlitzPZ.ViewModels.User;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<INavigationService, NavigationService>();

builder.Services.AddScoped<ISmartphoneService, SmartphoneService>();

builder.Services.AddScoped<ISmartphoneViewModel, SmartphoneViewModel>();
builder.Services.AddScoped<IUserViewModel, UserViewModel>();

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
