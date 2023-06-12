
namespace TileShop.GUI
{
    partial class TileShopForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tileShop = new System.Windows.Forms.TabPage();
            this.tileShop_panel = new System.Windows.Forms.Panel();
            this.tileShop_panel_allowOverbuying = new System.Windows.Forms.CheckBox();
            this.tileShop_panel_currentPrice = new System.Windows.Forms.Label();
            this.tileShop_panel_priceQuantity = new System.Windows.Forms.Label();
            this.tileShop_panel_inputQuantity = new System.Windows.Forms.NumericUpDown();
            this.tileShop_panel_btnAddToCart = new System.Windows.Forms.Button();
            this.tileShop_panel_picture = new System.Windows.Forms.PictureBox();
            this.tileShop_panel_tileName = new System.Windows.Forms.Label();
            this.tileShop_shopView = new System.Windows.Forms.DataGridView();
            this.tileShop_colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tileShop_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart = new System.Windows.Forms.TabPage();
            this.cart_btnOrder = new System.Windows.Forms.Button();
            this.cart_labelTotal = new System.Windows.Forms.Label();
            this.cart_view = new System.Windows.Forms.DataGridView();
            this.cart_colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cart_colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tileShop.SuspendLayout();
            this.tileShop_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_panel_inputQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_panel_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_shopView)).BeginInit();
            this.cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tileShop);
            this.tabControl.Controls.Add(this.cart);
            this.tabControl.Location = new System.Drawing.Point(9, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(743, 432);
            this.tabControl.TabIndex = 0;
            // 
            // tileShop
            // 
            this.tileShop.Controls.Add(this.tileShop_panel);
            this.tileShop.Controls.Add(this.tileShop_shopView);
            this.tileShop.Location = new System.Drawing.Point(4, 24);
            this.tileShop.Name = "tileShop";
            this.tileShop.Padding = new System.Windows.Forms.Padding(3);
            this.tileShop.Size = new System.Drawing.Size(735, 404);
            this.tileShop.TabIndex = 0;
            this.tileShop.Text = "Tile Shop";
            this.tileShop.UseVisualStyleBackColor = true;
            // 
            // tileShop_panel
            // 
            this.tileShop_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tileShop_panel.Controls.Add(this.tileShop_panel_allowOverbuying);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_currentPrice);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_priceQuantity);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_inputQuantity);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_btnAddToCart);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_picture);
            this.tileShop_panel.Controls.Add(this.tileShop_panel_tileName);
            this.tileShop_panel.Location = new System.Drawing.Point(374, 7);
            this.tileShop_panel.Name = "tileShop_panel";
            this.tileShop_panel.Size = new System.Drawing.Size(355, 391);
            this.tileShop_panel.TabIndex = 1;
            this.tileShop_panel.Visible = false;
            // 
            // tileShop_panel_allowOverbuying
            // 
            this.tileShop_panel_allowOverbuying.AutoSize = true;
            this.tileShop_panel_allowOverbuying.Location = new System.Drawing.Point(190, 312);
            this.tileShop_panel_allowOverbuying.Name = "tileShop_panel_allowOverbuying";
            this.tileShop_panel_allowOverbuying.Size = new System.Drawing.Size(158, 19);
            this.tileShop_panel_allowOverbuying.TabIndex = 6;
            this.tileShop_panel_allowOverbuying.Text = "Allow orders above stock";
            this.tileShop_panel_allowOverbuying.UseVisualStyleBackColor = true;
            this.tileShop_panel_allowOverbuying.CheckedChanged += new System.EventHandler(this.tileShop_panel_allowOverbuying_CheckedChanged);
            // 
            // tileShop_panel_currentPrice
            // 
            this.tileShop_panel_currentPrice.Location = new System.Drawing.Point(130, 361);
            this.tileShop_panel_currentPrice.Name = "tileShop_panel_currentPrice";
            this.tileShop_panel_currentPrice.Size = new System.Drawing.Size(137, 23);
            this.tileShop_panel_currentPrice.TabIndex = 5;
            this.tileShop_panel_currentPrice.Text = "label1";
            this.tileShop_panel_currentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tileShop_panel_priceQuantity
            // 
            this.tileShop_panel_priceQuantity.Location = new System.Drawing.Point(4, 312);
            this.tileShop_panel_priceQuantity.Name = "tileShop_panel_priceQuantity";
            this.tileShop_panel_priceQuantity.Size = new System.Drawing.Size(180, 46);
            this.tileShop_panel_priceQuantity.TabIndex = 4;
            this.tileShop_panel_priceQuantity.Text = "label1\r\namogus\r\namogusgus";
            // 
            // tileShop_panel_inputQuantity
            // 
            this.tileShop_panel_inputQuantity.Location = new System.Drawing.Point(4, 361);
            this.tileShop_panel_inputQuantity.Name = "tileShop_panel_inputQuantity";
            this.tileShop_panel_inputQuantity.Size = new System.Drawing.Size(120, 23);
            this.tileShop_panel_inputQuantity.TabIndex = 3;
            this.tileShop_panel_inputQuantity.ValueChanged += new System.EventHandler(this.tileShop_panel_inputQuantity_ValueChanged);
            // 
            // tileShop_panel_btnAddToCart
            // 
            this.tileShop_panel_btnAddToCart.Location = new System.Drawing.Point(273, 361);
            this.tileShop_panel_btnAddToCart.Name = "tileShop_panel_btnAddToCart";
            this.tileShop_panel_btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.tileShop_panel_btnAddToCart.TabIndex = 2;
            this.tileShop_panel_btnAddToCart.Text = "-> To Cart";
            this.tileShop_panel_btnAddToCart.UseVisualStyleBackColor = true;
            this.tileShop_panel_btnAddToCart.Click += new System.EventHandler(this.tileShop_panel_btnAddToCart_Click);
            // 
            // tileShop_panel_picture
            // 
            this.tileShop_panel_picture.Location = new System.Drawing.Point(4, 23);
            this.tileShop_panel_picture.Name = "tileShop_panel_picture";
            this.tileShop_panel_picture.Size = new System.Drawing.Size(344, 286);
            this.tileShop_panel_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tileShop_panel_picture.TabIndex = 1;
            this.tileShop_panel_picture.TabStop = false;
            // 
            // tileShop_panel_tileName
            // 
            this.tileShop_panel_tileName.Location = new System.Drawing.Point(4, 4);
            this.tileShop_panel_tileName.Name = "tileShop_panel_tileName";
            this.tileShop_panel_tileName.Size = new System.Drawing.Size(344, 16);
            this.tileShop_panel_tileName.TabIndex = 0;
            this.tileShop_panel_tileName.Text = "label1";
            this.tileShop_panel_tileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileShop_shopView
            // 
            this.tileShop_shopView.AllowUserToAddRows = false;
            this.tileShop_shopView.AllowUserToDeleteRows = false;
            this.tileShop_shopView.AllowUserToResizeRows = false;
            this.tileShop_shopView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tileShop_shopView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tileShop_shopView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tileShop_colManufacturer,
            this.tileShop_colName});
            this.tileShop_shopView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tileShop_shopView.Location = new System.Drawing.Point(7, 7);
            this.tileShop_shopView.MultiSelect = false;
            this.tileShop_shopView.Name = "tileShop_shopView";
            this.tileShop_shopView.ReadOnly = true;
            this.tileShop_shopView.RowHeadersVisible = false;
            this.tileShop_shopView.RowTemplate.Height = 25;
            this.tileShop_shopView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tileShop_shopView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tileShop_shopView.Size = new System.Drawing.Size(361, 391);
            this.tileShop_shopView.TabIndex = 0;
            this.tileShop_shopView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.tileShop_shopView_RowStateChanged);
            // 
            // tileShop_colManufacturer
            // 
            this.tileShop_colManufacturer.HeaderText = "Manufacturer";
            this.tileShop_colManufacturer.Name = "tileShop_colManufacturer";
            this.tileShop_colManufacturer.ReadOnly = true;
            // 
            // tileShop_colName
            // 
            this.tileShop_colName.HeaderText = "Name";
            this.tileShop_colName.Name = "tileShop_colName";
            this.tileShop_colName.ReadOnly = true;
            // 
            // cart
            // 
            this.cart.Controls.Add(this.cart_btnOrder);
            this.cart.Controls.Add(this.cart_labelTotal);
            this.cart.Controls.Add(this.cart_view);
            this.cart.Location = new System.Drawing.Point(4, 24);
            this.cart.Name = "cart";
            this.cart.Padding = new System.Windows.Forms.Padding(3);
            this.cart.Size = new System.Drawing.Size(735, 404);
            this.cart.TabIndex = 1;
            this.cart.Text = "Cart";
            this.cart.UseVisualStyleBackColor = true;
            // 
            // cart_btnOrder
            // 
            this.cart_btnOrder.Location = new System.Drawing.Point(532, 374);
            this.cart_btnOrder.Name = "cart_btnOrder";
            this.cart_btnOrder.Size = new System.Drawing.Size(197, 23);
            this.cart_btnOrder.TabIndex = 3;
            this.cart_btnOrder.Text = "Order";
            this.cart_btnOrder.UseVisualStyleBackColor = true;
            this.cart_btnOrder.Click += new System.EventHandler(this.cart_btnOrder_Click);
            // 
            // cart_labelTotal
            // 
            this.cart_labelTotal.Location = new System.Drawing.Point(532, 6);
            this.cart_labelTotal.Name = "cart_labelTotal";
            this.cart_labelTotal.Size = new System.Drawing.Size(197, 365);
            this.cart_labelTotal.TabIndex = 2;
            this.cart_labelTotal.Text = "Total: 0 HUF\r\nArrival time: 1-2 days";
            // 
            // cart_view
            // 
            this.cart_view.AllowUserToAddRows = false;
            this.cart_view.AllowUserToResizeRows = false;
            this.cart_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cart_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_colDelete,
            this.cart_colManufacturer,
            this.cart_colName,
            this.cart_colQuantity,
            this.cart_colPrice});
            this.cart_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cart_view.Location = new System.Drawing.Point(6, 6);
            this.cart_view.MultiSelect = false;
            this.cart_view.Name = "cart_view";
            this.cart_view.RowHeadersVisible = false;
            this.cart_view.RowTemplate.Height = 25;
            this.cart_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cart_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart_view.Size = new System.Drawing.Size(520, 392);
            this.cart_view.TabIndex = 1;
            this.cart_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cart_view_CellClick);
            // 
            // cart_colDelete
            // 
            this.cart_colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_colDelete.HeaderText = "";
            this.cart_colDelete.Name = "cart_colDelete";
            this.cart_colDelete.ReadOnly = true;
            this.cart_colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_colDelete.Width = 20;
            // 
            // cart_colManufacturer
            // 
            this.cart_colManufacturer.HeaderText = "Manufacturer";
            this.cart_colManufacturer.Name = "cart_colManufacturer";
            this.cart_colManufacturer.ReadOnly = true;
            // 
            // cart_colName
            // 
            this.cart_colName.HeaderText = "Name";
            this.cart_colName.Name = "cart_colName";
            this.cart_colName.ReadOnly = true;
            // 
            // cart_colQuantity
            // 
            this.cart_colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_colQuantity.HeaderText = "Qty.";
            this.cart_colQuantity.MinimumWidth = 40;
            this.cart_colQuantity.Name = "cart_colQuantity";
            this.cart_colQuantity.Width = 40;
            // 
            // cart_colPrice
            // 
            this.cart_colPrice.HeaderText = "Price";
            this.cart_colPrice.Name = "cart_colPrice";
            this.cart_colPrice.ReadOnly = true;
            // 
            // TileShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "TileShopForm";
            this.Text = "Tile Shop";
            this.tabControl.ResumeLayout(false);
            this.tileShop.ResumeLayout(false);
            this.tileShop_panel.ResumeLayout(false);
            this.tileShop_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_panel_inputQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_panel_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileShop_shopView)).EndInit();
            this.cart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cart_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tileShop;
        private System.Windows.Forms.DataGridView tileShop_shopView;
        private System.Windows.Forms.TabPage cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn tileShop_colManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tileShop_colName;
        private System.Windows.Forms.Panel tileShop_panel;
        private System.Windows.Forms.Label tileShop_panel_tileName;
        private System.Windows.Forms.PictureBox tileShop_panel_picture;
        private System.Windows.Forms.Label tileShop_panel_priceQuantity;
        private System.Windows.Forms.NumericUpDown tileShop_panel_inputQuantity;
        private System.Windows.Forms.Button tileShop_panel_btnAddToCart;
        private System.Windows.Forms.Label tileShop_panel_currentPrice;
        private System.Windows.Forms.DataGridView cart_view;
        private System.Windows.Forms.DataGridViewButtonColumn cart_colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_colManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_colPrice;
        private System.Windows.Forms.CheckBox tileShop_panel_allowOverbuying;
        private System.Windows.Forms.Label cart_labelTotal;
        private System.Windows.Forms.Button cart_btnOrder;
    }
}

