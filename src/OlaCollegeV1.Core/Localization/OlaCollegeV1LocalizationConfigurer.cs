using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OlaCollegeV1.Localization
{
    public static class OlaCollegeV1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OlaCollegeV1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OlaCollegeV1LocalizationConfigurer).GetAssembly(),
                        "OlaCollegeV1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
