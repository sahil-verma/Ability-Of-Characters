namespace MidTermAssignment_200335300
{
    partial class FinalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.abilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.CHALabel = new System.Windows.Forms.Label();
            this.PERLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.STRLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.healthPointsTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.healthPointsLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.characterFontDialog = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.characterInformationGroupBox.SuspendLayout();
            this.abilitiesGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this._printClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._buttonClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutClick);
            // 
            // characterInformationGroupBox
            // 
            this.characterInformationGroupBox.Controls.Add(this.weightTextBox);
            this.characterInformationGroupBox.Controls.Add(this.heightTextBox);
            this.characterInformationGroupBox.Controls.Add(this.weightLabel);
            this.characterInformationGroupBox.Controls.Add(this.heightLabel);
            this.characterInformationGroupBox.Controls.Add(this.ageTextBox);
            this.characterInformationGroupBox.Controls.Add(this.nameTextBox);
            this.characterInformationGroupBox.Controls.Add(this.ageLabel);
            this.characterInformationGroupBox.Controls.Add(this.nameLabel);
            this.characterInformationGroupBox.Controls.Add(this.groupBox2);
            this.characterInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterInformationGroupBox.Location = new System.Drawing.Point(12, 43);
            this.characterInformationGroupBox.Name = "characterInformationGroupBox";
            this.characterInformationGroupBox.Size = new System.Drawing.Size(350, 85);
            this.characterInformationGroupBox.TabIndex = 1;
            this.characterInformationGroupBox.TabStop = false;
            this.characterInformationGroupBox.Text = "Character Information";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(243, 53);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 10;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(243, 22);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 9;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(181, 56);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 16);
            this.weightLabel.TabIndex = 8;
            this.weightLabel.Text = "Weight: ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(187, 25);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(50, 16);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(59, 53);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(59, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(17, 53);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 16);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(390, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // abilitiesGroupBox
            // 
            this.abilitiesGroupBox.Controls.Add(this.CHATextBox);
            this.abilitiesGroupBox.Controls.Add(this.PERTextBox);
            this.abilitiesGroupBox.Controls.Add(this.INTTextBox);
            this.abilitiesGroupBox.Controls.Add(this.ENDTextBox);
            this.abilitiesGroupBox.Controls.Add(this.DEXTextBox);
            this.abilitiesGroupBox.Controls.Add(this.STRTextBox);
            this.abilitiesGroupBox.Controls.Add(this.CHALabel);
            this.abilitiesGroupBox.Controls.Add(this.PERLabel);
            this.abilitiesGroupBox.Controls.Add(this.INTLabel);
            this.abilitiesGroupBox.Controls.Add(this.ENDLabel);
            this.abilitiesGroupBox.Controls.Add(this.DEXLabel);
            this.abilitiesGroupBox.Controls.Add(this.STRLabel);
            this.abilitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilitiesGroupBox.Location = new System.Drawing.Point(12, 134);
            this.abilitiesGroupBox.Name = "abilitiesGroupBox";
            this.abilitiesGroupBox.Size = new System.Drawing.Size(261, 362);
            this.abilitiesGroupBox.TabIndex = 2;
            this.abilitiesGroupBox.TabStop = false;
            this.abilitiesGroupBox.Text = "Abilities";
            // 
            // CHATextBox
            // 
            this.CHATextBox.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.CHATextBox.Location = new System.Drawing.Point(127, 308);
            this.CHATextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.Size = new System.Drawing.Size(120, 21);
            this.CHATextBox.TabIndex = 39;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Location = new System.Drawing.Point(127, 248);
            this.PERTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.Size = new System.Drawing.Size(120, 22);
            this.PERTextBox.TabIndex = 38;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Location = new System.Drawing.Point(127, 189);
            this.INTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.Size = new System.Drawing.Size(120, 22);
            this.INTTextBox.TabIndex = 37;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Location = new System.Drawing.Point(127, 134);
            this.ENDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.Size = new System.Drawing.Size(120, 22);
            this.ENDTextBox.TabIndex = 36;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Location = new System.Drawing.Point(127, 78);
            this.DEXTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.Size = new System.Drawing.Size(120, 22);
            this.DEXTextBox.TabIndex = 35;
            // 
            // STRTextBox
            // 
            this.STRTextBox.Location = new System.Drawing.Point(127, 19);
            this.STRTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.Size = new System.Drawing.Size(120, 22);
            this.STRTextBox.TabIndex = 34;
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(17, 313);
            this.CHALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(36, 16);
            this.CHALabel.TabIndex = 33;
            this.CHALabel.Text = "CHA";
            // 
            // PERLabel
            // 
            this.PERLabel.AutoSize = true;
            this.PERLabel.Location = new System.Drawing.Point(17, 253);
            this.PERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(36, 16);
            this.PERLabel.TabIndex = 32;
            this.PERLabel.Text = "PER";
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Location = new System.Drawing.Point(17, 194);
            this.INTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(30, 16);
            this.INTLabel.TabIndex = 31;
            this.INTLabel.Text = "INT";
            // 
            // ENDLabel
            // 
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Location = new System.Drawing.Point(17, 138);
            this.ENDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(37, 16);
            this.ENDLabel.TabIndex = 30;
            this.ENDLabel.Text = "END";
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Location = new System.Drawing.Point(17, 79);
            this.DEXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(35, 16);
            this.DEXLabel.TabIndex = 29;
            this.DEXLabel.Text = "DEX";
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Location = new System.Drawing.Point(22, 23);
            this.STRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(36, 16);
            this.STRLabel.TabIndex = 28;
            this.STRLabel.Text = "STR";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.healthPointsTextBox);
            this.groupBox4.Controls.Add(this.jobTextBox);
            this.groupBox4.Controls.Add(this.raceTextBox);
            this.groupBox4.Controls.Add(this.healthPointsLabel);
            this.groupBox4.Controls.Add(this.raceLabel);
            this.groupBox4.Controls.Add(this.jobLabel);
            this.groupBox4.Location = new System.Drawing.Point(361, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 142);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // healthPointsTextBox
            // 
            this.healthPointsTextBox.Location = new System.Drawing.Point(118, 91);
            this.healthPointsTextBox.Name = "healthPointsTextBox";
            this.healthPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.healthPointsTextBox.TabIndex = 8;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(118, 21);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTextBox.TabIndex = 7;
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(118, 56);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(100, 20);
            this.raceTextBox.TabIndex = 6;
            // 
            // healthPointsLabel
            // 
            this.healthPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPointsLabel.Location = new System.Drawing.Point(6, 88);
            this.healthPointsLabel.Name = "healthPointsLabel";
            this.healthPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.healthPointsLabel.TabIndex = 2;
            this.healthPointsLabel.Text = "Health Points";
            this.healthPointsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // raceLabel
            // 
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.Location = new System.Drawing.Point(7, 53);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(100, 23);
            this.raceLabel.TabIndex = 1;
            this.raceLabel.Text = "Race:";
            this.raceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // jobLabel
            // 
            this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLabel.Location = new System.Drawing.Point(7, 20);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(100, 23);
            this.jobLabel.TabIndex = 0;
            this.jobLabel.Text = "Job:";
            this.jobLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // characterFontDialog
            // 
            this.characterFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.characterFontDialog.MaxSize = 18;
            this.characterFontDialog.MinSize = 10;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.Location = new System.Drawing.Point(339, 225);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.characterPictureBox.TabIndex = 8;
            this.characterPictureBox.TabStop = false;
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.characterPictureBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.abilitiesGroupBox);
            this.Controls.Add(this.characterInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.characterInformationGroupBox.ResumeLayout(false);
            this.characterInformationGroupBox.PerformLayout();
            this.abilitiesGroupBox.ResumeLayout(false);
            this.abilitiesGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox characterInformationGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox abilitiesGroupBox;
        internal System.Windows.Forms.TextBox CHATextBox;
        internal System.Windows.Forms.TextBox PERTextBox;
        internal System.Windows.Forms.TextBox INTTextBox;
        internal System.Windows.Forms.TextBox ENDTextBox;
        internal System.Windows.Forms.TextBox DEXTextBox;
        internal System.Windows.Forms.TextBox STRTextBox;
        internal System.Windows.Forms.Label CHALabel;
        internal System.Windows.Forms.Label PERLabel;
        internal System.Windows.Forms.Label INTLabel;
        internal System.Windows.Forms.Label ENDLabel;
        internal System.Windows.Forms.Label DEXLabel;
        internal System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox healthPointsTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.Label healthPointsLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.FontDialog characterFontDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox characterPictureBox;
    }
}