namespace Example
{
    partial class PersonAutomobiles
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
            this.Automobiles = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnaddcar = new DevExpress.XtraEditors.SimpleButton();
            this.lblregistrnumb = new DevExpress.XtraEditors.LabelControl();
            this.registrnumbtxtEdit = new DevExpress.XtraEditors.TextEdit();
            this.lbldescription = new DevExpress.XtraEditors.LabelControl();
            this.descriptiontxtEdit = new DevExpress.XtraEditors.TextEdit();
            this.Deletebtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnAutoEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Automobiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrnumbtxtEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptiontxtEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Automobiles
            // 
            this.Automobiles.Location = new System.Drawing.Point(12, 12);
            this.Automobiles.MainView = this.gridView1;
            this.Automobiles.Name = "Automobiles";
            this.Automobiles.Size = new System.Drawing.Size(457, 194);
            this.Automobiles.TabIndex = 1;
            this.Automobiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Number,
            this.Description});
            this.gridView1.GridControl = this.Automobiles;
            this.gridView1.Name = "gridView1";
            // 
            // Number
            // 
            this.Number.Caption = "Number";
            this.Number.FieldName = "Registration_number";
            this.Number.Name = "Number";
            this.Number.Visible = true;
            this.Number.VisibleIndex = 0;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            // 
            // btnaddcar
            // 
            this.btnaddcar.Location = new System.Drawing.Point(384, 302);
            this.btnaddcar.Name = "btnaddcar";
            this.btnaddcar.Size = new System.Drawing.Size(88, 25);
            this.btnaddcar.TabIndex = 26;
            this.btnaddcar.Text = "Add";
            this.btnaddcar.Click += new System.EventHandler(this.btnaddcar_Click);
            // 
            // lblregistrnumb
            // 
            this.lblregistrnumb.Location = new System.Drawing.Point(249, 269);
            this.lblregistrnumb.Name = "lblregistrnumb";
            this.lblregistrnumb.Size = new System.Drawing.Size(97, 13);
            this.lblregistrnumb.TabIndex = 25;
            this.lblregistrnumb.Text = "Registration number";
            // 
            // registrnumbtxtEdit
            // 
            this.registrnumbtxtEdit.Location = new System.Drawing.Point(352, 266);
            this.registrnumbtxtEdit.Name = "registrnumbtxtEdit";
            this.registrnumbtxtEdit.Size = new System.Drawing.Size(120, 20);
            this.registrnumbtxtEdit.TabIndex = 24;
            // 
            // lbldescription
            // 
            this.lbldescription.Location = new System.Drawing.Point(15, 269);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(53, 13);
            this.lbldescription.TabIndex = 23;
            this.lbldescription.Text = "Description";
            // 
            // descriptiontxtEdit
            // 
            this.descriptiontxtEdit.Location = new System.Drawing.Point(86, 266);
            this.descriptiontxtEdit.Name = "descriptiontxtEdit";
            this.descriptiontxtEdit.Size = new System.Drawing.Size(114, 20);
            this.descriptiontxtEdit.TabIndex = 22;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(290, 222);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(83, 25);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // btnAutoEdit
            // 
            this.btnAutoEdit.Location = new System.Drawing.Point(384, 222);
            this.btnAutoEdit.Name = "btnAutoEdit";
            this.btnAutoEdit.Size = new System.Drawing.Size(88, 25);
            this.btnAutoEdit.TabIndex = 20;
            this.btnAutoEdit.Text = "Edit...";
            this.btnAutoEdit.Click += new System.EventHandler(this.btnAutoEdit_Click);
            // 
            // PersonAutomobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 348);
            this.Controls.Add(this.btnaddcar);
            this.Controls.Add(this.lblregistrnumb);
            this.Controls.Add(this.registrnumbtxtEdit);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.descriptiontxtEdit);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.btnAutoEdit);
            this.Controls.Add(this.Automobiles);
            this.Name = "PersonAutomobiles";
            this.Text = "PersonAutomobiles";
            this.Load += new System.EventHandler(this.PersonAutomobiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Automobiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrnumbtxtEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptiontxtEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Automobiles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Number;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraEditors.SimpleButton btnaddcar;
        private DevExpress.XtraEditors.LabelControl lblregistrnumb;
        private DevExpress.XtraEditors.TextEdit registrnumbtxtEdit;
        private DevExpress.XtraEditors.LabelControl lbldescription;
        private DevExpress.XtraEditors.TextEdit descriptiontxtEdit;
        private DevExpress.XtraEditors.SimpleButton Deletebtn;
        private DevExpress.XtraEditors.SimpleButton btnAutoEdit;
    }
}