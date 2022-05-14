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

namespace myInvoice
{
     public partial class FormInvoice : Form
     {
          String tableName;
          SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\96478\documents\visual studio 2012\Projects\add_table\add_table\price_pieces.mdf;Integrated Security=True");
          public FormInvoice(int invoice)
          {
               con.Open();
               InitializeComponent();
               numberInvoice.Text = invoice + "";
               tableName="[dbo].[invoice" + invoice + "]";
               updataVeiwTableInvoice();

          }
          private void updataVeiwTableInvoice()
          {
               SqlDataAdapter da = new SqlDataAdapter("select * from "+tableName+"", con);
               DataTable dt = new DataTable();
               da.Fill(dt);
               dataGridView1.DataSource = dt;
               SqlCommand cmd = new SqlCommand("select * from " + tableName + "where number >= 0 ", con);
               SqlDataReader r = cmd.ExecuteReader();
               if (r.HasRows)
               {
                    r.Close();
                    SqlCommand cmd1 = new SqlCommand("select sum(sum) from " + tableName + " ", con);
                    labelSum.Text = cmd1.ExecuteScalar().ToString();
               }
               else
               {
                    r.Close();
               }
               SqlCommand cmd2 = new SqlCommand("select * from " + tableName + "where number >= 0 ", con);
               SqlDataReader r1 = cmd2.ExecuteReader();
               if (r1.HasRows)
               {
                    r1.Close();
                    SqlCommand cmd1 = new SqlCommand("select count(number) from " + tableName + " ", con);
                    labelCount.Text = cmd1.ExecuteScalar().ToString();
               }
               else
               {
                    r1.Close();
               }
          }
       

          private void button2_Click(object sender, EventArgs e)
          {
               if (textBoxDiscation.Text == "")
               {
                    textBoxDiscation.Text = "...";
               }
               if (textBoxCount.Text == "")
               {
                    textBoxCount.Text = "0";
               }
               if (textBoxPrice.Text == "")
               {
                    textBoxPrice.Text = "0";
               }
               if (textBoxType.Text == "")
               {
                    textBoxType.Text = "....";
               }
               int ID=0;
               SqlCommand cmd = new SqlCommand("select * from " + tableName + "where number >= 0 ", con);
               SqlDataReader r = cmd.ExecuteReader();
               if (r.HasRows)
               {
                    r.Close();
                    SqlCommand cmd1 = new SqlCommand("select max(number) from " + tableName + " ", con);
                    ID = int.Parse(cmd1.ExecuteScalar().ToString()) + 1;

               }
               else
               { 
                    r.Close();
               }
              
               SqlCommand i = new SqlCommand("insert into  " + tableName + " values(" + ID + ",'" + textBoxType.Text+ "','" + textBoxDiscation.Text + "'," + textBoxCount.Text+ "," + textBoxPrice.Text + "," + (int.Parse(textBoxCount.Text)*int.Parse(textBoxPrice.Text)).ToString()+ ")", con);
               i.ExecuteNonQuery();
               updataVeiwTableInvoice();
               
               
          }

          private void button4_Click(object sender, EventArgs e)
          {
               if (textBoxDiscation.Text == "")
               {
                    textBoxDiscation.Text = "...";
               }
               if (textBoxCount.Text == "")
               {
                    textBoxCount.Text = "0";
               }
               if (textBoxPrice.Text == "")
               {
                    textBoxPrice.Text = "0";
               }
               if (textBoxType.Text == "")
               {
                    textBoxType.Text = "....";
               }
               if (textBoxNumber.Text == "")
               {
                    MessageBox.Show("box number is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from " + tableName + "where number = " + textBoxNumber.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         SqlCommand i = new SqlCommand("update " + tableName + " set type  ='" + textBoxType.Text + "',description ='" + textBoxDiscation.Text + "',count = " + textBoxCount.Text + ", price =" + textBoxPrice.Text + " , sum = " + int.Parse(textBoxCount.Text) * int.Parse(textBoxPrice.Text) + " where [number] =" + textBoxNumber.Text + "", con);
                         i.ExecuteNonQuery();
                         updataVeiwTableInvoice();

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
               if (textBoxNumber.Text == "")
               {
                    MessageBox.Show("box number is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from " + tableName + "where number = " + textBoxNumber.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         SqlCommand i = new SqlCommand("delete  from  " + tableName + " where number = " + textBoxNumber.Text + "", con);
                         i.ExecuteNonQuery();
                         updataVeiwTableInvoice();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }


               }
               
              
              

          }

          private void button6_Click(object sender, EventArgs e){

               if (textBoxNumber.Text == "")
               {
                    MessageBox.Show("box number is empty");
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("select * from " + tableName + "where number = " + textBoxNumber.Text + " ", con);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                         r.Close();
                         SqlCommand type = new SqlCommand("select type from " + tableName + "  where [number ] =" + textBoxNumber.Text + "", con);
                         SqlCommand description = new SqlCommand("select description from " + tableName + "  where [number] =" + textBoxNumber.Text + "", con);
                         SqlCommand count = new SqlCommand("select count from " + tableName + "  where [number] =" + textBoxNumber.Text + "", con);
                         SqlCommand price = new SqlCommand("select price from " + tableName + "  where [number] =" + textBoxNumber.Text + "", con);
                         SqlCommand sum = new SqlCommand("select sum from " + tableName + "  where [number] =" + textBoxNumber.Text + "", con);
                         MessageBox.Show("type = " + type.ExecuteScalar().ToString() + ", description = " + description.ExecuteScalar().ToString() + ", count = " + count.ExecuteScalar().ToString() + ",price = " + price.ExecuteScalar().ToString() + ", sum = " + sum.ExecuteScalar().ToString());
                         updataVeiwTableInvoice();

                    }
                    else
                    {
                         r.Close();
                         MessageBox.Show("number incorrect ");
                    }
              
             
               }
              
          }

          private void button1_Click(object sender, EventArgs e)
          {
               con.Close();
               Application.Exit();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               textBoxNumber.Text = e.RowIndex + "";
          }
     }
}
