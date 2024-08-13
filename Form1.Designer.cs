namespace ASM2
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
            gbWaterBill = new GroupBox();
            btPrintBill = new Button();
            btExit = new Button();
            btReset = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btAdd = new Button();
            tbThis = new TextBox();
            tbLast = new TextBox();
            tbName = new TextBox();
            rbBusiness = new RadioButton();
            rbPro = new RadioButton();
            rbAdm = new RadioButton();
            rbHousehold = new RadioButton();
            lbType = new Label();
            lbThisM = new Label();
            lbLastM = new Label();
            lbCustomerName = new Label();
            lsvWaterBill = new ListView();
            lbWaterBill = new Label();
            btSearch = new Button();
            tbSearch = new TextBox();
            gbSearch = new GroupBox();
            lbSearchName = new Label();
            gbWaterBill.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // gbWaterBill
            // 
            gbWaterBill.BackColor = Color.White;
            gbWaterBill.Controls.Add(btPrintBill);
            gbWaterBill.Controls.Add(btExit);
            gbWaterBill.Controls.Add(btReset);
            gbWaterBill.Controls.Add(btDelete);
            gbWaterBill.Controls.Add(btEdit);
            gbWaterBill.Controls.Add(btAdd);
            gbWaterBill.Controls.Add(tbThis);
            gbWaterBill.Controls.Add(tbLast);
            gbWaterBill.Controls.Add(tbName);
            gbWaterBill.Controls.Add(rbBusiness);
            gbWaterBill.Controls.Add(rbPro);
            gbWaterBill.Controls.Add(rbAdm);
            gbWaterBill.Controls.Add(rbHousehold);
            gbWaterBill.Controls.Add(lbType);
            gbWaterBill.Controls.Add(lbThisM);
            gbWaterBill.Controls.Add(lbLastM);
            gbWaterBill.Controls.Add(lbCustomerName);
            gbWaterBill.Location = new Point(116, 86);
            gbWaterBill.Name = "gbWaterBill";
            gbWaterBill.Size = new Size(1000, 251);
            gbWaterBill.TabIndex = 0;
            gbWaterBill.TabStop = false;
            // 
            // btPrintBill
            // 
            btPrintBill.Location = new Point(839, 205);
            btPrintBill.Name = "btPrintBill";
            btPrintBill.Size = new Size(94, 29);
            btPrintBill.TabIndex = 16;
            btPrintBill.Text = "Print Bill";
            btPrintBill.UseVisualStyleBackColor = true;
            btPrintBill.Click += btPrintBill_Click_1;
            // 
            // btExit
            // 
            btExit.Location = new Point(688, 205);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 15;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(539, 205);
            btReset.Name = "btReset";
            btReset.Size = new Size(94, 29);
            btReset.TabIndex = 14;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(379, 205);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 13;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(225, 205);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 12;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(75, 205);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 11;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbThis
            // 
            tbThis.Location = new Point(380, 122);
            tbThis.Name = "tbThis";
            tbThis.Size = new Size(421, 27);
            tbThis.TabIndex = 10;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(380, 78);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(421, 27);
            tbLast.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(277, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(524, 27);
            tbName.TabIndex = 8;
            // 
            // rbBusiness
            // 
            rbBusiness.AutoSize = true;
            rbBusiness.Location = new Point(810, 164);
            rbBusiness.Name = "rbBusiness";
            rbBusiness.Size = new Size(140, 24);
            rbBusiness.TabIndex = 7;
            rbBusiness.TabStop = true;
            rbBusiness.Text = "Business services";
            rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbPro
            // 
            rbPro.AutoSize = true;
            rbPro.Location = new Point(645, 164);
            rbPro.Name = "rbPro";
            rbPro.Size = new Size(137, 24);
            rbPro.TabIndex = 6;
            rbPro.TabStop = true;
            rbPro.Text = "Production units";
            rbPro.UseVisualStyleBackColor = true;
            // 
            // rbAdm
            // 
            rbAdm.AutoSize = true;
            rbAdm.Location = new Point(340, 164);
            rbAdm.Name = "rbAdm";
            rbAdm.Size = new Size(280, 24);
            rbAdm.TabIndex = 5;
            rbAdm.TabStop = true;
            rbAdm.Text = "Administrative agency, public services";
            rbAdm.UseVisualStyleBackColor = true;
            // 
            // rbHousehold
            // 
            rbHousehold.AutoSize = true;
            rbHousehold.Location = new Point(199, 164);
            rbHousehold.Name = "rbHousehold";
            rbHousehold.Size = new Size(102, 24);
            rbHousehold.TabIndex = 4;
            rbHousehold.TabStop = true;
            rbHousehold.Text = "Household";
            rbHousehold.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(47, 161);
            lbType.Name = "lbType";
            lbType.Size = new Size(126, 20);
            lbType.TabIndex = 3;
            lbType.Text = "Type of customer:";
            // 
            // lbThisM
            // 
            lbThisM.AutoSize = true;
            lbThisM.Location = new Point(47, 122);
            lbThisM.Name = "lbThisM";
            lbThisM.Size = new Size(239, 20);
            lbThisM.TabIndex = 2;
            lbThisM.Text = "This month’s water meter readings:";
            // 
            // lbLastM
            // 
            lbLastM.AutoSize = true;
            lbLastM.Location = new Point(47, 81);
            lbLastM.Name = "lbLastM";
            lbLastM.Size = new Size(239, 20);
            lbLastM.TabIndex = 1;
            lbLastM.Text = "Last month’s water meter readings:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(47, 29);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 0;
            lbCustomerName.Text = "Customer Name";
            // 
            // lsvWaterBill
            // 
            lsvWaterBill.BackColor = Color.White;
            lsvWaterBill.Location = new Point(12, 452);
            lsvWaterBill.Name = "lsvWaterBill";
            lsvWaterBill.Size = new Size(1205, 201);
            lsvWaterBill.TabIndex = 1;
            lsvWaterBill.UseCompatibleStateImageBehavior = false;
            lsvWaterBill.SelectedIndexChanged += lsvWaterBill_SelectedIndexChanged;
            // 
            // lbWaterBill
            // 
            lbWaterBill.AutoSize = true;
            lbWaterBill.BackColor = Color.LavenderBlush;
            lbWaterBill.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWaterBill.Location = new Point(495, 21);
            lbWaterBill.Name = "lbWaterBill";
            lbWaterBill.Size = new Size(241, 62);
            lbWaterBill.TabIndex = 2;
            lbWaterBill.Text = "Water Bill";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(747, 33);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 18;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(246, 33);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(445, 27);
            tbSearch.TabIndex = 17;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // gbSearch
            // 
            gbSearch.BackColor = Color.White;
            gbSearch.Controls.Add(lbSearchName);
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(btSearch);
            gbSearch.Location = new Point(149, 357);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(929, 77);
            gbSearch.TabIndex = 19;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search for information";
            // 
            // lbSearchName
            // 
            lbSearchName.AutoSize = true;
            lbSearchName.Location = new Point(42, 40);
            lbSearchName.Name = "lbSearchName";
            lbSearchName.Size = new Size(157, 20);
            lbSearchName.TabIndex = 19;
            lbSearchName.Text = "Enter Customer Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1229, 665);
            Controls.Add(gbSearch);
            Controls.Add(lbWaterBill);
            Controls.Add(lsvWaterBill);
            Controls.Add(gbWaterBill);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbWaterBill.ResumeLayout(false);
            gbWaterBill.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbWaterBill;
        private Label lbCustomerName;
        private Label lbType;
        private Label lbThisM;
        private Label lbLastM;
        private RadioButton rbBusiness;
        private RadioButton rbPro;
        private RadioButton rbAdm;
        private RadioButton rbHousehold;
        private TextBox tbThis;
        private TextBox tbLast;
        private TextBox tbName;
        private Button btExit;
        private Button btReset;
        private Button btDelete;
        private Button btEdit;
        private Button btAdd;
        private ListView lsvWaterBill;
        private Label lbWaterBill;
        private Button btSearch;
        private TextBox tbSearch;
        private GroupBox gbSearch;
        private Label lbSearchName;
        private Button btPrintBill;
    }
}
