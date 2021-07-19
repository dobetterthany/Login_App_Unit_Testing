namespace StartPage
{
    partial class ViewButton
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
            this.btnViewInven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewInven
            // 
            this.btnViewInven.Location = new System.Drawing.Point(227, 109);
            this.btnViewInven.Name = "btnViewInven";
            this.btnViewInven.Size = new System.Drawing.Size(306, 186);
            this.btnViewInven.TabIndex = 0;
            this.btnViewInven.Text = "ViewInventory";
            this.btnViewInven.UseVisualStyleBackColor = true;
            this.btnViewInven.Click += new System.EventHandler(this.btnViewInven_Click);
            // 
            // ViewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewInven);
            this.Name = "ViewButton";
            this.Text = "AfterLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewInven;
    }
}