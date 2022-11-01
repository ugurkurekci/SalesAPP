namespace SalesApp.WinForm;

partial class LoginApp
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
            this.panel_fiil_fiil = new System.Windows.Forms.Panel();
            this.registered_lbl02 = new System.Windows.Forms.Label();
            this.information_lbl01 = new System.Windows.Forms.Label();
            this.password_txb02 = new System.Windows.Forms.TextBox();
            this.panel_fiil.SuspendLayout();
            this.panel_fiil_fiil.SuspendLayout();
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
            // 
            // login_button01
            // 
            this.login_button01.BackColor = System.Drawing.Color.Green;
            this.login_button01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button01.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button01.ForeColor = System.Drawing.Color.White;
            this.login_button01.Location = new System.Drawing.Point(57, 136);
            this.login_button01.Margin = new System.Windows.Forms.Padding(4);
            this.login_button01.Name = "login_button01";
            this.login_button01.Size = new System.Drawing.Size(271, 43);
            this.login_button01.TabIndex = 15;
            this.login_button01.Text = "Login";
            this.login_button01.UseVisualStyleBackColor = false;
            // 
            // panel_fiil
            // 
            this.panel_fiil.BackColor = System.Drawing.Color.Green;
            this.panel_fiil.Controls.Add(this.panel_fiil_fiil);
            this.panel_fiil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fiil.Location = new System.Drawing.Point(0, 0);
            this.panel_fiil.Name = "panel_fiil";
            this.panel_fiil.Size = new System.Drawing.Size(561, 496);
            this.panel_fiil.TabIndex = 19;
            // 
            // panel_fiil_fiil
            // 
            this.panel_fiil_fiil.BackColor = System.Drawing.Color.White;
            this.panel_fiil_fiil.Controls.Add(this.registered_lbl02);
            this.panel_fiil_fiil.Controls.Add(this.information_lbl01);
            this.panel_fiil_fiil.Controls.Add(this.username_txb01);
            this.panel_fiil_fiil.Controls.Add(this.password_txb02);
            this.panel_fiil_fiil.Controls.Add(this.login_button01);
            this.panel_fiil_fiil.Location = new System.Drawing.Point(89, 123);
            this.panel_fiil_fiil.Name = "panel_fiil_fiil";
            this.panel_fiil_fiil.Size = new System.Drawing.Size(399, 275);
            this.panel_fiil_fiil.TabIndex = 21;
            // 
            // registered_lbl02
            // 
            this.registered_lbl02.AutoSize = true;
            this.registered_lbl02.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registered_lbl02.ForeColor = System.Drawing.Color.Green;
            this.registered_lbl02.Location = new System.Drawing.Point(189, 205);
            this.registered_lbl02.Name = "registered_lbl02";
            this.registered_lbl02.Size = new System.Drawing.Size(124, 17);
            this.registered_lbl02.TabIndex = 22;
            this.registered_lbl02.Text = "Create an account";
            this.registered_lbl02.Click += new System.EventHandler(this.registered_lbl02_Click);
            // 
            // information_lbl01
            // 
            this.information_lbl01.AutoSize = true;
            this.information_lbl01.Font = new System.Drawing.Font("Bahnschrift Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.information_lbl01.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.information_lbl01.Location = new System.Drawing.Point(74, 205);
            this.information_lbl01.Name = "information_lbl01";
            this.information_lbl01.Size = new System.Drawing.Size(109, 17);
            this.information_lbl01.TabIndex = 21;
            this.information_lbl01.Text = "Not registered?";
            // 
            // password_txb02
            // 
            this.password_txb02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_txb02.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_txb02.Location = new System.Drawing.Point(57, 91);
            this.password_txb02.Margin = new System.Windows.Forms.Padding(4);
            this.password_txb02.Multiline = true;
            this.password_txb02.Name = "password_txb02";
            this.password_txb02.PasswordChar = '*';
            this.password_txb02.PlaceholderText = "  password";
            this.password_txb02.Size = new System.Drawing.Size(271, 37);
            this.password_txb02.TabIndex = 20;
            // 
            // LoginApp
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
            this.Name = "LoginApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginApp";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginApp_FormClosing);
            this.Load += new System.EventHandler(this.LoginApp_Load);
            this.panel_fiil.ResumeLayout(false);
            this.panel_fiil_fiil.ResumeLayout(false);
            this.panel_fiil_fiil.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TextBox username_txb01;
    private Button login_button01;
    private Panel panel_fiil;
    private TextBox password_txb02;
    private Panel panel_fiil_fiil;
    private Label information_lbl01;
    private Label registered_lbl02;
}
