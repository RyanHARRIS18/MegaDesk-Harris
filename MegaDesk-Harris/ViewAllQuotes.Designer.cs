namespace MegaDesk_Harris
{
    partial class ViewAllQuotes
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
            this.ViewRecent = new System.Windows.Forms.Button();
            this.ExitViewAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewRecent
            // 
            this.ViewRecent.Location = new System.Drawing.Point(293, 375);
            this.ViewRecent.Name = "ViewRecent";
            this.ViewRecent.Size = new System.Drawing.Size(75, 23);
            this.ViewRecent.TabIndex = 3;
            this.ViewRecent.Text = "Search";
            this.ViewRecent.UseVisualStyleBackColor = true;
            // 
            // ExitViewAllButton
            // 
            this.ExitViewAllButton.Location = new System.Drawing.Point(408, 375);
            this.ExitViewAllButton.Name = "ExitViewAllButton";
            this.ExitViewAllButton.Size = new System.Drawing.Size(75, 23);
            this.ExitViewAllButton.TabIndex = 2;
            this.ExitViewAllButton.Text = "Exit";
            this.ExitViewAllButton.UseVisualStyleBackColor = true;
            this.ExitViewAllButton.Click += new System.EventHandler(this.ExitViewAllButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewRecent);
            this.Controls.Add(this.ExitViewAllButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewRecent;
        private System.Windows.Forms.Button ExitViewAllButton;
    }
}