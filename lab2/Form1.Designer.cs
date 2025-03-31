namespace lab2
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
            lblResult = new Label();
            btnCalculateFactorial = new Button();
            txtInput = new TextBox();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(64, 174);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(65, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "Factorial";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(64, 232);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(223, 77);
            btnCalculateFactorial.TabIndex = 1;
            btnCalculateFactorial.Text = "Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(64, 96);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(223, 27);
            txtInput.TabIndex = 2;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(350, 96);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(223, 27);
            txtArrayInput.TabIndex = 3;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(350, 186);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(38, 20);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Sum";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(350, 232);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(223, 77);
            btnCalculateSum.TabIndex = 5;
            btnCalculateSum.Text = "Factorial";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnCalculateFactorial;
        private TextBox txtInput;
        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button btnCalculateSum;
    }
}
