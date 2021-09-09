namespace tehtava14
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
            this.paivakirj_textBox = new System.Windows.Forms.TextBox();
            this.tallena_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paivakirj_textBox
            // 
            this.paivakirj_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivakirj_textBox.Location = new System.Drawing.Point(13, 13);
            this.paivakirj_textBox.Multiline = true;
            this.paivakirj_textBox.Name = "paivakirj_textBox";
            this.paivakirj_textBox.Size = new System.Drawing.Size(775, 377);
            this.paivakirj_textBox.TabIndex = 0;
            // 
            // tallena_button
            // 
            this.tallena_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallena_button.Location = new System.Drawing.Point(13, 396);
            this.tallena_button.Name = "tallena_button";
            this.tallena_button.Size = new System.Drawing.Size(775, 63);
            this.tallena_button.TabIndex = 1;
            this.tallena_button.Text = "Tallenna";
            this.tallena_button.UseVisualStyleBackColor = true;
            this.tallena_button.Click += new System.EventHandler(this.tallena_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tallena_button);
            this.Controls.Add(this.paivakirj_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paivakirj_textBox;
        private System.Windows.Forms.Button tallena_button;
    }
}

