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
            this.ValueCC2.Location = new System.Drawing.Point(285, 49);
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
            this.Value1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value1_text_KeyPress);
            // 
            // Value2_text
            // 
            this.Value2_text.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Value2_text.Location = new System.Drawing.Point(285, 161);
            this.Value2_text.Name = "Value2_text";
            this.Value2_text.ReadOnly = true;
            this.Value2_text.Size = new System.Drawing.Size(121, 23);
            this.Value2_text.TabIndex = 4;
            this.Value2_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value2_text_KeyPress);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Image = global::Lab_8_Ex_1_var_23.Properties.Resources.circle;
            this.ReplaceButton.Location = new System.Drawing.Point(187, 100);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(55, 55);
            this.ReplaceButton.TabIndex = 5;
            this.ReplaceButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(443, 233);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.Value2_text);
            this.Controls.Add(this.Value1_text);
            this.Controls.Add(this.ValueCC2);
            this.Controls.Add(this.ValueCC1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lab-8_ValueConverter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ReplaceButton;

        private System.Windows.Forms.TextBox Value1_text;

        private System.Windows.Forms.TextBox Value2_text;

        private System.Windows.Forms.ComboBox ValueCC2;

        private System.Windows.Forms.ComboBox ValueCC1;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}