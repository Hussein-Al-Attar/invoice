using myInvoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInvoice
{
     public partial class FormMain : Form
     {
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\96478\documents\visual studio 2012\Projects\add_table\add_table\price_pieces.mdf;Integrated Security=True");
          public FormMain()
          {
               InitializeComponent();
               con.Open();
               DateTime now = DateTime.Now;
               textBoxDate.Text = now.ToString();
               updataVeiwTableInvoices();
          }
          private void updataVeiwTableInvoices()
          {
               SqlDataAdapter da = new SqlDataAdapter("select * from invoices", con);
               DataTable dt = new DataTable();
               da.Fill(dt);
               dataGridView1.DataSource = dt;
          }
         

          private void button2_Click(object sender, EventArgs e)
          {
               if (textBoxName.Text == "")
               {
                    textBoxName.Text = "Anonymous";
               }
               if (textBoxLocation.Text=="")
               {
                    textBoxLocation.Text = "not have location";
               }
               if (textBoxKeyCard.Text == "")
               {
                    textBoxKeyCard.Text = "0";
               }
               if (textBoxPhone.Text == "")
               {
                    textBoxPhone.Text = "0";
               }
               int ID;
               SqlCommand cmd1 = new SqlCommand("select * from invoices where [number invoice] >= 0 ", con);
               SqlDataReader r = cmd1.ExecuteReader();
               if (r.HasRows)
               {
               r.Close();
               SqlCommand cmd = new SqlCommand("select max([number invoice]) from invoices ", con);
               ID= int.Parse(cmd.ExecuteScalar().ToString()) + 1;
               }
               else
               {
                    r.Close();
                    ID = 0;
               }            
              
               
               SqlCommand i = new SqlCommand("insert into  invoices values(" + ID + ",'" + textBoxName.Text+"','" + textBoxDate.Text + "'," + textBoxPhone.Text + "," + textBoxKeyCard.Text + ",'" + textBoxLocation.Text + "')", con);
               i.ExecuteNonQuery();

               SqlCommand table = new SqlCommand("CREATE TABLE [dbo].[invoice" + ID + "](	[number] INT NOT NULL PRIMARY KEY DEFAULT 0, [type] varchar(50) NOT NULL,[description] varchar(50) NOT NULL, [count] INT NOT NULL, [price] INT NOT NULL, [sum] INT NOT NULL)", con);
               table.ExecuteNonQuery();

               updataVeiwTableInvoices();


              
          }

     

          private void button4_Click(object sender, EventArgs e)//up data
          {
               if (textBoxLocation.Text == "")
               {
                    textBoxLocation.Text = "not have location";
               }
               if (textBoxKeyCard.Text == "")
               {
                    textBoxKeyCard.Text = "0";
               }
               if (textBoxPhone.Text == "")
               {
                    textBoxPhone.Text = "000000000000000";
               }
               if (textBoxNumberInvoice.Text == "")
               {
                    MessageBox.Show("number Invoice is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from invoices where [number invoice] = " + textBoxNumberInvoice.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         SqlCommand i = new SqlCommand("update invoices set name  ='" + textBoxName.Text + "',date ='" + textBoxDate.Text + "',phone =" + textBoxPhone.Text + ", [key card] =" + textBoxKeyCard.Text + " , location ='" + textBoxLocation.Text + "' where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                         i.ExecuteNonQuery();
                         updataVeiwTableInvoices();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }

               }
             
          }

          private void button5_Click(object sender, EventArgs e)
          {
               if (textBoxNumberInvoice.Text == "")
               {
                    MessageBox.Show("number Invoice is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from invoices where [number invoice] = " + textBoxNumberInvoice.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         SqlCommand i = new SqlCommand("delete  from  invoices where [number invoice] = " + textBoxNumberInvoice.Text + "", con);
                         i.ExecuteNonQuery();
                         SqlCommand table = new SqlCommand("drop table [dbo].[Invoice" + textBoxNumberInvoice.Text + "]", con);
                         table.ExecuteNonQuery();

                         updataVeiwTableInvoices();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }

               }
              
          }

          private void button3_Click(object sender, EventArgs e)
          {
               if (textBoxNumberInvoice.Text == "")
               {
                    MessageBox.Show("number Invoice is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from invoices where [number invoice] = " + textBoxNumberInvoice.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         FormInvoice Form1 = new FormInvoice(int.Parse(textBoxNumberInvoice.Text));
                         Form1.Show();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }

               }
              
               
          }

         

          private void button6_Click(object sender, EventArgs e)
          {
               if (textBoxNumberInvoice.Text == "")
               {
                    MessageBox.Show("number Invoice is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from invoices where [number invoice] = " + textBoxNumberInvoice.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                    SqlCommand name = new SqlCommand("select name from invoices where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                    SqlCommand date = new SqlCommand("select date from invoices where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                    SqlCommand phone = new SqlCommand("select phone from invoices where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                    SqlCommand keyCard = new SqlCommand("select [key Card] from invoices where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                    SqlCommand Location = new SqlCommand("select Location from invoices where [number invoice] =" + textBoxNumberInvoice.Text + "", con);
                    MessageBox.Show("name = " + name.ExecuteScalar().ToString() + ", date = " + date.ExecuteScalar().ToString() + ", phone = " + phone.ExecuteScalar().ToString() + ", key card = " + keyCard.ExecuteScalar().ToString() + ", Loaction = " + Location.ExecuteScalar().ToString());
                    updataVeiwTableInvoices();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }
                   
               }
          }

          private void button8_Click(object sender, EventArgs e)
          {
               con.Close();
               Application.Exit();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               textBoxNumberInvoice.Text = e.RowIndex+"";
          }

        

          

         
         
     }
}
