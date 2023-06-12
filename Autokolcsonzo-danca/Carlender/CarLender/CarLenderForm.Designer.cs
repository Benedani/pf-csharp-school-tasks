
namespace CarLender.GUI
{
    partial class CarLenderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarLender_shopView = new System.Windows.Forms.DataGridView();
            this.CarLender_colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarLender_colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarLender_panel = new System.Windows.Forms.Panel();
            this.CarLender_panel_radio1 = new System.Windows.Forms.RadioButton();
            this.CarLender_panel_btnBook = new System.Windows.Forms.Button();
            this.CarLender_panel_picture = new System.Windows.Forms.PictureBox();
            this.CarLender_panel_tileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarLender_shopView)).BeginInit();
            this.CarLender_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarLender_panel_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // CarLender_shopView
            // 
            this.CarLender_shopView.AllowUserToAddRows = false;
            this.CarLender_shopView.AllowUserToDeleteRows = false;
            this.CarLender_shopView.AllowUserToResizeRows = false;
            this.CarLender_shopView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarLender_shopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarLender_shopView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarLender_colManufacturer,
            this.CarLender_colBrand});
            this.CarLender_shopView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CarLender_shopView.Location = new System.Drawing.Point(12, 12);
            this.CarLender_shopView.MultiSelect = false;
            this.CarLender_shopView.Name = "CarLender_shopView";
            this.CarLender_shopView.ReadOnly = true;
            this.CarLender_shopView.RowHeadersVisible = false;
            this.CarLender_shopView.RowTemplate.Height = 25;
            this.CarLender_shopView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CarLender_shopView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarLender_shopView.Size = new System.Drawing.Size(361, 391);
            this.CarLender_shopView.TabIndex = 0;
            this.CarLender_shopView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.CarLender_shopView_RowStateChanged);
            // 
            // CarLender_colManufacturer
            // 
            this.CarLender_colManufacturer.HeaderText = "Manufacturer";
            this.CarLender_colManufacturer.Name = "CarLender_colManufacturer";
            this.CarLender_colManufacturer.ReadOnly = true;
            // 
            // CarLender_colBrand
            // 
            this.CarLender_colBrand.HeaderText = "Brand";
            this.CarLender_colBrand.Name = "CarLender_colBrand";
            this.CarLender_colBrand.ReadOnly = true;
            // 
            // CarLender_panel
            // 
            this.CarLender_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CarLender_panel.Controls.Add(this.CarLender_panel_radio1);
            this.CarLender_panel.Controls.Add(this.CarLender_panel_btnBook);
            this.CarLender_panel.Controls.Add(this.CarLender_panel_picture);
            this.CarLender_panel.Controls.Add(this.CarLender_panel_tileName);
            this.CarLender_panel.Location = new System.Drawing.Point(379, 12);
            this.CarLender_panel.Name = "CarLender_panel";
            this.CarLender_panel.Size = new System.Drawing.Size(352, 391);
            this.CarLender_panel.TabIndex = 1;
            this.CarLender_panel.Visible = false;
            // 
            // CarLender_panel_radio1
            // 
            this.CarLender_panel_radio1.AutoSize = true;
            this.CarLender_panel_radio1.Location = new System.Drawing.Point(4, 363);
            this.CarLender_panel_radio1.Name = "CarLender_panel_radio1";
            this.CarLender_panel_radio1.Size = new System.Drawing.Size(54, 19);
            this.CarLender_panel_radio1.TabIndex = 5;
            this.CarLender_panel_radio1.TabStop = true;
            this.CarLender_panel_radio1.Text = "Day 1";
            this.CarLender_panel_radio1.UseVisualStyleBackColor = true;
            // 
            // CarLender_panel_btnBook
            // 
            this.CarLender_panel_btnBook.Location = new System.Drawing.Point(284, 361);
            this.CarLender_panel_btnBook.Name = "CarLender_panel_btnBook";
            this.CarLender_panel_btnBook.Size = new System.Drawing.Size(61, 23);
            this.CarLender_panel_btnBook.TabIndex = 2;
            this.CarLender_panel_btnBook.Text = "Book";
            this.CarLender_panel_btnBook.UseVisualStyleBackColor = true;
            this.CarLender_panel_btnBook.Click += new System.EventHandler(this.CarLender_panel_btnBook_Click);
            // 
            // CarLender_panel_picture
            // 
            this.CarLender_panel_picture.Location = new System.Drawing.Point(3, 42);
            this.CarLender_panel_picture.Name = "CarLender_panel_picture";
            this.CarLender_panel_picture.Size = new System.Drawing.Size(341, 313);
            this.CarLender_panel_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarLender_panel_picture.TabIndex = 1;
            this.CarLender_panel_picture.TabStop = false;
            // 
            // CarLender_panel_tileName
            // 
            this.CarLender_panel_tileName.Location = new System.Drawing.Point(4, 4);
            this.CarLender_panel_tileName.Name = "CarLender_panel_tileName";
            this.CarLender_panel_tileName.Size = new System.Drawing.Size(341, 35);
            this.CarLender_panel_tileName.TabIndex = 0;
            this.CarLender_panel_tileName.Text = "label1";
            this.CarLender_panel_tileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CarLenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 414);
            this.Controls.Add(this.CarLender_panel);
            this.Controls.Add(this.CarLender_shopView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CarLenderForm";
            this.Text = "Car Lending";
            ((System.ComponentModel.ISupportInitialize)(this.CarLender_shopView)).EndInit();
            this.CarLender_panel.ResumeLayout(false);
            this.CarLender_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarLender_panel_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarLender_shopView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarLender_colManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarLender_colBrand;
        private System.Windows.Forms.Panel CarLender_panel;
        private System.Windows.Forms.Button CarLender_panel_btnBook;
        private System.Windows.Forms.PictureBox CarLender_panel_picture;
        private System.Windows.Forms.Label CarLender_panel_tileName;
        private System.Windows.Forms.RadioButton CarLender_panel_radio1;
    }
}

