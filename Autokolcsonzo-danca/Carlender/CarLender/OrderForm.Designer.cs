﻿
namespace CarLender.GUI
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIDNum = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID number:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxIDNum
            // 
            this.textBoxIDNum.Location = new System.Drawing.Point(85, 40);
            this.textBoxIDNum.Name = "textBoxIDNum";
            this.textBoxIDNum.Size = new System.Drawing.Size(270, 23);
            this.textBoxIDNum.TabIndex = 3;
            this.textBoxIDNum.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(12, 73);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(343, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Book the car";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 108);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.textBoxIDNum);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Finalize order";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIDNum;
        private System.Windows.Forms.Button orderButton;
    }
}