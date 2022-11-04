namespace SalesApp.WinForm;

partial class RegisterApp
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
            this.username_txb01 = new System.Windows.Forms.TextBox();
            this.login_button01 = new System.Windows.Forms.Button();
            this.panel_fiil = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email_txb02 = new System.Windows.Forms.TextBox();
            this.password_txb03 = new System.Windows.Forms.TextBox();
            this.panel_fiil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_txb01
            // 
            this.username_txb01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.username_txb01.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_txb01.Location = new System.Drawing.Point(57, 46);
            this.username_txb01.Margin = new System.Windows.Forms.Padding(4);
            this.username_txb01.Multiline = true;
            this.username_txb01.Name = "username_txb01";
            this.username_txb01.PlaceholderText = " username";
            this.username_txb01.Size = new System.Drawing.Size(271, 37);
            this.username_txb01.TabIndex = 16;
            this.username_txb01.TextChanged += new System.EventHandler(this.username_txb01_TextChanged);
            // 
            // login_button01
            // 
            this.login_button01.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_button01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button01.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button01.ForeColor = System.Drawing.Color.White;
            this.login_button01.Location = new System.Drawing.Point(57, 211);
            this.login_button01.Margin = new System.Windows.Forms.Padding(4);
            this.login_button01.Name = "login_button01";
            this.login_button01.Size = new System.Drawing.Size(271, 43);
            this.login_button01.TabIndex = 15;
            this.login_button01.Text = "Register";
            this.login_button01.UseVisualStyleBackColor = false;
            this.login_button01.Click += new System.EventHandler(this.login_button01_Click);
            // 
            // panel_fiil
            // 
            this.panel_fiil.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_fiil.Controls.Add(this.panel1);
            this.panel_fiil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fiil.Location = new System.Drawing.Point(0, 0);
            this.panel_fiil.Name = "panel_fiil";
            this.panel_fiil.Size = new System.Drawing.Size(561, 496);
            this.panel_fiil.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.email_txb02);
            this.panel1.Controls.Add(this.username_txb01);
            this.panel1.Controls.Add(this.password_txb03);
            this.panel1.Controls.Add(this.login_button01);
            this.panel1.Location = new System.Drawing.Point(89, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 275);
            this.panel1.TabIndex = 21;
            // 
            // email_txb02
            // 
            this.email_txb02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_txb02.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_txb02.Location = new System.Drawing.Point(57, 91);
            this.email_txb02.Margin = new System.Windows.Forms.Padding(4);
            this.email_txb02.Multiline = true;
            this.email_txb02.Name = "email_txb02";
            this.email_txb02.PlaceholderText = " email";
            this.email_txb02.Size = new System.Drawing.Size(271, 37);
            this.email_txb02.TabIndex = 21;
            // 
            // password_txb03
            // 
            this.password_txb03.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_txb03.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_txb03.Location = new System.Drawing.Point(57, 136);
            this.password_txb03.Margin = new System.Windows.Forms.Padding(4);
            this.password_txb03.Multiline = true;
            this.password_txb03.Name = "password_txb03";
            this.password_txb03.PasswordChar = '*';
            this.password_txb03.PlaceholderText = "  password";
            this.password_txb03.Size = new System.Drawing.Size(271, 37);
            this.password_txb03.TabIndex = 20;
            // 
            // RegisterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(561, 496);
            this.Controls.Add(this.panel_fiil);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegisterApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterApp";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterApp_FormClosed);
            this.Load += new System.EventHandler(this.RegisterApp_Load);
            this.panel_fiil.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TextBox username_txb01;
    private Button login_button01;
    private Panel panel_fiil;
    private TextBox password_txb03;
    private Panel panel1;
    private TextBox email_txb02;
}
