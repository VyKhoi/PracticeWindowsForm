using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionSimpleMath
{
    public partial class simpleMathFraction : Form
    {
        public simpleMathFraction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateFraction();
        }
        private void CalculateFraction()
        {
            try
            {
                //get fracion one
                double numA = Convert.ToDouble(NFA.Text);
                double demA = Convert.ToDouble(DFA.Text); 
                if(demA == 0)
                {
                    throw new Exception("Fraction don't have 0 in demoninator");
                }
               
                Fraction a = new Fraction(numA,demA);

                //get fraction two
                double numB = Convert.ToDouble(NFB.Text);
                double demB = Convert.ToDouble(DFB.Text);
                if (demB == 0)
                {
                    throw new Exception("Fraction don't have 0 in demoninator");
                }

                Fraction b = new Fraction(numB,demB);
                ///check math is corect?
                if(checkMath())
                {
                    string mChar = Math.Text;
                    switch(mChar)
                    {
                        case "+":
                            {
                                Fraction c = a.SumFraction(b);
                                NFR.Text = c.Numerator.ToString();
                                DFR.Text = c.Demoninator.ToString();
                                break;
                            }
                        case "-":
                            {
                                Fraction c = a.SubtractionFraction(b);
                                NFR.Text = c.Numerator.ToString();
                                DFR.Text = c.Demoninator.ToString();
                                break;
                            }
                        case "x":
                            {
                                Fraction c = a.MultiplicationFraction(b);
                                NFR.Text = c.Numerator.ToString();
                                DFR.Text = c.Demoninator.ToString();
                                break;
                            }
                        case "/":
                            {
                                Fraction c = a.DivisionFraction(b);
                                NFR.Text = c.Numerator.ToString();
                                DFR.Text = c.Demoninator.ToString();
                                break;
                            }
                    }

                 

                 //   MessageBox.Show(c.Numerator.ToString() + "/"+ c.Demoninator.ToString());
                }
                else
                {
                    throw new Exception("math error");
                }

                
            }
            catch(FormatException)
            {
                MessageBox.Show("pls input correct number");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      bool checkMath()
        {  
            string[] math = { "+", "-", "x", "/" };
            foreach (string a in math)
            {
                if (a == Math.Text)
                {

                    return true;
                }
            }
            
         
            Math.Clear();
            return false;
        }

        void ClearInput()
        {
            DFA.Clear();
            DFB.Clear();
            NFA.Clear();
            NFB.Clear();
            NFR.Clear();
            DFR.Clear();
            Math.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }

      
    }
