namespace WindowsFormsPractice
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
            this.txtNewWindowName = new System.Windows.Forms.TextBox();
            this.lblNewWindowName = new System.Windows.Forms.Label();
            this.btnNewWindowSubmit = new System.Windows.Forms.Button();
            this.txtNewWindowID = new System.Windows.Forms.TextBox();
            this.lblNewWindowID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewWindowName
            // 
            this.txtNewWindowName.Location = new System.Drawing.Point(62, 40);
            this.txtNewWindowName.Name = "txtNewWindowName";
            this.txtNewWindowName.Size = new System.Drawing.Size(94, 22);
            this.txtNewWindowName.TabIndex = 16;
            // 
            // lblNewWindowName
            // 
            this.lblNewWindowName.AutoSize = true;
            this.lblNewWindowName.Location = new System.Drawing.Point(18, 43);
            this.lblNewWindowName.Name = "lblNewWindowName";
            this.lblNewWindowName.Size = new System.Drawing.Size(38, 12);
            this.lblNewWindowName.TabIndex = 15;
            this.lblNewWindowName.Text = "Name: ";
            // 
            // btnNewWindowSubmit
            // 
            this.btnNewWindowSubmit.Location = new System.Drawing.Point(233, 162);
            this.btnNewWindowSubmit.Name = "btnNewWindowSubmit";
            this.btnNewWindowSubmit.Size = new System.Drawing.Size(102, 24);
            this.btnNewWindowSubmit.TabIndex = 17;
            this.btnNewWindowSubmit.Text = "Submit";
            this.btnNewWindowSubmit.UseVisualStyleBackColor = true;
            this.btnNewWindowSubmit.Click += new System.EventHandler(this.btnNewWindowSubmit_Click);
            // 
            // txtNewWindowID
            // 
            this.txtNewWindowID.Location = new System.Drawing.Point(62, 12);
            this.txtNewWindowID.Name = "txtNewWindowID";
            this.txtNewWindowID.ReadOnly = true;
            this.txtNewWindowID.Size = new System.Drawing.Size(94, 22);
            this.txtNewWindowID.TabIndex = 19;
            // 
            // lblNewWindowID
            // 
            this.lblNewWindowID.AutoSize = true;
            this.lblNewWindowID.Location = new System.Drawing.Point(18, 15);
            this.lblNewWindowID.Name = "lblNewWindowID";
            this.lblNewWindowID.Size = new System.Drawing.Size(20, 12);
            this.lblNewWindowID.TabIndex = 18;
            this.lblNewWindowID.Text = "ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 198);
            this.Controls.Add(this.txtNewWindowID);
            this.Controls.Add(this.lblNewWindowID);
            this.Controls.Add(this.btnNewWindowSubmit);
            this.Controls.Add(this.txtNewWindowName);
            this.Controls.Add(this.lblNewWindowName);
            this.Name = "Form2";
            this.Text = "New Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewWindowName;
        private System.Windows.Forms.Label lblNewWindowName;
        private System.Windows.Forms.Button btnNewWindowSubmit;
        private System.Windows.Forms.TextBox txtNewWindowID;
        private System.Windows.Forms.Label lblNewWindowID;
    }
}