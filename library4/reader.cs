using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library4
{
    public partial class reader : Form
    {
        Form1 f1;
        public reader(Form1 q)
        {
            InitializeComponent();
            f1 = q;
        }
        bool f = false;//是否戳过一次查询
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void reader_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                try
                {
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
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
                        mid += "AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    }
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                        columnb.Name = "button";
                        columnb.Text = "借阅";
                        columnb.HeaderText = "操作";
                        columnb.UseColumnTextForButtonValue = true;
                        columnb.Visible = true;
                        columnb.Width = 50;
                        dataGridView1.Columns.Insert(0, columnb);
                        DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                        columnb2.Name = "button2";
                        columnb2.Text = "预约";
                        columnb2.HeaderText = "操作2";
                        columnb2.Width = 40;
                        columnb2.UseColumnTextForButtonValue = true;
                        columnb2.Visible = true;
                        dataGridView1.Columns.Insert(1, columnb2);
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                            if (i > 1)
                            {
                                dataGridView1.Columns[i].ReadOnly = true; 
                            }
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
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes' AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                        columnb.Name = "button";
                        columnb.Text = "借阅";
                        columnb.HeaderText = "操作";
                        columnb.Width = 40;
                        columnb.UseColumnTextForButtonValue = true;
                        columnb.Visible = true;
                        dataGridView1.Columns.Insert(0, columnb);
                        DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                        columnb2.Name = "button2";
                        columnb2.Text = "预约";
                        columnb2.HeaderText = "操作2";
                        columnb2.Width = 40;
                        columnb2.UseColumnTextForButtonValue = true;
                        columnb2.Visible = true;
                        dataGridView1.Columns.Insert(1, columnb2);
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                            if (i > 1)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
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
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book";
                    DataSet ds = sqluse.link(mid);
                    dataGridView1.DataSource = ds.Tables[0];
                    DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                    columnb.Name = "button";
                    columnb.Text = "借阅";
                    columnb.HeaderText = "操作";
                    columnb.Width = 40;
                    columnb.UseColumnTextForButtonValue = true;
                    columnb.Visible = true;
                    dataGridView1.Columns.Insert(0, columnb);
                    DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                    columnb2.Name = "button2";
                    columnb2.Text = "预约";
                    columnb2.HeaderText = "操作2";
                    columnb2.Width = 40;
                    columnb2.UseColumnTextForButtonValue = true;
                    columnb2.Visible = true;
                    dataGridView1.Columns.Insert(1, columnb2);
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        if (i > 1)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
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
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
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
                        DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                        columnb.Name = "button";
                        columnb.Text = "借阅";
                        columnb.HeaderText = "操作";
                        columnb.Width = 40;
                        columnb.UseColumnTextForButtonValue = true;
                        columnb.Visible = true;
                        dataGridView1.Columns.Insert(0, columnb);
                        DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                        columnb2.Name = "button2";
                        columnb2.Text = "预约";
                        columnb2.HeaderText = "操作2";
                        columnb2.Width = 40;
                        columnb2.UseColumnTextForButtonValue = true;
                        columnb2.Visible = true;
                        dataGridView1.Columns.Insert(1, columnb2);
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                            if (i > 1)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
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
                if (comboBox1.SelectedIndex != -1 && comboBox1.SelectedIndex != 0)
                {
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes' AND bookcategory = '" + comboBox1.SelectedItem + "'";
                    DataSet ds = sqluse.link(mid);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                        columnb.Name = "button";
                        columnb.Text = "借阅";
                        columnb.HeaderText = "操作";
                        columnb.Width = 40;
                        columnb.UseColumnTextForButtonValue = true;
                        columnb.Visible = true;
                        dataGridView1.Columns.Insert(0, columnb);
                        DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                        columnb2.Name = "button2";
                        columnb2.Text = "预约";
                        columnb2.HeaderText = "操作2";
                        columnb2.Width = 40;
                        columnb2.UseColumnTextForButtonValue = true;
                        columnb2.Visible = true;
                        dataGridView1.Columns.Insert(1, columnb2);
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                            if (i > 1)
                            {
                                dataGridView1.Columns[i].ReadOnly = true;
                            }
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
                    string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookborrowable = 'yes'";
                    DataSet ds = sqluse.link(mid);
                    dataGridView1.DataSource = ds.Tables[0];
                    DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                    columnb.Name = "button";
                    columnb.Text = "借阅";
                    columnb.HeaderText = "操作";
                    columnb.Width = 40;
                    columnb.UseColumnTextForButtonValue = true;
                    columnb.Visible = true;
                    dataGridView1.Columns.Insert(0, columnb);
                    DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                    columnb2.Name = "button2";
                    columnb2.Text = "预约";
                    columnb2.HeaderText = "操作2";
                    columnb2.Width = 40;
                    columnb2.UseColumnTextForButtonValue = true;
                    columnb2.Visible = true;
                    dataGridView1.Columns.Insert(1, columnb2);
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        if (i > 1)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
                    }
                    f = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f == true)
            {
                string mid = "SELECT [bookid] as 书编号,[bookname] as 书名,[bookauthor] as 作者,[bookpress] as 出版社,[bookborrowable] as 是否可借阅,[bookprice] as 价格,[bookcategory] as 分类 FROM Table_book WHERE bookstate = 'yes'";
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
                    mid += "AND bookcategory = '" + comboBox1.SelectedItem + "'";
                }
                DataSet ds = sqluse.link(mid);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    DataGridViewButtonColumn columnb = new DataGridViewButtonColumn();
                    columnb.Name = "button";
                    columnb.Text = "借阅";
                    columnb.HeaderText = "操作";
                    columnb.Width = 40;
                    columnb.UseColumnTextForButtonValue = true;
                    columnb.Visible = true;
                    dataGridView1.Columns.Insert(0, columnb);
                    DataGridViewButtonColumn columnb2 = new DataGridViewButtonColumn();
                    columnb2.Name = "button2";
                    columnb2.Text = "预约";
                    columnb2.HeaderText = "操作2";
                    columnb2.Width = 40;
                    columnb2.UseColumnTextForButtonValue = true;
                    columnb2.Visible = true;
                    dataGridView1.Columns.Insert(1, columnb2);
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        if (i > 1)
                        {
                            dataGridView1.Columns[i].ReadOnly = true;
                        }
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

        private void reader_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int clickIndex=e.ColumnIndex;
            if (clickIndex == 0)//用户戳了借阅
            {
                bool user = sqluse.booluser(f1.useid.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (user == true)//可借
                {
                    sqluse.cmdexecutenonquery("UPDATE Table_book SET bookborrowable='no' WHERE bookid=" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    int rown = Convert.ToInt32(sqluse.cmdexecutescalar("SELECT readerown FROM Table_reader WHERE readerid=" + f1.useid.ToString()));
                    rown += 1;
                    sqluse.cmdexecutenonquery("UPDATE Table_reader SET readerown=" + rown.ToString() + " WHERE readerid=" + f1.useid.ToString());
                    string bname=sqluse.cmdexecutescalar("select bookname from Table_book where bookid="+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    string bauthor=sqluse.cmdexecutescalar("select bookauthor from Table_book where bookid="+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    string bpress = sqluse.cmdexecutescalar("select bookpress from Table_book where bookid=" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DateTime dt = DateTime.Now;
                    sqluse.cmdexecutenonquery("INSERT INTO Table_record (recordreaderid,recordbookid,recordbookname,recordbookauthor,recordbookpress,recordborrowdate,recorddeadline) VALUES (" + f1.useid.ToString() + " ," + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " ,'" + bname + " ', '" + bauthor + " ','" + bpress + " ','" + dt + "','" + dt.AddDays(30d) + "')");
                    MessageBox.Show("借书成功！");
                    dataGridView1.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("您当前不符合借书条件，借书失败！");
                }
            }
            if (clickIndex == 1)//用户戳了预约
            {
 
            }
        }
    }
}
