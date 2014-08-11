namespace Example
{
    partial class MainForm
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
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spinAge = new DevExpress.XtraEditors.SpinEdit();
            this.lblAge = new DevExpress.XtraEditors.LabelControl();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(33, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(93, 41);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Example.Person);
            // 
            // spinAge
            // 
            this.spinAge.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Age", true));
            this.spinAge.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinAge.Location = new System.Drawing.Point(93, 72);
            this.spinAge.Name = "spinAge";
            this.spinAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinAge.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinAge.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinAge.Size = new System.Drawing.Size(179, 20);
            this.spinAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(64, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(23, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(33, 44);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(93, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(179, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(119, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(200, 166);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "City:";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Name", true));
            this.textEdit1.Location = new System.Drawing.Point(93, 100);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(179, 20);
            this.textEdit1.TabIndex = 9;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Example.City);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "ReturnAutomobile", true));
            this.textEdit2.Location = new System.Drawing.Point(93, 126);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(179, 20);
            this.textEdit2.TabIndex = 10;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Example.Person);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Cars:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 216);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.spinAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "MainForm";
            this.Text = "Person App";
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.SpinEdit spinAge;
        private DevExpress.XtraEditors.LabelControl lblAge;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

