namespace RecursiveFibonacci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFibonacciInput = new TextBox();
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            txtExponent = new TextBox();
            txtBase = new TextBox();
            btnCalculatePower = new Button();
            lblPowerResult = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(100, 179);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(223, 27);
            txtFibonacciInput.TabIndex = 3;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(118, 102);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(72, 20);
            lblFibonacciResult.TabIndex = 4;
            lblFibonacciResult.Text = "Fibonacci";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(100, 261);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(223, 77);
            btnCalculateFibonacci.TabIndex = 5;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(461, 221);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(223, 27);
            txtExponent.TabIndex = 6;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(461, 162);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(223, 27);
            txtBase.TabIndex = 7;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(461, 273);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(223, 77);
            btnCalculatePower.TabIndex = 8;
            btnCalculatePower.Text = "Calculate Power";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(461, 102);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(57, 20);
            lblPowerResult.TabIndex = 9;
            lblPowerResult.Text = "Answer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 165);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 10;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 224);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 11;
            label3.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(txtBase);
            Controls.Add(txtExponent);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblFibonacciResult);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private TextBox txtExponent;
        private TextBox txtBase;
        private Button btnCalculatePower;
        private Label lblPowerResult;
        private Label label2;
        private Label label3;
    }
}
