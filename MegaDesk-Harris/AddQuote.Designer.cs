﻿namespace MegaDesk_Harris
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.width_txt_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.depth_txt_label = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfDrawersLabel = new System.Windows.Forms.NumericUpDown();
            this.MaterialTextLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaterialTypeMenu = new System.Windows.Forms.ComboBox();
            this.RushOrderMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceOutputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.myDate = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // width_txt_label
            // 
            this.width_txt_label.AutoSize = true;
            this.width_txt_label.Location = new System.Drawing.Point(446, 45);
            this.width_txt_label.Name = "width_txt_label";
            this.width_txt_label.Size = new System.Drawing.Size(52, 17);
            this.width_txt_label.TabIndex = 1;
            this.width_txt_label.Text = "Width: ";
            this.width_txt_label.Click += new System.EventHandler(this.width_txt_label_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(636, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(636, 99);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // depth_txt_label
            // 
            this.depth_txt_label.AutoSize = true;
            this.depth_txt_label.Location = new System.Drawing.Point(446, 104);
            this.depth_txt_label.Name = "depth_txt_label";
            this.depth_txt_label.Size = new System.Drawing.Size(50, 17);
            this.depth_txt_label.TabIndex = 4;
            this.depth_txt_label.Text = "Depth:";
            this.depth_txt_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(449, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            this.exitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Drawers:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfDrawersLabel
            // 
            this.NumberOfDrawersLabel.Location = new System.Drawing.Point(636, 158);
            this.NumberOfDrawersLabel.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawersLabel.Name = "NumberOfDrawersLabel";
            this.NumberOfDrawersLabel.Size = new System.Drawing.Size(120, 22);
            this.NumberOfDrawersLabel.TabIndex = 9;
            this.NumberOfDrawersLabel.ValueChanged += new System.EventHandler(this.NumberOfDrawersLabel_ValueChanged);
            // 
            // MaterialTextLabel
            // 
            this.MaterialTextLabel.AutoSize = true;
            this.MaterialTextLabel.Location = new System.Drawing.Point(71, 101);
            this.MaterialTextLabel.Name = "MaterialTextLabel";
            this.MaterialTextLabel.Size = new System.Drawing.Size(98, 17);
            this.MaterialTextLabel.TabIndex = 11;
            this.MaterialTextLabel.Text = "Material Type:";
            this.MaterialTextLabel.Click += new System.EventHandler(this.MaterialTextLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rush Order Days:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MaterialTypeMenu
            // 
            this.MaterialTypeMenu.FormattingEnabled = true;
            this.MaterialTypeMenu.Items.AddRange(new object[] {
            ""});
            this.MaterialTypeMenu.Location = new System.Drawing.Point(200, 97);
            this.MaterialTypeMenu.Name = "MaterialTypeMenu";
            this.MaterialTypeMenu.Size = new System.Drawing.Size(190, 24);
            this.MaterialTypeMenu.TabIndex = 14;
            this.MaterialTypeMenu.SelectedIndexChanged += new System.EventHandler(this.MaterialTypeMenu_SelectedIndexChanged);
            // 
            // RushOrderMenu
            // 
            this.RushOrderMenu.FormattingEnabled = true;
            this.RushOrderMenu.Location = new System.Drawing.Point(200, 156);
            this.RushOrderMenu.Name = "RushOrderMenu";
            this.RushOrderMenu.Size = new System.Drawing.Size(190, 24);
            this.RushOrderMenu.TabIndex = 15;
            this.RushOrderMenu.SelectedIndexChanged += new System.EventHandler(this.RushOrderMenu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price: ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // PriceOutputBox
            // 
            this.PriceOutputBox.Location = new System.Drawing.Point(566, 290);
            this.PriceOutputBox.Name = "PriceOutputBox";
            this.PriceOutputBox.Size = new System.Drawing.Size(190, 22);
            this.PriceOutputBox.TabIndex = 17;
            this.PriceOutputBox.TextChanged += new System.EventHandler(this.PriceOutputBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "CurrentDate:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // myDate
            // 
            this.myDate.AutoSize = true;
            this.myDate.Location = new System.Drawing.Point(197, 228);
            this.myDate.Name = "myDate";
            this.myDate.Size = new System.Drawing.Size(0, 17);
            this.myDate.TabIndex = 19;
            this.myDate.Click += new System.EventHandler(this.myDate_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.SaveButton.Location = new System.Drawing.Point(200, 349);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 48);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.myDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceOutputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RushOrderMenu);
            this.Controls.Add(this.MaterialTypeMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaterialTextLabel);
            this.Controls.Add(this.NumberOfDrawersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.depth_txt_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.width_txt_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AddQuote";
            this.Text = "Add a Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuoteFormClose);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.Leave += new System.EventHandler(this.exitButton_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label width_txt_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label depth_txt_label;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberOfDrawersLabel;
        private System.Windows.Forms.Label MaterialTextLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MaterialTypeMenu;
        private System.Windows.Forms.ComboBox RushOrderMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceOutputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label myDate;
        private System.Windows.Forms.Button SaveButton;
    }
}