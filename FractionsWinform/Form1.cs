using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FractionsWinform
{
    public partial class Form1 : Form
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction();
        Fraction ResultsFraction = new Fraction();

        public Form1()
        {
            InitializeComponent();
        }


        /**
         * Creates the fractions
         */
        private void PrepareMath()
        {
            PopulateFraction(f1, "unit", txtUnit01);
            PopulateFraction(f1, "numerator", TxtNumerator01);
            PopulateFraction(f1, "denominator", TxtDenominator01);

            PopulateFraction(f2, "unit", txtUnit02);
            PopulateFraction(f2, "numerator", TxtNumerator02);
            PopulateFraction(f2, "denominator", TxtDenominator02);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PrepareMath();
            //LblDenominatorAnswer.Text = f2.Denominator.ToString();
            ResultsFraction = f1.Add(f2);
            //LblNumeratorAnswer.Text = ResultsFraction.Numerator.ToString();
            //LblDenominatorAnswer.Text = ResultsFraction.Denominator.ToString();
            TxtAnswer01.Text = ResultsFraction.ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            PrepareMath();
            //LblDenominatorAnswer.Text = f2.Denominator.ToString();
            ResultsFraction = f1.Subtract(f2);
            //LblNumeratorAnswer.Text = ResultsFraction.Numerator.ToString();
            //LblDenominatorAnswer.Text = ResultsFraction.Denominator.ToString();
            TxtAnswer01.Text = ResultsFraction.ToString();
        }
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            PrepareMath();
            ResultsFraction = f1.Multiply(f2);
            TxtAnswer01.Text = ResultsFraction.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            PrepareMath();
            ResultsFraction = f1.Divide(f2);
            TxtAnswer01.Text = ResultsFraction.ToString();
        }

        private void PopulateFraction(Fraction frac, string partOfFraction, TextBox box1)
        {
            if (!int.TryParse(box1.Text, out int temp))
            {
                MessageBox.Show("Please enter an integer");
                box1.Text = string.Empty;
                box1.Focus();
            }
            else
            {
                if (partOfFraction == "numerator")
                    //frac.Numerator = temp;
                    frac.Numerator = (temp > 0) ? temp : 0;
                else if (partOfFraction == "denominator")
                    //frac.Denominator = temp;
                    frac.Denominator = (temp > 0) ? temp : 1;
                else
                    frac.Unit = temp;
            }
        }

        private void BtnSimplify_Click(object sender, EventArgs e)
        {
            ResultsFraction.Simplify();
            TxtAnswer01.Text = ResultsFraction.ToString();
        }

        public static List<Control> FindControlsByTag(Control container, string tagValue)
        {
            List<Control> foundControls = new List<Control>();
            foreach (Control control in container.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == tagValue)
                {
                    foundControls.Add(control);
                }
                if (control.HasChildren)
                {
                    foundControls.AddRange(FindControlsByTag(control, tagValue));
                }
            }
            return foundControls;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            List<Control> controlsWithClearTag = FindControlsByTag(this, "Clear");
            foreach (Control control in controlsWithClearTag)
            {
                control.Text = string.Empty;
            }
            List<Control> controlsWithZeroTag = FindControlsByTag(this, "0");
            foreach (Control control in controlsWithZeroTag)
            {
                control.Text = "0";
            }

            txtUnit01.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnClear_Click(sender, e);
        }

        private void BtnSimplify_Click_1(object sender, EventArgs e)
        {

            Fraction t1 = new Fraction();
            PopulateFraction(t1, "unit", TxtUnit03);
            PopulateFraction(t1, "numerator", TxtNumerator03);
            PopulateFraction(t1, "denominator", TxtDenominator03);
            t1.Simplify();
            TxtAnswer02.Text = t1.ToString();
            
        }
    }
}
