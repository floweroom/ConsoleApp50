
namespace ConsoleApp50
{
    partial class Form2
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
            this.randomput = new System.Windows.Forms.Button();
            this.randomNo = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.checknumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomput
            // 
            this.randomput.Location = new System.Drawing.Point(84, 311);
            this.randomput.Name = "randomput";
            this.randomput.Size = new System.Drawing.Size(208, 88);
            this.randomput.TabIndex = 0;
            this.randomput.Text = "Играть";
            this.randomput.UseVisualStyleBackColor = true;
            this.randomput.Click += new System.EventHandler(this.button1_Click);
            // 
            // randomNo
            // 
            this.randomNo.AutoSize = true;
            this.randomNo.Location = new System.Drawing.Point(334, 331);
            this.randomNo.Name = "randomNo";
            this.randomNo.Size = new System.Drawing.Size(0, 13);
            this.randomNo.TabIndex = 1;
            this.randomNo.Click += new System.EventHandler(this.randomNo_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(498, 359);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(167, 20);
            this.input.TabIndex = 2;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // checknumber
            // 
            this.checknumber.Location = new System.Drawing.Point(493, 274);
            this.checknumber.Name = "checknumber";
            this.checknumber.Size = new System.Drawing.Size(171, 57);
            this.checknumber.TabIndex = 3;
            this.checknumber.Text = "Проверить";
            this.checknumber.UseVisualStyleBackColor = true;
            this.checknumber.Click += new System.EventHandler(this.checknumber_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checknumber);
            this.Controls.Add(this.input);
            this.Controls.Add(this.randomNo);
            this.Controls.Add(this.randomput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomput;
        private System.Windows.Forms.Label randomNo;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button checknumber;
    }
}