using System.Text.Json;

namespace DJ_ModPackCreator
{
    public class ModPack
    {
        public string ModPackName { get; set; } = string.Empty;
        public List<Block> Blocks { get; set; } = [];

        public static string SerializeModPack(ModPack modPack, bool Release)
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = !Release
            };

            return JsonSerializer.Serialize(modPack, options);
        }
    }
}
