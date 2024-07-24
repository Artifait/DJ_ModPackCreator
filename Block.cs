
namespace DJ_ModPackCreator
{
    public class v2f
    {
        // Constructor
        public v2f() : this(0f, 0f) { }
        public v2f(float x, float y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"{X},{Y}";
        public float X { get; set; }
        public float Y { get; set; }

        public static v2f Parse(string input, char separator)
        {
            string[] parts = input.Split(separator);

            string leftPart = parts[0];
            string rightPart = parts[1];

            int leftNumber = ExtractNumber(leftPart);
            int rightNumber = ExtractNumber(rightPart);

            return new v2f(leftNumber, rightNumber);
        }

        private static int ExtractNumber(string input)
        {
            string numberString = "";

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    numberString += c;
                }
            }

            return int.Parse(numberString);
        }
    }

    public enum ToolType
    {
        Axe,
        PickAxe,
        Hoe,
        Shovel,
        Sword,
        Other
    }
    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Durability { get; set; } = 1;
        public int BreakLvl { get; set; } = 1;

        public v2f AtlasOffset { get; set; } = new();
        public v2f TextureSize { get; set; } = new();

        public List<string> Tags { get; set; } = [];
        public Dictionary<ToolType, float> ToolMultiplier { get; set; } = [];


        public Block()
        {
            for (int i = 0; i < Enum.GetValues(typeof(ToolType)).Length; i++)
                ToolMultiplier[(ToolType)i] = 1;
        }
        public override string ToString() => Name;
    }
}
