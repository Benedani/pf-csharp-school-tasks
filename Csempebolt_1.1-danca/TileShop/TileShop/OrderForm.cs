using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using static TileShop.BL.GUI_Interface;

namespace TileShop.GUI
{
    public partial class OrderForm : Form
    {
        TileShopForm parentForm;

        public OrderForm(TileShopForm parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
            orderButton.Text = $"Order for {parentForm.OrderTotalPrice:N0} HUF";
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            orderButton.Enabled = textBoxName.Text.Length > 0 && textBoxAddress.Text.Length > 0;
        }

        void orderButton_Click(object sender, EventArgs e)
        {
            switch (Order(ShopDataSource.DataCsempeCSV, textBoxName.Text, textBoxAddress.Text,
                parentForm.CartData.ToDictionary(
                    kvp => parentForm.ShopData.Where(_kvp => $"{_kvp.Value[0]}\0{_kvp.Value[1]}" == kvp.Key).First().Key,
                    kvp => kvp.Value),
                out string information))
            {
                case OrderResult.OK:
                    MessageBox.Show(information, "Order dispatched", MessageBoxButtons.OK);
                    Close();
                    break;
                case OrderResult.Error:
                    MessageBox.Show(information, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
