using System.IO;
using System.Linq;
using YamlDotNet.Serialization;

namespace Capgemini.Commons.Config
{
    public static class Config
    {
        public static CapgeminiConfig CapgeminiConfig { get; set; }

        public static void SetConfig()
        {
            var file = Directory.EnumerateFiles("..\\", "CapgeminiConfig.yaml", SearchOption.AllDirectories).FirstOrDefault();
            CapgeminiConfig = new DeserializerBuilder().Build().Deserialize<CapgeminiConfig>(File.ReadAllText(file));
        }
    }
}