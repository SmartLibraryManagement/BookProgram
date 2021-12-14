﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookMgr
{
    public partial class MainForm : Form
    {
        DB db = new DB();
        string uNum, bNum;
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //아이디 비밀번호 찾기
        {
            FindForm findform = new FindForm(); // 
            findform.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e) // 로그인 버튼
        {
            string id = IDtxt.Text;
            string pw = PWtxt.Text;
            db.connect();
            string login = db.PWCheck(id);
            string usrName = db.NameCheck(id);
            string rank = db.RankCheck(id);
            uNum = db.userCheck(id);
            db.close();
            if (login == pw) //로그인확인
            {
                Loginpnl.Visible = true;
                Namelbl.Text = usrName;
                if (rank == "3")
                {
                    Treeptr.Visible = true;
                    Ranklbl.Text = "나무";
                }
                else if (rank == "2")
                {
                    Leafptr.Visible = true;
                    Ranklbl.Text = "새싹";
                }
                else if (rank == "1")
                {
                    Seedptr.Visible = true;
                    Ranklbl.Text = "씨앗";
                }
            }
            else
            {
                MessageBox.Show("ID 혹은 비밀번호를 잘못 입력하셨거나 등록되지 않은 ID입니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void IDtxt_Enter(object sender, EventArgs e) // 
        {
            //텍스트박스 워터마크설정
            if (IDtxt.ForeColor == Color.Silver)
            {
                IDtxt.Text = "";
                IDtxt.ForeColor = Color.Black;
            }
        }

        private void IDtxt_Leave(object sender, EventArgs e)
        {
            //텍스트박스 워터마크설정
            if (IDtxt.Text == "")
            {
                IDtxt.Text = "아이디";
                IDtxt.ForeColor = Color.Silver;
            }
        }

        private void Passwordtxt_Enter(object sender, EventArgs e)
        {
            //텍스트박스 워터마크설정
            if (PWtxt.ForeColor == Color.Silver)
            {
                PWtxt.Text = "";
                PWtxt.ForeColor = Color.Black;
            }
        }

        private void Passwordtxt_Leave(object sender, EventArgs e)
        {
            //텍스트박스 워터마크설정
            if (PWtxt.Text == "")
            {
                PWtxt.Text = "비밀번호";
                PWtxt.ForeColor = Color.Silver;
            }
        }

        private void Joinlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // 회원가입
        {
            JoinForm joinform = new JoinForm();  // 회원가입 폼 열기
            joinform.Show();
        }
        private void Logoutbtn_Click_1(object sender, EventArgs e) // 로그아웃 버튼
        {
            DialogResult result = MessageBox.Show("로그아웃하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // 로그아웃 확인시
            {
                Loginpnl.Visible = false;
                Book.Visible = false;
                User.Visible = false;
                Treeptr.Visible = false;
                Leafptr.Visible = false;
                Seedptr.Visible = false;
                IDtxt.Text = "아이디";
                PWtxt.Text = "비밀번호";
                IDtxt.ForeColor = Color.Silver;
                PWtxt.ForeColor = Color.Silver;
            }
        }
        private void bookBtn_Click(object sender, EventArgs e) // 북메뉴 버튼
        {
            Book.Visible = true;
            User.Visible = false;
        }

        private void userBtn_Click(object sender, EventArgs e) // 유저메뉴 버튼
        {
            Book.Visible = false;
            User.Visible = true;
        }
        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (CheckPWtxt.Text == "1234") //비밀번호 확인
            {
                UserDataUpdatepnl.Visible = true;
                CheckPWtxt.Text = "";
            }
            else
            {
                MessageBox.Show("비밀번호를 잘못 입력했습니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SameCheckbtn_Click(object sender, EventArgs e) // 유저-회원정보수정-아이디중복확인 버튼
        {
            String UpID = UpdateIDtxt.Text;

            if (UpdateIDtxt.Text == "1234") //아이디중복화인
            {
                MessageBox.Show("이미 등록된 아이디입니다.", "아이디 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateIDtxt.Text = "";
                ;
            }
            else if (UpdateIDtxt.Text == "") //빈칸
            {
                MessageBox.Show("아이디를 입력해주세요.", "아이디 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateIDtxt.Text = "";
                ;
            }
            else
            {
                MessageBox.Show("사용가능한 아이디입니다.", "아이디 사용가능", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e) // 유저-회원정보수정-수정완료 버튼
        {

            if (UpdateIDtxt.Text == "" || UpdatePW1txt.Text == "" || UpdatePW2txt.Text == "" || Emailtxt.Text == "" || Nametxt.Text == "" || Teltxt.Text == "") // 입력오류 
            {
                MessageBox.Show("필수 항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UpdatePW1txt.Text != UpdatePW2txt.Text) // 비밀번호 확인 오류
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Frdo.Checked == false && Mrdo.Checked == false) // 성별 선택 오류
            {
                MessageBox.Show("성별을 선택하여 주세요.", "성별선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   // 수정완료 제어
                DialogResult result = MessageBox.Show("회원정보를 수정하시겠습니까?", "회원정보수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserDataUpdatepnl.Visible = false;

                }
            }
        }

        private void Orderbtn_Click(object sender, EventArgs e) // 유저-도서신청-신청하기버튼
        {
            if (OrderTitletxt.Text == "" || OrderAuthortxt.Text == "" || OrderPublishertxt.Text == "" || OrderDatetxt.Text == "")
            {
                MessageBox.Show("항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("신청이 완료되었습니다.", "도서신청", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {


                }
            }
        }

        private void Googlebtn_Click(object sender, EventArgs e) // 유저-도서신청-구글사이트버튼
        {
            System.Diagnostics.Process.Start("https://books.google.co.kr"); //구글도서사이트 연결
        }

        private void UserRank_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.connect();
            DataTable dt = db.showDBTable("select * from user");
            dataGridView3.DataSource = dt;
            db.close();
        }

        private void OrderList_Enter(object sender, EventArgs e)
        {
            db.connect();
            DataTable dt = db.showDBTable("select * from request");
            dataGridView1.DataSource = dt;
            db.close();
        }

        private void Findbookpage_Enter(object sender, EventArgs e)
        {
            db.connect();
            DataTable dt = db.showDBTable("select * from books");
            FindGridView.DataSource = dt;
            db.close();
        }

        private void Returnbookpage_Enter(object sender, EventArgs e)
        {
            db.connect();
            DataTable dt = db.showDBTable("select * from rental");
            RtnGridView.DataSource = dt;
            db.close();
        }

        private void Mgrbookpage_Enter(object sender, EventArgs e)
        {
            DB db = new DB();
            db.connect();
            DataTable dt = db.showDBTable("select * from books");
            MgrGridView.DataSource = dt;
            db.close();
        }
        private void UserDelbtn_Click(object sender, EventArgs e) // 사용자-회원정보 수정-회원 탈퇴 버튼
        {

        }

        private void AllSelectBtn_Click(object sender, EventArgs e) // 유저-신청관리-도서신청관리-전체선택 버튼
        {

        }

        private void ListDelbtn_Click(object sender, EventArgs e) // 유저-신청관리-도서신청관리-목록제거 버튼
        {

        }

        private void AllSelect1btn_Click(object sender, EventArgs e) // 유저-신청관리-회원탈퇴신청-전체선택 버튼
        {

        }

        private void ListDel1btn_Click(object sender, EventArgs e) // 유저-신청관리-회원탈퇴신청-목록제거 버튼
        {

        }
        private void BookPutbtn_Click(object sender, EventArgs e) // // 유저-신청관리-도서신청관리-도서등록 버튼
        {
            Book.SelectedTab = Book.TabPages[2];
            User.Visible = false;
            Book.Visible = true;
        }
        private void KickOkbtn_Click(object sender, EventArgs e)  // 유저-신청관리-회원탈퇴신청-탈퇴승인 버튼
        {

        }

        private void RankUpbtn_Click(object sender, EventArgs e)  // 유저-신청관리-회원등급관리-등급올리기 버튼
        {

        }

        private void RankDown_Click(object sender, EventArgs e) // 유저-신청관리-회원등급관리-등급내리기 버튼
        {

        }

        private void SrchBookbtn_Click(object sender, EventArgs e) // 도서-도서검색-도서검색 버튼
        {

            string title = SrchTitletxt.Text, publisher = SrchPublishertxt.Text, author = Srchauthortxt.Text, date = SrchDatetxt.Text, ISBN = SrchISBNtxt.Text;
            string query = "SELECT * FROM Books WHERE ";
            var list = new List<string>();
            if (title.Length > 0)
            {
                list.Add("title like '%" + title + "%'");
            }
            if (publisher.Length > 0)
            {
                list.Add("publisher like '%" + publisher + "%'");
            }
            if (author.Length > 0)
            {
                list.Add("author like '%" + author + "%'");
            }
            if (date.Length > 0)
            {
                list.Add("publish_date ='" + date + "'");
            }
            if (ISBN.Length > 0)
            {
                list.Add("isbn = '" + ISBN + "'");
            }
            if (list.Count > 0)
            {
                query += string.Join(" AND ", list.ToArray());
                db.connect();
                DataTable dt = db.bookSerach(query);
                FindGridView.DataSource = dt;
                db.close();
            }
            else
            {
                MessageBox.Show("항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Longbtn_Click(object sender, EventArgs e) // 도서-도서반납-연장하기 버튼
        {

        }

        private void Rtnbtn_Click(object sender, EventArgs e) // 도서-도서반납-반납하기 버튼
        {

        }

        private void PutBookbtn_Click(object sender, EventArgs e) // 도서-도서관리-도서등록 버튼
        {

        }

        private void DelBookbtn_Click(object sender, EventArgs e) // 도서-도서관리-도서삭제 버튼
        {

        }
        private void ListBookbtn_Click(object sender, EventArgs e) // 도서-도서관리-신청목록 버튼
        {
            User.SelectedTab = User.TabPages[2];
            Order.SelectedTab = Order.TabPages[0];
            Book.Visible = false;
            User.Visible = true;
        }

        private void rntBookBtn_Click(object sender, EventArgs e)
        {
            db.connect();
            db.rental(uNum, bNum);
            db.close();
        }



        private void FindGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bNum = FindGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                SrchTitletxt.Text = FindGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Srchauthortxt.Text = FindGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                SrchPublishertxt.Text = FindGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                SrchDatetxt.Text = FindGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                SrchISBNtxt.Text = FindGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
            }
        }
    }

}
