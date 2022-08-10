namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloworld = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helloworld
            // 
            this.helloworld.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloworld.Location = new System.Drawing.Point(369, 116);
            this.helloworld.Name = "helloworld";
            this.helloworld.Size = new System.Drawing.Size(75, 23);
            this.helloworld.TabIndex = 0;
            this.helloworld.Text = "button1";
            this.helloworld.UseVisualStyleBackColor = true;
            this.helloworld.Click += new System.EventHandler(this.clickme_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(359, 145);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 23);
            this.textbox.TabIndex = 1;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.helloworld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button helloworld;
        private TextBox textbox;
    }
}