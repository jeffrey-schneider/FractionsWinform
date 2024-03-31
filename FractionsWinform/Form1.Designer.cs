namespace FractionsWinform
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
            this.TxtNumerator01 = new System.Windows.Forms.TextBox();
            this.TxtDenominator01 = new System.Windows.Forms.TextBox();
            this.TxtNumerator02 = new System.Windows.Forms.TextBox();
            this.TxtDenominator02 = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtAnswer01 = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtUnit01 = new System.Windows.Forms.TextBox();
            this.txtUnit02 = new System.Windows.Forms.TextBox();
            this.TxtUnit03 = new System.Windows.Forms.TextBox();
            this.TxtDenominator03 = new System.Windows.Forms.TextBox();
            this.TxtNumerator03 = new System.Windows.Forms.TextBox();
            this.TxtAnswer02 = new System.Windows.Forms.TextBox();
            this.BtnSimplify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNumerator01
            // 
            this.TxtNumerator01.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumerator01.Location = new System.Drawing.Point(100, 57);
            this.TxtNumerator01.Name = "TxtNumerator01";
            this.TxtNumerator01.Size = new System.Drawing.Size(100, 39);
            this.TxtNumerator01.TabIndex = 2;
            this.TxtNumerator01.Tag = "0";
            this.TxtNumerator01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDenominator01
            // 
            this.TxtDenominator01.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominator01.Location = new System.Drawing.Point(100, 102);
            this.TxtDenominator01.Name = "TxtDenominator01";
            this.TxtDenominator01.Size = new System.Drawing.Size(100, 39);
            this.TxtDenominator01.TabIndex = 3;
            this.TxtDenominator01.Tag = "0";
            this.TxtDenominator01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumerator02
            // 
            this.TxtNumerator02.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumerator02.Location = new System.Drawing.Point(295, 57);
            this.TxtNumerator02.Name = "TxtNumerator02";
            this.TxtNumerator02.Size = new System.Drawing.Size(100, 39);
            this.TxtNumerator02.TabIndex = 5;
            this.TxtNumerator02.Tag = "0";
            this.TxtNumerator02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDenominator02
            // 
            this.TxtDenominator02.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominator02.Location = new System.Drawing.Point(295, 102);
            this.TxtDenominator02.Name = "TxtDenominator02";
            this.TxtDenominator02.Size = new System.Drawing.Size(100, 39);
            this.TxtDenominator02.TabIndex = 6;
            this.TxtDenominator02.Tag = "0";
            this.TxtDenominator02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(361, 147);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(81, 58);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(11, 147);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(81, 58);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtAnswer01
            // 
            this.TxtAnswer01.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnswer01.Location = new System.Drawing.Point(401, 57);
            this.TxtAnswer01.Multiline = true;
            this.TxtAnswer01.Name = "TxtAnswer01";
            this.TxtAnswer01.ReadOnly = true;
            this.TxtAnswer01.Size = new System.Drawing.Size(218, 84);
            this.TxtAnswer01.TabIndex = 14;
            this.TxtAnswer01.Tag = "Clear";
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(100, 147);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(81, 58);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "&Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(187, 147);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(81, 58);
            this.BtnMultiply.TabIndex = 17;
            this.BtnMultiply.Text = "&Multiply";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(274, 147);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(81, 58);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "&Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // txtUnit01
            // 
            this.txtUnit01.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit01.Location = new System.Drawing.Point(11, 57);
            this.txtUnit01.Multiline = true;
            this.txtUnit01.Name = "txtUnit01";
            this.txtUnit01.Size = new System.Drawing.Size(83, 84);
            this.txtUnit01.TabIndex = 1;
            this.txtUnit01.Tag = "Clear";
            this.txtUnit01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnit02
            // 
            this.txtUnit02.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit02.Location = new System.Drawing.Point(206, 57);
            this.txtUnit02.Multiline = true;
            this.txtUnit02.Name = "txtUnit02";
            this.txtUnit02.Size = new System.Drawing.Size(83, 84);
            this.txtUnit02.TabIndex = 4;
            this.txtUnit02.Tag = "Clear";
            this.txtUnit02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtUnit03
            // 
            this.TxtUnit03.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnit03.Location = new System.Drawing.Point(9, 245);
            this.TxtUnit03.Multiline = true;
            this.TxtUnit03.Name = "TxtUnit03";
            this.TxtUnit03.Size = new System.Drawing.Size(83, 84);
            this.TxtUnit03.TabIndex = 19;
            this.TxtUnit03.Tag = "Clear";
            this.TxtUnit03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDenominator03
            // 
            this.TxtDenominator03.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDenominator03.Location = new System.Drawing.Point(98, 290);
            this.TxtDenominator03.Name = "TxtDenominator03";
            this.TxtDenominator03.Size = new System.Drawing.Size(100, 39);
            this.TxtDenominator03.TabIndex = 21;
            this.TxtDenominator03.Tag = "0";
            this.TxtDenominator03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumerator03
            // 
            this.TxtNumerator03.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumerator03.Location = new System.Drawing.Point(98, 245);
            this.TxtNumerator03.Name = "TxtNumerator03";
            this.TxtNumerator03.Size = new System.Drawing.Size(100, 39);
            this.TxtNumerator03.TabIndex = 20;
            this.TxtNumerator03.Tag = "0";
            this.TxtNumerator03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtAnswer02
            // 
            this.TxtAnswer02.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnswer02.Location = new System.Drawing.Point(204, 245);
            this.TxtAnswer02.Multiline = true;
            this.TxtAnswer02.Name = "TxtAnswer02";
            this.TxtAnswer02.ReadOnly = true;
            this.TxtAnswer02.Size = new System.Drawing.Size(335, 84);
            this.TxtAnswer02.TabIndex = 22;
            this.TxtAnswer02.Tag = "Clear";
            // 
            // BtnSimplify
            // 
            this.BtnSimplify.Location = new System.Drawing.Point(98, 355);
            this.BtnSimplify.Name = "BtnSimplify";
            this.BtnSimplify.Size = new System.Drawing.Size(81, 58);
            this.BtnSimplify.TabIndex = 23;
            this.BtnSimplify.Text = "S&implify";
            this.BtnSimplify.UseVisualStyleBackColor = true;
            this.BtnSimplify.Click += new System.EventHandler(this.BtnSimplify_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fraction Work";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSimplify);
            this.Controls.Add(this.TxtAnswer02);
            this.Controls.Add(this.TxtUnit03);
            this.Controls.Add(this.TxtDenominator03);
            this.Controls.Add(this.TxtNumerator03);
            this.Controls.Add(this.txtUnit02);
            this.Controls.Add(this.txtUnit01);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.TxtAnswer01);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtDenominator02);
            this.Controls.Add(this.TxtNumerator02);
            this.Controls.Add(this.TxtDenominator01);
            this.Controls.Add(this.TxtNumerator01);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Fractions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumerator01;
        private System.Windows.Forms.TextBox TxtDenominator01;
        private System.Windows.Forms.TextBox TxtNumerator02;
        private System.Windows.Forms.TextBox TxtDenominator02;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtAnswer01;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtUnit01;
        private System.Windows.Forms.TextBox txtUnit02;
        private System.Windows.Forms.TextBox TxtUnit03;
        private System.Windows.Forms.TextBox TxtDenominator03;
        private System.Windows.Forms.TextBox TxtNumerator03;
        private System.Windows.Forms.TextBox TxtAnswer02;
        private System.Windows.Forms.Button BtnSimplify;
        private System.Windows.Forms.Label label1;
    }
}

