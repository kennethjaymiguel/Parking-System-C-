namespace Parking_System
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbox = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsermame = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 161);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ckbox);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.txpass);
            this.panel2.Controls.Add(this.txtUsermame);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(136, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 316);
            this.panel2.TabIndex = 1;
            // 
            // ckbox
            // 
            this.ckbox.AutoSize = true;
            this.ckbox.Location = new System.Drawing.Point(315, 214);
            this.ckbox.Name = "ckbox";
            this.ckbox.Size = new System.Drawing.Size(102, 17);
            this.ckbox.TabIndex = 4;
            this.ckbox.Text = "Show Password";
            this.ckbox.UseVisualStyleBackColor = true;
            this.ckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlogin.Location = new System.Drawing.Point(184, 226);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(111, 30);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txpass
            // 
            this.txpass.BackColor = System.Drawing.SystemColors.Highlight;
            this.txpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txpass.ForeColor = System.Drawing.Color.White;
            this.txpass.HintForeColor = System.Drawing.Color.Empty;
            this.txpass.HintText = "";
            this.txpass.isPassword = true;
            this.txpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.txpass.LineIdleColor = System.Drawing.Color.Gray;
            this.txpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txpass.LineThickness = 3;
            this.txpass.Location = new System.Drawing.Point(38, 174);
            this.txpass.Margin = new System.Windows.Forms.Padding(4);
            this.txpass.Name = "txpass";
            this.txpass.Size = new System.Drawing.Size(379, 33);
            this.txpass.TabIndex = 2;
            this.txpass.Text = "Password";
            this.txpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txpass.Enter += new System.EventHandler(this.txpassEnter);
            this.txpass.Leave += new System.EventHandler(this.txpassLeave);
            // 
            // txtUsermame
            // 
            this.txtUsermame.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtUsermame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsermame.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsermame.ForeColor = System.Drawing.Color.White;
            this.txtUsermame.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsermame.HintText = "";
            this.txtUsermame.isPassword = false;
            this.txtUsermame.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsermame.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsermame.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsermame.LineThickness = 3;
            this.txtUsermame.Location = new System.Drawing.Point(38, 133);
            this.txtUsermame.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsermame.Name = "txtUsermame";
            this.txtUsermame.Size = new System.Drawing.Size(379, 33);
            this.txtUsermame.TabIndex = 1;
            this.txtUsermame.Text = "Username";
            this.txtUsermame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsermame.Enter += new System.EventHandler(this.txuserEnter);
            this.txtUsermame.Leave += new System.EventHandler(this.txuserLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(763, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsermame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txpass;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.CheckBox ckbox;
    }
}

