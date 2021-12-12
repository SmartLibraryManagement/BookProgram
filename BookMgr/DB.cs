using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMgr
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rentalbook;Uid=root;Pwd=123456");
        public void connect()
        {
            if (con.State.ToString().Equals("Closed"))
            {
                con.Open();
            }
        }

        public void close()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public void insertQuery(String sql)
        {

            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공");
                }
                else
                {
                    MessageBox.Show("실패");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public DataTable showDBTable(String sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public string userCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select PW from user where id = '" + ID + "'", con);
                com.Fill(ds);
                String str = ds.Tables[0].Rows[0]["PW"].ToString();
                return str;
        }
        public string userName(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select Name from user where id = '" + ID + "'", con);
            com.Fill(ds);
            String str = ds.Tables[0].Rows[0]["Name"].ToString();
            return str;
        }
    }
}
