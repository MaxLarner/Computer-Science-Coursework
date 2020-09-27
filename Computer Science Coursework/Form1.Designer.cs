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
            this.pnl_Holds = new System.Windows.Forms.Panel();
            this.pctBox_GreenHold = new System.Windows.Forms.PictureBox();
            this.pctBox_BlueHold = new System.Windows.Forms.PictureBox();
            this.pctBox_RedHold = new System.Windows.Forms.PictureBox();
            this.pnl_Holds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHold)).BeginInit();
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
            // pnl_Holds
            // 
            this.pnl_Holds.Controls.Add(this.pctBox_GreenHold);
            this.pnl_Holds.Controls.Add(this.pctBox_BlueHold);
            this.pnl_Holds.Controls.Add(this.pctBox_RedHold);
            this.pnl_Holds.Location = new System.Drawing.Point(280, 560);
            this.pnl_Holds.Name = "pnl_Holds";
            this.pnl_Holds.Size = new System.Drawing.Size(680, 160);
            this.pnl_Holds.TabIndex = 2;
            // 
            // pctBox_GreenHold
            // 
            this.pctBox_GreenHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pctBox_GreenHold.Location = new System.Drawing.Point(477, 26);
            this.pctBox_GreenHold.Name = "pctBox_GreenHold";
            this.pctBox_GreenHold.Size = new System.Drawing.Size(156, 119);
            this.pctBox_GreenHold.TabIndex = 2;
            this.pctBox_GreenHold.TabStop = false;
            this.pctBox_GreenHold.Click += new System.EventHandler(this.pctBox_GreenHold_Click);
            // 
            // pctBox_BlueHold
            // 
            this.pctBox_BlueHold.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctBox_BlueHold.Location = new System.Drawing.Point(260, 26);
            this.pctBox_BlueHold.Name = "pctBox_BlueHold";
            this.pctBox_BlueHold.Size = new System.Drawing.Size(158, 119);
            this.pctBox_BlueHold.TabIndex = 1;
            this.pctBox_BlueHold.TabStop = false;
            this.pctBox_BlueHold.Click += new System.EventHandler(this.pctBox_BlueHold_Click);
            // 
            // pctBox_RedHold
            // 
            this.pctBox_RedHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pctBox_RedHold.Location = new System.Drawing.Point(63, 26);
            this.pctBox_RedHold.Name = "pctBox_RedHold";
            this.pctBox_RedHold.Size = new System.Drawing.Size(141, 119);
            this.pctBox_RedHold.TabIndex = 0;
            this.pctBox_RedHold.TabStop = false;
            this.pctBox_RedHold.Click += new System.EventHandler(this.pctBox_RedHold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnl_Holds);
            this.Controls.Add(this.txt_WallHeight);
            this.Controls.Add(this.txt_WallWidth);
            this.Controls.Add(this.btn_WallSubmit);
            this.Name = "Form1";
            this.Text = "Wall Build";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Holds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_WallSubmit;
        private System.Windows.Forms.TextBox txt_WallWidth;
        private System.Windows.Forms.TextBox txt_WallHeight;
        private System.Windows.Forms.Panel pnl_Holds;
        private System.Windows.Forms.PictureBox pctBox_BlueHold;
        private System.Windows.Forms.PictureBox pctBox_RedHold;
        private System.Windows.Forms.PictureBox pctBox_GreenHold;
    }
}

