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

namespace AvdFractionMath
{
    public partial class FormMain : Form
    {
        Fraction f1, f2,f3;
        MixedFraction m1, m2, m3;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btSubtract_Click(object sender, EventArgs e)
        {

            int whole1 = Convert.ToInt32(txtWhole1.Text),
                whole2 = Convert.ToInt32(txtWhole2.Text),
                nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            m1 = new MixedFraction(whole1, nume1, denom1);
            m2 = new MixedFraction(whole2, nume2, denom2);
            f3 = m1 - m2;
            m3 = new MixedFraction();
            m3.ToMixedFraction(f3);
            UpdateDisplay();
        }

        private void btMutiply_Click(object sender, EventArgs e)
        {

            int whole1 = Convert.ToInt32(txtWhole1.Text),
                whole2 = Convert.ToInt32(txtWhole2.Text),
                nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            m1 = new MixedFraction(whole1, nume1, denom1);
            m2 = new MixedFraction(whole2, nume2, denom2);
            f3 = m1 * m2;
            m3 = new MixedFraction();
            m3.ToMixedFraction(f3);
            UpdateDisplay();
        }

        private void btDivide_Click(object sender, EventArgs e)
        {

            int whole1 = Convert.ToInt32(txtWhole1.Text),
                whole2 = Convert.ToInt32(txtWhole2.Text),
                nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            m1 = new MixedFraction(whole1, nume1, denom1);
            m2 = new MixedFraction(whole2, nume2, denom2);
            f3 = m1 / m2;
            m3 = new MixedFraction();
            m3.ToMixedFraction(f3);
            UpdateDisplay();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int whole1 = Convert.ToInt32(txtWhole1.Text),
                whole2 = Convert.ToInt32(txtWhole2.Text),
                nume1 = Convert.ToInt32(txtNumerator1.Text),
                nume2 = Convert.ToInt32(txtNumerator2.Text),
                denom1 = Convert.ToInt32(txtDenominator1.Text),
                denom2 = Convert.ToInt32(txtDenominator2.Text);
            //m1 = new MixedFraction(-2, -2, 4);
            m1 = new MixedFraction(whole1,nume1,denom1);
            m2 = new MixedFraction(whole2,nume2,denom2);
            f3 = m1 + m2;
            m3 = new MixedFraction();
            m3.ToMixedFraction(f3);
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            txtWhole3.Text = m3.GetMixedWhole();
            txtDenominator3.Text = m3.GetMixedDenominator();
            txtNumerator3.Text = m3.GetMixedNumerator();
            txtOutput.Text = f3.GetValue();
        }
    }
}
