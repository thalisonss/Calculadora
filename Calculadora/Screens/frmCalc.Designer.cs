namespace Calculadora
{
    partial class frmCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCalcSeven = new System.Windows.Forms.Button();
            this.btnCalcEight = new System.Windows.Forms.Button();
            this.btnCalcNine = new System.Windows.Forms.Button();
            this.btnCalcFour = new System.Windows.Forms.Button();
            this.btnCalcFive = new System.Windows.Forms.Button();
            this.btnCalcOne = new System.Windows.Forms.Button();
            this.btnCalcSix = new System.Windows.Forms.Button();
            this.btnCalcTwo = new System.Windows.Forms.Button();
            this.btnCalcThree = new System.Windows.Forms.Button();
            this.btnCalcZero = new System.Windows.Forms.Button();
            this.btnCalcComa = new System.Windows.Forms.Button();
            this.btnCalcSum = new System.Windows.Forms.Button();
            this.btnCalcSubtraction = new System.Windows.Forms.Button();
            this.btnCalcMultiplication = new System.Windows.Forms.Button();
            this.btnCalcDivision = new System.Windows.Forms.Button();
            this.btnCalcC = new System.Windows.Forms.Button();
            this.btnCalcCE = new System.Windows.Forms.Button();
            this.btnCalcEqual = new System.Windows.Forms.Button();
            this.lblPreviousValue = new System.Windows.Forms.Label();
            this.panelBorderForm = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnCalcNegative = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Calculadora = new System.Windows.Forms.TabPage();
            this.tpgCoin = new System.Windows.Forms.TabPage();
            this.btnCoinCE = new System.Windows.Forms.Button();
            this.btnCoinSeven = new System.Windows.Forms.Button();
            this.btnCoinEight = new System.Windows.Forms.Button();
            this.btnCoinNine = new System.Windows.Forms.Button();
            this.btnCoinFour = new System.Windows.Forms.Button();
            this.btnCoinFive = new System.Windows.Forms.Button();
            this.btnCoinOne = new System.Windows.Forms.Button();
            this.btnCoinSix = new System.Windows.Forms.Button();
            this.btnCoinTwo = new System.Windows.Forms.Button();
            this.btnCoinThree = new System.Windows.Forms.Button();
            this.btnCoinComma = new System.Windows.Forms.Button();
            this.btnCoinZero = new System.Windows.Forms.Button();
            this.lblLastRateUpdate = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtCoinValueSecond = new System.Windows.Forms.Label();
            this.lblSecondCurrencySymbols = new System.Windows.Forms.Label();
            this.lblFirstCurrencySymbols = new System.Windows.Forms.Label();
            this.cboFirstCoin = new System.Windows.Forms.ComboBox();
            this.cboSecondCoin = new System.Windows.Forms.ComboBox();
            this.txtCoinValueFirst = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.panelBorderForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Calculadora.SuspendLayout();
            this.tpgCoin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValue.Font = new System.Drawing.Font("Verdana", 20.75F);
            this.txtValue.Location = new System.Drawing.Point(15, 45);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(456, 34);
            this.txtValue.TabIndex = 0;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // btnCalcSeven
            // 
            this.btnCalcSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSeven.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSeven.Location = new System.Drawing.Point(15, 101);
            this.btnCalcSeven.Name = "btnCalcSeven";
            this.btnCalcSeven.Size = new System.Drawing.Size(102, 66);
            this.btnCalcSeven.TabIndex = 1;
            this.btnCalcSeven.Text = "7";
            this.btnCalcSeven.UseVisualStyleBackColor = false;
            this.btnCalcSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnCalcEight
            // 
            this.btnCalcEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcEight.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcEight.Location = new System.Drawing.Point(123, 101);
            this.btnCalcEight.Name = "btnCalcEight";
            this.btnCalcEight.Size = new System.Drawing.Size(102, 66);
            this.btnCalcEight.TabIndex = 2;
            this.btnCalcEight.Text = "8";
            this.btnCalcEight.UseVisualStyleBackColor = true;
            this.btnCalcEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnCalcNine
            // 
            this.btnCalcNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcNine.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcNine.Location = new System.Drawing.Point(231, 101);
            this.btnCalcNine.Name = "btnCalcNine";
            this.btnCalcNine.Size = new System.Drawing.Size(102, 66);
            this.btnCalcNine.TabIndex = 3;
            this.btnCalcNine.Text = "9";
            this.btnCalcNine.UseVisualStyleBackColor = true;
            this.btnCalcNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnCalcFour
            // 
            this.btnCalcFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcFour.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcFour.Location = new System.Drawing.Point(15, 173);
            this.btnCalcFour.Name = "btnCalcFour";
            this.btnCalcFour.Size = new System.Drawing.Size(102, 66);
            this.btnCalcFour.TabIndex = 4;
            this.btnCalcFour.Text = "4";
            this.btnCalcFour.UseVisualStyleBackColor = true;
            this.btnCalcFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnCalcFive
            // 
            this.btnCalcFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcFive.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcFive.Location = new System.Drawing.Point(123, 173);
            this.btnCalcFive.Name = "btnCalcFive";
            this.btnCalcFive.Size = new System.Drawing.Size(102, 66);
            this.btnCalcFive.TabIndex = 5;
            this.btnCalcFive.Text = "5";
            this.btnCalcFive.UseVisualStyleBackColor = true;
            this.btnCalcFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnCalcOne
            // 
            this.btnCalcOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcOne.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcOne.Location = new System.Drawing.Point(15, 245);
            this.btnCalcOne.Name = "btnCalcOne";
            this.btnCalcOne.Size = new System.Drawing.Size(102, 66);
            this.btnCalcOne.TabIndex = 6;
            this.btnCalcOne.Text = "1";
            this.btnCalcOne.UseVisualStyleBackColor = true;
            this.btnCalcOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnCalcSix
            // 
            this.btnCalcSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSix.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSix.Location = new System.Drawing.Point(231, 173);
            this.btnCalcSix.Name = "btnCalcSix";
            this.btnCalcSix.Size = new System.Drawing.Size(102, 66);
            this.btnCalcSix.TabIndex = 6;
            this.btnCalcSix.Text = "6";
            this.btnCalcSix.UseVisualStyleBackColor = true;
            this.btnCalcSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnCalcTwo
            // 
            this.btnCalcTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcTwo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTwo.Location = new System.Drawing.Point(123, 245);
            this.btnCalcTwo.Name = "btnCalcTwo";
            this.btnCalcTwo.Size = new System.Drawing.Size(102, 66);
            this.btnCalcTwo.TabIndex = 7;
            this.btnCalcTwo.Text = "2";
            this.btnCalcTwo.UseVisualStyleBackColor = true;
            this.btnCalcTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnCalcThree
            // 
            this.btnCalcThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcThree.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcThree.Location = new System.Drawing.Point(231, 245);
            this.btnCalcThree.Name = "btnCalcThree";
            this.btnCalcThree.Size = new System.Drawing.Size(102, 66);
            this.btnCalcThree.TabIndex = 8;
            this.btnCalcThree.Text = "3";
            this.btnCalcThree.UseVisualStyleBackColor = true;
            this.btnCalcThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnCalcZero
            // 
            this.btnCalcZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcZero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcZero.Location = new System.Drawing.Point(15, 317);
            this.btnCalcZero.Name = "btnCalcZero";
            this.btnCalcZero.Size = new System.Drawing.Size(210, 66);
            this.btnCalcZero.TabIndex = 9;
            this.btnCalcZero.Text = "0";
            this.btnCalcZero.UseVisualStyleBackColor = true;
            this.btnCalcZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnCalcComa
            // 
            this.btnCalcComa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcComa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcComa.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcComa.Location = new System.Drawing.Point(231, 317);
            this.btnCalcComa.Name = "btnCalcComa";
            this.btnCalcComa.Size = new System.Drawing.Size(102, 66);
            this.btnCalcComa.TabIndex = 10;
            this.btnCalcComa.Text = ",";
            this.btnCalcComa.UseVisualStyleBackColor = true;
            this.btnCalcComa.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnCalcSum
            // 
            this.btnCalcSum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSum.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSum.Location = new System.Drawing.Point(339, 389);
            this.btnCalcSum.Name = "btnCalcSum";
            this.btnCalcSum.Size = new System.Drawing.Size(132, 68);
            this.btnCalcSum.TabIndex = 11;
            this.btnCalcSum.Text = "+";
            this.btnCalcSum.UseVisualStyleBackColor = true;
            this.btnCalcSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCalcSubtraction
            // 
            this.btnCalcSubtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcSubtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSubtraction.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSubtraction.Location = new System.Drawing.Point(339, 317);
            this.btnCalcSubtraction.Name = "btnCalcSubtraction";
            this.btnCalcSubtraction.Size = new System.Drawing.Size(132, 66);
            this.btnCalcSubtraction.TabIndex = 12;
            this.btnCalcSubtraction.Text = "-";
            this.btnCalcSubtraction.UseVisualStyleBackColor = true;
            this.btnCalcSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnCalcMultiplication
            // 
            this.btnCalcMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcMultiplication.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMultiplication.Location = new System.Drawing.Point(339, 245);
            this.btnCalcMultiplication.Name = "btnCalcMultiplication";
            this.btnCalcMultiplication.Size = new System.Drawing.Size(132, 66);
            this.btnCalcMultiplication.TabIndex = 13;
            this.btnCalcMultiplication.Text = "x";
            this.btnCalcMultiplication.UseVisualStyleBackColor = true;
            this.btnCalcMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnCalcDivision
            // 
            this.btnCalcDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcDivision.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcDivision.Location = new System.Drawing.Point(339, 173);
            this.btnCalcDivision.Name = "btnCalcDivision";
            this.btnCalcDivision.Size = new System.Drawing.Size(132, 66);
            this.btnCalcDivision.TabIndex = 14;
            this.btnCalcDivision.Text = "÷";
            this.btnCalcDivision.UseVisualStyleBackColor = true;
            this.btnCalcDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnCalcC
            // 
            this.btnCalcC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcC.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcC.Location = new System.Drawing.Point(339, 101);
            this.btnCalcC.Name = "btnCalcC";
            this.btnCalcC.Size = new System.Drawing.Size(63, 66);
            this.btnCalcC.TabIndex = 15;
            this.btnCalcC.Text = "C";
            this.btnCalcC.UseVisualStyleBackColor = true;
            this.btnCalcC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCalcCE
            // 
            this.btnCalcCE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcCE.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCE.Location = new System.Drawing.Point(408, 101);
            this.btnCalcCE.Name = "btnCalcCE";
            this.btnCalcCE.Size = new System.Drawing.Size(63, 66);
            this.btnCalcCE.TabIndex = 16;
            this.btnCalcCE.Text = "CE";
            this.btnCalcCE.UseVisualStyleBackColor = true;
            this.btnCalcCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnCalcEqual
            // 
            this.btnCalcEqual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcEqual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcEqual.Location = new System.Drawing.Point(123, 389);
            this.btnCalcEqual.Name = "btnCalcEqual";
            this.btnCalcEqual.Size = new System.Drawing.Size(210, 68);
            this.btnCalcEqual.TabIndex = 17;
            this.btnCalcEqual.Text = "=";
            this.btnCalcEqual.UseVisualStyleBackColor = true;
            this.btnCalcEqual.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblPreviousValue
            // 
            this.lblPreviousValue.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousValue.Location = new System.Drawing.Point(18, 9);
            this.lblPreviousValue.Name = "lblPreviousValue";
            this.lblPreviousValue.Size = new System.Drawing.Size(456, 33);
            this.lblPreviousValue.TabIndex = 18;
            this.lblPreviousValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBorderForm
            // 
            this.panelBorderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.panelBorderForm.Controls.Add(this.btnExit);
            this.panelBorderForm.Location = new System.Drawing.Point(0, 0);
            this.panelBorderForm.Name = "panelBorderForm";
            this.panelBorderForm.Size = new System.Drawing.Size(492, 38);
            this.panelBorderForm.TabIndex = 19;
            this.panelBorderForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorderForm_MouseDown);
            this.panelBorderForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBorderForm_MouseMove);
            this.panelBorderForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBorderForm_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Calculadora.Properties.Resources.button_exit;
            this.btnExit.Location = new System.Drawing.Point(434, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 38);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalcNegative
            // 
            this.btnCalcNegative.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCalcNegative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCalcNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcNegative.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcNegative.Location = new System.Drawing.Point(15, 389);
            this.btnCalcNegative.Name = "btnCalcNegative";
            this.btnCalcNegative.Size = new System.Drawing.Size(102, 68);
            this.btnCalcNegative.TabIndex = 20;
            this.btnCalcNegative.Text = "+/-";
            this.btnCalcNegative.UseVisualStyleBackColor = true;
            this.btnCalcNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calculadora);
            this.tabControl.Controls.Add(this.tpgCoin);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(0, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(492, 490);
            this.tabControl.TabIndex = 21;
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.Calculadora.Controls.Add(this.lblPreviousValue);
            this.Calculadora.Controls.Add(this.btnCalcNegative);
            this.Calculadora.Controls.Add(this.txtValue);
            this.Calculadora.Controls.Add(this.btnCalcSeven);
            this.Calculadora.Controls.Add(this.btnCalcEight);
            this.Calculadora.Controls.Add(this.btnCalcEqual);
            this.Calculadora.Controls.Add(this.btnCalcNine);
            this.Calculadora.Controls.Add(this.btnCalcCE);
            this.Calculadora.Controls.Add(this.btnCalcFour);
            this.Calculadora.Controls.Add(this.btnCalcC);
            this.Calculadora.Controls.Add(this.btnCalcFive);
            this.Calculadora.Controls.Add(this.btnCalcDivision);
            this.Calculadora.Controls.Add(this.btnCalcOne);
            this.Calculadora.Controls.Add(this.btnCalcMultiplication);
            this.Calculadora.Controls.Add(this.btnCalcSix);
            this.Calculadora.Controls.Add(this.btnCalcSubtraction);
            this.Calculadora.Controls.Add(this.btnCalcTwo);
            this.Calculadora.Controls.Add(this.btnCalcSum);
            this.Calculadora.Controls.Add(this.btnCalcThree);
            this.Calculadora.Controls.Add(this.btnCalcComa);
            this.Calculadora.Controls.Add(this.btnCalcZero);
            this.Calculadora.Location = new System.Drawing.Point(4, 22);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Padding = new System.Windows.Forms.Padding(3);
            this.Calculadora.Size = new System.Drawing.Size(484, 464);
            this.Calculadora.TabIndex = 0;
            this.Calculadora.Text = "Calculadora";
            // 
            // tpgCoin
            // 
            this.tpgCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.tpgCoin.Controls.Add(this.btnCoinCE);
            this.tpgCoin.Controls.Add(this.btnCoinSeven);
            this.tpgCoin.Controls.Add(this.btnCoinEight);
            this.tpgCoin.Controls.Add(this.btnCoinNine);
            this.tpgCoin.Controls.Add(this.btnCoinFour);
            this.tpgCoin.Controls.Add(this.btnCoinFive);
            this.tpgCoin.Controls.Add(this.btnCoinOne);
            this.tpgCoin.Controls.Add(this.btnCoinSix);
            this.tpgCoin.Controls.Add(this.btnCoinTwo);
            this.tpgCoin.Controls.Add(this.btnCoinThree);
            this.tpgCoin.Controls.Add(this.btnCoinComma);
            this.tpgCoin.Controls.Add(this.btnCoinZero);
            this.tpgCoin.Controls.Add(this.lblLastRateUpdate);
            this.tpgCoin.Controls.Add(this.lblTaxa);
            this.tpgCoin.Controls.Add(this.txtCoinValueSecond);
            this.tpgCoin.Controls.Add(this.lblSecondCurrencySymbols);
            this.tpgCoin.Controls.Add(this.lblFirstCurrencySymbols);
            this.tpgCoin.Controls.Add(this.cboFirstCoin);
            this.tpgCoin.Controls.Add(this.cboSecondCoin);
            this.tpgCoin.Controls.Add(this.txtCoinValueFirst);
            this.tpgCoin.Location = new System.Drawing.Point(4, 22);
            this.tpgCoin.Name = "tpgCoin";
            this.tpgCoin.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCoin.Size = new System.Drawing.Size(484, 464);
            this.tpgCoin.TabIndex = 1;
            this.tpgCoin.Text = "Moeda";
            // 
            // btnCoinCE
            // 
            this.btnCoinCE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinCE.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinCE.Location = new System.Drawing.Point(320, 200);
            this.btnCoinCE.Name = "btnCoinCE";
            this.btnCoinCE.Size = new System.Drawing.Size(142, 41);
            this.btnCoinCE.TabIndex = 22;
            this.btnCoinCE.Text = "CE";
            this.btnCoinCE.UseVisualStyleBackColor = true;
            this.btnCoinCE.Click += new System.EventHandler(this.btnCoinCE_Click);
            // 
            // btnCoinSeven
            // 
            this.btnCoinSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnCoinSeven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinSeven.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinSeven.Location = new System.Drawing.Point(28, 247);
            this.btnCoinSeven.Name = "btnCoinSeven";
            this.btnCoinSeven.Size = new System.Drawing.Size(136, 47);
            this.btnCoinSeven.TabIndex = 11;
            this.btnCoinSeven.Text = "7";
            this.btnCoinSeven.UseVisualStyleBackColor = false;
            this.btnCoinSeven.Click += new System.EventHandler(this.btnCoinSeven_Click);
            // 
            // btnCoinEight
            // 
            this.btnCoinEight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinEight.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinEight.Location = new System.Drawing.Point(170, 247);
            this.btnCoinEight.Name = "btnCoinEight";
            this.btnCoinEight.Size = new System.Drawing.Size(144, 47);
            this.btnCoinEight.TabIndex = 12;
            this.btnCoinEight.Text = "8";
            this.btnCoinEight.UseVisualStyleBackColor = true;
            this.btnCoinEight.Click += new System.EventHandler(this.btnCoinEight_Click);
            // 
            // btnCoinNine
            // 
            this.btnCoinNine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinNine.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinNine.Location = new System.Drawing.Point(320, 247);
            this.btnCoinNine.Name = "btnCoinNine";
            this.btnCoinNine.Size = new System.Drawing.Size(142, 47);
            this.btnCoinNine.TabIndex = 13;
            this.btnCoinNine.Text = "9";
            this.btnCoinNine.UseVisualStyleBackColor = true;
            this.btnCoinNine.Click += new System.EventHandler(this.btnCoinNine_Click);
            // 
            // btnCoinFour
            // 
            this.btnCoinFour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinFour.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinFour.Location = new System.Drawing.Point(28, 300);
            this.btnCoinFour.Name = "btnCoinFour";
            this.btnCoinFour.Size = new System.Drawing.Size(136, 45);
            this.btnCoinFour.TabIndex = 14;
            this.btnCoinFour.Text = "4";
            this.btnCoinFour.UseVisualStyleBackColor = true;
            this.btnCoinFour.Click += new System.EventHandler(this.btnCoinFour_Click);
            // 
            // btnCoinFive
            // 
            this.btnCoinFive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinFive.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinFive.Location = new System.Drawing.Point(170, 300);
            this.btnCoinFive.Name = "btnCoinFive";
            this.btnCoinFive.Size = new System.Drawing.Size(144, 45);
            this.btnCoinFive.TabIndex = 15;
            this.btnCoinFive.Text = "5";
            this.btnCoinFive.UseVisualStyleBackColor = true;
            this.btnCoinFive.Click += new System.EventHandler(this.btnCoinFive_Click);
            // 
            // btnCoinOne
            // 
            this.btnCoinOne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinOne.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinOne.Location = new System.Drawing.Point(28, 351);
            this.btnCoinOne.Name = "btnCoinOne";
            this.btnCoinOne.Size = new System.Drawing.Size(136, 41);
            this.btnCoinOne.TabIndex = 16;
            this.btnCoinOne.Text = "1";
            this.btnCoinOne.UseVisualStyleBackColor = true;
            this.btnCoinOne.Click += new System.EventHandler(this.btnCoinOne_Click);
            // 
            // btnCoinSix
            // 
            this.btnCoinSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinSix.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinSix.Location = new System.Drawing.Point(320, 300);
            this.btnCoinSix.Name = "btnCoinSix";
            this.btnCoinSix.Size = new System.Drawing.Size(142, 45);
            this.btnCoinSix.TabIndex = 17;
            this.btnCoinSix.Text = "6";
            this.btnCoinSix.UseVisualStyleBackColor = true;
            this.btnCoinSix.Click += new System.EventHandler(this.btnCoinSix_Click);
            // 
            // btnCoinTwo
            // 
            this.btnCoinTwo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinTwo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinTwo.Location = new System.Drawing.Point(170, 351);
            this.btnCoinTwo.Name = "btnCoinTwo";
            this.btnCoinTwo.Size = new System.Drawing.Size(144, 41);
            this.btnCoinTwo.TabIndex = 18;
            this.btnCoinTwo.Text = "2";
            this.btnCoinTwo.UseVisualStyleBackColor = true;
            this.btnCoinTwo.Click += new System.EventHandler(this.btnCoinTwo_Click);
            // 
            // btnCoinThree
            // 
            this.btnCoinThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinThree.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinThree.Location = new System.Drawing.Point(320, 351);
            this.btnCoinThree.Name = "btnCoinThree";
            this.btnCoinThree.Size = new System.Drawing.Size(142, 41);
            this.btnCoinThree.TabIndex = 19;
            this.btnCoinThree.Text = "3";
            this.btnCoinThree.UseVisualStyleBackColor = true;
            this.btnCoinThree.Click += new System.EventHandler(this.btnCoinThree_Click);
            // 
            // btnCoinComma
            // 
            this.btnCoinComma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinComma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinComma.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinComma.Location = new System.Drawing.Point(320, 398);
            this.btnCoinComma.Name = "btnCoinComma";
            this.btnCoinComma.Size = new System.Drawing.Size(142, 50);
            this.btnCoinComma.TabIndex = 21;
            this.btnCoinComma.Text = ",";
            this.btnCoinComma.UseVisualStyleBackColor = true;
            this.btnCoinComma.Click += new System.EventHandler(this.btnCoinComma_Click);
            // 
            // btnCoinZero
            // 
            this.btnCoinZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.btnCoinZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.btnCoinZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinZero.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinZero.Location = new System.Drawing.Point(170, 398);
            this.btnCoinZero.Name = "btnCoinZero";
            this.btnCoinZero.Size = new System.Drawing.Size(144, 50);
            this.btnCoinZero.TabIndex = 20;
            this.btnCoinZero.Text = "0";
            this.btnCoinZero.UseVisualStyleBackColor = true;
            this.btnCoinZero.Click += new System.EventHandler(this.btnCoinZero_Click);
            // 
            // lblLastRateUpdate
            // 
            this.lblLastRateUpdate.AutoSize = true;
            this.lblLastRateUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLastRateUpdate.Location = new System.Drawing.Point(38, 223);
            this.lblLastRateUpdate.Name = "lblLastRateUpdate";
            this.lblLastRateUpdate.Size = new System.Drawing.Size(0, 13);
            this.lblLastRateUpdate.TabIndex = 10;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTaxa.Location = new System.Drawing.Point(38, 200);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(0, 13);
            this.lblTaxa.TabIndex = 9;
            // 
            // txtCoinValueSecond
            // 
            this.txtCoinValueSecond.Font = new System.Drawing.Font("Verdana", 31F, System.Drawing.FontStyle.Italic);
            this.txtCoinValueSecond.Location = new System.Drawing.Point(93, 102);
            this.txtCoinValueSecond.Name = "txtCoinValueSecond";
            this.txtCoinValueSecond.Size = new System.Drawing.Size(369, 51);
            this.txtCoinValueSecond.TabIndex = 8;
            this.txtCoinValueSecond.Text = "0";
            this.txtCoinValueSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecondCurrencySymbols
            // 
            this.lblSecondCurrencySymbols.AutoSize = true;
            this.lblSecondCurrencySymbols.Font = new System.Drawing.Font("Verdana", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondCurrencySymbols.Location = new System.Drawing.Point(22, 103);
            this.lblSecondCurrencySymbols.Name = "lblSecondCurrencySymbols";
            this.lblSecondCurrencySymbols.Size = new System.Drawing.Size(48, 49);
            this.lblSecondCurrencySymbols.TabIndex = 7;
            this.lblSecondCurrencySymbols.Text = "$";
            this.lblSecondCurrencySymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstCurrencySymbols
            // 
            this.lblFirstCurrencySymbols.AutoSize = true;
            this.lblFirstCurrencySymbols.Font = new System.Drawing.Font("Verdana", 20.75F);
            this.lblFirstCurrencySymbols.Location = new System.Drawing.Point(21, 20);
            this.lblFirstCurrencySymbols.Name = "lblFirstCurrencySymbols";
            this.lblFirstCurrencySymbols.Size = new System.Drawing.Size(52, 34);
            this.lblFirstCurrencySymbols.TabIndex = 6;
            this.lblFirstCurrencySymbols.Text = "R$";
            this.lblFirstCurrencySymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFirstCoin
            // 
            this.cboFirstCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.cboFirstCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFirstCoin.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboFirstCoin.FormattingEnabled = true;
            this.cboFirstCoin.Items.AddRange(new object[] {
            "BRL",
            "USD",
            "EUR"});
            this.cboFirstCoin.Location = new System.Drawing.Point(32, 161);
            this.cboFirstCoin.Name = "cboFirstCoin";
            this.cboFirstCoin.Size = new System.Drawing.Size(430, 26);
            this.cboFirstCoin.TabIndex = 5;
            this.cboFirstCoin.TextChanged += new System.EventHandler(this.cboFirstCoin_TextChanged);
            // 
            // cboSecondCoin
            // 
            this.cboSecondCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.cboSecondCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSecondCoin.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboSecondCoin.FormattingEnabled = true;
            this.cboSecondCoin.Items.AddRange(new object[] {
            "BRL",
            "USD",
            "EUR"});
            this.cboSecondCoin.Location = new System.Drawing.Point(32, 63);
            this.cboSecondCoin.Name = "cboSecondCoin";
            this.cboSecondCoin.Size = new System.Drawing.Size(430, 26);
            this.cboSecondCoin.TabIndex = 4;
            this.cboSecondCoin.TextChanged += new System.EventHandler(this.cboSecondCoin_TextChanged);
            // 
            // txtCoinValueFirst
            // 
            this.txtCoinValueFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.txtCoinValueFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoinValueFirst.Font = new System.Drawing.Font("Verdana", 20.75F);
            this.txtCoinValueFirst.Location = new System.Drawing.Point(78, 21);
            this.txtCoinValueFirst.Name = "txtCoinValueFirst";
            this.txtCoinValueFirst.Size = new System.Drawing.Size(383, 34);
            this.txtCoinValueFirst.TabIndex = 1;
            this.txtCoinValueFirst.TextChanged += new System.EventHandler(this.txtCoinValueFirst_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblGitHub);
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 24);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.logotipo_do_github;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Location = new System.Drawing.Point(32, 6);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(87, 13);
            this.lblGitHub.TabIndex = 0;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "github/thalisonss";
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(491, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelBorderForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalc";
            this.panelBorderForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Calculadora.ResumeLayout(false);
            this.Calculadora.PerformLayout();
            this.tpgCoin.ResumeLayout(false);
            this.tpgCoin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCalcSeven;
        private System.Windows.Forms.Button btnCalcEight;
        private System.Windows.Forms.Button btnCalcNine;
        private System.Windows.Forms.Button btnCalcFour;
        private System.Windows.Forms.Button btnCalcFive;
        private System.Windows.Forms.Button btnCalcOne;
        private System.Windows.Forms.Button btnCalcSix;
        private System.Windows.Forms.Button btnCalcTwo;
        private System.Windows.Forms.Button btnCalcThree;
        private System.Windows.Forms.Button btnCalcZero;
        private System.Windows.Forms.Button btnCalcComa;
        private System.Windows.Forms.Button btnCalcSum;
        private System.Windows.Forms.Button btnCalcSubtraction;
        private System.Windows.Forms.Button btnCalcMultiplication;
        private System.Windows.Forms.Button btnCalcDivision;
        private System.Windows.Forms.Button btnCalcC;
        private System.Windows.Forms.Button btnCalcCE;
        private System.Windows.Forms.Button btnCalcEqual;
        private System.Windows.Forms.Label lblPreviousValue;
        private System.Windows.Forms.Panel panelBorderForm;
        private System.Windows.Forms.Button btnCalcNegative;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Calculadora;
        private System.Windows.Forms.TabPage tpgCoin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.TextBox txtCoinValueFirst;
        private System.Windows.Forms.ComboBox cboSecondCoin;
        private System.Windows.Forms.ComboBox cboFirstCoin;
        private System.Windows.Forms.Label lblSecondCurrencySymbols;
        private System.Windows.Forms.Label lblFirstCurrencySymbols;
        private System.Windows.Forms.Label txtCoinValueSecond;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblLastRateUpdate;
        private System.Windows.Forms.Button btnCoinCE;
        private System.Windows.Forms.Button btnCoinSeven;
        private System.Windows.Forms.Button btnCoinEight;
        private System.Windows.Forms.Button btnCoinNine;
        private System.Windows.Forms.Button btnCoinFour;
        private System.Windows.Forms.Button btnCoinFive;
        private System.Windows.Forms.Button btnCoinOne;
        private System.Windows.Forms.Button btnCoinSix;
        private System.Windows.Forms.Button btnCoinTwo;
        private System.Windows.Forms.Button btnCoinThree;
        private System.Windows.Forms.Button btnCoinComma;
        private System.Windows.Forms.Button btnCoinZero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblGitHub;
    }
}

