#region | Using |
using Calculadora.API;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
#endregion

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
            cboFirstCoin.Text = "BRL";
            cboSecondCoin.Text = "USD";
        }

        Database.CalculadoraDatabase db = new Database.CalculadoraDatabase();

        #region | Variables |

        #region | Variables - Basic Calculator |

        decimal firstValue = 0;
        decimal total = 0;
        string records = string.Empty;
        string operation = string.Empty;
        bool mouseClicked;
        Point clickedAt;

        #endregion

        #region | Variables - Currency Converter |

        string CoinValueFirst;
        string currencyRate;
        string convertedCurrency;

        #endregion

        #endregion

        #region | Controls Events |

        #region | Controls event - Basic Calculator |

        //Mover form com mouse
        private void panelBorderForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void panelBorderForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void panelBorderForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        //Botões da calculadora adiciona numero no TextBox
        private void btnZero_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "3";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "4";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
           
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "5";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "6";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "7";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "8";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += "9";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text += ",";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        //Botões de operações
        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "+";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "-";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "*";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "/";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text = db.PutNegativeValuePositive(Convert.ToDecimal(txtValue.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }

        //Botões de limpar
        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                firstValue = 0;
                lblPreviousValue.Text = string.Empty;
                txtValue.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }       
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyBoardValidation(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
        #endregion

        #region | Controls Events - Currency Converter |
        private void txtCoinValueFirst_TextChanged(object sender, EventArgs e)
        {
            CoinValueFirst = txtCoinValueFirst.Text;
            if (CoinValueFirst == string.Empty)
                CoinValueFirst = "0";

            currencyRate = db.CurrencyRate(cboSecondCoin.Text, cboFirstCoin.Text);

            this.UpdateRate();

            txtCoinValueSecond.Text = db.Calculate
                (Convert.ToDecimal(currencyRate), Convert.ToDecimal(CoinValueFirst), "*").ToString("F");
        }

        private void cboSecondCoin_TextChanged(object sender, EventArgs e)
        {
            if (cboSecondCoin.Text == "BRL")
            {
                
                lblFirstCurrencySymbols.Text = "R$";
            }

            if (cboSecondCoin.Text == "USD")
            {
                lblFirstCurrencySymbols.Text = "$";
            }
        }

        private void cboFirstCoin_TextChanged(object sender, EventArgs e)
        {
            if (cboFirstCoin.Text == "BRL")
            {
                lblSecondCurrencySymbols.Text = "R$";
            }

            if (cboFirstCoin.Text == "USD")
            {
                lblSecondCurrencySymbols.Text = "$";
            }
        }

        #endregion

        #endregion

        #region | Functions |

        #region | Functions - Basic Calculator |
        private void PreviousValue(decimal firstValue)
        {
            records = firstValue.ToString() + " " + operation + " ";
            lblPreviousValue.Text = records;
        }

        private void Calculate()
        {
            lblPreviousValue.Text = records + txtValue.Text + " =";

            total = db.Calculate(firstValue, Convert.ToDecimal(txtValue.Text), operation);
            txtValue.Text = total.ToString();
        }

        private void KeyBoardValidation(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '+')
                {
                    operation = "+";
                    firstValue = Convert.ToDecimal(txtValue.Text);
                    PreviousValue(firstValue);
                }
                if (e.KeyChar == '-')
                {
                    operation = "-";
                    firstValue = Convert.ToDecimal(txtValue.Text);
                    PreviousValue(firstValue);
                }
                if (e.KeyChar == '/')
                {
                    operation = "/";
                    firstValue = Convert.ToDecimal(txtValue.Text);
                    PreviousValue(firstValue);
                }
                if (e.KeyChar == '*')
                {
                    operation = "*";
                    firstValue = Convert.ToDecimal(txtValue.Text);
                    PreviousValue(firstValue);
                }
                if (e.KeyChar == 13)
                {
                    Calculate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        #endregion

        #region | Functions - Currency Converter |

        public void UpdateRate()
        {
            string exchangeRate = db.Calculate (Convert.ToDecimal(currencyRate), 1, "*").ToString();

            lblTaxa.Text = $"1 {cboSecondCoin.Text} = {exchangeRate} {cboFirstCoin.Text}";
            lblLastRateUpdate.Text = $"Atualizado {DateTime.Now.ToString()}";
        }

        #endregion

        #endregion

    }
}
