using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TileShop.GUI
{
    public partial class TileShopForm : Form
    {
        void tileShop_shopView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            UpdateShopDetails();
        }

        void tileShop_panel_inputQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (tileShop_panel_inputQuantity.Enabled == false)
            {
                tileShop_panel_currentPrice.Text = "";
                return;
            }

            DataGridViewRow selectedRow = tileShop_shopView.SelectedRows.Count == 0 ? null : tileShop_shopView.SelectedRows[0];

            if (selectedRow != null)
            {
                KeyValuePair<int, string[]> row = ShopData.Where(kvp => kvp.Value[0] == selectedRow.Cells[0].Value.ToString() && kvp.Value[1] == selectedRow.Cells[1].Value.ToString()).FirstOrDefault();

                int price = int.Parse(row.Value[3]);

                tileShop_panel_currentPrice.Text = $"Price: {price * tileShop_panel_inputQuantity.Value} HUF";
                tileShop_panel_btnAddToCart.Visible = tileShop_panel_inputQuantity.Value > 0;
            }
        }

        void cart_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // :skull:
            {
                DataGridViewRow row = cart_view.Rows[e.RowIndex];
                string cartKey = $"{row.Cells[1].Value}\0{row.Cells[2].Value}";
                if (CartData.Remove(cartKey))
                    cart_view.Rows.RemoveAt(e.RowIndex);
            }
        }

        void tileShop_panel_btnAddToCart_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = tileShop_shopView.SelectedRows.Count == 0 ? null : tileShop_shopView.SelectedRows[0];

            if (selectedRow != null)
            {
                KeyValuePair<int, string[]> row = ShopData.Where(kvp => kvp.Value[0] == selectedRow.Cells[0].Value.ToString() && kvp.Value[1] == selectedRow.Cells[1].Value.ToString()).FirstOrDefault();

                int price = int.Parse(row.Value[3]);
                int quantity = (int)tileShop_panel_inputQuantity.Value;

                string cartKey = $"{row.Value[0]}\0{row.Value[1]}";
                if (!CartData.ContainsKey(cartKey))
                {
                    CartData.Add(cartKey, 0);
                }
                CartData[cartKey] += quantity;

                UpdateCart();
                UpdateShopDetails();
            }
        }

        void tileShop_panel_allowOverbuying_CheckedChanged(object sender, EventArgs e)
        {
            if (tileShop_panel_allowOverbuying.Checked)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to order above stock?{Environment.NewLine}" +
                    $"Orders within stock will be delivered in 1-2 days.{Environment.NewLine}" +
                    $"If you order more than what we currently have in storage, we can get the additional tiles for you, but the order will take 2-3 weeks to arrive!",
                    "Confirmation", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.No:
                        tileShop_panel_allowOverbuying.Checked = false;
                        break;
                }
            }
            else
            {
                bool updateCart = false;
                foreach (var _key in CartData.Keys)
                {
                    string[] key = _key.Split('\0');
                    KeyValuePair<int, string[]> shopRow = ShopData.Where(kvp => kvp.Value[0] == key[0] && kvp.Value[1] == key[1]).FirstOrDefault();

                    int price = int.Parse(shopRow.Value[3]);
                    int stonk = int.Parse(shopRow.Value[4]);
                    int quantity = CartData[_key];

                    if (quantity > stonk)
                    {
                        CartData[_key] = stonk;
                        updateCart = true;
                    }
                }

                if (updateCart)
                    UpdateCart();
            }
            UpdateShopDetails();
        }

        void cart_btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new(this);
            orderForm.Show();
        }
    }
}
