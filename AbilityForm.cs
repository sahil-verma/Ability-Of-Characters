using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermAssignment_200335300
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();
        private List<TextBox> _abilities;

        public AbilityForm()
        {
            InitializeComponent();

            //inititalizing the list
            this._abilities = new List<TextBox>();
        }

        private void _initializeAbilities()
        {
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);

        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int _Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            STRTextBox.Text = this._Roll3D10().ToString();
            DEXTextBox.Text = this._Roll3D10().ToString();
            ENDTextBox.Text = this._Roll3D10().ToString();
            INTTextBox.Text = this._Roll3D10().ToString();
            PERTextBox.Text = this._Roll3D10().ToString();
            CHATextBox.Text = this._Roll3D10().ToString();
        }

        public static string SetValueForSTRTextBox = "";
        public static string SetValueForDEXTextBox = "";
        public static string SetValueForENDTextBox = "";
        public static string SetValueForINTTextBox = "";
        public static string SetValueForPERTextBox = "";
        public static string SetValueForCHATextBox = "";



        private void NextButton_Click(object sender, EventArgs e)
        {
            SetValueForSTRTextBox = STRTextBox.Text;
            SetValueForDEXTextBox = DEXTextBox.Text;
            SetValueForENDTextBox = ENDTextBox.Text;
            SetValueForINTTextBox = INTTextBox.Text;
            SetValueForPERTextBox = PERTextBox.Text;
            SetValueForCHATextBox = CHATextBox.Text;

            //1. intantiate 
            RaceForm raceForm = new RaceForm();

            //2. pass a reference to the 
            raceForm.previousForm = this;

            raceForm.Show();
            this.Hide();
        }
    }
}
