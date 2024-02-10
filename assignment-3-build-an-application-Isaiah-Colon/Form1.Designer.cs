
namespace US_States
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usStateDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.populationRadioButton = new System.Windows.Forms.RadioButton();
            this.percentageOfComputerJobsRadioButton = new System.Windows.Forms.RadioButton();
            this.medianIncomeRadioButton = new System.Windows.Forms.RadioButton();
            this.stateCapitolRadioButton = new System.Windows.Forms.RadioButton();
            this.threeLargestCitiesRadioButton = new System.Windows.Forms.RadioButton();
            this.stateColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.stateBirdRadioButton = new System.Windows.Forms.RadioButton();
            this.stateFlowerRadioButton = new System.Windows.Forms.RadioButton();
            this.flagDescriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.stateNameRadioButton = new System.Windows.Forms.RadioButton();
            this.stateValueTextBox = new System.Windows.Forms.TextBox();
            this.numberValueTextBox = new System.Windows.Forms.TextBox();
            this.greaterThenCheckBox = new System.Windows.Forms.CheckBox();
            this.lessThenCheckBox = new System.Windows.Forms.CheckBox();
            this.stateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeLargestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCapitolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageOfComputerJobsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDataSet = new US_States.StatesDataSet();
            this.uS_StatesTableAdapter = new US_States.StatesDataSetTableAdapters.US_StatesTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usStateDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usStateDataGridView
            // 
            this.usStateDataGridView.AutoGenerateColumns = false;
            this.usStateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usStateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateNumberDataGridViewTextBoxColumn,
            this.stateNameDataGridViewTextBoxColumn,
            this.flagDescriptionDataGridViewTextBoxColumn,
            this.stateFlowerDataGridViewTextBoxColumn,
            this.stateBirdDataGridViewTextBoxColumn,
            this.stateColorsDataGridViewTextBoxColumn,
            this.threeLargestCitiesDataGridViewTextBoxColumn,
            this.stateCapitolDataGridViewTextBoxColumn,
            this.medianIncomeDataGridViewTextBoxColumn,
            this.percentageOfComputerJobsDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.usStateDataGridView.DataSource = this.uSStatesBindingSource;
            this.usStateDataGridView.Location = new System.Drawing.Point(0, 52);
            this.usStateDataGridView.Name = "usStateDataGridView";
            this.usStateDataGridView.Size = new System.Drawing.Size(1246, 245);
            this.usStateDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem1.Text = "State";
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(56, 346);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 2;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateDropdownMenu_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(526, 522);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "S&earch";
            this.toolTip1.SetToolTip(this.searchButton, "This button filters the data.");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1258, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // populationRadioButton
            // 
            this.populationRadioButton.AutoSize = true;
            this.populationRadioButton.Location = new System.Drawing.Point(667, 405);
            this.populationRadioButton.Name = "populationRadioButton";
            this.populationRadioButton.Size = new System.Drawing.Size(75, 17);
            this.populationRadioButton.TabIndex = 5;
            this.populationRadioButton.TabStop = true;
            this.populationRadioButton.Text = "Population";
            this.populationRadioButton.UseVisualStyleBackColor = true;
            // 
            // percentageOfComputerJobsRadioButton
            // 
            this.percentageOfComputerJobsRadioButton.AutoSize = true;
            this.percentageOfComputerJobsRadioButton.Location = new System.Drawing.Point(708, 382);
            this.percentageOfComputerJobsRadioButton.Name = "percentageOfComputerJobsRadioButton";
            this.percentageOfComputerJobsRadioButton.Size = new System.Drawing.Size(165, 17);
            this.percentageOfComputerJobsRadioButton.TabIndex = 6;
            this.percentageOfComputerJobsRadioButton.TabStop = true;
            this.percentageOfComputerJobsRadioButton.Text = "Percentage of Computer Jobs";
            this.percentageOfComputerJobsRadioButton.UseVisualStyleBackColor = true;
            // 
            // medianIncomeRadioButton
            // 
            this.medianIncomeRadioButton.AutoSize = true;
            this.medianIncomeRadioButton.Location = new System.Drawing.Point(835, 405);
            this.medianIncomeRadioButton.Name = "medianIncomeRadioButton";
            this.medianIncomeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.medianIncomeRadioButton.TabIndex = 7;
            this.medianIncomeRadioButton.TabStop = true;
            this.medianIncomeRadioButton.Text = "Median Income";
            this.medianIncomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateCapitolRadioButton
            // 
            this.stateCapitolRadioButton.AutoSize = true;
            this.stateCapitolRadioButton.Location = new System.Drawing.Point(131, 84);
            this.stateCapitolRadioButton.Name = "stateCapitolRadioButton";
            this.stateCapitolRadioButton.Size = new System.Drawing.Size(85, 17);
            this.stateCapitolRadioButton.TabIndex = 8;
            this.stateCapitolRadioButton.TabStop = true;
            this.stateCapitolRadioButton.Text = "State Capitol";
            this.stateCapitolRadioButton.UseVisualStyleBackColor = true;
            // 
            // threeLargestCitiesRadioButton
            // 
            this.threeLargestCitiesRadioButton.AutoSize = true;
            this.threeLargestCitiesRadioButton.Location = new System.Drawing.Point(131, 61);
            this.threeLargestCitiesRadioButton.Name = "threeLargestCitiesRadioButton";
            this.threeLargestCitiesRadioButton.Size = new System.Drawing.Size(119, 17);
            this.threeLargestCitiesRadioButton.TabIndex = 9;
            this.threeLargestCitiesRadioButton.TabStop = true;
            this.threeLargestCitiesRadioButton.Text = "Three Largest Cities";
            this.threeLargestCitiesRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateColorsRadioButton
            // 
            this.stateColorsRadioButton.AutoSize = true;
            this.stateColorsRadioButton.Location = new System.Drawing.Point(21, 130);
            this.stateColorsRadioButton.Name = "stateColorsRadioButton";
            this.stateColorsRadioButton.Size = new System.Drawing.Size(82, 17);
            this.stateColorsRadioButton.TabIndex = 10;
            this.stateColorsRadioButton.TabStop = true;
            this.stateColorsRadioButton.Text = "State Colors";
            this.stateColorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateBirdRadioButton
            // 
            this.stateBirdRadioButton.AutoSize = true;
            this.stateBirdRadioButton.Location = new System.Drawing.Point(131, 107);
            this.stateBirdRadioButton.Name = "stateBirdRadioButton";
            this.stateBirdRadioButton.Size = new System.Drawing.Size(71, 17);
            this.stateBirdRadioButton.TabIndex = 11;
            this.stateBirdRadioButton.TabStop = true;
            this.stateBirdRadioButton.Text = "State Bird";
            this.stateBirdRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateFlowerRadioButton
            // 
            this.stateFlowerRadioButton.AutoSize = true;
            this.stateFlowerRadioButton.Location = new System.Drawing.Point(19, 107);
            this.stateFlowerRadioButton.Name = "stateFlowerRadioButton";
            this.stateFlowerRadioButton.Size = new System.Drawing.Size(84, 17);
            this.stateFlowerRadioButton.TabIndex = 12;
            this.stateFlowerRadioButton.TabStop = true;
            this.stateFlowerRadioButton.Text = "State Flower";
            this.stateFlowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // flagDescriptionRadioButton
            // 
            this.flagDescriptionRadioButton.AutoSize = true;
            this.flagDescriptionRadioButton.Location = new System.Drawing.Point(19, 84);
            this.flagDescriptionRadioButton.Name = "flagDescriptionRadioButton";
            this.flagDescriptionRadioButton.Size = new System.Drawing.Size(101, 17);
            this.flagDescriptionRadioButton.TabIndex = 13;
            this.flagDescriptionRadioButton.TabStop = true;
            this.flagDescriptionRadioButton.Text = "Flag Description";
            this.flagDescriptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateNameRadioButton
            // 
            this.stateNameRadioButton.AutoSize = true;
            this.stateNameRadioButton.Location = new System.Drawing.Point(19, 61);
            this.stateNameRadioButton.Name = "stateNameRadioButton";
            this.stateNameRadioButton.Size = new System.Drawing.Size(81, 17);
            this.stateNameRadioButton.TabIndex = 14;
            this.stateNameRadioButton.TabStop = true;
            this.stateNameRadioButton.Text = "State Name";
            this.stateNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // stateValueTextBox
            // 
            this.stateValueTextBox.Location = new System.Drawing.Point(93, 153);
            this.stateValueTextBox.Name = "stateValueTextBox";
            this.stateValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateValueTextBox.TabIndex = 15;
            // 
            // numberValueTextBox
            // 
            this.numberValueTextBox.Location = new System.Drawing.Point(104, 158);
            this.numberValueTextBox.Name = "numberValueTextBox";
            this.numberValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberValueTextBox.TabIndex = 16;
            // 
            // greaterThenCheckBox
            // 
            this.greaterThenCheckBox.AutoSize = true;
            this.greaterThenCheckBox.Location = new System.Drawing.Point(835, 360);
            this.greaterThenCheckBox.Name = "greaterThenCheckBox";
            this.greaterThenCheckBox.Size = new System.Drawing.Size(89, 17);
            this.greaterThenCheckBox.TabIndex = 19;
            this.greaterThenCheckBox.Text = "Greater Then";
            this.greaterThenCheckBox.UseVisualStyleBackColor = true;
            // 
            // lessThenCheckBox
            // 
            this.lessThenCheckBox.AutoSize = true;
            this.lessThenCheckBox.Location = new System.Drawing.Point(667, 359);
            this.lessThenCheckBox.Name = "lessThenCheckBox";
            this.lessThenCheckBox.Size = new System.Drawing.Size(76, 17);
            this.lessThenCheckBox.TabIndex = 20;
            this.lessThenCheckBox.Text = "Less Then";
            this.lessThenCheckBox.UseVisualStyleBackColor = true;
            // 
            // stateNumberDataGridViewTextBoxColumn
            // 
            this.stateNumberDataGridViewTextBoxColumn.DataPropertyName = "State Number";
            this.stateNumberDataGridViewTextBoxColumn.HeaderText = "State Number";
            this.stateNumberDataGridViewTextBoxColumn.Name = "stateNumberDataGridViewTextBoxColumn";
            this.stateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "State Name";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "State Name";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // flagDescriptionDataGridViewTextBoxColumn
            // 
            this.flagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Flag Description";
            this.flagDescriptionDataGridViewTextBoxColumn.HeaderText = "Flag Description";
            this.flagDescriptionDataGridViewTextBoxColumn.Name = "flagDescriptionDataGridViewTextBoxColumn";
            // 
            // stateFlowerDataGridViewTextBoxColumn
            // 
            this.stateFlowerDataGridViewTextBoxColumn.DataPropertyName = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.HeaderText = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.Name = "stateFlowerDataGridViewTextBoxColumn";
            // 
            // stateBirdDataGridViewTextBoxColumn
            // 
            this.stateBirdDataGridViewTextBoxColumn.DataPropertyName = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.HeaderText = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.Name = "stateBirdDataGridViewTextBoxColumn";
            // 
            // stateColorsDataGridViewTextBoxColumn
            // 
            this.stateColorsDataGridViewTextBoxColumn.DataPropertyName = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.HeaderText = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.Name = "stateColorsDataGridViewTextBoxColumn";
            // 
            // threeLargestCitiesDataGridViewTextBoxColumn
            // 
            this.threeLargestCitiesDataGridViewTextBoxColumn.DataPropertyName = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.HeaderText = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.Name = "threeLargestCitiesDataGridViewTextBoxColumn";
            // 
            // stateCapitolDataGridViewTextBoxColumn
            // 
            this.stateCapitolDataGridViewTextBoxColumn.DataPropertyName = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.HeaderText = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.Name = "stateCapitolDataGridViewTextBoxColumn";
            // 
            // medianIncomeDataGridViewTextBoxColumn
            // 
            this.medianIncomeDataGridViewTextBoxColumn.DataPropertyName = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.HeaderText = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.Name = "medianIncomeDataGridViewTextBoxColumn";
            // 
            // percentageOfComputerJobsDataGridViewTextBoxColumn
            // 
            this.percentageOfComputerJobsDataGridViewTextBoxColumn.DataPropertyName = "Percentage of Computer Jobs";
            this.percentageOfComputerJobsDataGridViewTextBoxColumn.HeaderText = "Percentage of Computer Jobs";
            this.percentageOfComputerJobsDataGridViewTextBoxColumn.Name = "percentageOfComputerJobsDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // uSStatesBindingSource
            // 
            this.uSStatesBindingSource.DataMember = "US States";
            this.uSStatesBindingSource.DataSource = this.statesDataSet;
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "StatesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uS_StatesTableAdapter
            // 
            this.uS_StatesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.stateValueTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.stateBirdRadioButton);
            this.groupBox2.Controls.Add(this.stateColorsRadioButton);
            this.groupBox2.Controls.Add(this.stateFlowerRadioButton);
            this.groupBox2.Controls.Add(this.flagDescriptionRadioButton);
            this.groupBox2.Controls.Add(this.stateNameRadioButton);
            this.groupBox2.Controls.Add(this.threeLargestCitiesRadioButton);
            this.groupBox2.Controls.Add(this.stateCapitolRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(234, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numberValueTextBox);
            this.groupBox3.Location = new System.Drawing.Point(651, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 193);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Numeric Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please choose what column you \r\nwant to filter and then add a description.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please choose the range and the colum \r\nyou want to filter and then add the data." +
    " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Press the button to filter the data by the columns.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Select a state from the Dropdown Menu.";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(780, 522);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "This button exits the program.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1258, 557);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lessThenCheckBox);
            this.Controls.Add(this.greaterThenCheckBox);
            this.Controls.Add(this.medianIncomeRadioButton);
            this.Controls.Add(this.percentageOfComputerJobsRadioButton);
            this.Controls.Add(this.populationRadioButton);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.usStateDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isaiah-Colon-assignment-3-build-an-application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usStateDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usStateDataGridView;
        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource uSStatesBindingSource;
        private StatesDataSetTableAdapters.US_StatesTableAdapter uS_StatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateBirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeLargestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCapitolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageOfComputerJobsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.RadioButton populationRadioButton;
        private System.Windows.Forms.RadioButton percentageOfComputerJobsRadioButton;
        private System.Windows.Forms.RadioButton medianIncomeRadioButton;
        private System.Windows.Forms.RadioButton stateCapitolRadioButton;
        private System.Windows.Forms.RadioButton threeLargestCitiesRadioButton;
        private System.Windows.Forms.RadioButton stateColorsRadioButton;
        private System.Windows.Forms.RadioButton stateBirdRadioButton;
        private System.Windows.Forms.RadioButton stateFlowerRadioButton;
        private System.Windows.Forms.RadioButton flagDescriptionRadioButton;
        private System.Windows.Forms.RadioButton stateNameRadioButton;
        private System.Windows.Forms.TextBox stateValueTextBox;
        private System.Windows.Forms.TextBox numberValueTextBox;
        private System.Windows.Forms.CheckBox greaterThenCheckBox;
        private System.Windows.Forms.CheckBox lessThenCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitButton;
    }
}

