namespace Computer_Science_Coursework
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
            this.btn_WallSubmit = new System.Windows.Forms.Button();
            this.txt_WallWidth = new System.Windows.Forms.TextBox();
            this.txt_WallHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_WallSubmit
            // 
            this.btn_WallSubmit.Location = new System.Drawing.Point(98, 218);
            this.btn_WallSubmit.Name = "btn_WallSubmit";
            this.btn_WallSubmit.Size = new System.Drawing.Size(89, 31);
            this.btn_WallSubmit.TabIndex = 0;
            this.btn_WallSubmit.Text = "Submit ";
            this.btn_WallSubmit.UseVisualStyleBackColor = true;
            this.btn_WallSubmit.Click += new System.EventHandler(this.btn_WallSubmit_Click);
            // 
            // txt_WallWidth
            // 
            this.txt_WallWidth.Location = new System.Drawing.Point(98, 157);
            this.txt_WallWidth.Name = "txt_WallWidth";
            this.txt_WallWidth.Size = new System.Drawing.Size(89, 23);
            this.txt_WallWidth.TabIndex = 1;
            // 
            // txt_WallHeight
            // 
            this.txt_WallHeight.Location = new System.Drawing.Point(98, 186);
            this.txt_WallHeight.Name = "txt_WallHeight";
            this.txt_WallHeight.Size = new System.Drawing.Size(89, 23);
            this.txt_WallHeight.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.txt_WallHeight);
            this.Controls.Add(this.txt_WallWidth);
            this.Controls.Add(this.btn_WallSubmit);
            this.Name = "Form1";
            this.Text = "Wall Build";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_WallSubmit;
        private System.Windows.Forms.TextBox txt_WallWidth;
        private System.Windows.Forms.TextBox txt_WallHeight;
    }
}

