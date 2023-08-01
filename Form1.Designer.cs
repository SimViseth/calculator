namespace calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(298, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value2";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(196, 129);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(122, 22);
            this.txtVal1.TabIndex = 3;
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(196, 176);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(122, 22);
            this.txtVal2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(196, 219);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(122, 22);
            this.txtResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(430, 132);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(49, 44);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(495, 132);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(49, 44);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(430, 182);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(49, 44);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(495, 182);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(49, 44);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(430, 241);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(114, 44);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "=";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(274, 314);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(85, 36);
            this.txtClose.TabIndex = 13;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button txtClose;
    }
}

