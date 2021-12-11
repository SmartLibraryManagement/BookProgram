using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMgr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //아이디 비밀번호 찾기
        {
            FindForm findform = new FindForm();
            findform.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "root" && PWtxt.Text == "1234") //로그인확인
            {
                Loginpnl.Visible = true;
            }
            else
            {
                MessageBox.Show("ID 혹은 비밀번호를 잘못 입력하셨거나 등록되지 않은 ID입니다.", "로그인 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void Loginbtn_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void Verlbl_Click(object sender, EventArgs e)
        {

        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtxt_Enter(object sender, EventArgs e)
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
       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Joinlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//회원가입
        {
            JoinForm joinform = new JoinForm();
            joinform.Show();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoHomebtn_Click(object sender, EventArgs e)
        {

        }

        private void MemberMenubtn_Click(object sender, EventArgs e)
        {

        }

        private void BookMenubtn_Click(object sender, EventArgs e)
        {

        }

        private void Userlbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logoutbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("로그아웃하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Loginpnl.Visible = false;
                Book.Visible = false;
                User.Visible = false;
                IDtxt.Text = "아이디";
                PWtxt.Text = "비밀번호";
                IDtxt.ForeColor = Color.Silver;
                PWtxt.ForeColor = Color.Silver;
            }



           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book.Visible = true;
            User.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book.Visible = false;
            User.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void CheckPWtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserDataUpdatepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SameCheckbtn_Click(object sender, EventArgs e)
        {
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

        private void Updatebtn_Click(object sender, EventArgs e) //수정완료 오류
        {
            if (UpdateIDtxt.Text == "" || UpdatePW1txt.Text == "" || UpdatePW2txt.Text == "" || Emailtxt.Text == "" || Nametxt.Text == "" || Teltxt.Text == "")
            {
                MessageBox.Show("필수 항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UpdatePW1txt.Text != UpdatePW2txt.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("회원정보를 수정하시겠습니까?", "회원정보수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserDataUpdatepnl.Visible = false;

                }
            }
        }

        private void Orderbtn_Click(object sender, EventArgs e) //도서신청
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://books.google.co.kr"); //구글도서사이트 연결
        }

        private void OrderBook_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void MgrOrder_Click(object sender, EventArgs e)
        {

        }


        private void ListBookbtn_Click(object sender, EventArgs e)
        {
            User.SelectedTab = User.TabPages[2];
            Order.SelectedTab = Order.TabPages[0];
            Book.Visible = false;
            User.Visible = true;
        }

        private void DatabaseMgrbtn_Click(object sender, EventArgs e) //데이터베이스관리
        {

        }

        private void RankMgrbtn_Click(object sender, EventArgs e)//회원등급관리
        {

        }

        private void BookPutbtn_Click(object sender, EventArgs e)
        {
            Book.SelectedTab = Book.TabPages[2];
            User.Visible = false;
            Book.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.Visible = false;
            Book.Visible = false;
        }

        private void UserRank_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.connect();
            DataTable dt = db.showDBTable("select * from user");
            dataGridView3.DataSource = dt;
        }
    }

}
