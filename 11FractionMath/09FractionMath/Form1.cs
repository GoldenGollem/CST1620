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
            int whole1,
                whole2,
                nume1,
                nume2,
                denom1,
                denom2;
            if (Int32.TryParse(txtNumerator1.Text, out nume1) &&
                Int32.TryParse(txtNumerator2.Text, out nume2) &&
                Int32.TryParse(txtDenominator1.Text, out denom1) &&
                Int32.TryParse(txtDenominator2.Text, out denom2) &&
                Int32.TryParse(txtWhole1.Text, out whole1) &&
                Int32.TryParse(txtWhole2.Text, out whole2)
                )
            {
                try
                {
                    m1 = new MixedFraction(whole1, nume1, denom1);
                    m2 = new MixedFraction(whole2, nume2, denom2);
                    f3 = m1 - m2;
                    m3 = new MixedFraction();
                    m3.ToMixedFraction(f3);
                    UpdateDisplay();

                }
                catch (DivideByZeroException d0)
                {
                    MessageBox.Show(d0.Message);
                }
            }
            else
            {
                MessageBox.Show("Illegal Character entered or t too many characters");
            }
        }

        private void btMutiply_Click(object sender, EventArgs e)
        {
            int whole1,
                            whole2,
                            nume1,
                            nume2,
                            denom1,
                            denom2;
            if (Int32.TryParse(txtNumerator1.Text, out nume1) &&
                Int32.TryParse(txtNumerator2.Text, out nume2) &&
                Int32.TryParse(txtDenominator1.Text, out denom1) &&
                Int32.TryParse(txtDenominator2.Text, out denom2) &&
                Int32.TryParse(txtWhole1.Text, out whole1) &&
                Int32.TryParse(txtWhole2.Text, out whole2)
                )
            {
                try
                {
                    m1 = new MixedFraction(whole1, nume1, denom1);
                    m2 = new MixedFraction(whole2, nume2, denom2);
                    f3 = m1 * m2;
                    m3 = new MixedFraction();
                    m3.ToMixedFraction(f3);
                    UpdateDisplay();
                }
                catch (DivideByZeroException d0)
                {
                    MessageBox.Show(d0.Message);
                }
            }
            else
            {
                MessageBox.Show("Illegal Character entered or t too many characters");
            }
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            int whole1,
                whole2,
                nume1,
                nume2,
                denom1,
                denom2;
            if (Int32.TryParse(txtNumerator1.Text, out nume1) &&
                Int32.TryParse(txtNumerator2.Text, out nume2) &&
                Int32.TryParse(txtDenominator1.Text, out denom1) &&
                Int32.TryParse(txtDenominator2.Text, out denom2) &&
                Int32.TryParse(txtWhole1.Text, out whole1) &&
                Int32.TryParse(txtWhole2.Text, out whole2)
                )
            {
                try
                {
                    m1 = new MixedFraction(whole1, nume1, denom1);
                    m2 = new MixedFraction(whole2, nume2, denom2);
                    f3 = m1 / m2;
                    m3 = new MixedFraction();
                    m3.ToMixedFraction(f3);
                    UpdateDisplay();

                }
                catch (DivideByZeroException d0)
                {
                    MessageBox.Show(d0.Message);
                }
            }
            else
            {
                MessageBox.Show("Illegal Character entered or t too many characters");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int whole1,
                whole2,
                nume1,
                nume2,
                denom1,
                denom2;
            if (Int32.TryParse(txtNumerator1.Text, out nume1)&&
                Int32.TryParse(txtNumerator2.Text, out nume2) &&
                Int32.TryParse(txtDenominator1.Text, out denom1) &&
                Int32.TryParse(txtDenominator2.Text, out denom2) &&
                Int32.TryParse(txtWhole1.Text, out whole1) &&
                Int32.TryParse(txtWhole2.Text, out whole2)
                )
            {
                try
                {
                    m1 = new MixedFraction(whole1, nume1, denom1);
                    m2 = new MixedFraction(whole2, nume2, denom2);
                    f3 = m1 + m2;
                    m3 = new MixedFraction();
                    m3.ToMixedFraction(f3);
                    UpdateDisplay();

                }
                catch (DivideByZeroException d0)
                {
                    MessageBox.Show(d0.Message);
                }
            }
            else
            {
                MessageBox.Show("Illegal Character entered or t too many characters");
            }
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
