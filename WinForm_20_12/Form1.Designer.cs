namespace WinForm_20_12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.NumericUpDown();
            this.operation = new System.Windows.Forms.ComboBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number1)).BeginInit();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(65, 72);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(120, 20);
            this.number1.TabIndex = 0;
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operation.Location = new System.Drawing.Point(191, 72);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(121, 21);
            this.operation.TabIndex = 1;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(318, 72);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 2;
            // 
            // calc
            // 
            this.calc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.calc.Location = new System.Drawing.Point(424, 70);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 3;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Location = new System.Drawing.Point(105, 137);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 23);
            this.result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown number1;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
    }
}

