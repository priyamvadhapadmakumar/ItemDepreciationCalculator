/*Programmer name: Priyamvadha Padmakumar
 * Program description: Program calculates depriciation of item
 * using straight-line method and declining-balance method 
 *displays the residual value at the end of each year
 * till the residual value reaches 0*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppadmakumarHW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaring field variables
        string itemDescription;
        int yearPurchased;
        double purchasePrice;
        
        //To verify description of item textbox is not left empty.
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if(txtDescription.Text.Length==0)
            {
                MessageBox.Show("Please enter the description of item purchased!");
                txtDescription.Focus();
            }
        }
        //To verify year puchased is not empty and non-negative numeric value
        private void txtYearPurchased_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.TryParse(txtYearPurchased.Text, out yearPurchased) == false)
                {
                    MessageBox.Show("Please check the year entered!");
                    txtYearPurchased.Focus();
                    txtYearPurchased.SelectAll();
                }
                else if (int.Parse(txtYearPurchased.Text) <= 0)
                {
                    MessageBox.Show("Please enter a valid year of purchase!");
                    txtYearPurchased.Focus();
                    txtYearPurchased.SelectAll();
                }
                else if (txtYearPurchased.Text.Length == 0)
                {
                    MessageBox.Show("Please enter the year of purchase!");
                    txtYearPurchased.Focus();
                    txtYearPurchased.SelectAll();
                }               
            }
            catch
            {
                MessageBox.Show("Enter the correct year!");
                txtYearPurchased.Focus();
                txtYearPurchased.SelectAll();
            }
        }
        //To verify purchase price textbox is not empty and non-negative numeric value
        private void txtPurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (double.TryParse(txtPurchasePrice.Text, out purchasePrice) == false)
                {
                    erpPurchasePrice.SetError(txtPurchasePrice, "Check the value entered!");
                    txtPurchasePrice.Focus();
                    txtPurchasePrice.SelectAll();
                }
                else if (double.Parse(txtPurchasePrice.Text) <= 0)
                {
                    erpPurchasePrice.SetError(txtPurchasePrice, "Enter a valid purchase price!");
                    txtPurchasePrice.Focus();
                    txtPurchasePrice.SelectAll();
                }
                else if (txtPurchasePrice.Text.Length == 0)
                {
                    erpPurchasePrice.SetError(txtPurchasePrice, "Purchase price empty! Enter a valid price!");
                    txtPurchasePrice.Focus();
                    txtPurchasePrice.SelectAll();
                }                  
                else
                    erpPurchasePrice.SetError(txtPurchasePrice, "");
            }
            catch
            {
                MessageBox.Show("Check the Purchase price entered!");
                txtPurchasePrice.Focus();
                txtPurchasePrice.SelectAll();
            }
        }

        //Calculates depriciation of item using straight-line method
        private void btnStraightLine_Click(object sender, EventArgs e)
        {
            try
            {
                //local variable declaraion & initialisation
                double n; //for no. of years to be depriciated
                double depriciationAmount;
                double residualValue = 0;
                double accumulatedDepriciation = 0;
                itemDescription = txtDescription.Text;
                yearPurchased = int.Parse(txtYearPurchased.Text);
                purchasePrice = double.Parse(txtPurchasePrice.Text);

                // Late valdiation to verify the depreciation years textbox input.
                if (double.TryParse(txtDepreciationYears.Text, out n) == false)
                {
                    erpDepriciationYears.SetError(txtDepreciationYears, "Check the value entered!");
                    txtDepreciationYears.Focus();
                    txtDepreciationYears.SelectAll();
                    return;
                }
                else if (double.Parse(txtDepreciationYears.Text) < 0)
                {
                    erpDepriciationYears.SetError(txtDepreciationYears, "Depreciation years should" +
                                                   " be greater than 0!");
                    txtDepreciationYears.Focus();
                    txtDepreciationYears.SelectAll();
                    return;
                }
                else
                {
                    erpDepriciationYears.SetError(txtDepreciationYears, "");
                }

                n = double.Parse(txtDepreciationYears.Text);
                int count;

                lstOutput.Items.Clear();
                lstOutput.Items.Add("Straight-Line method depriciation:\n");
                lstOutput.Items.Add(string.Format("{0,10}{1,30:C}{2,30:C}{3,20:C}", "Year",
                                                        "Depriciated amount", "Accumulated depriciation",
                                                        "Residual value"));
                //creating loop to determine depriciation amount and residual value each year.
                for (count = 1; count <= n; count++)
                {
                    depriciationAmount = 1 / n * purchasePrice;
                    accumulatedDepriciation += depriciationAmount;
                    residualValue = purchasePrice - accumulatedDepriciation;

                    //displays results in listbox.
                    lstOutput.Items.Add("");
                    lstOutput.Items.Add(string.Format("{0,10}{1,30:C}{2,30:C}{3,35:C}", count,
                                                        depriciationAmount, accumulatedDepriciation,
                                                        residualValue));
                }
            }
            catch
            {
                MessageBox.Show("Please check the values entered!");

            }

        }
        //Calculates depriciation using declining-balance method
        private void btnDecliningBalance_Click(object sender, EventArgs e)
        {
            double depreciationRate;
            double yearlyDepreciation;
            double residualValue;
            double accumulatedDepriciation = 0;
                
            itemDescription = txtDescription.Text;
            yearPurchased = int.Parse(txtYearPurchased.Text);
            purchasePrice = double.Parse(txtPurchasePrice.Text);
            residualValue = purchasePrice; //initiation of residual value

            //Late validation to verify input in depriciation rate textbox
            if (double.TryParse(txtDepreciationRate.Text, out depreciationRate) == false)
            {
                erpDepriciationRate.SetError(txtDepreciationRate, "Please check the entered value!");
                txtDepreciationRate.Focus();
                txtDepreciationRate.SelectAll();
                return;
            }
            else if (double.Parse(txtDepreciationRate.Text) <= 0)
            {
                erpDepriciationRate.SetError(txtDepreciationRate, "Depriciation rate cannot be zero or negative!");
                txtDepreciationRate.Focus();
                txtDepreciationRate.SelectAll();
                return;
            }
            else
            {
                erpDepriciationRate.SetError(txtDepreciationRate, "");
            }

            depreciationRate = double.Parse(txtDepreciationRate.Text);         
            residualValue = purchasePrice;// initiation of residual value
            int years = yearPurchased;

            lstOutput.Items.Clear();
            lstOutput.Items.Add("Declining-balance method:\n");
            lstOutput.Items.Add(string.Format("{0,10}{1,30:C3}{2,30:C3}{3,20:C3}", "Year",
                                                    "Depriciated amount", "Accumulated depriciation",
                                                    "Residual value"));
            //loop for yearly depreciation and residual value for each year
            while (residualValue > 0.005)
            {                    
                yearlyDepreciation = residualValue * depreciationRate / 100;
                accumulatedDepriciation += yearlyDepreciation;
                residualValue = purchasePrice - accumulatedDepriciation;
                //residualValue=residualValue-yearlyDepriciation;
                years++;

                //Displays results in listbox.
                lstOutput.Items.Add("");
                lstOutput.Items.Add(string.Format("{0,10}{1,30:C3}{2,30:C3}{3,35:C3}", years,
                                                    yearlyDepreciation, accumulatedDepriciation,
                                                    residualValue));
            }
            
        }
        //Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Clears all input and ouput values
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtYearPurchased.Clear();
            txtPurchasePrice.Clear();
            txtDepreciationYears.Clear();
            txtDepreciationRate.Clear();
            lstOutput.Items.Clear();
        }

        
    }
}
