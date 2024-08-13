namespace ASM2
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lbWater = new Label();
            lbUserName = new Label();
            lbPassword = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            btLogin = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbWater
            // 
            lbWater.AutoSize = true;
            lbWater.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWater.Location = new Point(185, 19);
            lbWater.Name = "lbWater";
            lbWater.Size = new Size(177, 46);
            lbWater.TabIndex = 0;
            lbWater.Text = "Water Bill";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(39, 91);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(87, 20);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "UserName:";
            lbUserName.Click += lbYourName_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(39, 147);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(83, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "PassWord:";
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Window;
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(162, 91);
            tbName.Name = "tbName";
            tbName.Size = new Size(329, 27);
            tbName.TabIndex = 3;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(162, 147);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(329, 27);
            tbPass.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(162, 221);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += FormLogin_Load;
            btLogin.Enter += btLogin_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(326, 221);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 6;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            btExit.Leave += btExit_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(541, 283);
            Controls.Add(btExit);
            Controls.Add(btLogin);
            Controls.Add(tbPass);
            Controls.Add(tbName);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(lbWater);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWater;
        private Label lbUserName;
        private Label lbPassword;
        private TextBox tbName;
        private TextBox tbPass;
        private Button btLogin;
        private Button btExit;
    }
}