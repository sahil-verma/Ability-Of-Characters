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
        public JobForm previousForm;
        public FinalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// to exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonClick(object sender, EventArgs e)
        {
            //Button _buttonClick = (Button)sender;
            Button _buttonClick = sender as Button;
            
            this.Close();
        }

        
        /// <summary>
        /// will be used to change the font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// about the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutClick(object sender, EventArgs e)
        {
            AboutBox1 aboutApp = new AboutBox1();
            aboutApp.ShowDialog();
        }

        /// <summary>
        /// short info for the apllication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _printClick(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the health", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void _charactersRace_CheckedChanged(object sender, EventArgs e)
        {
            STRTextBox.Text = AbilityForm.SetValueForSTRTextBox;
            DEXTextBox.Text = AbilityForm.SetValueForDEXTextBox;
            ENDTextBox.Text = AbilityForm.SetValueForENDTextBox;
            INTTextBox.Text = AbilityForm.SetValueForINTTextBox;
            PERTextBox.Text = AbilityForm.SetValueForPERTextBox;
            CHATextBox.Text = AbilityForm.SetValueForCHATextBox;

        }

        private void _chractersSelection(object sender, EventArgs e)
        {
            jobTextBox.Text = previousForm.job;
            raceTextBox.Text = previousForm.previousForm.race;
            healthPointsTextBox.Text = previousForm.DEX;
            healthPointsTextBox.Text = previousForm.END;
            healthPointsTextBox.Text = previousForm.INT;
            healthPointsTextBox.Text = previousForm.CHA;

        }

    }
}
