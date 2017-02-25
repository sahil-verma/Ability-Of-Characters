namespace MidTermAssignment_200335300
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.soldierRadioButton = new System.Windows.Forms.RadioButton();
            this.rogueRadioButton = new System.Windows.Forms.RadioButton();
            this.magickerRadioButton = new System.Windows.Forms.RadioButton();
            this.cultistRadioButton = new System.Windows.Forms.RadioButton();
            this.healthPointLabel = new System.Windows.Forms.Label();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.cultistRadioButton);
            this.jobGroupBox.Controls.Add(this.magickerRadioButton);
            this.jobGroupBox.Controls.Add(this.rogueRadioButton);
            this.jobGroupBox.Controls.Add(this.soldierRadioButton);
            this.jobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobGroupBox.Location = new System.Drawing.Point(12, 66);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(244, 226);
            this.jobGroupBox.TabIndex = 4;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Character’sJob";
            // 
            // soldierRadioButton
            // 
            this.soldierRadioButton.AutoSize = true;
            this.soldierRadioButton.Location = new System.Drawing.Point(7, 47);
            this.soldierRadioButton.Name = "soldierRadioButton";
            this.soldierRadioButton.Size = new System.Drawing.Size(76, 24);
            this.soldierRadioButton.TabIndex = 0;
            this.soldierRadioButton.TabStop = true;
            this.soldierRadioButton.Text = "Soldier";
            this.soldierRadioButton.UseVisualStyleBackColor = true;
            this.soldierRadioButton.CheckedChanged += new System.EventHandler(this._charactersJob_CheckedChanged);
            // 
            // rogueRadioButton
            // 
            this.rogueRadioButton.AutoSize = true;
            this.rogueRadioButton.Location = new System.Drawing.Point(7, 97);
            this.rogueRadioButton.Name = "rogueRadioButton";
            this.rogueRadioButton.Size = new System.Drawing.Size(75, 24);
            this.rogueRadioButton.TabIndex = 1;
            this.rogueRadioButton.TabStop = true;
            this.rogueRadioButton.Text = "Rogue";
            this.rogueRadioButton.UseVisualStyleBackColor = true;
            // 
            // magickerRadioButton
            // 
            this.magickerRadioButton.AutoSize = true;
            this.magickerRadioButton.Location = new System.Drawing.Point(7, 146);
            this.magickerRadioButton.Name = "magickerRadioButton";
            this.magickerRadioButton.Size = new System.Drawing.Size(91, 24);
            this.magickerRadioButton.TabIndex = 2;
            this.magickerRadioButton.TabStop = true;
            this.magickerRadioButton.Text = "Magicker";
            this.magickerRadioButton.UseVisualStyleBackColor = true;
            // 
            // cultistRadioButton
            // 
            this.cultistRadioButton.AutoSize = true;
            this.cultistRadioButton.Location = new System.Drawing.Point(7, 195);
            this.cultistRadioButton.Name = "cultistRadioButton";
            this.cultistRadioButton.Size = new System.Drawing.Size(71, 24);
            this.cultistRadioButton.TabIndex = 3;
            this.cultistRadioButton.TabStop = true;
            this.cultistRadioButton.Text = "Cultist";
            this.cultistRadioButton.UseVisualStyleBackColor = true;
            // 
            // healthPointLabel
            // 
            this.healthPointLabel.Location = new System.Drawing.Point(392, 163);
            this.healthPointLabel.Name = "healthPointLabel";
            this.healthPointLabel.Size = new System.Drawing.Size(161, 49);
            this.healthPointLabel.TabIndex = 5;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthPointLabel);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.RadioButton cultistRadioButton;
        private System.Windows.Forms.RadioButton magickerRadioButton;
        private System.Windows.Forms.RadioButton rogueRadioButton;
        private System.Windows.Forms.RadioButton soldierRadioButton;
        private System.Windows.Forms.Label healthPointLabel;
    }
}