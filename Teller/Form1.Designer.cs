namespace Teller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtQR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNumCheq = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rdTotalCheq = new System.Windows.Forms.RadioButton();
            this.rdTransfer = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtBranch2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SignCus = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.AuthSign = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountText = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccounntNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQR
            // 
            this.txtQR.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtQR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtQR.Location = new System.Drawing.Point(263, 27);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(237, 31);
            this.txtQR.TabIndex = 1;
            this.txtQR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQR_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Superspace Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัส QR-Code";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(506, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtBranch2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.SignCus);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.AuthSign);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAmountText);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAccountName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAccounntNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtBranch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(60, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 540);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtNumCheq);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.rdTotalCheq);
            this.groupBox1.Controls.Add(this.rdTransfer);
            this.groupBox1.Controls.Add(this.rdCash);
            this.groupBox1.Location = new System.Drawing.Point(148, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 48);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Superspace Bold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(471, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 22);
            this.label22.TabIndex = 39;
            this.label22.Text = "หมายเลขเช็ค";
            // 
            // txtNumCheq
            // 
            this.txtNumCheq.Enabled = false;
            this.txtNumCheq.Font = new System.Drawing.Font("Superspace Bold", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtNumCheq.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNumCheq.Location = new System.Drawing.Point(572, 13);
            this.txtNumCheq.Name = "txtNumCheq";
            this.txtNumCheq.Size = new System.Drawing.Size(219, 27);
            this.txtNumCheq.TabIndex = 39;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(332, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 39;
            // 
            // rdTotalCheq
            // 
            this.rdTotalCheq.AutoSize = true;
            this.rdTotalCheq.Enabled = false;
            this.rdTotalCheq.Font = new System.Drawing.Font("Superspace Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.rdTotalCheq.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdTotalCheq.Location = new System.Drawing.Point(257, 14);
            this.rdTotalCheq.Name = "rdTotalCheq";
            this.rdTotalCheq.Size = new System.Drawing.Size(69, 23);
            this.rdTotalCheq.TabIndex = 2;
            this.rdTotalCheq.TabStop = true;
            this.rdTotalCheq.Text = "เช็ครวม";
            this.rdTotalCheq.UseVisualStyleBackColor = true;
            // 
            // rdTransfer
            // 
            this.rdTransfer.AutoSize = true;
            this.rdTransfer.Enabled = false;
            this.rdTransfer.Font = new System.Drawing.Font("Superspace Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.rdTransfer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdTransfer.Location = new System.Drawing.Point(120, 13);
            this.rdTransfer.Name = "rdTransfer";
            this.rdTransfer.Size = new System.Drawing.Size(90, 23);
            this.rdTransfer.TabIndex = 1;
            this.rdTransfer.TabStop = true;
            this.rdTransfer.Text = "รายการโอน";
            this.rdTransfer.UseVisualStyleBackColor = true;
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Enabled = false;
            this.rdCash.Font = new System.Drawing.Font("Superspace Bold", 11.75F, System.Drawing.FontStyle.Bold);
            this.rdCash.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdCash.Location = new System.Drawing.Point(17, 14);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(61, 23);
            this.rdCash.TabIndex = 0;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "เงินสด";
            this.rdCash.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTime.Location = new System.Drawing.Point(707, 29);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(49, 24);
            this.txtTime.TabIndex = 73;
            this.txtTime.Text = "Date";
            // 
            // txtBranch2
            // 
            this.txtBranch2.Enabled = false;
            this.txtBranch2.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtBranch2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBranch2.FormattingEnabled = true;
            this.txtBranch2.Items.AddRange(new object[] {
            "ลาดพร้าว",
            "พระโขนง",
            "สยาม"});
            this.txtBranch2.Location = new System.Drawing.Point(483, 163);
            this.txtBranch2.Name = "txtBranch2";
            this.txtBranch2.Size = new System.Drawing.Size(232, 32);
            this.txtBranch2.TabIndex = 72;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Superspace Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(977, 516);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 15);
            this.label21.TabIndex = 71;
            this.label21.Text = "รหัสพัสดุ kk 231502";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Superspace Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(55, 516);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 15);
            this.label20.TabIndex = 70;
            this.label20.Text = "CPS 992355 210";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Superspace Bold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(112, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "ลายมือชื่อผู้นำฝาก / Signature";
            // 
            // SignCus
            // 
            this.SignCus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SignCus.Location = new System.Drawing.Point(123, 387);
            this.SignCus.Name = "SignCus";
            this.SignCus.Size = new System.Drawing.Size(173, 79);
            this.SignCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignCus.TabIndex = 60;
            this.SignCus.TabStop = false;
            this.SignCus.Click += new System.EventHandler(this.SignCus_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Superspace Bold", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Azure;
            this.btnSubmit.Location = new System.Drawing.Point(917, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 79);
            this.btnSubmit.TabIndex = 75;
            this.btnSubmit.Text = "ทำรายการ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Superspace Bold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(671, 468);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 20);
            this.label18.TabIndex = 68;
            this.label18.Text = "ลายมือชื่อเจ้าหน้าที่ธนาคาร";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Superspace Bold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(417, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "จำนวนเงิน / Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTotalAmount.Location = new System.Drawing.Point(359, 434);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(244, 31);
            this.txtTotalAmount.TabIndex = 62;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthSign
            // 
            this.AuthSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AuthSign.Location = new System.Drawing.Point(666, 386);
            this.AuthSign.Name = "AuthSign";
            this.AuthSign.Size = new System.Drawing.Size(173, 79);
            this.AuthSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthSign.TabIndex = 61;
            this.AuthSign.TabStop = false;
            this.AuthSign.Click += new System.EventHandler(this.AuthSign_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Superspace Bold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(116, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(661, 22);
            this.label12.TabIndex = 59;
            this.label12.Text = "I hereby verify and confirm that the infomation mentioned above is true and corre" +
    "ct.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Superspace Bold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(116, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(465, 22);
            this.label11.TabIndex = 58;
            this.label11.Text = "ข้าพเจ้าได้ตรวจสอบและขอยืนยันว่าข้อมูลในเอกสารถูกต้องทุกประการ";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPhone.Location = new System.Drawing.Point(294, 282);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(244, 31);
            this.txtPhone.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(70, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 24);
            this.label10.TabIndex = 56;
            this.label10.Text = "หมายเลขโทรศัพท์ผู้นำฝาก";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(375, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "จำนวนเงินเป็นตัวอักษร";
            // 
            // txtAmountText
            // 
            this.txtAmountText.Enabled = false;
            this.txtAmountText.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAmountText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAmountText.Location = new System.Drawing.Point(556, 222);
            this.txtAmountText.Name = "txtAmountText";
            this.txtAmountText.Size = new System.Drawing.Size(327, 31);
            this.txtAmountText.TabIndex = 54;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAmount.FormattingEnabled = true;
            this.txtAmount.Items.AddRange(new object[] {
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "4000",
            "5000",
            "10000",
            "20000",
            "50000"});
            this.txtAmount.Location = new System.Drawing.Point(176, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(176, 32);
            this.txtAmount.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(70, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 52;
            this.label8.Text = "จำนวนเงิน";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Enabled = false;
            this.txtAccountName.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAccountName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAccountName.Location = new System.Drawing.Point(845, 163);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(219, 31);
            this.txtAccountName.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(769, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "ชื่อบัญชี";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(428, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "สาขา";
            // 
            // txtAccounntNumber
            // 
            this.txtAccounntNumber.Enabled = false;
            this.txtAccounntNumber.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtAccounntNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtAccounntNumber.Location = new System.Drawing.Point(176, 163);
            this.txtAccounntNumber.Name = "txtAccounntNumber";
            this.txtAccounntNumber.Size = new System.Drawing.Size(219, 31);
            this.txtAccounntNumber.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(70, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "เลขที่บัญชี";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(70, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "ฝากโดย";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Teller.Properties.Resources.slip;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(924, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // txtBranch
            // 
            this.txtBranch.Enabled = false;
            this.txtBranch.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtBranch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBranch.FormattingEnabled = true;
            this.txtBranch.Items.AddRange(new object[] {
            "ลาดพร้าว",
            "พระโขนง",
            "สยาม"});
            this.txtBranch.Location = new System.Drawing.Point(477, 26);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(176, 32);
            this.txtBranch.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(401, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Branch";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(401, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "สาขา";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Teller.Properties.Resources.ktb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(74, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Superspace Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Location = new System.Drawing.Point(390, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(738, 24);
            this.label16.TabIndex = 48;
            this.label16.Text = "                                                                                 " +
    "                       ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Superspace Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label17.Location = new System.Drawing.Point(114, 445);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 24);
            this.label17.TabIndex = 66;
            this.label17.Text = "                          ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Superspace Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label19.Location = new System.Drawing.Point(656, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 24);
            this.label19.TabIndex = 67;
            this.label19.Text = "                          ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Superspace Bold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Location = new System.Drawing.Point(678, 485);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 20);
            this.label23.TabIndex = 69;
            this.label23.Text = "Authorized Signature";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Superspace Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(355, 445);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(255, 24);
            this.label24.TabIndex = 64;
            this.label24.Text = "                                   ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::Teller.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Superspace Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(618, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 661);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Teller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtNumCheq;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton rdTotalCheq;
        private System.Windows.Forms.RadioButton rdTransfer;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.ComboBox txtBranch2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox SignCus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.PictureBox AuthSign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmountText;
        public System.Windows.Forms.ComboBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAccounntNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox txtBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnRefresh;
    }
}

