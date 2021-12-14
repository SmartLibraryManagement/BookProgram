using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMgr
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rentalbook;Uid=root;Pwd=1234");
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
            MySqlDataAdapter com = new MySqlDataAdapter("select User_Num from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["User_Num"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string PWCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select PW from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["PW"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string NameCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select Name from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["Name"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string RankCheck(string ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select Name from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["Rank"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public bool dupCheck(string ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select * from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["ID"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable bookSerach(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void rental(string uNum, string bNum)
        {
            DateTime date = DateTime.Today;
            string Tdate = date.ToString("d");
            string rDate = date.AddDays(14).ToString("d");
            string sql = "insert into rental(Book_Num, User_Num, Rental_Date, Return_Date) values ('" + bNum + "', '" + uNum + "', '" + Tdate + "', '" + rDate + "');" ;
           
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
    }
}
