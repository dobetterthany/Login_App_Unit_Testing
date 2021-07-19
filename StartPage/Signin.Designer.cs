namespace StartPage
{
    partial class Signin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCredential = new System.Windows.Forms.TextBox();
            this.lbUNstatus = new System.Windows.Forms.Label();
            this.lbPWstatus = new System.Windows.Forms.Label();
            this.lbCstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(327, 154);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 25);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(327, 108);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 25);
            this.tbUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Credential";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCredential
            // 
            this.tbCredential.Location = new System.Drawing.Point(327, 210);
            this.tbCredential.Name = "tbCredential";
            this.tbCredential.Size = new System.Drawing.Size(100, 25);
            this.tbCredential.TabIndex = 11;
            // 
            // lbUNstatus
            // 
            this.lbUNstatus.AutoSize = true;
            this.lbUNstatus.Location = new System.Drawing.Point(443, 118);
            this.lbUNstatus.Name = "lbUNstatus";
            this.lbUNstatus.Size = new System.Drawing.Size(0, 19);
            this.lbUNstatus.TabIndex = 12;
            // 
            // lbPWstatus
            // 
            this.lbPWstatus.AutoSize = true;
            this.lbPWstatus.Location = new System.Drawing.Point(443, 164);
            this.lbPWstatus.Name = "lbPWstatus";
            this.lbPWstatus.Size = new System.Drawing.Size(0, 19);
            this.lbPWstatus.TabIndex = 13;
            this.lbPWstatus.Click += new System.EventHandler(this.lbPWstatus_Click);
            // 
            // lbCstatus
            // 
            this.lbCstatus.AutoSize = true;
            this.lbCstatus.Location = new System.Drawing.Point(443, 220);
            this.lbCstatus.Name = "lbCstatus";
            this.lbCstatus.Size = new System.Drawing.Size(0, 19);
            this.lbCstatus.TabIndex = 14;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCstatus);
            this.Controls.Add(this.lbPWstatus);
            this.Controls.Add(this.lbUNstatus);
            this.Controls.Add(this.tbCredential);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Name = "Signin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Signin";
            this.Load += new System.EventHandler(this.Signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCredential;
        private System.Windows.Forms.Label lbUNstatus;
        private System.Windows.Forms.Label lbPWstatus;
        private System.Windows.Forms.Label lbCstatus;
    }
}