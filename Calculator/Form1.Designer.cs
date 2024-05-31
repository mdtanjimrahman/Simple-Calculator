namespace Calculator
{
    partial class Calculator
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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.button_Multi = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(29, 197);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(53, 46);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Div
            // 
            this.button_Div.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Div.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Div.Location = new System.Drawing.Point(282, 197);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(53, 46);
            this.button_Div.TabIndex = 1;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = false;
            this.button_Div.Click += new System.EventHandler(this.button_Div_Click);
            // 
            // button_Multi
            // 
            this.button_Multi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Multi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Multi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multi.Location = new System.Drawing.Point(197, 197);
            this.button_Multi.Name = "button_Multi";
            this.button_Multi.Size = new System.Drawing.Size(53, 46);
            this.button_Multi.TabIndex = 2;
            this.button_Multi.Text = "*";
            this.button_Multi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Multi.UseVisualStyleBackColor = false;
            this.button_Multi.Click += new System.EventHandler(this.button_Multi_Click);
            // 
            // button_Sub
            // 
            this.button_Sub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sub.Location = new System.Drawing.Point(113, 197);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(53, 46);
            this.button_Sub.TabIndex = 3;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = false;
            this.button_Sub.Click += new System.EventHandler(this.button_Sub_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 35);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(29, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 35);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "1st Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "2nd Input";
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.DarkRed;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Exit.Location = new System.Drawing.Point(29, 289);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(306, 62);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            this.button_Exit.MouseHover += new System.EventHandler(this.button_Exit_MouseHover);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(359, 402);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Sub);
            this.Controls.Add(this.button_Multi);
            this.Controls.Add(this.button_Div);
            this.Controls.Add(this.button_Add);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Div;
        private System.Windows.Forms.Button button_Multi;
        private System.Windows.Forms.Button button_Sub;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Exit;
    }
}

