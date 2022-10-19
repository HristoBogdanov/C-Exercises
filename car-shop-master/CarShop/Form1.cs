using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CarShop
{
    public partial class Form1 : Form
    {
        List<Shop> shops = new List<Shop>();
        int currentShop = -1;

        public PartCategory Result()
        {
            PartCategory p = PartCategory.Engine;
            if (partCategoryInput.SelectedIndex == 0) p = PartCategory.Engine;
            else if (partCategoryInput.SelectedIndex == 1) p = PartCategory.Tires;
            else if (partCategoryInput.SelectedIndex == 2) p = PartCategory.Exhaust;
            else if (partCategoryInput.SelectedIndex == 3) p = PartCategory.Suspention;
            else if (partCategoryInput.SelectedIndex == 4) p = PartCategory.Brake;
            return p;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private const string NoShopMessage = "Моля изберете магазин!",
            EmptyFieldsMessage = "Моля попълнете всички полета!";

        private bool emptyFields {
            get
            {
                foreach (Control c in partInputPanel.Controls)
                    if (c.Name.Contains("Input") && !c.Name.Contains("Label"))
                        if (c.Text.Length == 0)
                            return true;
                foreach (Control c in manufacturerInputPanel.Controls)
                    if (c.Name.Contains("Input") && !c.Name.Contains("Label"))
                        if (c.Text.Length == 0)
                            return true;
                return false;
            }
        }

        private bool hasShop => currentShop != -1;

        private void RefreshStock()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Общ брой части:" + shops[currentShop].Parts.Count);
            listBox1.Items.Add("");
            foreach (Part p in shops[currentShop].Parts)
                listBox1.Items.Add(p.ToString());
        }
        


        private void inputButton_Click(object sender, EventArgs e)
        {
            if (!hasShop)
            {
                MessageBox.Show(NoShopMessage);
                return;
            }

            if (emptyFields)
            {
                MessageBox.Show(EmptyFieldsMessage);
                return;
            }

            string partName = partNameInput.Text;
            string partCode = partCodeInput.Text;
            double partDelivery = double.Parse(partDeliveryInput.Text);
            double partPrice = int.Parse(partPriceInput.Text);
            string brandName = manufacturerNameInput.Text;
            string brandCountry = manufacturerCountryInput.Text;
            string brandAddress = manufacturerAddressInput.Text;
            string brandPhone = manufacturerPhoneInput.Text;
            string brandFax = manufacturerFaxInput.Text;

            Manufacturer manufacturer = new Manufacturer(brandName, brandCountry, brandAddress, brandPhone, brandFax);
            Part part = new Part(partName, partDelivery, partPrice, manufacturer, partCode, Result());
            shops[currentShop].AddPart(part);
            RefreshStock();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            partNameInput.Clear();
            partCodeInput.Clear();
            partDeliveryInput.Clear();
            partPriceInput.Clear();
            manufacturerNameInput.Clear();
            manufacturerCountryInput.Clear();
            manufacturerAddressInput.Clear();
            manufacturerPhoneInput.Clear();
            manufacturerFaxInput.Clear();
        }

        private void manufacturerSearch_Click(object sender, EventArgs e)
        {
            if (!hasShop)
            {
                MessageBox.Show(NoShopMessage);
                return;
            }

            manufacturerSearchResult.Items.Clear();
            string manufacturer = manufacturerSearchInput.Text.ToLower();
            foreach (Part x in shops[currentShop].Parts
                .Where(p => p.Manufacturer.Name.ToLower().Contains(manufacturer)))
                manufacturerSearchResult.Items.Add(x.ToString());
        }

        private void brandSearch_Click(object sender, EventArgs e)
        {
            if (!hasShop)
            {
                MessageBox.Show(NoShopMessage);
                return;
            }

            brandSearchResult.Items.Clear();
            string brand = brandSearchInput.Text.ToLower();
            string part = brandSearchPartNameInput.Text.ToLower();
            foreach (Part x in shops[currentShop].Parts
                .Where(p => p.SupportedCars.Any(c => c.Brand.ToLower().Contains(brand)) && p.Name.ToLower().Contains(part)))
                brandSearchResult.Items.Add(x.ToString());
        }

        private void shopsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShop = shopsList.SelectedIndex;
            Text = "Избран магазин: " + shops[currentShop];
            RefreshStock();
        }

        private void shopAdd_Click(object sender, EventArgs e)
        {
            shops.Add(new Shop(shopNameInput.Text));
            shopsList.Items.Add(shopNameInput.Text);
            shopNameInput.Clear();
            shopsList.SelectedIndex = shopsList.Items.Count - 1;
        }
    }
}
