
namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Lbcreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUname = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.ForeColor = System.Drawing.Color.White;
            this.BtnLog.Location = new System.Drawing.Point(454, 354);
            this.BtnLog.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(226, 29);
            this.BtnLog.TabIndex = 1;
            this.BtnLog.Text = "Log in";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(636, 462);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(71, 29);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Lbcreate
            // 
            this.Lbcreate.AutoSize = true;
            this.Lbcreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbcreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbcreate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Lbcreate.Location = new System.Drawing.Point(494, 401);
            this.Lbcreate.Name = "Lbcreate";
            this.Lbcreate.Size = new System.Drawing.Size(67, 19);
            this.Lbcreate.TabIndex = 2;
            this.Lbcreate.Text = "Created ";
            this.Lbcreate.Click += new System.EventHandler(this.Lbcreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(558, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtUname
            // 
            this.TxtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUname.Location = new System.Drawing.Point(474, 205);
            this.TxtUname.Multiline = true;
            this.TxtUname.Name = "TxtUname";
            this.TxtUname.Size = new System.Drawing.Size(204, 25);
            this.TxtUname.TabIndex = 3;
            this.TxtUname.TextChanged += new System.EventHandler(this.TxtUname_TextChanged);
            // 
            // TxtPass
            // 
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(474, 286);
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(204, 24);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 499);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbcreate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Lbcreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUname;
        private System.Windows.Forms.TextBox TxtPass;
    }
}

