using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;


namespace DJ_ModPackCreator
{
    public partial class General : Form
    {
        private int _IdEditBlock;

        private ModPack? ModPackNow = null;
        private Block? BlockNow = null;
        private Image? AtlasTexture = null;

        private int IdEditBlock
        {
            get { return _IdEditBlock; }
            set
            {
                SetActiveBlockCreator(value != -1);
                _IdEditBlock = value;
            }
        }
        private string FilePath = "AppConfig.json";
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
            InpAtlasOffset.Enabled = active; InpBlockName.Enabled = active;
            InpDurability.Enabled = active; InpBreakLvl.Enabled = active;
            InpTextureSize.Enabled = active; InpAtlasOffset.Enabled = active;
            InpMultAxe.Enabled = active; InpMultHoe.Enabled = active;
            InpMultSword.Enabled = active; InpMultOther.Enabled = active;
            InpMultShovel.Enabled = active; InpMultPickAxe.Enabled = active;
            BtnAppendDefoaltTag.Enabled = active; BtnAppendTag.Enabled = active;
            BtnDeleteTag.Enabled = active; ComboBoxOfDefoaltTag.Enabled = active;
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
            if (ListOfBlock.SelectedIndex == IdEditBlock) return;
            SaveCurrentBlock();
            LoadDataFromListToBlockCreator();
            BtnUpdateBlockPreView_Click(sender, e);
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

        private void BtnLoadAtlas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы PNG (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                AtlasTexture = Image.FromFile(selectedFilePath);

                Bitmap bitmap = new Bitmap(PictureAtlas.Width, PictureAtlas.Height);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.PixelOffsetMode = PixelOffsetMode.Half;

                    g.DrawImage(AtlasTexture, new Rectangle(0, 0, PictureAtlas.Width, PictureAtlas.Height));
                }

                PictureAtlas.Image = bitmap;
                PictureAtlas.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void BtnUpdateBlockPreView_Click(object sender, EventArgs e)
        {
            if (AtlasTexture == null)
            {
                MessageBox.Show("Сначала загрузите изображение в PictureAtlas.", "Ошибка загрузки PreViewBlock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            v2f atlasOffset = GetAtlasOffset();
            v2f textureSize = GetTextureSize();

            int offsetX = (int)atlasOffset.X;
            int offsetY = (int)atlasOffset.Y;
            int width = (int)textureSize.X;
            int height = (int)textureSize.Y;

            if (offsetX < 0 && offsetY < 0)
            {
                MessageBox.Show("Смещение не может отрицательно.");
                return;
            }
            if (width < 0 && height < 0)
            {
                MessageBox.Show("Размер текстуры не может отрицательным.");
                return;
            }

            Bitmap previewBitmap = new Bitmap(PicturePreViewBlock.Width, PicturePreViewBlock.Height);

            using (Graphics g = Graphics.FromImage(previewBitmap))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.Half;

                Rectangle sourceRect = new(offsetX, offsetY, width, height);
                Rectangle destRect = new(0, 0, PicturePreViewBlock.Width, PicturePreViewBlock.Height);

                g.DrawImage(AtlasTexture, destRect, sourceRect, GraphicsUnit.Pixel);
            }

            PicturePreViewBlock.Image = previewBitmap;
            PicturePreViewBlock.SizeMode = PictureBoxSizeMode.Normal;
        }

        private v2f GetAtlasOffset() => v2f.Parse(InpAtlasOffset.Text, ',');
        private v2f GetTextureSize() => v2f.Parse(InpTextureSize.Text, ',');

        private void BtnCreateModPack_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(InpNameMode.Text)) 
            {
                MessageBox.Show("Название мода инvalid");
                return;
            }
            if (AtlasTexture == null)
            {
                MessageBox.Show("Атлас текстур ОБЯЗАТЕЛЕН.");
                return;
            }

            ModPack modPack = new()
            {
                ModPackName = InpNameMode.Text,
                Blocks = ListOfBlock.Items.OfType<Block>().ToList()
            };

            string modPacksPath = Path.Combine(Directory.GetCurrentDirectory(), "ModPacks");

            if (!Directory.Exists(modPacksPath))
                Directory.CreateDirectory(modPacksPath);
            

            string zipPath = $"ModPacks/{modPack.ModPackName}_Mod.zip";
            string jsonModPack = ModPack.SerializeModPack(modPack, ComboAssemblyMode.Text == "Release");
            
            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonModPack);
                using (Stream jsonStream = archive.CreateEntry("ModPackData.json").Open())
                {   
                    jsonStream.Write(jsonBytes, 0, jsonBytes.Length);
                }

                using (Stream imageStream = archive.CreateEntry("AtlasTexture.png").Open())
                {
                    AtlasTexture.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            Process.Start("explorer.exe", modPacksPath);
        }
    }
}
