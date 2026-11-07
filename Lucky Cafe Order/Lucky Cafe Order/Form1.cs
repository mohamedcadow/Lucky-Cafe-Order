using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Cafe_Order
{
    public partial class LuckyCafeOrder : Form
    {
        double totalBeforeDiscount = 0;
        double finalPrice = 0;
      

        public LuckyCafeOrder()
        {
            InitializeComponent();
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter your name.");
                    txtName.Focus();
                    return;
                }
                if (!name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Name must contain letters only.");
                    txtName.Focus();
                    return;
                }


                if (txtQuantity.Text == "" || !int.TryParse(txtQuantity.Text, out int quantity) || quantity < 1)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    txtQuantity.Focus();
                    return;
                }

                double price = 0;
                String drinkName = "";

                if (rdoTea.Checked)
                {
                    price = 1.0;
                    drinkName = "Tea";
                }
                else if (rdoCoffee.Checked)
                {
                    price = 2.0;
                    drinkName = "Coffee";
                }
                else if (rdoJuice.Checked)
                {
                    price = 3.0;
                    drinkName = "Juice";

                }
                else
                {
                    MessageBox.Show("Select a drink");
                    return;
                }

                lstOrderList.Items.Clear();
                double totalBeforeDiscount = price * quantity;
              
                Random rand = new Random();
                double luckyNumber = 0;
                bool getCookie = false;
                for (int i = 1; i < quantity + 1; i++)
                {
                     luckyNumber = rand.Next(1, 51);
                    lstOrderList.Items.Add($" {i} ) {name} - {drinkName}  - Lucky: {luckyNumber} - ${price.ToString("0.00")}");
      
                    if (luckyNumber == 7 || luckyNumber == 17)
                    {
                        getCookie = true;
                       
                    }
                }
                double finalPrice = totalBeforeDiscount;
               


                if (chkStudentMember.Checked == true)
                {
                    finalPrice = totalBeforeDiscount - (totalBeforeDiscount * 0.10);
                    lstOrderList.Items.Add($"");
                    lstOrderList.Items.Add($"");

                    lstOrderList.Items.Add($"Member Discount: 10%");
                }
                lblTotal.Text = $"Total Price: ${finalPrice.ToString("0.00")}";


                if (getCookie == true)
                {
                    
                    lblLucky.Text = "Lucky Message: you got a free cookie! ("+luckyNumber+")";
                    
                }
                else
                {
                    lblLucky.Text = "Lucky Message: No price this time";

                }
                lstOrderList.Items.Add($"");
                lstOrderList.Items.Add($"Total before Discount: ${totalBeforeDiscount.ToString("0.00")}");
                lstOrderList.Items.Add($"");

                lstOrderList.Items.Add($"total after Discount: ${finalPrice.ToString("0.00")}");
                lstOrderList.Items.Add($"");

                lstOrderList.Items.Add($"{lblLucky.Text}");

                lstOrderList.Items.Add($"");
                lstOrderList.Items.Add($"============================== ==========================");
                lstOrderList.Items.Add($"");

                




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstOrderList.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }
            StreamWriter writer = File.AppendText("Orders.txt");
            foreach (var item in lstOrderList.Items)
            {
                writer.WriteLine(item.ToString());
            }
          


            writer.Close();
            MessageBox.Show("Order saved to Orders.txt");
        }

        private void lblLucky_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtName.Clear();
            txtQuantity.Clear();
            rdoTea.Checked = false;
            rdoCoffee.Checked = false;
            rdoJuice.Checked = false;
            chkStudentMember.Checked = false;
            lstOrderList.Items.Clear();
            lblTotal.Text = "Total Price: $0.00";
            lblLucky.Text = "Lucky Message: ";
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("Orders.txt") == false)
            {
                MessageBox.Show("No file found.");
                return;
            }
            lstOrderList.Items.Clear();
            StreamReader reader = File.OpenText("Orders.txt");
         

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                lstOrderList.Items.Add(line);
            }
            reader.Close();
        }
    }
}

