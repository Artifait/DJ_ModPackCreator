

namespace DJ_ModPackCreator
{
    partial class General
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            label1 = new Label();
            InpNameMode = new TextBox();
            groupBox1 = new GroupBox();
            ViewAtlasSize = new Label();
            label12 = new Label();
            BtnLoadAtlas = new Button();
            PictureAtlas = new PictureBox();
            GroupBlockCreator = new GroupBox();
            label15 = new Label();
            groupBox8 = new GroupBox();
            InpUserTag = new TextBox();
            BtnAppendTag = new Button();
            BtnDeleteTag = new Button();
            groupBox3 = new GroupBox();
            ComboBoxOfDefoaltTag = new ComboBox();
            BtnAppendDefoaltTag = new Button();
            ListOfTag = new ListBox();
            label14 = new Label();
            InpBreakLvl = new TextBox();
            label5 = new Label();
            InpAtlasOffset = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            InpTextureSize = new TextBox();
            InpDurability = new TextBox();
            InpBlockName = new TextBox();
            groupBox4 = new GroupBox();
            InpMultOther = new TextBox();
            InpMultSword = new TextBox();
            label10 = new Label();
            label11 = new Label();
            InpMultPickAxe = new TextBox();
            InpMultShovel = new TextBox();
            label8 = new Label();
            label9 = new Label();
            InpMultHoe = new TextBox();
            InpMultAxe = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox6 = new GroupBox();
            ListOfBlock = new ListBox();
            groupBox7 = new GroupBox();
            BtnUpdateBlockPreView = new Button();
            PicturePreViewBlock = new PictureBox();
            BtnDeleteBlock = new Button();
            BtnEditBlock = new Button();
            BtnCreateModPack = new Button();
            BtnCreateNewBlock = new Button();
            label13 = new Label();
            ComboAssemblyMode = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureAtlas).BeginInit();
            GroupBlockCreator.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicturePreViewBlock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 34);
            label1.TabIndex = 0;
            label1.Text = "Название Мода:";
            // 
            // InpNameMode
            // 
            InpNameMode.Location = new Point(221, 12);
            InpNameMode.Name = "InpNameMode";
            InpNameMode.Size = new Size(256, 33);
            InpNameMode.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ViewAtlasSize);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(BtnLoadAtlas);
            groupBox1.Controls.Add(PictureAtlas);
            groupBox1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(497, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 308);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atlas";
            // 
            // ViewAtlasSize
            // 
            ViewAtlasSize.AutoSize = true;
            ViewAtlasSize.Location = new Point(6, 135);
            ViewAtlasSize.Name = "ViewAtlasSize";
            ViewAtlasSize.Size = new Size(88, 23);
            ViewAtlasSize.TabIndex = 12;
            ViewAtlasSize.Text = "(256, 256)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 101);
            label12.Name = "label12";
            label12.Size = new Size(42, 23);
            label12.TabIndex = 11;
            label12.Text = "Size";
            // 
            // BtnLoadAtlas
            // 
            BtnLoadAtlas.BackColor = Color.Black;
            BtnLoadAtlas.Location = new Point(7, 39);
            BtnLoadAtlas.Name = "BtnLoadAtlas";
            BtnLoadAtlas.Size = new Size(87, 40);
            BtnLoadAtlas.TabIndex = 10;
            BtnLoadAtlas.Text = "Load";
            BtnLoadAtlas.UseVisualStyleBackColor = false;
            BtnLoadAtlas.Click += BtnLoadAtlas_Click;
            // 
            // PictureAtlas
            // 
            PictureAtlas.Location = new Point(111, 22);
            PictureAtlas.Name = "PictureAtlas";
            PictureAtlas.Size = new Size(275, 275);
            PictureAtlas.TabIndex = 0;
            PictureAtlas.TabStop = false;
            // 
            // GroupBlockCreator
            // 
            GroupBlockCreator.Controls.Add(label15);
            GroupBlockCreator.Controls.Add(groupBox8);
            GroupBlockCreator.Controls.Add(groupBox3);
            GroupBlockCreator.Controls.Add(ListOfTag);
            GroupBlockCreator.Controls.Add(label14);
            GroupBlockCreator.Controls.Add(InpBreakLvl);
            GroupBlockCreator.Controls.Add(label5);
            GroupBlockCreator.Controls.Add(InpAtlasOffset);
            GroupBlockCreator.Controls.Add(label4);
            GroupBlockCreator.Controls.Add(label3);
            GroupBlockCreator.Controls.Add(label2);
            GroupBlockCreator.Controls.Add(InpTextureSize);
            GroupBlockCreator.Controls.Add(InpDurability);
            GroupBlockCreator.Controls.Add(InpBlockName);
            GroupBlockCreator.Controls.Add(groupBox4);
            GroupBlockCreator.ForeColor = Color.White;
            GroupBlockCreator.Location = new Point(12, 51);
            GroupBlockCreator.Name = "GroupBlockCreator";
            GroupBlockCreator.Size = new Size(465, 490);
            GroupBlockCreator.TabIndex = 3;
            GroupBlockCreator.TabStop = false;
            GroupBlockCreator.Text = "BlockCreator";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(333, 151);
            label15.Name = "label15";
            label15.Size = new Size(53, 26);
            label15.TabIndex = 24;
            label15.Text = "Tags";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(InpUserTag);
            groupBox8.Controls.Add(BtnAppendTag);
            groupBox8.Controls.Add(BtnDeleteTag);
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(16, 254);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(251, 110);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "UserTags";
            // 
            // InpUserTag
            // 
            InpUserTag.Location = new Point(6, 32);
            InpUserTag.Name = "InpUserTag";
            InpUserTag.Size = new Size(224, 33);
            InpUserTag.TabIndex = 10;
            // 
            // BtnAppendTag
            // 
            BtnAppendTag.BackColor = Color.Black;
            BtnAppendTag.Location = new Point(115, 71);
            BtnAppendTag.Name = "BtnAppendTag";
            BtnAppendTag.Size = new Size(115, 34);
            BtnAppendTag.TabIndex = 12;
            BtnAppendTag.Text = "Append";
            BtnAppendTag.UseVisualStyleBackColor = false;
            BtnAppendTag.Click += BtnAppendTag_Click;
            // 
            // BtnDeleteTag
            // 
            BtnDeleteTag.BackColor = Color.Black;
            BtnDeleteTag.Location = new Point(6, 71);
            BtnDeleteTag.Name = "BtnDeleteTag";
            BtnDeleteTag.Size = new Size(103, 34);
            BtnDeleteTag.TabIndex = 11;
            BtnDeleteTag.Text = "Delete";
            BtnDeleteTag.UseVisualStyleBackColor = false;
            BtnDeleteTag.Click += BtnDeleteTag_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ComboBoxOfDefoaltTag);
            groupBox3.Controls.Add(BtnAppendDefoaltTag);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(16, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 111);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "DefoaltTags";
            // 
            // ComboBoxOfDefoaltTag
            // 
            ComboBoxOfDefoaltTag.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxOfDefoaltTag.FormattingEnabled = true;
            ComboBoxOfDefoaltTag.Items.AddRange(new object[] { "" });
            ComboBoxOfDefoaltTag.Location = new Point(6, 32);
            ComboBoxOfDefoaltTag.Name = "ComboBoxOfDefoaltTag";
            ComboBoxOfDefoaltTag.Size = new Size(228, 34);
            ComboBoxOfDefoaltTag.TabIndex = 13;
            // 
            // BtnAppendDefoaltTag
            // 
            BtnAppendDefoaltTag.BackColor = Color.Black;
            BtnAppendDefoaltTag.Location = new Point(6, 71);
            BtnAppendDefoaltTag.Name = "BtnAppendDefoaltTag";
            BtnAppendDefoaltTag.Size = new Size(228, 34);
            BtnAppendDefoaltTag.TabIndex = 12;
            BtnAppendDefoaltTag.Text = "Append";
            BtnAppendDefoaltTag.UseVisualStyleBackColor = false;
            BtnAppendDefoaltTag.Click += BtnAppendDefoaltTag_Click;
            // 
            // ListOfTag
            // 
            ListOfTag.BackColor = Color.Black;
            ListOfTag.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListOfTag.ForeColor = Color.White;
            ListOfTag.FormattingEnabled = true;
            ListOfTag.ItemHeight = 20;
            ListOfTag.Location = new Point(274, 180);
            ListOfTag.Name = "ListOfTag";
            ListOfTag.Size = new Size(177, 184);
            ListOfTag.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(258, 68);
            label14.Name = "label14";
            label14.Size = new Size(80, 23);
            label14.TabIndex = 23;
            label14.Text = "BreakLvl:";
            // 
            // InpBreakLvl
            // 
            InpBreakLvl.Location = new Point(344, 62);
            InpBreakLvl.Name = "InpBreakLvl";
            InpBreakLvl.Size = new Size(107, 33);
            InpBreakLvl.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(33, 68);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 21;
            label5.Text = "Durability:";
            // 
            // InpAtlasOffset
            // 
            InpAtlasOffset.Location = new Point(344, 101);
            InpAtlasOffset.Name = "InpAtlasOffset";
            InpAtlasOffset.Size = new Size(107, 33);
            InpAtlasOffset.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(238, 107);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 19;
            label4.Text = "AtlasOffset:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(25, 107);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 17;
            label3.Text = "TextureSize:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 29);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 16;
            label2.Text = "BlockName:";
            // 
            // InpTextureSize
            // 
            InpTextureSize.Location = new Point(131, 101);
            InpTextureSize.Name = "InpTextureSize";
            InpTextureSize.Size = new Size(101, 33);
            InpTextureSize.TabIndex = 15;
            // 
            // InpDurability
            // 
            InpDurability.Location = new Point(131, 62);
            InpDurability.Name = "InpDurability";
            InpDurability.Size = new Size(101, 33);
            InpDurability.TabIndex = 14;
            // 
            // InpBlockName
            // 
            InpBlockName.Location = new Point(131, 23);
            InpBlockName.Name = "InpBlockName";
            InpBlockName.Size = new Size(320, 33);
            InpBlockName.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(InpMultOther);
            groupBox4.Controls.Add(InpMultSword);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(InpMultPickAxe);
            groupBox4.Controls.Add(InpMultShovel);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(InpMultHoe);
            groupBox4.Controls.Add(InpMultAxe);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Impact", 14.25F);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(6, 364);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(445, 120);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Multiplier";
            // 
            // InpMultOther
            // 
            InpMultOther.Location = new Point(355, 67);
            InpMultOther.Name = "InpMultOther";
            InpMultOther.Size = new Size(72, 31);
            InpMultOther.TabIndex = 22;
            // 
            // InpMultSword
            // 
            InpMultSword.Location = new Point(355, 30);
            InpMultSword.Name = "InpMultSword";
            InpMultSword.Size = new Size(72, 31);
            InpMultSword.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(292, 75);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 20;
            label10.Text = "Other:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(285, 38);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 19;
            label11.Text = "Sword:";
            // 
            // InpMultPickAxe
            // 
            InpMultPickAxe.Location = new Point(210, 67);
            InpMultPickAxe.Name = "InpMultPickAxe";
            InpMultPickAxe.Size = new Size(72, 31);
            InpMultPickAxe.TabIndex = 18;
            // 
            // InpMultShovel
            // 
            InpMultShovel.Location = new Point(210, 30);
            InpMultShovel.Name = "InpMultShovel";
            InpMultShovel.Size = new Size(72, 31);
            InpMultShovel.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 75);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 16;
            label8.Text = "PickAxe:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 38);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 15;
            label9.Text = "Shovel:";
            // 
            // InpMultHoe
            // 
            InpMultHoe.Location = new Point(56, 67);
            InpMultHoe.Name = "InpMultHoe";
            InpMultHoe.Size = new Size(72, 31);
            InpMultHoe.TabIndex = 14;
            // 
            // InpMultAxe
            // 
            InpMultAxe.Location = new Point(56, 30);
            InpMultAxe.Name = "InpMultAxe";
            InpMultAxe.Size = new Size(72, 31);
            InpMultAxe.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 75);
            label7.Name = "label7";
            label7.Size = new Size(45, 23);
            label7.TabIndex = 1;
            label7.Text = "Hoe:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 38);
            label6.Name = "label6";
            label6.Size = new Size(40, 23);
            label6.TabIndex = 0;
            label6.Text = "Axe:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ListOfBlock);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Font = new Font("Impact", 14.25F);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(497, 344);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(392, 197);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Blocks";
            // 
            // ListOfBlock
            // 
            ListOfBlock.BackColor = Color.Black;
            ListOfBlock.ForeColor = Color.White;
            ListOfBlock.FormattingEnabled = true;
            ListOfBlock.ItemHeight = 23;
            ListOfBlock.Location = new Point(157, 26);
            ListOfBlock.Name = "ListOfBlock";
            ListOfBlock.Size = new Size(222, 165);
            ListOfBlock.TabIndex = 8;
            ListOfBlock.SelectedIndexChanged += ListOfBlock_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(BtnUpdateBlockPreView);
            groupBox7.Controls.Add(PicturePreViewBlock);
            groupBox7.Font = new Font("Impact", 14.25F);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(6, 20);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(145, 171);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "PreViewBlock";
            // 
            // BtnUpdateBlockPreView
            // 
            BtnUpdateBlockPreView.BackColor = Color.Black;
            BtnUpdateBlockPreView.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BtnUpdateBlockPreView.ForeColor = Color.White;
            BtnUpdateBlockPreView.Location = new Point(22, 131);
            BtnUpdateBlockPreView.Name = "BtnUpdateBlockPreView";
            BtnUpdateBlockPreView.Size = new Size(100, 34);
            BtnUpdateBlockPreView.TabIndex = 1;
            BtnUpdateBlockPreView.Text = "Update";
            BtnUpdateBlockPreView.UseVisualStyleBackColor = false;
            BtnUpdateBlockPreView.Click += BtnUpdateBlockPreView_Click;
            // 
            // PicturePreViewBlock
            // 
            PicturePreViewBlock.Location = new Point(22, 25);
            PicturePreViewBlock.Name = "PicturePreViewBlock";
            PicturePreViewBlock.Size = new Size(100, 100);
            PicturePreViewBlock.TabIndex = 0;
            PicturePreViewBlock.TabStop = false;
            // 
            // BtnDeleteBlock
            // 
            BtnDeleteBlock.BackColor = Color.Black;
            BtnDeleteBlock.Location = new Point(12, 547);
            BtnDeleteBlock.Name = "BtnDeleteBlock";
            BtnDeleteBlock.Size = new Size(189, 67);
            BtnDeleteBlock.TabIndex = 7;
            BtnDeleteBlock.Text = "Удалить";
            BtnDeleteBlock.UseVisualStyleBackColor = false;
            BtnDeleteBlock.Click += BtnDeleteBlock_Click;
            // 
            // BtnEditBlock
            // 
            BtnEditBlock.BackColor = Color.Black;
            BtnEditBlock.Location = new Point(207, 547);
            BtnEditBlock.Name = "BtnEditBlock";
            BtnEditBlock.Size = new Size(270, 67);
            BtnEditBlock.TabIndex = 8;
            BtnEditBlock.Text = "Редактировать";
            BtnEditBlock.UseVisualStyleBackColor = false;
            BtnEditBlock.Click += BtnEditBlock_Click;
            // 
            // BtnCreateModPack
            // 
            BtnCreateModPack.BackColor = Color.Black;
            BtnCreateModPack.Location = new Point(690, 547);
            BtnCreateModPack.Name = "BtnCreateModPack";
            BtnCreateModPack.Size = new Size(199, 67);
            BtnCreateModPack.TabIndex = 9;
            BtnCreateModPack.Text = "Создать Zip";
            BtnCreateModPack.UseVisualStyleBackColor = false;
            BtnCreateModPack.Click += BtnCreateModPack_Click;
            // 
            // BtnCreateNewBlock
            // 
            BtnCreateNewBlock.BackColor = Color.Black;
            BtnCreateNewBlock.Location = new Point(497, 547);
            BtnCreateNewBlock.Name = "BtnCreateNewBlock";
            BtnCreateNewBlock.Size = new Size(187, 67);
            BtnCreateNewBlock.TabIndex = 10;
            BtnCreateNewBlock.Text = "New Block";
            BtnCreateNewBlock.UseVisualStyleBackColor = false;
            BtnCreateNewBlock.Click += BtnCreateNewBlock_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(640, 12);
            label13.Name = "label13";
            label13.Size = new Size(83, 26);
            label13.TabIndex = 11;
            label13.Text = "Сборка:";
            // 
            // ComboAssemblyMode
            // 
            ComboAssemblyMode.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboAssemblyMode.FormattingEnabled = true;
            ComboAssemblyMode.Items.AddRange(new object[] { "Development", "Release" });
            ComboAssemblyMode.Location = new Point(729, 9);
            ComboAssemblyMode.Name = "ComboAssemblyMode";
            ComboAssemblyMode.Size = new Size(160, 34);
            ComboAssemblyMode.TabIndex = 12;
            // 
            // General
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(901, 620);
            Controls.Add(ComboAssemblyMode);
            Controls.Add(label13);
            Controls.Add(BtnCreateNewBlock);
            Controls.Add(BtnCreateModPack);
            Controls.Add(BtnEditBlock);
            Controls.Add(BtnDeleteBlock);
            Controls.Add(groupBox6);
            Controls.Add(GroupBlockCreator);
            Controls.Add(groupBox1);
            Controls.Add(InpNameMode);
            Controls.Add(label1);
            Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "General";
            Text = "DJ_ModPackCreator-V1";
            Load += General_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureAtlas).EndInit();
            GroupBlockCreator.ResumeLayout(false);
            GroupBlockCreator.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicturePreViewBlock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox InpNameMode;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private PictureBox PictureAtlas;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button BtnDeleteBlock;
        private Button BtnEditBlock;
        private Button BtnCreateModPack;
        private Button BtnLoadAtlas;
        private Button BtnAppendTag;
        private Button BtnDeleteTag;
        private TextBox InpUserTag;
        private ListBox ListOfTag;
        private ListBox ListOfBlock;
        private Label label3;
        private Label label2;
        private TextBox InpTextureSize;
        private TextBox InpDurability;
        private TextBox InpBlockName;
        private Label label5;
        private TextBox InpAtlasOffset;
        private Label label4;
        private Label label6;
        private PictureBox PicturePreViewBlock;
        private TextBox InpMultAxe;
        private Label label7;
        private TextBox InpMultHoe;
        private TextBox InpMultOther;
        private TextBox InpMultSword;
        private Label label10;
        private Label label11;
        private TextBox InpMultPickAxe;
        private TextBox InpMultShovel;
        private Label label8;
        private Label label9;
        private Label ViewAtlasSize;
        private Label label12;
        private Button BtnCreateNewBlock;
        private Label label13;
        private ComboBox ComboAssemblyMode;
        private Label label14;
        private TextBox InpBreakLvl;
        private Button BtnAppendDefoaltTag;
        private ComboBox ComboBoxOfDefoaltTag;
        private GroupBox groupBox3;
        private GroupBox groupBox8;
        private Label label15;
        private Button BtnUpdateBlockPreView;
        public GroupBox GroupBlockCreator;
    }
}
