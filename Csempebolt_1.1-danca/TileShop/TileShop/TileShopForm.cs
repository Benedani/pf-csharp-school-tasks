using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using static TileShop.BL.GUI_Interface;

namespace TileShop.GUI
{
    public partial class TileShopForm : Form
    {
        public Dictionary<int, string[]> ShopData { get; private set; }
        public Dictionary<string, int> CartData { get; } = new Dictionary<string, int>();

        public long OrderTotalPrice { get; private set; }

        public TileShopForm()
        {
            InitializeComponent();

            ShopData = GetShopData(ShopDataSource.DataCsempeCSV, new string[] { "Manufacturer", "Name", "Size", "Price", "Quantity" });
            UpdateShop();
            UpdateCart();
        }

        public void UpdateShop()
        {
            tileShop_shopView.Rows.Clear();
            foreach (var kvp in ShopData)
            {
                tileShop_shopView.Rows.Add(kvp.Value[0], kvp.Value[1]);
            }
        }

        public void UpdateCart()
        {
            OrderTotalPrice = 0;
            bool overOrder = false;

            cart_view.Rows.Clear();
            foreach (var kvp in CartData)
            {
                string[] key = kvp.Key.Split('\0');
                KeyValuePair<int, string[]> shopRow = ShopData.Where(kvp => kvp.Value[0] == key[0] && kvp.Value[1] == key[1]).FirstOrDefault();

                int price = int.Parse(shopRow.Value[3]);
                int stock = int.Parse(shopRow.Value[4]);
                int quantity = kvp.Value;

                cart_view.Rows.Add("💀", shopRow.Value[0], shopRow.Value[1], quantity.ToString(), $"{price * quantity:N0} HUF");

                OrderTotalPrice += price * quantity;
                if (quantity > stock)
                    overOrder = true;
            }

            cart_labelTotal.Text = $"Total: {OrderTotalPrice:N0} HUF{Environment.NewLine}Delivery time: {(overOrder ? "2-3 weeks (not enough stock)" : "1-2 days")}";
            cart_btnOrder.Enabled = OrderTotalPrice > 0;
        }


        void UpdateShopDetails()
        {
            DataGridViewRow selectedRow = tileShop_shopView.SelectedRows.Count == 0 ? null : tileShop_shopView.SelectedRows[0];

            tileShop_panel.Visible = selectedRow != null;
            if (selectedRow != null)
            {
                KeyValuePair<int, string[]> row = ShopData.Where(kvp => kvp.Value[0] == selectedRow.Cells[0].Value.ToString() && kvp.Value[1] == selectedRow.Cells[1].Value.ToString()).FirstOrDefault();

                int stock = int.Parse(row.Value[4]);

                tileShop_panel_tileName.Text = $"{row.Value[0]} - {row.Value[1]} ({row.Value[2]})";
                tileShop_panel_picture.Image = Image.FromFile($"{row.Key}.jpg");

                tileShop_panel_priceQuantity.Text = $"Price / tile: {row.Value[3]} HUF{Environment.NewLine}" +
                    (stock > 0 ? $"In stock: {stock}" : $"Out of stock");

                if (tileShop_panel_allowOverbuying.Checked)
                    stock = 99999; // still capped to avoid breaking stuff, but should be enough

                string cartKey = $"{row.Value[0]}\0{row.Value[1]}";
                if (CartData.ContainsKey(cartKey))
                {
                    tileShop_panel_priceQuantity.Text += $"{Environment.NewLine}In cart: {CartData[cartKey]}";
                    stock -= CartData[cartKey]; // cap input based on cart, otherwise overbuying is possible
                }

                tileShop_panel_inputQuantity.Enabled = stock > 0;
                tileShop_panel_inputQuantity.Minimum = 0;
                tileShop_panel_inputQuantity.Maximum = stock;
                tileShop_panel_inputQuantity.Value = Math.Min(1, stock);
                tileShop_panel_btnAddToCart.Visible = stock > 0;
            }
        }
    }
}
