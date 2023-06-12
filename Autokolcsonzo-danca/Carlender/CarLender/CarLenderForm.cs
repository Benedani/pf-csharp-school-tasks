using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using static CarLender.BL.GUI_Interface;

namespace CarLender.GUI
{
    public partial class CarLenderForm : Form
    {
        public Dictionary<string, string[]> ShopData { get; private set; }


        RadioButton[] daySelection = new RadioButton[Constants.DAY_COUNT];

        public CarLenderForm()
        {
            InitializeComponent();

            for (int i = 0; i < daySelection.Length; i++)
            {
                RadioButton current;
                if (i == 0)
                {
                    current = CarLender_panel_radio1;
                }
                else
                {
                    current = new RadioButton();
                    CarLender_panel.Controls.Add(current);
                    current.AutoSize = true;
                    current.Location = new Point(daySelection[i - 1].Location.X + 56, daySelection[i - 1].Location.Y);
                    current.Name = $"CarLender_panel_radio{i + 1}";
                    current.Size = new Size(54, 19);
                    current.Text = $"Day {i + 1}";
                    current.UseVisualStyleBackColor = true;
                }

                daySelection[i] = current;
            }

            ReloadShop();
        }

        public void ReloadShop()
        {
            ShopData = GetShopData(ShopDataSource.AutokCSV, new string[] { "Manufacturer", "Brand", "Consumption", "IsLended" });
            UpdateShop();
        }

        public void UpdateShop()
        {
            CarLender_shopView.Rows.Clear();
            foreach (var kvp in ShopData)
            {
                CarLender_shopView.Rows.Add(kvp.Value[0], kvp.Value[1]);
            }
        }


        void UpdateShopDetails()
        {
            DataGridViewRow selectedRow = CarLender_shopView.SelectedRows.Count == 0 ? null : CarLender_shopView.SelectedRows[0];

            CarLender_panel.Visible = selectedRow != null;
            if (selectedRow != null)
            {
                KeyValuePair<string, string[]> row = ShopData.Where(kvp => kvp.Value[0] == selectedRow.Cells[0].Value.ToString() && kvp.Value[1] == selectedRow.Cells[1].Value.ToString()).FirstOrDefault();

                CarLender_panel_tileName.Text = $"{row.Value[0]} {row.Value[1]}" +
                    $"{Environment.NewLine}Consumption: {row.Value[2]}";
                CarLender_panel_picture.Image = Image.FromFile($"{row.Key}.jpeg");

                RadioButton firstEnabledRBtn = null;
                for (int i = 0; i < daySelection.Length; i++)
                {
                    daySelection[i].Enabled = row.Value[3][i] == '0';
                    if (daySelection[i].Enabled)
                    {
                        if (firstEnabledRBtn == null)
                            firstEnabledRBtn = daySelection[i];
                    }
                    else if (daySelection[i].Checked)
                    {
                        daySelection[i].Checked = false;
                    }
                }

                if (firstEnabledRBtn != null && !daySelection.Any(rb => rb.Enabled && rb.Checked))
                    firstEnabledRBtn.Checked = true;

                CarLender_panel_btnBook.Visible = true;
                CarLender_panel_btnBook.Enabled = firstEnabledRBtn != null;
            }
        }
    }
}
