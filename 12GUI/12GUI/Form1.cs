using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12GUI
{
    public partial class FormPizza : Form
    {
        public FormPizza()
        {
            InitializeComponent();
        }
        public string order;
        public double subtotal, tax, tip, total;

        private void btOrder_Click(object sender, EventArgs e)
        {
            order = "";
            subtotal = 10;
            //Adds crust to order
            order += rbThinCrust.Checked ? rbThinCrust.Text : "";
            order += rbNormalCrust.Checked ? rbNormalCrust.Text : "";
            order += rbDeepDishCrust.Checked ? rbDeepDishCrust.Text : "";
            subtotal += rbDeepDishCrust.Checked ? 2 : 0;
            order += rbStuffCrust.Checked ? rbStuffCrust.Text : "";
            subtotal += rbStuffCrust.Checked ? 3 : 0;
            //Adds Topping to order
            order += ", Cheese";
            order += cbxCheese.Checked ? ", "+ cbxCheese.Text : "";
            subtotal += cbxCheese.Checked ? .5 : 0;
            order += cbxPepperoni.Checked ? ", "+cbxPepperoni.Text : "";
            subtotal += cbxPepperoni.Checked ? .5 : 0;
            order += cbxSausage.Checked ? ", "+cbxSausage.Text : "";
            subtotal += cbxSausage.Checked ? .5 : 0;
            order += cbxMushroom.Checked ? ", "+cbxMushroom.Text : "";
            subtotal += cbxMushroom.Checked ? .5 : 0;
            order += cbxOlives.Checked ? ", " + cbxOlives.Text : "";
            subtotal += cbxOlives.Checked ? .5 : 0;
            order += cbxCanadianBacon.Checked ? ", " + cbxCanadianBacon.Text : "";
            subtotal += cbxCanadianBacon.Checked ? .5 : 0;
            order += cbxPIneaplle.Checked ? ", " + cbxPIneaplle.Text : "";
            subtotal += cbxPIneaplle.Checked ? .5 : 0;
            order += cbxOnion.Checked ? ", " + cbxOnion.Text : "";
            subtotal += cbxOnion.Checked ? .5 : 0;
            //Add Beverage option
            order += ".\n Beverage : ";
            order += cbxDrPepper.Checked ? ", " + cbxDrPepper.Text : "";
            subtotal += cbxDrPepper.Checked ? 2 : 0;
            order += cbxMtDew.Checked ? ", " + cbxMtDew.Text : "";
            subtotal += cbxMtDew.Checked ? 2 : 0;
            order += cbxSevenUp.Checked ? ", " + cbxSevenUp.Text : "";
            subtotal += cbxSevenUp.Checked ? 2 : 0;
            //Calculate Tax
            tax = subtotal * 0.06875;
            //Add dining option
            order += ".\n Dining Option : ";
            order += rbDelivery.Checked ? rbDelivery.Text : "";
            subtotal += rbDelivery.Checked ? 5 : 0;
            order += rbDineIn.Checked ? rbDineIn.Text : "";
            order += rbCarryOut.Checked ? rbCarryOut.Text : "";
            //Add Tip
            double.TryParse(txtTip.Text, out tip);
            //Add Phone number
            order += "\n Phone: " + mtxtPhoneNumber.Text;
            txtPizza.Text = order;
            //Display Total & Tax
            total = tax + subtotal +tip;
            txtSubtotal.Text = Convert.ToString(subtotal);
            txtTax.Text = Convert.ToString(tax);
            txtTotal.Text = Convert.ToString(total);
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            pbxPizza.Visible = !pbxPizza.Visible;
            //if (tmrBlink.Interval > 10) tmrBlink.Interval -= 5;
        }

        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked)
            {
                DialogResult result= MessageBox.Show(
                    "Are you within City Limits?",
                    "Delivery Option",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    rbDineIn.Checked = true;
                }
            }   
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            FormHelp frmHelp = new FormHelp();
            frmHelp.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("C:\\Windows\\System32\\calc.exe");
            Process.Start(@"calc.exe");
        }
    }
}
