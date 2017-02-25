using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermAssignment_200335300
{
    public partial class FinalForm : Form
    {
        //3. create a reference to the previous form
        public Form previousForm;
        public FinalForm()
        {
            InitializeComponent();
        }

        private void _buttonClick(object sender, EventArgs e)
        {
            //Button _buttonClick = (Button)sender;
            Button _buttonClick = sender as Button;
            
            this.Close();
        }




        

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            characterFontDialog.ShowDialog();
            nameTextBox.Font = characterFontDialog.Font;
            heightTextBox.Font = characterFontDialog.Font;
            ageTextBox.Font = characterFontDialog.Font;
            weightTextBox.Font = characterFontDialog.Font;
            jobTextBox.Font = characterFontDialog.Font;
            raceTextBox.Font = characterFontDialog.Font;
            healthPointsTextBox.Font = characterFontDialog.Font;

            nameLabel.Font = characterFontDialog.Font;
            heightLabel.Font = characterFontDialog.Font;
            ageLabel.Font = characterFontDialog.Font;
            weightLabel.Font = characterFontDialog.Font;
            jobLabel.Font = characterFontDialog.Font;
            raceLabel.Font = characterFontDialog.Font;
            healthPointsLabel.Font = characterFontDialog.Font;

        }

        private void _aboutClick(object sender, EventArgs e)
        {
            AboutBox1 aboutApp = new AboutBox1();
            aboutApp.ShowDialog();
        }

        private void _printClick(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the health", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
