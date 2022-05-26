namespace OptionActions.WebApp
{
    public static class StartupExtensions
    {
        public static void AddService(this IServiceCollection services, Action<ServiceOptions>? setupAction = null)
        {
            services.Configure(setupAction);
        }
    }
}
