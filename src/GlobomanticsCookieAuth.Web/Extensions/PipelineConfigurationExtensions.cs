namespace GlobomanticsCookieAuth.Web.Extensions;

public static class PipelineConfigurationExtensions
{
    public static void UseConfiguredPipeline(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(name: "default", pattern: "{controller=Conference}/{action=Index}/{id?}");
    }
}
