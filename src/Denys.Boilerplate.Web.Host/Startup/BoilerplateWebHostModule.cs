using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Denys.Boilerplate.Configuration;

namespace Denys.Boilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerplateWebCoreModule))]
    public class BoilerplateWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateWebHostModule).GetAssembly());
        }
    }
}
