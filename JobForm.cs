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
    public partial class JobForm : Form
    {
        //3. create a reference to the previous form
        public Form previousForm;
        public JobForm()
        {
            InitializeComponent();
        }

        private void _charactersJob_CheckedChanged(object sender, EventArgs e)
        {
            string STR, DEX, END, INT, PER, CHA;

            if (soldierRadioButton.Checked)
            {
                END = (Int16.Parse(AbilityForm.SetValueForENDTextBox) + 30).ToString();


                STR = (Int16.Parse(AbilityForm.SetValueForSTRTextBox) + 5).ToString();
                PER = (Int16.Parse(AbilityForm.SetValueForPERTextBox) + 5).ToString();
            }
            else
            {
                END = (Int16.Parse(AbilityForm.SetValueForENDTextBox) - 30).ToString();
            }

            if (rogueRadioButton.Checked)
            {
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) + 28).ToString();
            }
            else
            {
                DEX = (Int16.Parse(AbilityForm.SetValueForDEXTextBox) - 28).ToString();
            }

            if (magickerRadioButton.Checked)
            {
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) + 15).ToString();
            }
            else
            {
                INT = (Int16.Parse(AbilityForm.SetValueForINTTextBox) - 15).ToString();
            }

            if (cultistRadioButton.Checked)
            {
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) + 24).ToString();
            }
            else
            {
                CHA = (Int16.Parse(AbilityForm.SetValueForCHATextBox) + 24).ToString();
            }


        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            //1. intantiate 
            FinalForm finalForm = new FinalForm();

            //2. pass a reference to the 
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
