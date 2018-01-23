using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace library4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool f = false;//是否戳过一次查询
        public int useid;
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                try
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
                    if (textBox1.Text != "")
                    {
                        mid += " AND bookid =" + textBox1.Text;
                    }
                    if (textBox4.Text != "")
                    {
                        mid += " AND bookpress LIKE '%" + textBox4.Text + "%'";
                    }
                    if (textBox3.Text != "")
                    {
                        mid += " AND bookauthor LIKE '%" + textBox3.Text + "%'";
                    }
                    if (textBox2.Text != "")
                    {
                        mid += " AND bookname LIKE '%" + textBox2.Text + "%'";
                    }
                    if (comboBox1.SelectedIndex != -1&&comboBox1.SelectedIndex!=0)
                    {
                        mid += "AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    }
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到查询结果！");
                        dataGridView1.DataSource = null;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        f = false;
                        comboBox1.SelectedIndex = -1;
                        
                        
                    }
                    f = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("信息输入有误，请重新输入");
                    dataGridView1.DataSource = null;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    f = false;
                    comboBox1.SelectedIndex = -1;
                }
            }
            else
            {
                if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes' AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    DataSet ds=sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到查询结果！");
                        dataGridView1.DataSource = null;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        f = false;
                        comboBox1.SelectedIndex = -1;
                        
                    }
                    f = true;
                }
                else
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book";
                    DataSet ds = sqluse.link(mid);
                    dataGridView1.DataSource = ds.Tables[0];
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    f = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                try
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
                    if (textBox1.Text != "")
                    {
                        mid += " AND bookid =" + textBox1.Text;
                    }
                    if (textBox4.Text != "")
                    {
                        mid += " AND bookpress LIKE '%" + textBox4.Text + "%'";
                    }
                    if (textBox3.Text != "")
                    {
                        mid += " AND bookauthor LIKE '%" + textBox3.Text + "%'";
                    }
                    if (textBox2.Text != "")
                    {
                        mid += " AND bookname LIKE '%" + textBox2.Text + "%'";
                    }
                    if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
                    {
                        mid += " AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    }
                    mid += " AND bookborrowable = 'yes'";
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到查询结果！");
                        dataGridView1.DataSource = null;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        f = false;
                        comboBox1.SelectedIndex = -1;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("信息输入有误，请重新输入");
                    dataGridView1.DataSource = null;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    f = false;
                    comboBox1.SelectedIndex = -1; 
                }
                f = true;

            }
            else
            {
                if (comboBox1.SelectedIndex != -1&&comboBox1.SelectedIndex != 0)
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes' AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到查询结果！");
                        dataGridView1.DataSource = null;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        f = false;
                        comboBox1.SelectedIndex = -1;
                       
                    }
                    f = true;
                }
                else
                {
                    string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookborrowable = 'yes'";
                    DataSet ds = sqluse.link(mid);
                    dataGridView1.DataSource = ds.Tables[0];
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    f = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == true)
            {
                string mid = "SELECT [bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
                if (textBox1.Text != "")
                {
                    mid += " AND bookid =" + textBox1.Text;
                }
                if (textBox4.Text != "")
                {
                    mid += " AND bookpress LIKE '%" + textBox4.Text + "%'";
                }
                if (textBox3.Text != "")
                {
                    mid += " AND bookauthor LIKE '%" + textBox3.Text + "%'";
                }
                if (textBox2.Text != "")
                {
                    mid += " AND bookname LIKE '%" + textBox2.Text + "%'";
                }
                if (comboBox1.SelectedIndex != -1&&comboBox1.SelectedIndex!=0)
                {
                    mid += "AND bookcategory = '" + comboBox1.SelectedItem + "'";
                }
                DataSet ds = sqluse.link(mid);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
                else
                {
                    MessageBox.Show("未找到查询结果！");
                    dataGridView1.DataSource = null;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    f = false;
                    comboBox1.SelectedIndex = -1;
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.AllowUserToAddRows = false;
            loginradioButton1.Checked = true;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string mid = "";
            if (logintextBoxusername.Text != "" && logintextBoxuserpassword.Text != "") //用户名栏和密码栏均不为空
            {
                if (radioButton1.Checked == true)//超级管理员登陆
                {
                    try
                    {
                        SqlDataReader read = sqluse.cmdexecutereader("SELECT spmanagername FROM Table_spmanager WHERE spmanagername='" + logintextBoxusername.Text + "' AND spmanagerpassword = '" + logintextBoxuserpassword.Text + "'");
                        if (read.HasRows)
                        {
                            supermanager sm = new supermanager(this);
                            this.Hide();
                            sm.Show();

                        }
                        else
                        {
                            MessageBox.Show("信息输入错误，请重新输入！");
                            logintextBoxusername.Text = "";
                            logintextBoxuserpassword.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (loginradioButton5.Checked == true)//管理员模式登陆
                    {
                        try
                        {
                            SqlDataReader read = sqluse.cmdexecutereader("SELECT managername FROM Table_manager WHERE managername='" + logintextBoxusername.Text + "' AND managerpassword = '" + logintextBoxuserpassword.Text + "'");
                            if (read.HasRows)
                            {
                                useid = Convert.ToInt32(sqluse.cmdexecutescalar("SELECT readerid FROM Table_reader WHERE readername='" + logintextBoxusername.Text + "'"));
                                Formmanager fm = new Formmanager(this);
                                this.Hide();
                                fm.Show();
                                
                            }
                            else
                            {
                                MessageBox.Show("信息输入错误，请重新输入！");
                                logintextBoxusername.Text = "";
                                logintextBoxuserpassword.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else//普通读者模式登陆
                    {
                        try
                        {
                            SqlDataReader read = sqluse.cmdexecutereader("SELECT readername FROM Table_reader WHERE readername='" + logintextBoxusername.Text + "' AND readerpassword = '" + logintextBoxuserpassword.Text + "'");
                            if (read.HasRows)
                            {
                                useid = Convert.ToInt32(sqluse.cmdexecutescalar("SELECT readerid FROM Table_reader WHERE readername='" + logintextBoxusername.Text + "'"));
                                reader fr = new reader(this);
                                this.Hide();
                                fr.Show();
                            }
                            else
                            {
                                MessageBox.Show("信息输入错误，请重新输入！");
                                logintextBoxusername.Text = "";
                                logintextBoxuserpassword.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请重新输入用户ID和密码！");
            }
        }

        
    }
}
