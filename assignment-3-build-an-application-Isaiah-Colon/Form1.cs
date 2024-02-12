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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDataSet.US_States' table. You can move, or remove it, as needed.
            this.uS_StatesTableAdapter.Fill(this.statesDataSet.US_States);//reutrn states dataset

            
            LoadStatesIntoComboBox();
        }
                

        //Method for the action of selecting from combo box
        private void stateDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatesClass state = new StatesClass();
            SelectDropdownState(state);

        }

        //Fills Combo box with states
        private void LoadStatesIntoComboBox()
        {
            var result = from state in statesDataSet.US_States
                         select state.State_Name;
            
            stateComboBox.Items.AddRange(result.ToArray());
        }

        //Method to search state data from chosen item
        private void SelectDropdownState(StatesClass state)
        {
            //State chosen from dropdown stored into variable
            state.StateName = stateComboBox.SelectedItem.ToString();

            //SQL query
            this.uS_StatesTableAdapter.SelectState(this.statesDataSet.US_States, state.StateName);


            state.State = stateComboBox.SelectedItem.ToString();

            //Allows to call state details into another form
            var stateDetails = new StatesClass
            {
                State = state.State
            };


        }

        //Method to filter data upon user input running queries
        private void FilterData(StatesClass state)
        {            
            state.StateName = stateValueTextBox.Text;
            

            if (flagDescriptionRadioButton.Checked)
            {                
                this.uS_StatesTableAdapter.SelectFlagDescription(this.statesDataSet.US_States,state.StateName);
            }
            else if (stateNameRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.SelectState(this.statesDataSet.US_States, state.StateName);
            }
            else if (stateFlowerRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.SelectStateFlower(this.statesDataSet.US_States, state.StateName);
            }
            else if (stateBirdRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.selectStateBird(this.statesDataSet.US_States, state.StateName);
            }
            else if (stateColorsRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.SelectStateColors(this.statesDataSet.US_States, state.StateName);
            }
            else if (threeLargestCitiesRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.SelectThreeLargestCities(this.statesDataSet.US_States, state.StateName);
            }
            else if (stateCapitolRadioButton.Checked)
            {
                this.uS_StatesTableAdapter.SelectStateCapitol(this.statesDataSet.US_States, state.StateName);
            }
        }

        //Method to filter numeric data upon user input running queries
        private void FilterNumericData(StatesClass state)
        {
            state.StateName = numberValueTextBox.Text;

            //Filters data with queries in SQL depennding on user input
            if (lessThenCheckBox.Checked)
            {
                if(populationRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectPopulationLessThen(this.statesDataSet.US_States, int.Parse(state.StateName));
                }
                else if (medianIncomeRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectMedianIncomeLessThen(this.statesDataSet.US_States, int.Parse(state.StateName));
                }
                else if (percentageOfComputerJobsRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectPercentageLessThen(this.statesDataSet.US_States, state.StateName);
                }
            }
            if (greaterThenCheckBox.Checked)
            {
                if (populationRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectPopulationGreaterThen(this.statesDataSet.US_States, int.Parse(state.StateName));
                }
                else if (medianIncomeRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectMedianIncomeGreaterThen(this.statesDataSet.US_States, int.Parse(state.StateName));
                }
                else if (percentageOfComputerJobsRadioButton.Checked)
                {
                    this.uS_StatesTableAdapter.SelectPercentageGreaterThen(this.statesDataSet.US_States, state.StateName);
                }
            }
        }

        //Calls methods to filter data
        private void searchButton_Click(object sender, EventArgs e)
        {
            StatesClass state = new StatesClass();
            FilterData(state);
            FilterNumericData(state);
        }

        private void stateDetailsButton_Click(object sender, EventArgs e)
        {
            //StatesClass state = new StatesClass();
            //state.StateName = stateComboBox.SelectedItem.ToString();

            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
