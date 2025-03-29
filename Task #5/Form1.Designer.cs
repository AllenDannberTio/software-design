namespace Task__5
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            btnDescendingSort = new Button();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(180, 348);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(204, 52);
            btnSort.TabIndex = 3;
            btnSort.Text = "BubbleSort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(180, 41);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(465, 284);
            listBoxResults.TabIndex = 4;
            // 
            // btnDescendingSort
            // 
            btnDescendingSort.Location = new Point(476, 348);
            btnDescendingSort.Name = "btnDescendingSort";
            btnDescendingSort.Size = new Size(169, 52);
            btnDescendingSort.TabIndex = 5;
            btnDescendingSort.Text = "Descending Sort";
            btnDescendingSort.UseVisualStyleBackColor = true;
            btnDescendingSort.Click += btnDescendingSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDescendingSort);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
        private Button btnDescendingSort;
    }
}
