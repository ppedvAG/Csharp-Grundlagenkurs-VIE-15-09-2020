namespace D_M16_Delegates
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxPlus = new System.Windows.Forms.TextBox();
            this.textBoxMinus = new System.Windows.Forms.TextBox();
            this.textBoxAlles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Zahl 1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(28, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 45);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Zahl 2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(207, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(436, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "+-*/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxPlus
            // 
            this.textBoxPlus.Location = new System.Drawing.Point(207, 78);
            this.textBoxPlus.Name = "textBoxPlus";
            this.textBoxPlus.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlus.TabIndex = 5;
            // 
            // textBoxMinus
            // 
            this.textBoxMinus.Location = new System.Drawing.Point(324, 78);
            this.textBoxMinus.Name = "textBoxMinus";
            this.textBoxMinus.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinus.TabIndex = 6;
            // 
            // textBoxAlles
            // 
            this.textBoxAlles.Location = new System.Drawing.Point(436, 78);
            this.textBoxAlles.Name = "textBoxAlles";
            this.textBoxAlles.Size = new System.Drawing.Size(100, 22);
            this.textBoxAlles.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAlles);
            this.Controls.Add(this.textBoxMinus);
            this.Controls.Add(this.textBoxPlus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxPlus;
        private System.Windows.Forms.TextBox textBoxMinus;
        private System.Windows.Forms.TextBox textBoxAlles;
    }
}

