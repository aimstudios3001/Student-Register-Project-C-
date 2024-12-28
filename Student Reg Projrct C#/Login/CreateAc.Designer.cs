
namespace Login
{
    partial class CreateAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCreAc = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtPassConf = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCreAc
            // 
            this.BtnCreAc.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnCreAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreAc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreAc.ForeColor = System.Drawing.Color.White;
            this.BtnCreAc.Location = new System.Drawing.Point(453, 388);
            this.BtnCreAc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCreAc.Name = "BtnCreAc";
            this.BtnCreAc.Size = new System.Drawing.Size(226, 29);
            this.BtnCreAc.TabIndex = 2;
            this.BtnCreAc.Text = "Create Account";
            this.BtnCreAc.UseVisualStyleBackColor = false;
            this.BtnCreAc.Click += new System.EventHandler(this.BtnCreAc_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(637, 462);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(71, 29);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.SlateBlue;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(560, 462);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(71, 29);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtFname
            // 
            this.TxtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFname.Location = new System.Drawing.Point(453, 124);
            this.TxtFname.Multiline = true;
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(226, 25);
            this.TxtFname.TabIndex = 4;
            this.TxtFname.TextChanged += new System.EventHandler(this.TxtUname_TextChanged);
            // 
            // TxtLname
            // 
            this.TxtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLname.Location = new System.Drawing.Point(453, 185);
            this.TxtLname.Multiline = true;
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(226, 25);
            this.TxtLname.TabIndex = 4;
            this.TxtLname.TextChanged += new System.EventHandler(this.TxtUname_TextChanged);
            // 
            // TxtPass
            // 
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(453, 274);
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(226, 25);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtUname_TextChanged);
            // 
            // TxtPassConf
            // 
            this.TxtPassConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassConf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassConf.Location = new System.Drawing.Point(453, 339);
            this.TxtPassConf.Multiline = true;
            this.TxtPassConf.Name = "TxtPassConf";
            this.TxtPassConf.Size = new System.Drawing.Size(226, 25);
            this.TxtPassConf.TabIndex = 4;
            this.TxtPassConf.TextChanged += new System.EventHandler(this.TxtUname_TextChanged);
            // 
            // CreateAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(717, 500);
            this.Controls.Add(this.TxtPassConf);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtLname);
            this.Controls.Add(this.TxtFname);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCreAc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCreAc;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.TextBox TxtLname;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtPassConf;
    }
}