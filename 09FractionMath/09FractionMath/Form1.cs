//FractionMath
//Author : Nate Christensen
//Date : 10/23/2018
//Form1.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09FractionMath
{
    public partial class FormMain : Form
    {
        Fraction f1, f2,f3;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btSubtract_Click(object sender, EventArgs e)
        {

            int nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            f1 = new Fraction(nume1, denom1);
            f2 = new Fraction(nume2, denom2);
            f3 = f1 - f2;
            //f3 = new Fraction.Add(f1, f2);
            UpdateDisplay();
        }

        private void btMutiply_Click(object sender, EventArgs e)
        {

            int nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            f1 = new Fraction(nume1, denom1);
            f2 = new Fraction(nume2, denom2);
            f3 = f1 * f2;
            //f3 = new Fraction.Add(f1, f2);
            UpdateDisplay();
        }

        private void btDivide_Click(object sender, EventArgs e)
        {

            int nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            f1 = new Fraction(nume1, denom1);
            f2 = new Fraction(nume2, denom2);
            f3 = f1 / f2;
            //f3 = new Fraction.Add(f1, f2);
            UpdateDisplay();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            f1 = new Fraction(nume1,denom1);
            f2 = new Fraction(nume2,denom2);
            f3 = f1 + f2;
            //f3 = new Fraction.Add(f1, f2);
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            txtDenominator3.Text = f3.GetDenominator();
            txtNumerator3.Text = f3.GetNumerator();
            txtOutput.Text = f3.GetValue();
        }
    }
}
