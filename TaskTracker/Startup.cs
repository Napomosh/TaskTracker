namespace TaskTracker;

public class Startup{
    public static void ConfigureServices(IServiceCollection service){
        service.AddRazorPages();
    }

    public static void Configure(IApplicationBuilder app, IHostEnvironment env){
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();
        else
            app.UseExceptionHandler("/Error");
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints => {
            endpoints.MapRazorPages();
        });
    }
}