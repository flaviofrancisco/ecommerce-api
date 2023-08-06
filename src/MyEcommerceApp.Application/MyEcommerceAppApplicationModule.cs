using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerceApp.Authorization;

namespace MyEcommerceApp
{
    [DependsOn(
        typeof(MyEcommerceAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyEcommerceAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyEcommerceAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyEcommerceAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
