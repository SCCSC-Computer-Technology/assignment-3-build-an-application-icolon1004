using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_States
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.US_States' table. You can move, or remove it, as needed.
            this.uS_StatesTableAdapter.Fill(this.statesDataSet.US_States);

            StatesClass state = new StatesClass();

            stateDetailsLabel.Text = state.State;

            
        }


    }
}
