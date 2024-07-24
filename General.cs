using Newtonsoft.Json;

namespace DJ_ModPackCreator
{
    public partial class General : Form
    {
        private int _IdEditBlock;

        private ModPack? ModPackNow = null;
        private Block? BlockNow = null;
        private int IdEditBlock
        {
            get { return _IdEditBlock; }
            set
            {
                SetActiveBlockCreator(value != -1);
                _IdEditBlock = value;
            }
        }
        private string FilePath = "iniFile.json";
        private Dictionary<string, bool> TagsOnBlock = [];

        public General()
        {
            InitializeComponent();
        }
        private void General_Load(object sender, EventArgs e)
        {
            string jsonContent = File.ReadAllText(FilePath);

            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonContent);

            ComboBoxOfDefoaltTag.Items.Clear();
            ComboBoxOfDefoaltTag.Items.AddRange(jsonObject["DefoaltTag"].ToArray());

            IdEditBlock = -1;
        }
        public void SaveCurrentBlock()
        {
            try
            {
                if (IdEditBlock != -1)
                {
                    LoadDataToBlock();
                    if (BlockNow != null)
                        ListOfBlock.Items[IdEditBlock] = BlockNow;
                }
            }
            catch { }
        }
        private void BtnCreateNewBlock_Click_1(object sender, EventArgs e)
        {
            SaveCurrentBlock();

            BlockNow = new Block();
            TagsOnBlock.Clear();

            LoadDataToBlockCreator();

            IdEditBlock = ListOfBlock.Items.Count;
            ListOfBlock.Items.Add(BlockNow);
        }
        private void SetActiveBlockCreator(bool active)
        {
            InpAtlasOffset.Enabled = active;
            InpBlockName.Enabled = active;
            InpDurability.Enabled = active;
            InpBreakLvl.Enabled = active;
            InpTextureSize.Enabled = active;
            InpAtlasOffset.Enabled = active;
            InpMultAxe.Enabled = active;
            InpMultHoe.Enabled = active;
            InpMultSword.Enabled = active;
            InpMultOther.Enabled = active;
            InpMultShovel.Enabled = active;
            InpMultPickAxe.Enabled = active;
            BtnAppendDefoaltTag.Enabled = active;
            BtnAppendTag.Enabled = active;
            BtnDeleteTag.Enabled = active;
            ComboBoxOfDefoaltTag.Enabled = active;
        }
        private void LoadDataToBlockCreator()
        {
            if (BlockNow != null)
            {
                InpAtlasOffset.Text = BlockNow.AtlasOffset.ToString();
                InpBlockName.Text = BlockNow.Name;
                InpDurability.Text = BlockNow.Durability.ToString();
                InpBreakLvl.Text = BlockNow.BreakLvl.ToString();

                InpTextureSize.Text = BlockNow.TextureSize.ToString();
                InpAtlasOffset.Text = BlockNow.AtlasOffset.ToString();

                InpMultAxe.Text = BlockNow.ToolMultiplier[ToolType.Axe].ToString();
                InpMultHoe.Text = BlockNow.ToolMultiplier[ToolType.Hoe].ToString();
                InpMultSword.Text = BlockNow.ToolMultiplier[ToolType.Sword].ToString();
                InpMultOther.Text = BlockNow.ToolMultiplier[ToolType.Other].ToString();
                InpMultShovel.Text = BlockNow.ToolMultiplier[ToolType.Shovel].ToString();
                InpMultPickAxe.Text = BlockNow.ToolMultiplier[ToolType.PickAxe].ToString();

                ListOfTag.Items.Clear();
                ListOfTag.Items.AddRange(BlockNow.Tags.ToArray());
            }
        }
        private void ClearBlockCreator()
        {
            if (BlockNow != null)
            {
                InpAtlasOffset.Text = string.Empty;
                InpBlockName.Text = string.Empty;
                InpDurability.Text = string.Empty;
                InpBreakLvl.Text = string.Empty;

                InpTextureSize.Text = string.Empty;
                InpAtlasOffset.Text = string.Empty;

                InpMultAxe.Text = string.Empty;
                InpMultHoe.Text = string.Empty;
                InpMultSword.Text = string.Empty;
                InpMultOther.Text = string.Empty;
                InpMultShovel.Text = string.Empty;
                InpMultPickAxe.Text = string.Empty;

                ListOfTag.Items.Clear();
            }
        }
        private void LoadDataToBlock()
        {
            if (BlockNow != null)
            {
                BlockNow.AtlasOffset = v2f.Parse(InpAtlasOffset.Text, ',');
                BlockNow.Name = InpBlockName.Text;
                BlockNow.Durability = int.Parse(InpDurability.Text);
                BlockNow.BreakLvl = int.Parse(InpBreakLvl.Text);

                BlockNow.TextureSize = v2f.Parse(InpTextureSize.Text, ',');
                BlockNow.AtlasOffset = v2f.Parse(InpAtlasOffset.Text, ',');

                BlockNow.ToolMultiplier[ToolType.Axe] = float.Parse(InpMultAxe.Text);
                BlockNow.ToolMultiplier[ToolType.Hoe] = float.Parse(InpMultHoe.Text);
                BlockNow.ToolMultiplier[ToolType.Sword] = float.Parse(InpMultSword.Text);
                BlockNow.ToolMultiplier[ToolType.Other] = float.Parse(InpMultOther.Text);
                BlockNow.ToolMultiplier[ToolType.Shovel] = float.Parse(InpMultShovel.Text);
                BlockNow.ToolMultiplier[ToolType.PickAxe] = float.Parse(InpMultPickAxe.Text);

                BlockNow.Tags = ListOfTag.Items.OfType<string>().ToList();
            }
        }
        private void ListOfBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfBlock.SelectedIndex == -1) return;
            if(ListOfBlock.SelectedIndex == IdEditBlock) return;
            SaveCurrentBlock();
            LoadDataFromListToBlockCreator();
        }


        private void LoadDataFromListToBlockCreator()
        {
            IdEditBlock = ListOfBlock.SelectedIndex;
            BlockNow = (Block)ListOfBlock.Items[IdEditBlock];

            TagsOnBlock.Clear();
            foreach (var tag in BlockNow.Tags)
                TagsOnBlock[tag] = true;

            LoadDataToBlockCreator();
        }

        private void BtnEditBlock_Click(object sender, EventArgs e)
        {
            if (IdEditBlock != -1)
                SaveCurrentBlock();
            else
                MessageBox.Show("Чтоб редактировать\nнужно создать новый блок", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void BtnDeleteBlock_Click(object sender, EventArgs e)
        {
            if (ListOfBlock.SelectedIndex == -1)
                return;

            if (IdEditBlock == ListOfBlock.SelectedIndex)
            {
                ClearBlockCreator();
                TagsOnBlock.Clear();
                BlockNow = null;
                IdEditBlock = -1;
            }
            else if (IdEditBlock < ListOfBlock.SelectedIndex)
                IdEditBlock--;

            ListOfBlock.Items.RemoveAt(ListOfBlock.SelectedIndex);
        }
        private void BtnAppendDefoaltTag_Click(object sender, EventArgs e)
        {
            string choisedTag = (string)GetSelected(ComboBoxOfDefoaltTag);

            TryAddTag(choisedTag);
        }
        private void BtnAppendTag_Click(object sender, EventArgs e)
        {
            string choisedTag = InpUserTag.Text;

            TryAddTag(choisedTag);
        }
        private bool TryAddTag(string tag)
        {
            if (TagsOnBlock.ContainsKey(tag))
                return false;

            TagsOnBlock[tag] = true;
            ListOfTag.Items.Add(tag);

            return true;
        }

        private object GetSelected(ComboBox container) => container.Items[container.SelectedIndex];
        private object GetSelected(ListBox container) => container.Items[container.SelectedIndex];

        private void BtnDeleteTag_Click(object sender, EventArgs e)
        {
            if (ListOfTag.SelectedIndex == -1) 
                return;

            string choisedTag = (string)GetSelected(ListOfTag);

            ListOfTag.Items.RemoveAt(ListOfTag.SelectedIndex);
            TagsOnBlock.Remove(choisedTag);
        }
    }
}
