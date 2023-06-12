using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarLender.GUI
{
    public partial class CarLenderForm : Form
    {
        void CarLender_shopView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            UpdateShopDetails();
        }

        void CarLender_panel_btnBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = CarLender_shopView.SelectedRows.Count == 0 ? null : CarLender_shopView.SelectedRows[0];

            if (selectedRow != null)
            {
                KeyValuePair<string, string[]> row = ShopData.Where(kvp => kvp.Value[0] == selectedRow.Cells[0].Value.ToString() && kvp.Value[1] == selectedRow.Cells[1].Value.ToString()).FirstOrDefault();

                UpdateShopDetails();

                int dayId = 0;
                for (; dayId < daySelection.Length; dayId++)
                {
                    if (daySelection[dayId].Checked) break;
                }

                if (dayId < daySelection.Length)
                {
                    OrderForm orderForm = new(this, row.Key, dayId);
                    orderForm.ShowDialog();
                }
            }
        }
    }
}
