using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    public partial class cashRegister : Form
    {
        double burgerPrice = 5;
        double fryPrice = 2;
        double drinkPrice = 1;

        double burgerCount;
        double fryCount;
        double drinkCount;

        double subTotalOwed;
        double taxRate = 1.13;
        double taxAmountOwed;
        double totalOwed;
        double amountTendered; 
        double changeOwed;

        

        public cashRegister()
        {
            InitializeComponent();
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            tenderedAmount.Enabled = false; 
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //check if a number has been entered 
            try
            {
                tenderedAmount.Enabled = true;
                burgerCount = Convert.ToDouble(burgerBox.Text);
                fryCount = Convert.ToDouble(fryBox.Text);
                drinkCount = Convert.ToDouble(drinkBox.Text);

                //display the subtotal 
                subTotalOwed = (burgerCount * burgerPrice) + (fryCount * fryPrice) + (drinkCount * drinkPrice);
                subTotalAmount.Text = $"{subTotalOwed.ToString("c")}";
            }
            // if a number has not been enterd, display warning message for 3.5 secs
            catch {
                this.warningLabel.Visible = true;
                warningLabel.Text = "Please enter a number of 0 or more";
                Refresh();
                Thread.Sleep(3500);
                this.warningLabel.Visible = false;}

            //display the amount of tax owed 
            taxAmountOwed = subTotalOwed * taxRate - subTotalOwed;
            taxAmount.Text = $"{taxAmountOwed.ToString("c")}";

            //display amount plus tax owed 
            totalOwed = subTotalOwed + taxAmountOwed;
            totalAmount.Text = $"{totalOwed.ToString("c")}";

            //enable "calculate change" button 
            changeButton.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //check if a number has been entered 
            try
            {
                //display amount tendered 
                amountTendered = Convert.ToDouble(tenderedAmount.Text);
                changeOwed = amountTendered - totalOwed;
                changeAmount.Text = $"{changeOwed.ToString("c")}";
            }
            //if a number has not been entered, display error message 
            catch
            {
                this.warningLabel.Visible = true;
                warningLabel.Text = "Please enter a number of 0 or more";
                Refresh();
                Thread.Sleep(3500);
                this.warningLabel.Visible = false;

            }
            reciptButton.Enabled = true; 
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            //display recipt title
            outputLabel.Visible =  true; 
            outputLabel.Text = $"The Burger Shop";

            //display rest of recipt 
            outputLabel.Text += $"\n\nHamburger x {burgerCount}       @    {burgerPrice.ToString("c")}";
            outputLabel.Text += $"\nFries x {fryCount}                  @    {fryPrice.ToString("c")} ";              
            outputLabel.Text += $"\nDrinks x {drinkCount}                @   {drinkPrice.ToString("c")}";

            outputLabel.Text += $"\n\nSubtotal                          {subTotalOwed.ToString("c")}";
            outputLabel.Text += $"\nTax                                   {taxAmountOwed.ToString("c")}";
            outputLabel.Text += $"\nTotal                                {totalOwed.ToString("c")}";

            outputLabel.Text += $"\n\nTendered                        {amountTendered.ToString("c")} ";
            outputLabel.Text += $"\nChange                           {changeOwed.ToString("c")}";

            outputLabel.Text += $"\n\nHave a nice day!";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //set values to zero and disable buttons 
            burgerBox.Text = Convert.ToString(0);
            fryBox.Text = Convert.ToString(0);
            drinkBox.Text = Convert.ToString(0);
            tenderedAmount.Text = Convert.ToString(0);

            subTotalOwed = 0;
            taxAmountOwed = 0;
            totalOwed = 0;
            amountTendered = 0;
            changeOwed = 0; 
            
            changeButton.Enabled = false;
            reciptButton.Enabled = false;
            tenderedAmount.Enabled = false;
            outputLabel.Visible = false;

        }
    }
}
