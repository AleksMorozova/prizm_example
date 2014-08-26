namespace Example
{
    partial class Extra
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBirthPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtBirtDate = new DevExpress.XtraEditors.TextEdit();
            this.btnSaveExtra = new DevExpress.XtraEditors.SimpleButton();
            this.additionalInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Place of birth";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Date of birth";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(103, 61);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(166, 20);
            this.txtBirthPlace.TabIndex = 8;
            // 
            // txtBirtDate
            // 
            this.txtBirtDate.Location = new System.Drawing.Point(103, 17);
            this.txtBirtDate.Name = "txtBirtDate";
            this.txtBirtDate.Size = new System.Drawing.Size(166, 20);
            this.txtBirtDate.TabIndex = 7;
            // 
            // btnSaveExtra
            // 
            this.btnSaveExtra.Location = new System.Drawing.Point(194, 111);
            this.btnSaveExtra.Name = "btnSaveExtra";
            this.btnSaveExtra.Size = new System.Drawing.Size(75, 23);
            this.btnSaveExtra.TabIndex = 6;
            this.btnSaveExtra.Text = "OK";
            this.btnSaveExtra.Click += new System.EventHandler(this.btnSaveExtra_Click);
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.txtBirtDate);
            this.Controls.Add(this.btnSaveExtra);
            this.Name = "Extra";
            this.Text = "Extra";
            this.Load += new System.EventHandler(this.Extra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBirthPlace;
        private DevExpress.XtraEditors.TextEdit txtBirtDate;
        private DevExpress.XtraEditors.SimpleButton btnSaveExtra;
        private System.Windows.Forms.BindingSource additionalInformationBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}