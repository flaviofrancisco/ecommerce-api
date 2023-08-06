using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyEcommerceApp.EntityFrameworkCore;
using MyEcommerceApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyEcommerceApp.Web.Tests
{
    [DependsOn(
        typeof(MyEcommerceAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyEcommerceAppWebTestModule : AbpModule
    {
        public MyEcommerceAppWebTestModule(MyEcommerceAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyEcommerceAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyEcommerceAppWebMvcModule).Assembly);
        }
    }
}