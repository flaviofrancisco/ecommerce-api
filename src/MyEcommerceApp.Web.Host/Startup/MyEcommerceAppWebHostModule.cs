using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerceApp.Configuration;

namespace MyEcommerceApp.Web.Host.Startup
{
    [DependsOn(
       typeof(MyEcommerceAppWebCoreModule))]
    public class MyEcommerceAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyEcommerceAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceAppWebHostModule).GetAssembly());
        }
    }
}
