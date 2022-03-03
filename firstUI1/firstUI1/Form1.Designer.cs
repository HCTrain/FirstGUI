namespace firstUI1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(8, 25);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(12, 9);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(33, 13);
            this.lbNumber1.TabIndex = 2;
            this.lbNumber1.Text = "num1";
          
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(175, 9);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(33, 13);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "num2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(154, 25);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(303, 10);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer";
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(117, 25);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(31, 20);
            this.txtOperator.TabIndex = 6;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(306, 26);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 9;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(260, 25);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 20);
            this.btnEquals.TabIndex = 10;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 55);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnEquals;
    }
}

