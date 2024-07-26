using System.Text.Json;

namespace DJ_ModPackCreator
{
    public class ModPack
    {
        public string ModPackName { get; set; } = string.Empty;
        public List<Block> Blocks { get; set; } = [];

        public static string SerializeModPack(ModPack modPack, bool Release)
        {
            modPack.Blocks.Sort((left, right) => left.Name.CompareTo(right.Name));
            for (int i = 0; i < modPack.Blocks.Count; i++) modPack.Blocks[i].Id = i;

            JsonSerializerOptions options = new()
            {
                WriteIndented = !Release
            };

            return JsonSerializer.Serialize(modPack, options);
        }
    }
}
