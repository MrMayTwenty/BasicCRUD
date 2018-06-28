namespace BasicCRUD
{
    partial class CtrlContactName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGivenName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoEllipsis = true;
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.BackColor = System.Drawing.Color.Transparent;
            this.lblGivenName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGivenName.Location = new System.Drawing.Point(14, 39);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(134, 21);
            this.lblGivenName.TabIndex = 3;
            this.lblGivenName.Text = "Aga Francis Amiel";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoEllipsis = true;
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(13, 9);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(90, 30);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Anciano";
            // 
            // CtrlContactName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGivenName);
            this.Controls.Add(this.lblSurname);
            this.Name = "CtrlContactName";
            this.Size = new System.Drawing.Size(160, 69);
            this.Load += new System.EventHandler(this.CtrlContactName_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CtrlContactName_MouseDown);
            this.MouseEnter += new System.EventHandler(this.CtrlContactName_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CtrlContactName_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGivenName;
        private System.Windows.Forms.Label lblSurname;
    }
}
