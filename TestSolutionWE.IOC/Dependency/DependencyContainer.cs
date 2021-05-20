using Microsoft.Extensions.DependencyInjection;
using TestSolutionWEB.PROVIDERS.Data;
using TestSolutionWEB.PROVIDERS.Interfaces;
using TestSolutionWEB.SERVICES.Interfaces;
using TestSolutionWEB.SERVICES.Services;

namespace TestSolutionWE.IOC.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Dependency
            services.AddScoped<IAddUsserService, AddUsserService>();
            #endregion

            #region Services
            services.AddScoped(typeof(IDataService<>), typeof(DataService<>));
            #endregion
        }
    }
}
