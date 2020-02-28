using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Kaya.Authorization;

namespace Kaya
{
    [DependsOn(
        typeof(KayaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KayaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KayaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KayaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
