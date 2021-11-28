namespace Lab_8_Ex_1_var_23
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
            this.ValueCC1 = new System.Windows.Forms.ComboBox();
            this.ValueCC2 = new System.Windows.Forms.ComboBox();
            this.Value1_text = new System.Windows.Forms.TextBox();
            this.Value2_text = new System.Windows.Forms.TextBox();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueCC1
            // 
            this.ValueCC1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ValueCC1.FormattingEnabled = true;
            this.ValueCC1.IntegralHeight = false;
            this.ValueCC1.Location = new System.Drawing.Point(23, 49);
            this.ValueCC1.Name = "ValueCC1";
            this.ValueCC1.Size = new System.Drawing.Size(121, 23);
            this.ValueCC1.TabIndex = 0;
            this.ValueCC1.SelectedIndexChanged += new System.EventHandler(this.ValueCC1_SelectedIndexChanged);
            // 
            // ValueCC2
            // 
            this.ValueCC2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ValueCC2.FormattingEnabled = true;
            this.ValueCC2.IntegralHeight = false;
            this.ValueCC2.Location = new System.Drawing.Point(369, 49);
            this.ValueCC2.Name = "ValueCC2";
            this.ValueCC2.Size = new System.Drawing.Size(121, 23);
            this.ValueCC2.TabIndex = 2;
            this.ValueCC2.SelectedIndexChanged += new System.EventHandler(this.ValueCC2_SelectedIndexChanged);
            // 
            // Value1_text
            // 
            this.Value1_text.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Value1_text.Location = new System.Drawing.Point(23, 161);
            this.Value1_text.Name = "Value1_text";
            this.Value1_text.Size = new System.Drawing.Size(121, 23);
            this.Value1_text.TabIndex = 1;
            this.Value1_text.TextChanged += new System.EventHandler(this.Value1_text_TextChanged);
            this.Value1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value1_text_KeyPress);
            // 
            // Value2_text
            // 
            this.Value2_text.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Value2_text.Location = new System.Drawing.Point(369, 161);
            this.Value2_text.Name = "Value2_text";
            this.Value2_text.ReadOnly = true;
            this.Value2_text.Size = new System.Drawing.Size(121, 23);
            this.Value2_text.TabIndex = 4;
            this.Value2_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value2_text_KeyPress);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Image = global::Lab_8_Ex_1_var_23.Properties.Resources.circle;
            this.ReplaceButton.Location = new System.Drawing.Point(223, 85);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(55, 55);
            this.ReplaceButton.TabIndex = 5;
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Валюта:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(369, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Валюта:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(369, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кількість:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(369, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(515, 237);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.Value2_text);
            this.Controls.Add(this.Value1_text);
            this.Controls.Add(this.ValueCC2);
            this.Controls.Add(this.ValueCC1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lab-8_ValueConverter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button ReplaceButton;

        private System.Windows.Forms.TextBox Value1_text;

        private System.Windows.Forms.TextBox Value2_text;

        private System.Windows.Forms.ComboBox ValueCC2;

        private System.Windows.Forms.ComboBox ValueCC1;
        

        #endregion
    }
}