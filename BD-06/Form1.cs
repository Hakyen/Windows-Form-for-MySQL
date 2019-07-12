using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace BD_06
{
    public partial class Form1 : Form
    {
        string constr = "server=' '; database=' '; user=' '; password=''; port=' '; charset=utf8";
        MySqlConnection conn = null;
        MySqlDataAdapter adap = null;
        DataTable tabl = null;
        MySqlCommandBuilder combil = null;
        string sqlzap = "SELECT * FROM videofragment;";
        string tabstr = "show tables";
        DialogINs diains = new DialogINs();
        Dial_Sel dialsel = null;
        Otchet otch = new Otchet();
        Avtorization dialavtoriz = new Avtorization();
        public Form1()
        {
            InitializeComponent();
            //  printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            conn = new MySqlConnection(constr);
            try
            {
                conn.Open();
                if (dialavtoriz.ShowDialog() == DialogResult.OK)
                {
                    string sqlstr = "select password from users where login=\"" + dialavtoriz.Login_tb.Text + "\"";
                    MySqlCommand comsql = new MySqlCommand(sqlstr, conn);
                    if (dialavtoriz.password_tb.Text != comsql.ExecuteScalar().ToString()) {
                        MessageBox.Show("вы не тот за кого себя выдаете");
                    }

                }
                adap = new MySqlDataAdapter(sqlzap, conn);
                tabl = new DataTable();
                adap.Fill(tabl);
                MySqlDataAdapter adap1 = new MySqlDataAdapter(tabstr, conn);
                DataTable tab = new DataTable();
                adap1.Fill(tab);
                for (int i = 0; i < tab.Rows.Count; i++)
                    table_nav.Items.Insert(i, tab.Rows[i][0]);
                combil = new MySqlCommandBuilder(adap);
                bindingSource1.DataSource = tabl;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                conn.Close();
            } catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap.Update(tabl);
                conn.Close();



            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
                conn.Close();
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adap.Update(tabl);
                conn.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
                conn.Close();
            }
        }

        private void table_nav_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strsql = "SELECT * From " + table_nav.Items[table_nav.SelectedIndex].ToString() + ";";
            try
            {
                conn.Open();
                adap = new MySqlDataAdapter(strsql, conn);
                tabl.Dispose();
                tabl = new DataTable();
                adap.Fill(tabl);
                combil = new MySqlCommandBuilder(adap);
                bindingSource1.DataSource = tabl;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                conn.Close();

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
                conn.Close();
            }
        }

        private void mjnitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id, name_corp, name, developer, manuf_date, sqlins;

            if (diains.ShowDialog() == DialogResult.OK)
            {
                id = diains.id.Text;
                name_corp = diains.name_corp.Text;
                name = diains.name.Text;
                developer = diains.developer.Text;
                manuf_date = diains.Date_manufactured.Text;
                sqlins = "INSERT INTO  monitor VALUES(" + Convert.ToInt64(id)
                    + ",'" +
                    name_corp + "','" + name + "','" +
                    developer + "','" + manuf_date + "');";
                try
                {
                    conn.Open();
                    MySqlCommand sqlcom = new MySqlCommand(sqlins, conn);
                    sqlcom.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Запись добавлена");
                } catch (Exception ex1)
                {
                    MessageBox.Show(ex1.ToString());
                    conn.Close();
                }
            }
        }

        private void selectUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM USERS;";
            DataTable tablsh;
            using (conn)
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sqlstr, conn);
                MySqlDataReader reader = comm.ExecuteReader();
                tablsh = new DataTable();
                tablsh = reader.GetSchemaTable();
                tabl = new DataTable(); 
                List<DataColumn> listCols = new List<DataColumn>();
                if (tablsh != null)
                {
                    foreach (DataRow drow in tablsh.Rows)
                    {
                        string columnName = Convert.ToString(drow["ColumnName"]);
                        DataColumn column = new DataColumn(columnName, (Type)(drow["DataType"]));
                        column.Unique = (bool)drow["IsUnique"];
                        column.AllowDBNull = (bool)drow["AllowDBNull"];
                        column.AutoIncrement = (bool)drow["IsAutoIncrement"];
                        listCols.Add(column);
                        tabl.Columns.Add(column);
                    }
                }
                // Read rows from DataReader and populate the DataTable
                while (reader.Read())
                {
                    DataRow dataRow = tabl.NewRow();
                    for (int i = 0; i < listCols.Count; i++)
                    {
                        dataRow[((DataColumn)listCols[i])] = reader[i];
                    }
                    tabl.Rows.Add(dataRow);
                }
                
            }
            dialsel = new Dial_Sel();
            dialsel.datasel.DataSource = tabl;
            

            if (dialsel.ShowDialog() == DialogResult.OK) dialsel.Dispose();
            
        }

        private void selectHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM USERS;";
            string[] columnName;
            DataTable tablsh;
            string HTML_cod,path;
            path = @"D:\Users\Fridman\source\repos\bd-06-03-01\bd-06-03\BD-06\ot.html";
            using (conn)
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sqlstr, conn);
                MySqlDataReader reader = comm.ExecuteReader();
                tablsh = new DataTable();
                tablsh = reader.GetSchemaTable();
                 columnName = new string[tablsh.Rows.Count];
                if (tablsh != null)
                {
                    int i = 0;
                    foreach (DataRow drow in tablsh.Rows)
                    {

                        columnName[i] = Convert.ToString(drow["ColumnName"]);
                        i++;
                    }
                }
                HTML_cod = "<html><head><title>ОТЧЕТ</title><meta http-equiv=\"content - type\" content=\"text / html\"; charset =\" utf-8\"> </head>" +
                     "<body> <center><h1>Отчет по пользователям</h1><table border=\"1\">";
                File.WriteAllText(path, HTML_cod);
                HTML_cod = "<tr>";
                for (int j = 0; j < columnName.Length; j++)

                    HTML_cod += "<th>" + columnName[j] + "</th>";
                File.AppendAllText(path, HTML_cod);
                while (reader.Read())
                {
                    HTML_cod = "<tr>";
                    for (int j = 0; j < columnName.Length; j++)

                        HTML_cod += "<td>" + reader.GetString(j) + "</td>";
                     HTML_cod += "</tr>";
                File.AppendAllText(path, HTML_cod);
                }
                HTML_cod = "</center></body></html>";
                File.AppendAllText(path, HTML_cod);
                otch.ShowDialog();
               // if (otch.ShowDialog() == DialogResult.OK) ;
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
