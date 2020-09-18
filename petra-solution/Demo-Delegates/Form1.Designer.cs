namespace Demo_Delegates
{
    partial class Rechner
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
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonAlles = new System.Windows.Forms.Button();
            this.textBoxPlus = new System.Windows.Forms.TextBox();
            this.textBoxMinus = new System.Windows.Forms.TextBox();
            this.textBoxAlles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZahl1.Location = new System.Drawing.Point(52, 29);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(90, 38);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.Text = "Zahl 1";
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZahl2.Location = new System.Drawing.Point(52, 92);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(90, 38);
            this.textBoxZahl2.TabIndex = 0;
            this.textBoxZahl2.Text = "Zahl 2";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(219, 29);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(55, 55);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(389, 29);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(55, 55);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonAlles
            // 
            this.buttonAlles.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlles.Location = new System.Drawing.Point(566, 29);
            this.buttonAlles.Name = "buttonAlles";
            this.buttonAlles.Size = new System.Drawing.Size(90, 55);
            this.buttonAlles.TabIndex = 1;
            this.buttonAlles.Text = "+-/*";
            this.buttonAlles.UseVisualStyleBackColor = true;
            this.buttonAlles.Click += new System.EventHandler(this.buttonAlles_Click);
            // 
            // textBoxPlus
            // 
            this.textBoxPlus.Location = new System.Drawing.Point(219, 92);
            this.textBoxPlus.Name = "textBoxPlus";
            this.textBoxPlus.Size = new System.Drawing.Size(111, 20);
            this.textBoxPlus.TabIndex = 2;
            // 
            // textBoxMinus
            // 
            this.textBoxMinus.Location = new System.Drawing.Point(389, 92);
            this.textBoxMinus.Name = "textBoxMinus";
            this.textBoxMinus.Size = new System.Drawing.Size(111, 20);
            this.textBoxMinus.TabIndex = 2;
            // 
            // textBoxAlles
            // 
            this.textBoxAlles.Location = new System.Drawing.Point(566, 92);
            this.textBoxAlles.Name = "textBoxAlles";
            this.textBoxAlles.Size = new System.Drawing.Size(111, 20);
            this.textBoxAlles.TabIndex = 2;
            // 
            // Rechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAlles);
            this.Controls.Add(this.textBoxMinus);
            this.Controls.Add(this.textBoxPlus);
            this.Controls.Add(this.buttonAlles);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Name = "Rechner";
            this.Text = "Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonAlles;
        private System.Windows.Forms.TextBox textBoxPlus;
        private System.Windows.Forms.TextBox textBoxMinus;
        private System.Windows.Forms.TextBox textBoxAlles;
    }
}

