
namespace US_States
{
    partial class Form2
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
            this.uSStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDataSet = new US_States.StatesDataSet();
            this.uS_StatesTableAdapter = new US_States.StatesDataSetTableAdapters.US_StatesTableAdapter();
            this.stateDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uSStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uSStatesBindingSource
            // 
            this.uSStatesBindingSource.DataMember = "US States";
            this.uSStatesBindingSource.DataSource = this.statesDataSetBindingSource;
            // 
            // statesDataSetBindingSource
            // 
            this.statesDataSetBindingSource.DataSource = this.statesDataSet;
            this.statesDataSetBindingSource.Position = 0;
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
            // stateDetailsLabel
            // 
            this.stateDetailsLabel.AutoSize = true;
            this.stateDetailsLabel.Location = new System.Drawing.Point(294, 140);
            this.stateDetailsLabel.Name = "stateDetailsLabel";
            this.stateDetailsLabel.Size = new System.Drawing.Size(35, 13);
            this.stateDetailsLabel.TabIndex = 0;
            this.stateDetailsLabel.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 384);
            this.Controls.Add(this.stateDetailsLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource statesDataSetBindingSource;
        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource uSStatesBindingSource;
        private StatesDataSetTableAdapters.US_StatesTableAdapter uS_StatesTableAdapter;
        private System.Windows.Forms.Label stateDetailsLabel;
    }
}