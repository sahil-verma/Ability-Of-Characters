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
    }
}
