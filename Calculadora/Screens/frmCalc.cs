#region | Using |
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
#endregion

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        Database.CalculadoraDatabase db = new Database.CalculadoraDatabase();

        #region | Variables |

        decimal firstValue = 0;
        decimal total = 0;
        string records = string.Empty;
        string operation = string.Empty;
        bool mouseClicked;
        Point clickedAt;

        #endregion

        #region | Controls event |

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
            txtValue.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtValue.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtValue.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtValue.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtValue.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtValue.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtValue.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtValue.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtValue.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtValue.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtValue.Text += ",";
        }

        //Botões de operações
        private void btnSum_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstValue = Convert.ToDecimal(txtValue.Text);
            PreviousValue(firstValue);

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstValue = Convert.ToDecimal(txtValue.Text);
            PreviousValue(firstValue);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            firstValue = Convert.ToDecimal(txtValue.Text);
            PreviousValue(firstValue);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstValue = Convert.ToDecimal(txtValue.Text);
            PreviousValue(firstValue);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Calculate();

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtValue.Text = string.Empty;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtValue.Text = string.Empty;
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(sender, e);
        }
        #endregion

        #region | Functions |
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

        private decimal Sum(decimal firstValue, decimal secondValue)
        {
            decimal total = firstValue + secondValue;
            return total;
        }

        private decimal Subtraction(decimal firstValue, decimal secondValue)
        {
            decimal total = firstValue - secondValue;
            return total;
        }

        private decimal Multiplication(decimal firstValue, decimal secondValue)
        {
            decimal total = firstValue * secondValue;
            return total;
        }

        private decimal Division(decimal firstValue, decimal secondValue)
        {
            decimal total = firstValue / secondValue;
            return total;
        }

        private void Validation(object sender, KeyPressEventArgs e)
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
                Sum(firstValue, Convert.ToDecimal(txtValue.Text));
            }
            if (e.KeyChar == '-')
            {
                operation = "-";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
                Subtraction(firstValue, Convert.ToDecimal(txtValue.Text));
            }
            if (e.KeyChar == '/')
            {
                operation = "/";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
                Division(firstValue, Convert.ToDecimal(txtValue.Text));
            }
            if (e.KeyChar == '*')
            {
                operation = "*";
                firstValue = Convert.ToDecimal(txtValue.Text);
                PreviousValue(firstValue);
                Subtraction(firstValue, Convert.ToDecimal(txtValue.Text));
            }
            if (e.KeyChar == 13)
            {
                Calculate();
            }

        }
        #endregion

        private void btnNegative_Click(object sender, EventArgs e)
        {
            decimal valueTb = Convert.ToDecimal(txtValue.Text);

            decimal result = valueTb - (valueTb * 2);

            txtValue.Text = result.ToString();
        }
    }
}
