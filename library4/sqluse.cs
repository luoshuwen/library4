using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace library4
{
    static class sqluse
    {
        static string s = @"Data Source=localhost;
                     Initial Catalog=library3;
                     database=library3;
                     MultipleActiveResultSets=true;
                     User ID=sa;Password=123456";
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="a">sql语句</param>
        public static DataSet link(string a)
        {
                SqlConnection conn;
                conn = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string mid = a;
                SqlDataAdapter sda = new SqlDataAdapter(mid, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            
        }

        public static SqlDataReader cmdexecutereader(string a)
        {
            SqlConnection conn;
            conn = new SqlConnection(s);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = a;
            SqlDataReader reader = cmd.ExecuteReader();//SqlDataReader 
            return reader;
        }

        public static string cmdexecutescalar(string a)
        {
            SqlConnection conn;
            conn = new SqlConnection(s);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = a;
            string k = cmd.ExecuteScalar().ToString();
            conn.Close();
            return k;
        }

        public static void cmdexecutenonquery(string a)
        {
            SqlConnection conn;
            conn = new SqlConnection(s);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = a;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        /// <summary>
        /// 该用户可否借阅该书
        /// </summary>
        /// <param name="uname">用户id</param>
        /// <param name="bname">书id</param>
        /// <returns></returns>
        public static bool booluser(string uname,string bname)
        {

            string bookborrowable = sqluse.cmdexecutescalar("SELECT bookborrowable FROM Table_book WHERE bookid="+bname);
            string reliable = sqluse.cmdexecutescalar("SELECT readerreliable FROM Table_reader WHERE readerid=" + uname);
            int uown = Convert.ToInt32( sqluse.cmdexecutescalar("SELECT readerown FROM Table_reader WHERE readerid="+uname));
            int uallow = Convert.ToInt32(sqluse.cmdexecutescalar("SELECT readerallowed FROM Table_reader WHERE readerid=" + uname));
            if (bookborrowable == "yes" && reliable == "yes" && uown < uallow)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
