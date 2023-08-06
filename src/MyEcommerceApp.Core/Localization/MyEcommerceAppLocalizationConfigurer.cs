using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyEcommerceApp.Localization
{
    public static class MyEcommerceAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyEcommerceAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyEcommerceAppLocalizationConfigurer).GetAssembly(),
                        "MyEcommerceApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
