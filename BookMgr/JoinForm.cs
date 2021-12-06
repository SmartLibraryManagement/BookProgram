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
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CheckBox() //체크박스 확인
        {
            if (Agree1chk.Checked == true && Agree2chk.Checked == true)
            {
                AllAgreechk.Checked = true;
            }
            else if (Agree1chk.Checked == false || Agree2chk.Checked == false)
            {
                AllAgreechk.Checked = false;
            }
        }

        private void AllAgreechk_CheckedChanged(object sender, EventArgs e)//전체동의 코드
        {
            CheckBox();
        }

        private void NextPagebtn_Click(object sender, EventArgs e)//체크사항 확인
        {
            if(Agree1chk.Checked ==true && Agree2chk.Checked == true)
            {
                UserDatapnl.Visible = true;
            }
            else
            {
                MessageBox.Show("약관동의를 해주세요.", "약관 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Agree1chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox();
        }

        private void Agree2chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox();
        }

        private void PrevPage1btn_Click(object sender, EventArgs e)
        {
            UserDatapnl.Visible = false;
        }

        private void SameCheckbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "1234") //아이디중복화인
            {
                MessageBox.Show("이미 등록된 아이디입니다.", "아이디 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtxt.Text = "";
                
            }
            else
            {
                MessageBox.Show("사용가능한 아이디입니다.", "아이디 사용가능", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void NextPage1btn_Click(object sender, EventArgs e) //다음페이지 조건 충족확인
        {
            if (IDtxt.Text == "" || PW1txt.Text == "" || PW2txt.Text == "" || Emailtxt.Text == "" || Nametxt.Text == "" || Teltxt.Text == "")
            {
                MessageBox.Show("필수 항목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PW1txt.Text != PW2txt.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "비밀번호 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("회원가입을 하시겠습니까?", "회원가입", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Joinpnl.Visible = true;

                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
