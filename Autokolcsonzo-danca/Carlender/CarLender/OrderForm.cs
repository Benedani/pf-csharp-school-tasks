using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using static CarLender.BL.GUI_Interface;

namespace CarLender.GUI
{
    public partial class OrderForm : Form
    {
        CarLenderForm parentForm;
        string carRN;
        int dayId;

        public OrderForm(CarLenderForm parentForm, string carRN, int dayId)
        {
            this.parentForm = parentForm;
            this.carRN = carRN;
            this.dayId = dayId;

            InitializeComponent();

            orderButton.Text = $"Book {parentForm.ShopData[carRN][0]} {parentForm.ShopData[carRN][1]} for day {dayId + 1}";
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            orderButton.Enabled = textBoxName.Text.Length > 0 && textBoxIDNum.Text.Length > 0;
        }

        void orderButton_Click(object sender, EventArgs e)
        {
            switch (Order(ShopDataSource.AutokCSV, textBoxName.Text, textBoxIDNum.Text,
                carRN, dayId,
                out string information))
            {
                case OrderResult.OK:
                    MessageBox.Show(information, "Order dispatched", MessageBoxButtons.OK);
                    parentForm.ReloadShop();
                    Close();
                    break;
                case OrderResult.Error:
                    MessageBox.Show(information, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
