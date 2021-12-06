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
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        private void FindIDbtn_Click(object sender, EventArgs e) //아이디찾기버튼
        {
            if (FindName1txt.Text == "" || FindEmail1txt.Text == "")
            {
                MessageBox.Show("빈칸을 입력해주세요", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("이메일로 아이디를 보냈습니다", "아이디 찾기", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void FindPWbtn_Click(object sender, EventArgs e) //비밀번호 찾기 버튼
        {
            if (FindName2txt.Text == "" || FindEmail2txt.Text == ""||FindIDtxt.Text == "")
            {
                MessageBox.Show("빈칸을 입력해주세요", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("이메일로 비밀번호를 보냈습니다", "아이디 찾기", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Homebtn_Click(object sender, EventArgs e) //되돌아가기
        {
            this.Close();
        }
    }
}
