using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DAL;
using DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace SteamSupreme
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
      builder.Services.AddSingleton<AccountRepository>();
      builder.Services.AddSingleton<CompanyRepository>();
      builder.Services.AddSingleton<GameRepository>();
      builder.Services.AddSingleton<OrderRepository>();
      builder.Services.AddSingleton<SettingsRepository>();
      builder.Services.AddSingleton<UserRepository>();

      builder.Services.AddServerSideBlazor();

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

      app.UseRouting();

      app.MapBlazorHub();
      app.MapFallbackToPage("/_Host");

      app.Run();
    }
  }
}