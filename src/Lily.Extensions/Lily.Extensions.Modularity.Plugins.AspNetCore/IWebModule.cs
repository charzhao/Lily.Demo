namespace Lily.Extensions.Modularity.Plugins.AspNetCore
{
    public interface IWebModule
    {
        void WebInitContext(WebAppInitContext webAppInitContext);
    }
}
