using JetBrains.Annotations;
using OpenMLTD.MilliSim.Configuration;
using OpenMLTD.MilliSim.Foundation;
using OpenMLTD.TheaterDays.Configuration;
using OpenMLTD.TheaterDays.Configuration.Extending;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization.TypeInspectors;

namespace OpenMLTD.TheaterDays.Subsystems.Configuration {
    internal static class ConfigurationHelper {

        internal static ConfigurationStore CreateConfigurationStore([NotNull] BasePluginManager pluginManager) {
            var typeConverterFactories = pluginManager.GetPluginsOfType<IConfigTypeConverterFactory>();

            var deserializerBuilder = new DeserializerBuilder()
                .WithTypeInspector(inspector => new DataContractTypeInspector(inspector) {
                    NamingConvention = new UnderscoredNamingConvention(),
                    DataMemberSerialization = DataMemberSerialization.OptIn
                })
                .IgnoreUnmatchedProperties();

            // External converters
            foreach (var factory in typeConverterFactories) {
                var converter = factory.CreateTypeConverter();
                deserializerBuilder.WithTypeConverter(converter);
            }

            var deserializer = deserializerBuilder.Build();

            return TheaterDaysConfigurationStore.Load(ConfigurationEntryFile, deserializer);
        }

        private static readonly string ConfigurationEntryFile = "Contents/app.config.yml";

    }
}
