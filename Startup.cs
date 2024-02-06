public void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IDataService, LocalDataService>();
    services.AddDbContextFactory<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddQuickTableEntityFrameworkAdapter();
    services.AddRazorPages();
    services.AddServerSideBlazor();
    
    services.AddScoped<ICodeSnippetService, LocalSnippetService>();
    services.AddDocs();
}




{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=YourDatabase;User=YourUser;Password=YourPassword;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
