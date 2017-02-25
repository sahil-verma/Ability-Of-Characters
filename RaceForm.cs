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
    public partial class RaceForm : Form
    {
        //3. create a reference to the previous form
        public Form previousForm;

        public RaceForm()
        {
            InitializeComponent();
        }

        private void _charactersRace_CheckedChanged(object sender, EventArgs e)
        {
            string STR, DEX, END, INT, PER, CHA;
            if (humanRadioButton.Checked)
            {
                CharacterPictureBox.Image = MidTermAssignment_200335300.Properties.Resources.M_Human1;
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) + 5).ToString();
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) + 5).ToString();
                END = (Int16.Parse(AbilityForm.SetValueForENDTextBox) + 5).ToString();
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) + 5).ToString();
                PER = (Int16.Parse(AbilityForm.SetValueForPERTextBox) + 5).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) + 5).ToString();

                RacialBonusTextBox.Text = "Abilities are inc by 5";
            }
            else
            {
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) - 5).ToString();
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) - 5).ToString();
                END = (Int16.Parse(AbilityForm.SetValueForENDTextBox) - 5).ToString();
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) - 5).ToString();
                PER = (Int16.Parse(AbilityForm.SetValueForPERTextBox) - 5).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) - 5).ToString();

            }

            if (dwarfRadioButton.Checked)
            {
                CharacterPictureBox.Image = MidTermAssignment_200335300.Properties.Resources.M_Dwarf1;
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) + 20).ToString();
                PER = (Int16.Parse(AbilityForm.SetValueForPERTextBox) + 20).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) - 10).ToString();

                RacialBonusTextBox.Text = "STR and PER inc by 20, CHA dec by 20";
            }
            else
            {
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) - 20).ToString();
                PER = (Int16.Parse(AbilityForm.SetValueForPERTextBox) - 20).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) + 10).ToString();
            }

            if (elfRadioButton.Checked)
            {
                CharacterPictureBox.Image = MidTermAssignment_200335300.Properties.Resources.M_Elf1;
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) + 15).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) + 15).ToString();

                RacialBonusTextBox.Text = "DEX and CHA inc by 15";
            }
            else
            {
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) - 15).ToString();
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) - 15).ToString();
            }

            if (halflingRadioButton.Checked)
            {
                CharacterPictureBox.Image = MidTermAssignment_200335300.Properties.Resources.M_Halfling2;
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) + 20).ToString();
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) + 20).ToString();
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) - 10).ToString();

                RacialBonusTextBox.Text = "DEX and INT inc by 20 and STR dec by 10";
            }
            else
            {
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) - 20).ToString();
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) - 20).ToString();
                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) + 10).ToString();
            }
        }

    }
}
