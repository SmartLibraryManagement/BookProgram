﻿
namespace BookMgr
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BookMenubtn = new System.Windows.Forms.Button();
            this.MemberMenubtn = new System.Windows.Forms.Button();
            this.GoHomebtn = new System.Windows.Forms.Button();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.PWtxt = new System.Windows.Forms.TextBox();
            this.FindIDPasswordlbl = new System.Windows.Forms.Label();
            this.Findlbl = new System.Windows.Forms.LinkLabel();
            this.Joinlbl = new System.Windows.Forms.LinkLabel();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Verlbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Loginpnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Treeptr = new System.Windows.Forms.PictureBox();
            this.Nimlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TabControl();
            this.UserData = new System.Windows.Forms.TabPage();
            this.UserDataUpdatepnl = new System.Windows.Forms.Panel();
            this.UserDelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.Frdo = new System.Windows.Forms.RadioButton();
            this.Mrdo = new System.Windows.Forms.RadioButton();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.Teltxt = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.UpdatePW2txt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.UpdatePW1txt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SameCheckbtn = new System.Windows.Forms.Button();
            this.UpdateIDtxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.CheckPWtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderBook = new System.Windows.Forms.TabPage();
            this.Googlebtn = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.OrderDatetxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.OrderPublishertxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.OrderAuthortxt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.OrderTitletxt = new System.Windows.Forms.TextBox();
            this.MgrOrder = new System.Windows.Forms.TabPage();
            this.Order = new System.Windows.Forms.TabControl();
            this.OrderList = new System.Windows.Forms.TabPage();
            this.BookPutbtn = new System.Windows.Forms.Button();
            this.ListDelbtn = new System.Windows.Forms.Button();
            this.AllSelectBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sucession = new System.Windows.Forms.TabPage();
            this.KickOkbtn = new System.Windows.Forms.Button();
            this.ListDel1btn = new System.Windows.Forms.Button();
            this.AllSelect1btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UserRank = new System.Windows.Forms.TabPage();
            this.RankDown = new System.Windows.Forms.Button();
            this.RankUpbtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Database = new System.Windows.Forms.TabPage();
            this.Book = new System.Windows.Forms.TabControl();
            this.Findbookpage = new System.Windows.Forms.TabPage();
            this.SrchBookbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SrchPublishertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Srchauthortxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SrchDatetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SrchISBNtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SrchTitletxt = new System.Windows.Forms.TextBox();
            this.FindGridView = new System.Windows.Forms.DataGridView();
            this.Returnbookpage = new System.Windows.Forms.TabPage();
            this.Longbtn = new System.Windows.Forms.Button();
            this.Rtnbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.RtnDatetxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RtnPublishertxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RtnAuthortxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RtnTitletxt = new System.Windows.Forms.TextBox();
            this.RtnGridView = new System.Windows.Forms.DataGridView();
            this.Mgrbookpage = new System.Windows.Forms.TabPage();
            this.ListBookbtn = new System.Windows.Forms.Button();
            this.PutBookbtn = new System.Windows.Forms.Button();
            this.DelBookbtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.MgrISBNtxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MgrPublishertxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MgrAuthortxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MgrDatetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MgrPricetxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MgrTitletxt = new System.Windows.Forms.TextBox();
            this.MgrGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Loginpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Treeptr)).BeginInit();
            this.User.SuspendLayout();
            this.UserData.SuspendLayout();
            this.UserDataUpdatepnl.SuspendLayout();
            this.OrderBook.SuspendLayout();
            this.MgrOrder.SuspendLayout();
            this.Order.SuspendLayout();
            this.OrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Sucession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.UserRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Book.SuspendLayout();
            this.Findbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).BeginInit();
            this.Returnbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RtnGridView)).BeginInit();
            this.Mgrbookpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgrGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookMenubtn
            // 
            this.BookMenubtn.BackColor = System.Drawing.Color.Gray;
            this.BookMenubtn.Image = ((System.Drawing.Image)(resources.GetObject("BookMenubtn.Image")));
            this.BookMenubtn.Location = new System.Drawing.Point(0, 0);
            this.BookMenubtn.Name = "BookMenubtn";
            this.BookMenubtn.Size = new System.Drawing.Size(120, 120);
            this.BookMenubtn.TabIndex = 0;
            this.BookMenubtn.UseVisualStyleBackColor = false;
            this.BookMenubtn.Click += new System.EventHandler(this.BookMenubtn_Click);
            // 
            // MemberMenubtn
            // 
            this.MemberMenubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemberMenubtn.Image = ((System.Drawing.Image)(resources.GetObject("MemberMenubtn.Image")));
            this.MemberMenubtn.Location = new System.Drawing.Point(116, 0);
            this.MemberMenubtn.Name = "MemberMenubtn";
            this.MemberMenubtn.Size = new System.Drawing.Size(120, 120);
            this.MemberMenubtn.TabIndex = 1;
            this.MemberMenubtn.UseVisualStyleBackColor = false;
            this.MemberMenubtn.Click += new System.EventHandler(this.MemberMenubtn_Click);
            // 
            // GoHomebtn
            // 
            this.GoHomebtn.BackColor = System.Drawing.Color.White;
            this.GoHomebtn.Image = ((System.Drawing.Image)(resources.GetObject("GoHomebtn.Image")));
            this.GoHomebtn.Location = new System.Drawing.Point(900, 30);
            this.GoHomebtn.Name = "GoHomebtn";
            this.GoHomebtn.Size = new System.Drawing.Size(50, 50);
            this.GoHomebtn.TabIndex = 2;
            this.GoHomebtn.UseVisualStyleBackColor = false;
            this.GoHomebtn.Click += new System.EventHandler(this.GoHomebtn_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDtxt.ForeColor = System.Drawing.Color.Silver;
            this.IDtxt.Location = new System.Drawing.Point(968, 30);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(180, 21);
            this.IDtxt.TabIndex = 3;
            this.IDtxt.Text = "아이디";
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            this.IDtxt.Enter += new System.EventHandler(this.IDtxt_Enter);
            this.IDtxt.Leave += new System.EventHandler(this.IDtxt_Leave);
            // 
            // PWtxt
            // 
            this.PWtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PWtxt.ForeColor = System.Drawing.Color.Silver;
            this.PWtxt.Location = new System.Drawing.Point(968, 57);
            this.PWtxt.Name = "PWtxt";
            this.PWtxt.Size = new System.Drawing.Size(180, 21);
            this.PWtxt.TabIndex = 4;
            this.PWtxt.Text = "비밀번호";
            this.PWtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            this.PWtxt.Enter += new System.EventHandler(this.Passwordtxt_Enter);
            this.PWtxt.Leave += new System.EventHandler(this.Passwordtxt_Leave);
            // 
            // FindIDPasswordlbl
            // 
            this.FindIDPasswordlbl.AutoSize = true;
            this.FindIDPasswordlbl.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.FindIDPasswordlbl.Location = new System.Drawing.Point(532, 323);
            this.FindIDPasswordlbl.Name = "FindIDPasswordlbl";
            this.FindIDPasswordlbl.Size = new System.Drawing.Size(211, 70);
            this.FindIDPasswordlbl.TabIndex = 5;
            this.FindIDPasswordlbl.Text = "K-형제들";
            // 
            // Findlbl
            // 
            this.Findlbl.AutoSize = true;
            this.Findlbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Findlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Findlbl.LinkColor = System.Drawing.Color.Black;
            this.Findlbl.Location = new System.Drawing.Point(965, 88);
            this.Findlbl.Name = "Findlbl";
            this.Findlbl.Size = new System.Drawing.Size(145, 13);
            this.Findlbl.TabIndex = 6;
            this.Findlbl.TabStop = true;
            this.Findlbl.Text = "아이디/비밀번호 찾기";
            this.Findlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Joinlbl
            // 
            this.Joinlbl.AutoSize = true;
            this.Joinlbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Joinlbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Joinlbl.LinkColor = System.Drawing.Color.Black;
            this.Joinlbl.Location = new System.Drawing.Point(965, 107);
            this.Joinlbl.Name = "Joinlbl";
            this.Joinlbl.Size = new System.Drawing.Size(63, 13);
            this.Joinlbl.TabIndex = 7;
            this.Joinlbl.TabStop = true;
            this.Joinlbl.Text = "회원가입";
            this.Joinlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Joinlbl_LinkClicked);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Loginbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loginbtn.Location = new System.Drawing.Point(1154, 30);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(85, 50);
            this.Loginbtn.TabIndex = 8;
            this.Loginbtn.Text = "로그인";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            this.Loginbtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Loginbtn_KeyUp);
            // 
            // Verlbl
            // 
            this.Verlbl.AutoSize = true;
            this.Verlbl.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Verlbl.Location = new System.Drawing.Point(1150, 637);
            this.Verlbl.Name = "Verlbl";
            this.Verlbl.Size = new System.Drawing.Size(95, 19);
            this.Verlbl.TabIndex = 9;
            this.Verlbl.Text = "ver-1.0.0";
            this.Verlbl.Click += new System.EventHandler(this.Verlbl_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Member.png");
            this.imageList1.Images.SetKeyName(1, "Tree.png");
            this.imageList1.Images.SetKeyName(2, "Book.png");
            this.imageList1.Images.SetKeyName(3, "GoHome.png");
            // 
            // Loginpnl
            // 
            this.Loginpnl.Controls.Add(this.label4);
            this.Loginpnl.Controls.Add(this.label3);
            this.Loginpnl.Controls.Add(this.Treeptr);
            this.Loginpnl.Controls.Add(this.Nimlbl);
            this.Loginpnl.Controls.Add(this.Namelbl);
            this.Loginpnl.Controls.Add(this.Logoutbtn);
            this.Loginpnl.Controls.Add(this.button2);
            this.Loginpnl.Controls.Add(this.button3);
            this.Loginpnl.Controls.Add(this.button4);
            this.Loginpnl.Controls.Add(this.User);
            this.Loginpnl.Controls.Add(this.Book);
            this.Loginpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loginpnl.Location = new System.Drawing.Point(0, 0);
            this.Loginpnl.Name = "Loginpnl";
            this.Loginpnl.Size = new System.Drawing.Size(1264, 681);
            this.Loginpnl.TabIndex = 10;
            this.Loginpnl.Visible = false;
            this.Loginpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(990, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "등급";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(958, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "나무";
            // 
            // Treeptr
            // 
            this.Treeptr.Image = ((System.Drawing.Image)(resources.GetObject("Treeptr.Image")));
            this.Treeptr.Location = new System.Drawing.Point(964, 30);
            this.Treeptr.Name = "Treeptr";
            this.Treeptr.Size = new System.Drawing.Size(50, 50);
            this.Treeptr.TabIndex = 22;
            this.Treeptr.TabStop = false;
            // 
            // Nimlbl
            // 
            this.Nimlbl.AutoSize = true;
            this.Nimlbl.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.Nimlbl.Location = new System.Drawing.Point(1108, 36);
            this.Nimlbl.Name = "Nimlbl";
            this.Nimlbl.Size = new System.Drawing.Size(42, 39);
            this.Nimlbl.TabIndex = 21;
            this.Nimlbl.Text = "님";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Namelbl.Location = new System.Drawing.Point(1020, 36);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(92, 39);
            this.Namelbl.TabIndex = 20;
            this.Namelbl.Text = "홍길동";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Logoutbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logoutbtn.Location = new System.Drawing.Point(1154, 30);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(85, 50);
            this.Logoutbtn.TabIndex = 18;
            this.Logoutbtn.Text = "로그아웃";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(900, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(116, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // User
            // 
            this.User.Controls.Add(this.UserData);
            this.User.Controls.Add(this.OrderBook);
            this.User.Controls.Add(this.MgrOrder);
            this.User.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.User.ItemSize = new System.Drawing.Size(50, 50);
            this.User.Location = new System.Drawing.Point(4, 117);
            this.User.Name = "User";
            this.User.Padding = new System.Drawing.Point(22, 3);
            this.User.SelectedIndex = 0;
            this.User.Size = new System.Drawing.Size(1260, 550);
            this.User.TabIndex = 26;
            this.User.Visible = false;
            // 
            // UserData
            // 
            this.UserData.BackColor = System.Drawing.Color.White;
            this.UserData.Controls.Add(this.UserDataUpdatepnl);
            this.UserData.Controls.Add(this.label19);
            this.UserData.Controls.Add(this.Nextbtn);
            this.UserData.Controls.Add(this.CheckPWtxt);
            this.UserData.Controls.Add(this.label1);
            this.UserData.Location = new System.Drawing.Point(4, 54);
            this.UserData.Name = "UserData";
            this.UserData.Padding = new System.Windows.Forms.Padding(3);
            this.UserData.Size = new System.Drawing.Size(1252, 492);
            this.UserData.TabIndex = 0;
            this.UserData.Text = "회원정보";
            // 
            // UserDataUpdatepnl
            // 
            this.UserDataUpdatepnl.Controls.Add(this.UserDelbtn);
            this.UserDataUpdatepnl.Controls.Add(this.Updatebtn);
            this.UserDataUpdatepnl.Controls.Add(this.comboBox1);
            this.UserDataUpdatepnl.Controls.Add(this.label41);
            this.UserDataUpdatepnl.Controls.Add(this.label40);
            this.UserDataUpdatepnl.Controls.Add(this.Frdo);
            this.UserDataUpdatepnl.Controls.Add(this.Mrdo);
            this.UserDataUpdatepnl.Controls.Add(this.Emailtxt);
            this.UserDataUpdatepnl.Controls.Add(this.label37);
            this.UserDataUpdatepnl.Controls.Add(this.Addresstxt);
            this.UserDataUpdatepnl.Controls.Add(this.label38);
            this.UserDataUpdatepnl.Controls.Add(this.Nametxt);
            this.UserDataUpdatepnl.Controls.Add(this.label39);
            this.UserDataUpdatepnl.Controls.Add(this.Teltxt);
            this.UserDataUpdatepnl.Controls.Add(this.label35);
            this.UserDataUpdatepnl.Controls.Add(this.UpdatePW2txt);
            this.UserDataUpdatepnl.Controls.Add(this.label34);
            this.UserDataUpdatepnl.Controls.Add(this.UpdatePW1txt);
            this.UserDataUpdatepnl.Controls.Add(this.label23);
            this.UserDataUpdatepnl.Controls.Add(this.SameCheckbtn);
            this.UserDataUpdatepnl.Controls.Add(this.UpdateIDtxt);
            this.UserDataUpdatepnl.Controls.Add(this.label22);
            this.UserDataUpdatepnl.Controls.Add(this.label21);
            this.UserDataUpdatepnl.Controls.Add(this.label20);
            this.UserDataUpdatepnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataUpdatepnl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDataUpdatepnl.Location = new System.Drawing.Point(3, 3);
            this.UserDataUpdatepnl.Name = "UserDataUpdatepnl";
            this.UserDataUpdatepnl.Size = new System.Drawing.Size(1246, 486);
            this.UserDataUpdatepnl.TabIndex = 4;
            this.UserDataUpdatepnl.Visible = false;
            this.UserDataUpdatepnl.Paint += new System.Windows.Forms.PaintEventHandler(this.UserDataUpdatepnl_Paint);
            // 
            // UserDelbtn
            // 
            this.UserDelbtn.BackColor = System.Drawing.Color.LightGray;
            this.UserDelbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserDelbtn.Location = new System.Drawing.Point(1016, 377);
            this.UserDelbtn.Name = "UserDelbtn";
            this.UserDelbtn.Size = new System.Drawing.Size(110, 45);
            this.UserDelbtn.TabIndex = 30;
            this.UserDelbtn.Text = "회원탈퇴";
            this.UserDelbtn.UseVisualStyleBackColor = false;
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.LightGray;
            this.Updatebtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Updatebtn.Location = new System.Drawing.Point(893, 377);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(110, 45);
            this.Updatebtn.TabIndex = 29;
            this.Updatebtn.Text = "수정완료";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "naver.com",
            "gmail.com",
            "kyungmin.ac.kr",
            "hanmail.com"});
            this.comboBox1.Location = new System.Drawing.Point(411, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(388, 259);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 16);
            this.label41.TabIndex = 27;
            this.label41.Text = "@";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(941, 85);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(45, 16);
            this.label40.TabIndex = 26;
            this.label40.Text = "성별:";
            // 
            // Frdo
            // 
            this.Frdo.AutoSize = true;
            this.Frdo.Location = new System.Drawing.Point(1037, 83);
            this.Frdo.Name = "Frdo";
            this.Frdo.Size = new System.Drawing.Size(42, 20);
            this.Frdo.TabIndex = 25;
            this.Frdo.TabStop = true;
            this.Frdo.Text = "여";
            this.Frdo.UseVisualStyleBackColor = true;
            // 
            // Mrdo
            // 
            this.Mrdo.AutoSize = true;
            this.Mrdo.Location = new System.Drawing.Point(991, 82);
            this.Mrdo.Name = "Mrdo";
            this.Mrdo.Size = new System.Drawing.Size(42, 20);
            this.Mrdo.TabIndex = 24;
            this.Mrdo.TabStop = true;
            this.Mrdo.Text = "남";
            this.Mrdo.UseVisualStyleBackColor = true;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Emailtxt.Location = new System.Drawing.Point(230, 255);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(158, 26);
            this.Emailtxt.TabIndex = 23;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(700, 205);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 16);
            this.label37.TabIndex = 20;
            this.label37.Text = "*전화번호:";
            // 
            // Addresstxt
            // 
            this.Addresstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Addresstxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addresstxt.Location = new System.Drawing.Point(830, 140);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(370, 26);
            this.Addresstxt.TabIndex = 19;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.Location = new System.Drawing.Point(700, 145);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 16);
            this.label38.TabIndex = 18;
            this.label38.Text = "주소:";
            // 
            // Nametxt
            // 
            this.Nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nametxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Nametxt.Location = new System.Drawing.Point(830, 80);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 26);
            this.Nametxt.TabIndex = 17;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(700, 85);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(56, 16);
            this.label39.TabIndex = 16;
            this.label39.Text = "*이름:";
            // 
            // Teltxt
            // 
            this.Teltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Teltxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Teltxt.Location = new System.Drawing.Point(830, 200);
            this.Teltxt.Mask = "000-0000-0000";
            this.Teltxt.Name = "Teltxt";
            this.Teltxt.Size = new System.Drawing.Size(250, 26);
            this.Teltxt.TabIndex = 15;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.Location = new System.Drawing.Point(100, 260);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 16);
            this.label35.TabIndex = 13;
            this.label35.Text = "*이메일:";
            // 
            // UpdatePW2txt
            // 
            this.UpdatePW2txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdatePW2txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdatePW2txt.Location = new System.Drawing.Point(230, 195);
            this.UpdatePW2txt.Name = "UpdatePW2txt";
            this.UpdatePW2txt.PasswordChar = '*';
            this.UpdatePW2txt.Size = new System.Drawing.Size(250, 26);
            this.UpdatePW2txt.TabIndex = 12;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(100, 200);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(124, 16);
            this.label34.TabIndex = 11;
            this.label34.Text = "*비밀번호확인:";
            // 
            // UpdatePW1txt
            // 
            this.UpdatePW1txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdatePW1txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdatePW1txt.Location = new System.Drawing.Point(230, 135);
            this.UpdatePW1txt.Name = "UpdatePW1txt";
            this.UpdatePW1txt.PasswordChar = '*';
            this.UpdatePW1txt.Size = new System.Drawing.Size(250, 26);
            this.UpdatePW1txt.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(100, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 16);
            this.label23.TabIndex = 9;
            this.label23.Text = "*비밀번호:";
            // 
            // SameCheckbtn
            // 
            this.SameCheckbtn.BackColor = System.Drawing.Color.LightGray;
            this.SameCheckbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SameCheckbtn.Location = new System.Drawing.Point(486, 73);
            this.SameCheckbtn.Name = "SameCheckbtn";
            this.SameCheckbtn.Size = new System.Drawing.Size(90, 30);
            this.SameCheckbtn.TabIndex = 8;
            this.SameCheckbtn.Text = "중복확인";
            this.SameCheckbtn.UseVisualStyleBackColor = false;
            this.SameCheckbtn.Click += new System.EventHandler(this.SameCheckbtn_Click);
            // 
            // UpdateIDtxt
            // 
            this.UpdateIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateIDtxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateIDtxt.Location = new System.Drawing.Point(230, 75);
            this.UpdateIDtxt.Name = "UpdateIDtxt";
            this.UpdateIDtxt.Size = new System.Drawing.Size(250, 26);
            this.UpdateIDtxt.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(100, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 16);
            this.label22.TabIndex = 6;
            this.label22.Text = "*아이디:";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(50, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1150, 2);
            this.label21.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label20.Location = new System.Drawing.Point(517, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 49);
            this.label20.TabIndex = 4;
            this.label20.Text = "회원정보수정";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label19.Location = new System.Drawing.Point(500, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(218, 49);
            this.label19.TabIndex = 3;
            this.label19.Text = "비밀번호 확인";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Image = ((System.Drawing.Image)(resources.GetObject("Nextbtn.Image")));
            this.Nextbtn.Location = new System.Drawing.Point(553, 244);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(90, 90);
            this.Nextbtn.TabIndex = 2;
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckPWtxt
            // 
            this.CheckPWtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckPWtxt.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CheckPWtxt.Location = new System.Drawing.Point(414, 149);
            this.CheckPWtxt.Name = "CheckPWtxt";
            this.CheckPWtxt.PasswordChar = '*';
            this.CheckPWtxt.Size = new System.Drawing.Size(400, 39);
            this.CheckPWtxt.TabIndex = 0;
            this.CheckPWtxt.TextChanged += new System.EventHandler(this.CheckPWtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label1.Location = new System.Drawing.Point(282, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "비밀번호:";
            // 
            // OrderBook
            // 
            this.OrderBook.BackColor = System.Drawing.Color.White;
            this.OrderBook.Controls.Add(this.Googlebtn);
            this.OrderBook.Controls.Add(this.label36);
            this.OrderBook.Controls.Add(this.label42);
            this.OrderBook.Controls.Add(this.Orderbtn);
            this.OrderBook.Controls.Add(this.label24);
            this.OrderBook.Controls.Add(this.OrderDatetxt);
            this.OrderBook.Controls.Add(this.label25);
            this.OrderBook.Controls.Add(this.OrderPublishertxt);
            this.OrderBook.Controls.Add(this.label26);
            this.OrderBook.Controls.Add(this.OrderAuthortxt);
            this.OrderBook.Controls.Add(this.label27);
            this.OrderBook.Controls.Add(this.OrderTitletxt);
            this.OrderBook.Location = new System.Drawing.Point(4, 54);
            this.OrderBook.Name = "OrderBook";
            this.OrderBook.Padding = new System.Windows.Forms.Padding(3);
            this.OrderBook.Size = new System.Drawing.Size(1252, 492);
            this.OrderBook.TabIndex = 1;
            this.OrderBook.Text = "도서신청";
            this.OrderBook.Click += new System.EventHandler(this.OrderBook_Click);
            // 
            // Googlebtn
            // 
            this.Googlebtn.Image = ((System.Drawing.Image)(resources.GetObject("Googlebtn.Image")));
            this.Googlebtn.Location = new System.Drawing.Point(524, 58);
            this.Googlebtn.Name = "Googlebtn";
            this.Googlebtn.Size = new System.Drawing.Size(218, 63);
            this.Googlebtn.TabIndex = 14;
            this.Googlebtn.UseVisualStyleBackColor = true;
            this.Googlebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label36
            // 
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(50, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1150, 2);
            this.label36.TabIndex = 13;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label42.Location = new System.Drawing.Point(548, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(156, 49);
            this.label42.TabIndex = 12;
            this.label42.Text = "도서 신청";
            // 
            // Orderbtn
            // 
            this.Orderbtn.BackColor = System.Drawing.Color.LightGray;
            this.Orderbtn.Location = new System.Drawing.Point(577, 380);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(110, 45);
            this.Orderbtn.TabIndex = 11;
            this.Orderbtn.Text = "신청하기";
            this.Orderbtn.UseVisualStyleBackColor = false;
            this.Orderbtn.Click += new System.EventHandler(this.Orderbtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(419, 325);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 10;
            this.label24.Text = "발행일:";
            // 
            // OrderDatetxt
            // 
            this.OrderDatetxt.BackColor = System.Drawing.Color.White;
            this.OrderDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderDatetxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderDatetxt.Location = new System.Drawing.Point(527, 320);
            this.OrderDatetxt.Name = "OrderDatetxt";
            this.OrderDatetxt.Size = new System.Drawing.Size(215, 26);
            this.OrderDatetxt.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(419, 265);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 16);
            this.label25.TabIndex = 8;
            this.label25.Text = "출판사:";
            // 
            // OrderPublishertxt
            // 
            this.OrderPublishertxt.BackColor = System.Drawing.Color.White;
            this.OrderPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPublishertxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderPublishertxt.Location = new System.Drawing.Point(527, 260);
            this.OrderPublishertxt.Name = "OrderPublishertxt";
            this.OrderPublishertxt.Size = new System.Drawing.Size(215, 26);
            this.OrderPublishertxt.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(419, 205);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "저자:";
            // 
            // OrderAuthortxt
            // 
            this.OrderAuthortxt.BackColor = System.Drawing.Color.White;
            this.OrderAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderAuthortxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderAuthortxt.Location = new System.Drawing.Point(527, 200);
            this.OrderAuthortxt.Name = "OrderAuthortxt";
            this.OrderAuthortxt.Size = new System.Drawing.Size(215, 26);
            this.OrderAuthortxt.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(419, 145);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 16);
            this.label27.TabIndex = 4;
            this.label27.Text = "제목:";
            // 
            // OrderTitletxt
            // 
            this.OrderTitletxt.BackColor = System.Drawing.Color.White;
            this.OrderTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTitletxt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderTitletxt.Location = new System.Drawing.Point(527, 140);
            this.OrderTitletxt.Name = "OrderTitletxt";
            this.OrderTitletxt.Size = new System.Drawing.Size(215, 26);
            this.OrderTitletxt.TabIndex = 3;
            // 
            // MgrOrder
            // 
            this.MgrOrder.BackColor = System.Drawing.Color.White;
            this.MgrOrder.Controls.Add(this.Order);
            this.MgrOrder.Location = new System.Drawing.Point(4, 54);
            this.MgrOrder.Name = "MgrOrder";
            this.MgrOrder.Padding = new System.Windows.Forms.Padding(3);
            this.MgrOrder.Size = new System.Drawing.Size(1252, 492);
            this.MgrOrder.TabIndex = 2;
            this.MgrOrder.Text = "신청관리";
            this.MgrOrder.Click += new System.EventHandler(this.MgrOrder_Click);
            // 
            // Order
            // 
            this.Order.Controls.Add(this.OrderList);
            this.Order.Controls.Add(this.Sucession);
            this.Order.Controls.Add(this.UserRank);
            this.Order.Controls.Add(this.Database);
            this.Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order.ItemSize = new System.Drawing.Size(120, 30);
            this.Order.Location = new System.Drawing.Point(3, 3);
            this.Order.Name = "Order";
            this.Order.SelectedIndex = 0;
            this.Order.Size = new System.Drawing.Size(1246, 486);
            this.Order.TabIndex = 0;
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.White;
            this.OrderList.Controls.Add(this.BookPutbtn);
            this.OrderList.Controls.Add(this.ListDelbtn);
            this.OrderList.Controls.Add(this.AllSelectBtn);
            this.OrderList.Controls.Add(this.dataGridView1);
            this.OrderList.Location = new System.Drawing.Point(4, 34);
            this.OrderList.Name = "OrderList";
            this.OrderList.Padding = new System.Windows.Forms.Padding(3);
            this.OrderList.Size = new System.Drawing.Size(1238, 448);
            this.OrderList.TabIndex = 0;
            this.OrderList.Text = "도서신청관리";
            // 
            // BookPutbtn
            // 
            this.BookPutbtn.BackColor = System.Drawing.Color.LightGray;
            this.BookPutbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookPutbtn.Location = new System.Drawing.Point(1067, 150);
            this.BookPutbtn.Name = "BookPutbtn";
            this.BookPutbtn.Size = new System.Drawing.Size(110, 45);
            this.BookPutbtn.TabIndex = 32;
            this.BookPutbtn.Text = "도서등록";
            this.BookPutbtn.UseVisualStyleBackColor = false;
            this.BookPutbtn.Click += new System.EventHandler(this.BookPutbtn_Click);
            // 
            // ListDelbtn
            // 
            this.ListDelbtn.BackColor = System.Drawing.Color.LightGray;
            this.ListDelbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListDelbtn.Location = new System.Drawing.Point(1067, 90);
            this.ListDelbtn.Name = "ListDelbtn";
            this.ListDelbtn.Size = new System.Drawing.Size(110, 45);
            this.ListDelbtn.TabIndex = 31;
            this.ListDelbtn.Text = "목록제거";
            this.ListDelbtn.UseVisualStyleBackColor = false;
            // 
            // AllSelectBtn
            // 
            this.AllSelectBtn.BackColor = System.Drawing.Color.LightGray;
            this.AllSelectBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllSelectBtn.Location = new System.Drawing.Point(1067, 30);
            this.AllSelectBtn.Name = "AllSelectBtn";
            this.AllSelectBtn.Size = new System.Drawing.Size(110, 45);
            this.AllSelectBtn.TabIndex = 30;
            this.AllSelectBtn.Text = "전체선택";
            this.AllSelectBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sucession
            // 
            this.Sucession.BackColor = System.Drawing.Color.White;
            this.Sucession.Controls.Add(this.KickOkbtn);
            this.Sucession.Controls.Add(this.ListDel1btn);
            this.Sucession.Controls.Add(this.AllSelect1btn);
            this.Sucession.Controls.Add(this.dataGridView2);
            this.Sucession.Location = new System.Drawing.Point(4, 34);
            this.Sucession.Name = "Sucession";
            this.Sucession.Padding = new System.Windows.Forms.Padding(3);
            this.Sucession.Size = new System.Drawing.Size(1238, 448);
            this.Sucession.TabIndex = 1;
            this.Sucession.Text = "회원탈퇴신청";
            // 
            // KickOkbtn
            // 
            this.KickOkbtn.BackColor = System.Drawing.Color.LightGray;
            this.KickOkbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KickOkbtn.Location = new System.Drawing.Point(1067, 150);
            this.KickOkbtn.Name = "KickOkbtn";
            this.KickOkbtn.Size = new System.Drawing.Size(110, 45);
            this.KickOkbtn.TabIndex = 36;
            this.KickOkbtn.Text = "탈퇴승인";
            this.KickOkbtn.UseVisualStyleBackColor = false;
            // 
            // ListDel1btn
            // 
            this.ListDel1btn.BackColor = System.Drawing.Color.LightGray;
            this.ListDel1btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListDel1btn.Location = new System.Drawing.Point(1067, 90);
            this.ListDel1btn.Name = "ListDel1btn";
            this.ListDel1btn.Size = new System.Drawing.Size(110, 45);
            this.ListDel1btn.TabIndex = 35;
            this.ListDel1btn.Text = "목록제거";
            this.ListDel1btn.UseVisualStyleBackColor = false;
            // 
            // AllSelect1btn
            // 
            this.AllSelect1btn.BackColor = System.Drawing.Color.LightGray;
            this.AllSelect1btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllSelect1btn.Location = new System.Drawing.Point(1067, 30);
            this.AllSelect1btn.Name = "AllSelect1btn";
            this.AllSelect1btn.Size = new System.Drawing.Size(110, 45);
            this.AllSelect1btn.TabIndex = 34;
            this.AllSelect1btn.Text = "전체선택";
            this.AllSelect1btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView2.TabIndex = 33;
            // 
            // UserRank
            // 
            this.UserRank.BackColor = System.Drawing.Color.White;
            this.UserRank.Controls.Add(this.RankDown);
            this.UserRank.Controls.Add(this.RankUpbtn);
            this.UserRank.Controls.Add(this.dataGridView3);
            this.UserRank.Location = new System.Drawing.Point(4, 34);
            this.UserRank.Name = "UserRank";
            this.UserRank.Padding = new System.Windows.Forms.Padding(3);
            this.UserRank.Size = new System.Drawing.Size(1238, 448);
            this.UserRank.TabIndex = 2;
            this.UserRank.Text = "회원등급관리";
            // 
            // RankDown
            // 
            this.RankDown.BackColor = System.Drawing.Color.LightGray;
            this.RankDown.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RankDown.Location = new System.Drawing.Point(1067, 90);
            this.RankDown.Name = "RankDown";
            this.RankDown.Size = new System.Drawing.Size(110, 45);
            this.RankDown.TabIndex = 38;
            this.RankDown.Text = "등급내리기";
            this.RankDown.UseVisualStyleBackColor = false;
            // 
            // RankUpbtn
            // 
            this.RankUpbtn.BackColor = System.Drawing.Color.LightGray;
            this.RankUpbtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RankUpbtn.Location = new System.Drawing.Point(1067, 30);
            this.RankUpbtn.Name = "RankUpbtn";
            this.RankUpbtn.Size = new System.Drawing.Size(110, 45);
            this.RankUpbtn.TabIndex = 37;
            this.RankUpbtn.Text = "등급올리기";
            this.RankUpbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(30, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView3.TabIndex = 36;
            // 
            // Database
            // 
            this.Database.BackColor = System.Drawing.Color.White;
            this.Database.Location = new System.Drawing.Point(4, 34);
            this.Database.Name = "Database";
            this.Database.Padding = new System.Windows.Forms.Padding(3);
            this.Database.Size = new System.Drawing.Size(1238, 448);
            this.Database.TabIndex = 3;
            this.Database.Text = "데이터베이스관리";
            // 
            // Book
            // 
            this.Book.Controls.Add(this.Findbookpage);
            this.Book.Controls.Add(this.Returnbookpage);
            this.Book.Controls.Add(this.Mgrbookpage);
            this.Book.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Book.ItemSize = new System.Drawing.Size(50, 50);
            this.Book.Location = new System.Drawing.Point(4, 117);
            this.Book.Name = "Book";
            this.Book.Padding = new System.Drawing.Point(22, 3);
            this.Book.SelectedIndex = 0;
            this.Book.Size = new System.Drawing.Size(1260, 550);
            this.Book.TabIndex = 25;
            this.Book.Visible = false;
            // 
            // Findbookpage
            // 
            this.Findbookpage.BackColor = System.Drawing.Color.White;
            this.Findbookpage.Controls.Add(this.SrchBookbtn);
            this.Findbookpage.Controls.Add(this.label8);
            this.Findbookpage.Controls.Add(this.SrchPublishertxt);
            this.Findbookpage.Controls.Add(this.label6);
            this.Findbookpage.Controls.Add(this.Srchauthortxt);
            this.Findbookpage.Controls.Add(this.label7);
            this.Findbookpage.Controls.Add(this.SrchDatetxt);
            this.Findbookpage.Controls.Add(this.label5);
            this.Findbookpage.Controls.Add(this.SrchISBNtxt);
            this.Findbookpage.Controls.Add(this.label2);
            this.Findbookpage.Controls.Add(this.SrchTitletxt);
            this.Findbookpage.Controls.Add(this.FindGridView);
            this.Findbookpage.Location = new System.Drawing.Point(4, 54);
            this.Findbookpage.Name = "Findbookpage";
            this.Findbookpage.Padding = new System.Windows.Forms.Padding(3);
            this.Findbookpage.Size = new System.Drawing.Size(1252, 492);
            this.Findbookpage.TabIndex = 0;
            this.Findbookpage.Text = "도서검색";
            // 
            // SrchBookbtn
            // 
            this.SrchBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.SrchBookbtn.Location = new System.Drawing.Point(1100, 380);
            this.SrchBookbtn.Name = "SrchBookbtn";
            this.SrchBookbtn.Size = new System.Drawing.Size(110, 45);
            this.SrchBookbtn.TabIndex = 11;
            this.SrchBookbtn.Text = "도서검색";
            this.SrchBookbtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(890, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ISBN:";
            // 
            // SrchPublishertxt
            // 
            this.SrchPublishertxt.BackColor = System.Drawing.Color.White;
            this.SrchPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchPublishertxt.Location = new System.Drawing.Point(998, 155);
            this.SrchPublishertxt.Name = "SrchPublishertxt";
            this.SrchPublishertxt.Size = new System.Drawing.Size(215, 26);
            this.SrchPublishertxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "발행일:";
            // 
            // Srchauthortxt
            // 
            this.Srchauthortxt.BackColor = System.Drawing.Color.White;
            this.Srchauthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Srchauthortxt.Location = new System.Drawing.Point(998, 215);
            this.Srchauthortxt.Name = "Srchauthortxt";
            this.Srchauthortxt.Size = new System.Drawing.Size(215, 26);
            this.Srchauthortxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "저자:";
            // 
            // SrchDatetxt
            // 
            this.SrchDatetxt.BackColor = System.Drawing.Color.White;
            this.SrchDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchDatetxt.Location = new System.Drawing.Point(998, 275);
            this.SrchDatetxt.Name = "SrchDatetxt";
            this.SrchDatetxt.Size = new System.Drawing.Size(215, 26);
            this.SrchDatetxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "출판사:";
            // 
            // SrchISBNtxt
            // 
            this.SrchISBNtxt.BackColor = System.Drawing.Color.White;
            this.SrchISBNtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchISBNtxt.Location = new System.Drawing.Point(998, 335);
            this.SrchISBNtxt.Name = "SrchISBNtxt";
            this.SrchISBNtxt.Size = new System.Drawing.Size(215, 26);
            this.SrchISBNtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "제목:";
            // 
            // SrchTitletxt
            // 
            this.SrchTitletxt.BackColor = System.Drawing.Color.White;
            this.SrchTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchTitletxt.Location = new System.Drawing.Point(998, 95);
            this.SrchTitletxt.Name = "SrchTitletxt";
            this.SrchTitletxt.Size = new System.Drawing.Size(215, 26);
            this.SrchTitletxt.TabIndex = 1;
            // 
            // FindGridView
            // 
            this.FindGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindGridView.Location = new System.Drawing.Point(0, 0);
            this.FindGridView.Name = "FindGridView";
            this.FindGridView.RowTemplate.Height = 23;
            this.FindGridView.Size = new System.Drawing.Size(871, 510);
            this.FindGridView.TabIndex = 0;
            // 
            // Returnbookpage
            // 
            this.Returnbookpage.BackColor = System.Drawing.Color.White;
            this.Returnbookpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Returnbookpage.Controls.Add(this.Longbtn);
            this.Returnbookpage.Controls.Add(this.Rtnbtn);
            this.Returnbookpage.Controls.Add(this.label11);
            this.Returnbookpage.Controls.Add(this.RtnDatetxt);
            this.Returnbookpage.Controls.Add(this.label12);
            this.Returnbookpage.Controls.Add(this.RtnPublishertxt);
            this.Returnbookpage.Controls.Add(this.label10);
            this.Returnbookpage.Controls.Add(this.RtnAuthortxt);
            this.Returnbookpage.Controls.Add(this.label9);
            this.Returnbookpage.Controls.Add(this.RtnTitletxt);
            this.Returnbookpage.Controls.Add(this.RtnGridView);
            this.Returnbookpage.Location = new System.Drawing.Point(4, 54);
            this.Returnbookpage.Name = "Returnbookpage";
            this.Returnbookpage.Padding = new System.Windows.Forms.Padding(3);
            this.Returnbookpage.Size = new System.Drawing.Size(1252, 492);
            this.Returnbookpage.TabIndex = 1;
            this.Returnbookpage.Text = "도서반납";
            // 
            // Longbtn
            // 
            this.Longbtn.BackColor = System.Drawing.Color.LightGray;
            this.Longbtn.Location = new System.Drawing.Point(980, 380);
            this.Longbtn.Name = "Longbtn";
            this.Longbtn.Size = new System.Drawing.Size(110, 45);
            this.Longbtn.TabIndex = 12;
            this.Longbtn.Text = "연장하기";
            this.Longbtn.UseVisualStyleBackColor = false;
            // 
            // Rtnbtn
            // 
            this.Rtnbtn.BackColor = System.Drawing.Color.LightGray;
            this.Rtnbtn.Location = new System.Drawing.Point(1100, 380);
            this.Rtnbtn.Name = "Rtnbtn";
            this.Rtnbtn.Size = new System.Drawing.Size(110, 45);
            this.Rtnbtn.TabIndex = 11;
            this.Rtnbtn.Text = "반납하기";
            this.Rtnbtn.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(890, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "반납예정일:";
            // 
            // RtnDatetxt
            // 
            this.RtnDatetxt.BackColor = System.Drawing.Color.White;
            this.RtnDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnDatetxt.Location = new System.Drawing.Point(998, 275);
            this.RtnDatetxt.Name = "RtnDatetxt";
            this.RtnDatetxt.Size = new System.Drawing.Size(215, 26);
            this.RtnDatetxt.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(890, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "출판사:";
            // 
            // RtnPublishertxt
            // 
            this.RtnPublishertxt.BackColor = System.Drawing.Color.White;
            this.RtnPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnPublishertxt.Location = new System.Drawing.Point(998, 215);
            this.RtnPublishertxt.Name = "RtnPublishertxt";
            this.RtnPublishertxt.Size = new System.Drawing.Size(215, 26);
            this.RtnPublishertxt.TabIndex = 7;
            this.RtnPublishertxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "저자:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // RtnAuthortxt
            // 
            this.RtnAuthortxt.BackColor = System.Drawing.Color.White;
            this.RtnAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnAuthortxt.Location = new System.Drawing.Point(998, 155);
            this.RtnAuthortxt.Name = "RtnAuthortxt";
            this.RtnAuthortxt.Size = new System.Drawing.Size(215, 26);
            this.RtnAuthortxt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(890, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "제목:";
            // 
            // RtnTitletxt
            // 
            this.RtnTitletxt.BackColor = System.Drawing.Color.White;
            this.RtnTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtnTitletxt.Location = new System.Drawing.Point(998, 95);
            this.RtnTitletxt.Name = "RtnTitletxt";
            this.RtnTitletxt.Size = new System.Drawing.Size(215, 26);
            this.RtnTitletxt.TabIndex = 3;
            // 
            // RtnGridView
            // 
            this.RtnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RtnGridView.Location = new System.Drawing.Point(0, 0);
            this.RtnGridView.Name = "RtnGridView";
            this.RtnGridView.RowTemplate.Height = 23;
            this.RtnGridView.Size = new System.Drawing.Size(871, 510);
            this.RtnGridView.TabIndex = 1;
            // 
            // Mgrbookpage
            // 
            this.Mgrbookpage.BackColor = System.Drawing.Color.White;
            this.Mgrbookpage.Controls.Add(this.ListBookbtn);
            this.Mgrbookpage.Controls.Add(this.PutBookbtn);
            this.Mgrbookpage.Controls.Add(this.DelBookbtn);
            this.Mgrbookpage.Controls.Add(this.label17);
            this.Mgrbookpage.Controls.Add(this.MgrISBNtxt);
            this.Mgrbookpage.Controls.Add(this.label18);
            this.Mgrbookpage.Controls.Add(this.MgrPublishertxt);
            this.Mgrbookpage.Controls.Add(this.label13);
            this.Mgrbookpage.Controls.Add(this.MgrAuthortxt);
            this.Mgrbookpage.Controls.Add(this.label14);
            this.Mgrbookpage.Controls.Add(this.MgrDatetxt);
            this.Mgrbookpage.Controls.Add(this.label15);
            this.Mgrbookpage.Controls.Add(this.MgrPricetxt);
            this.Mgrbookpage.Controls.Add(this.label16);
            this.Mgrbookpage.Controls.Add(this.MgrTitletxt);
            this.Mgrbookpage.Controls.Add(this.MgrGridView);
            this.Mgrbookpage.Location = new System.Drawing.Point(4, 54);
            this.Mgrbookpage.Name = "Mgrbookpage";
            this.Mgrbookpage.Padding = new System.Windows.Forms.Padding(3);
            this.Mgrbookpage.Size = new System.Drawing.Size(1252, 492);
            this.Mgrbookpage.TabIndex = 2;
            this.Mgrbookpage.Text = "도서관리";
            // 
            // ListBookbtn
            // 
            this.ListBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.ListBookbtn.Location = new System.Drawing.Point(1100, 430);
            this.ListBookbtn.Name = "ListBookbtn";
            this.ListBookbtn.Size = new System.Drawing.Size(110, 45);
            this.ListBookbtn.TabIndex = 25;
            this.ListBookbtn.Text = "신청목록";
            this.ListBookbtn.UseVisualStyleBackColor = false;
            this.ListBookbtn.Click += new System.EventHandler(this.ListBookbtn_Click);
            // 
            // PutBookbtn
            // 
            this.PutBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.PutBookbtn.Location = new System.Drawing.Point(980, 380);
            this.PutBookbtn.Name = "PutBookbtn";
            this.PutBookbtn.Size = new System.Drawing.Size(110, 45);
            this.PutBookbtn.TabIndex = 24;
            this.PutBookbtn.Text = "도서등록";
            this.PutBookbtn.UseVisualStyleBackColor = false;
            // 
            // DelBookbtn
            // 
            this.DelBookbtn.BackColor = System.Drawing.Color.LightGray;
            this.DelBookbtn.Location = new System.Drawing.Point(1100, 380);
            this.DelBookbtn.Name = "DelBookbtn";
            this.DelBookbtn.Size = new System.Drawing.Size(110, 45);
            this.DelBookbtn.TabIndex = 23;
            this.DelBookbtn.Text = "도서삭제";
            this.DelBookbtn.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(890, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "ISBN:";
            // 
            // MgrISBNtxt
            // 
            this.MgrISBNtxt.BackColor = System.Drawing.Color.White;
            this.MgrISBNtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrISBNtxt.Location = new System.Drawing.Point(998, 336);
            this.MgrISBNtxt.Name = "MgrISBNtxt";
            this.MgrISBNtxt.Size = new System.Drawing.Size(215, 26);
            this.MgrISBNtxt.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(890, 281);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "출판사:";
            // 
            // MgrPublishertxt
            // 
            this.MgrPublishertxt.BackColor = System.Drawing.Color.White;
            this.MgrPublishertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrPublishertxt.Location = new System.Drawing.Point(998, 276);
            this.MgrPublishertxt.Name = "MgrPublishertxt";
            this.MgrPublishertxt.Size = new System.Drawing.Size(215, 26);
            this.MgrPublishertxt.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(890, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "저자:";
            // 
            // MgrAuthortxt
            // 
            this.MgrAuthortxt.BackColor = System.Drawing.Color.White;
            this.MgrAuthortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrAuthortxt.Location = new System.Drawing.Point(998, 216);
            this.MgrAuthortxt.Name = "MgrAuthortxt";
            this.MgrAuthortxt.Size = new System.Drawing.Size(215, 26);
            this.MgrAuthortxt.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(890, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "발행일:";
            // 
            // MgrDatetxt
            // 
            this.MgrDatetxt.BackColor = System.Drawing.Color.White;
            this.MgrDatetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrDatetxt.Location = new System.Drawing.Point(998, 156);
            this.MgrDatetxt.Name = "MgrDatetxt";
            this.MgrDatetxt.Size = new System.Drawing.Size(215, 26);
            this.MgrDatetxt.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(890, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "가격:";
            // 
            // MgrPricetxt
            // 
            this.MgrPricetxt.BackColor = System.Drawing.Color.White;
            this.MgrPricetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrPricetxt.Location = new System.Drawing.Point(998, 96);
            this.MgrPricetxt.Name = "MgrPricetxt";
            this.MgrPricetxt.Size = new System.Drawing.Size(215, 26);
            this.MgrPricetxt.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(890, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "제목:";
            // 
            // MgrTitletxt
            // 
            this.MgrTitletxt.BackColor = System.Drawing.Color.White;
            this.MgrTitletxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MgrTitletxt.Location = new System.Drawing.Point(998, 36);
            this.MgrTitletxt.Name = "MgrTitletxt";
            this.MgrTitletxt.Size = new System.Drawing.Size(215, 26);
            this.MgrTitletxt.TabIndex = 11;
            // 
            // MgrGridView
            // 
            this.MgrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MgrGridView.Location = new System.Drawing.Point(0, 0);
            this.MgrGridView.Name = "MgrGridView";
            this.MgrGridView.RowTemplate.Height = 23;
            this.MgrGridView.Size = new System.Drawing.Size(871, 510);
            this.MgrGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Loginpnl);
            this.Controls.Add(this.Verlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Joinlbl);
            this.Controls.Add(this.Findlbl);
            this.Controls.Add(this.FindIDPasswordlbl);
            this.Controls.Add(this.PWtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.GoHomebtn);
            this.Controls.Add(this.MemberMenubtn);
            this.Controls.Add(this.BookMenubtn);
            this.Name = "MainForm";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Loginpnl.ResumeLayout(false);
            this.Loginpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Treeptr)).EndInit();
            this.User.ResumeLayout(false);
            this.UserData.ResumeLayout(false);
            this.UserData.PerformLayout();
            this.UserDataUpdatepnl.ResumeLayout(false);
            this.UserDataUpdatepnl.PerformLayout();
            this.OrderBook.ResumeLayout(false);
            this.OrderBook.PerformLayout();
            this.MgrOrder.ResumeLayout(false);
            this.Order.ResumeLayout(false);
            this.OrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Sucession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.UserRank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Book.ResumeLayout(false);
            this.Findbookpage.ResumeLayout(false);
            this.Findbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindGridView)).EndInit();
            this.Returnbookpage.ResumeLayout(false);
            this.Returnbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RtnGridView)).EndInit();
            this.Mgrbookpage.ResumeLayout(false);
            this.Mgrbookpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MgrGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookMenubtn;
        private System.Windows.Forms.Button MemberMenubtn;
        private System.Windows.Forms.Button GoHomebtn;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox PWtxt;
        private System.Windows.Forms.Label FindIDPasswordlbl;
        private System.Windows.Forms.LinkLabel Findlbl;
        private System.Windows.Forms.LinkLabel Joinlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label Verlbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Loginpnl;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Treeptr;
        private System.Windows.Forms.Label Nimlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TabControl Book;
        private System.Windows.Forms.TabPage Findbookpage;
        private System.Windows.Forms.TabPage Returnbookpage;
        private System.Windows.Forms.TabPage Mgrbookpage;
        private System.Windows.Forms.Button SrchBookbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SrchPublishertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Srchauthortxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SrchDatetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SrchISBNtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SrchTitletxt;
        private System.Windows.Forms.DataGridView FindGridView;
        private System.Windows.Forms.DataGridView RtnGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RtnDatetxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RtnPublishertxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RtnAuthortxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RtnTitletxt;
        private System.Windows.Forms.Button Longbtn;
        private System.Windows.Forms.Button Rtnbtn;
        private System.Windows.Forms.DataGridView MgrGridView;
        private System.Windows.Forms.Button ListBookbtn;
        private System.Windows.Forms.Button PutBookbtn;
        private System.Windows.Forms.Button DelBookbtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MgrISBNtxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MgrPublishertxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MgrAuthortxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MgrDatetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MgrPricetxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MgrTitletxt;
        private System.Windows.Forms.TabControl User;
        private System.Windows.Forms.TabPage UserData;
        private System.Windows.Forms.TabPage OrderBook;
        private System.Windows.Forms.Button Orderbtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox OrderDatetxt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox OrderPublishertxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox OrderAuthortxt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox OrderTitletxt;
        private System.Windows.Forms.TextBox CheckPWtxt;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UserDataUpdatepnl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox Teltxt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox UpdatePW2txt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox UpdatePW1txt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button SameCheckbtn;
        private System.Windows.Forms.TextBox UpdateIDtxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.RadioButton Frdo;
        private System.Windows.Forms.RadioButton Mrdo;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UserDelbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button Googlebtn;
        private System.Windows.Forms.TabPage MgrOrder;
        private System.Windows.Forms.TabControl Order;
        private System.Windows.Forms.TabPage OrderList;
        private System.Windows.Forms.Button BookPutbtn;
        private System.Windows.Forms.Button ListDelbtn;
        private System.Windows.Forms.Button AllSelectBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Sucession;
        private System.Windows.Forms.TabPage UserRank;
        private System.Windows.Forms.TabPage Database;
        private System.Windows.Forms.Button KickOkbtn;
        private System.Windows.Forms.Button ListDel1btn;
        private System.Windows.Forms.Button AllSelect1btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button RankDown;
        private System.Windows.Forms.Button RankUpbtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
