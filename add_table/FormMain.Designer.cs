namespace MyInvoice
{
     partial class FormMain
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.label1 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label9 = new System.Windows.Forms.Label();
               this.textBoxNumberInvoice = new System.Windows.Forms.TextBox();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.textBoxName = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.textBoxDate = new System.Windows.Forms.TextBox();
               this.button6 = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               this.textBoxPhone = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.textBoxKeyCard = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.textBoxLocation = new System.Windows.Forms.TextBox();
               this.button8 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.White;
               this.label1.Location = new System.Drawing.Point(240, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(106, 40);
               this.label1.TabIndex = 1;
               this.label1.Text = "Invoices";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(178, 55);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(0, 13);
               this.label3.TabIndex = 3;
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(12, 141);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(555, 298);
               this.dataGridView1.TabIndex = 11;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Transparent;
               this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label9.Location = new System.Drawing.Point(6, 55);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(95, 34);
               this.label9.TabIndex = 13;
               this.label9.Text = "Number ";
               // 
               // textBoxNumberInvoice
               // 
               this.textBoxNumberInvoice.Location = new System.Drawing.Point(94, 59);
               this.textBoxNumberInvoice.Name = "textBoxNumberInvoice";
               this.textBoxNumberInvoice.Size = new System.Drawing.Size(187, 20);
               this.textBoxNumberInvoice.TabIndex = 14;
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(12, 445);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 35);
               this.button2.TabIndex = 15;
               this.button2.Text = "New";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(127, 445);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(75, 35);
               this.button3.TabIndex = 16;
               this.button3.Text = "Open";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(247, 445);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(75, 35);
               this.button4.TabIndex = 17;
               this.button4.Text = "Eidt";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.Location = new System.Drawing.Point(354, 445);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(85, 35);
               this.button5.TabIndex = 18;
               this.button5.Text = "Delete";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // textBoxName
               // 
               this.textBoxName.Location = new System.Drawing.Point(94, 85);
               this.textBoxName.Name = "textBoxName";
               this.textBoxName.Size = new System.Drawing.Size(187, 20);
               this.textBoxName.TabIndex = 19;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label2.Location = new System.Drawing.Point(6, 83);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(69, 34);
               this.label2.TabIndex = 20;
               this.label2.Text = "Name";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.Transparent;
               this.label8.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label8.Location = new System.Drawing.Point(6, 109);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(57, 34);
               this.label8.TabIndex = 21;
               this.label8.Text = "Date";
               // 
               // textBoxDate
               // 
               this.textBoxDate.Location = new System.Drawing.Point(94, 113);
               this.textBoxDate.Name = "textBoxDate";
               this.textBoxDate.Size = new System.Drawing.Size(187, 20);
               this.textBoxDate.TabIndex = 22;
               // 
               // button6
               // 
               this.button6.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button6.Location = new System.Drawing.Point(470, 445);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(97, 35);
               this.button6.TabIndex = 23;
               this.button6.Text = "Search";
               this.button6.UseVisualStyleBackColor = true;
               this.button6.Click += new System.EventHandler(this.button6_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(287, 55);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(71, 34);
               this.label4.TabIndex = 24;
               this.label4.Text = "Phone";
               // 
               // textBoxPhone
               // 
               this.textBoxPhone.Location = new System.Drawing.Point(379, 58);
               this.textBoxPhone.Name = "textBoxPhone";
               this.textBoxPhone.Size = new System.Drawing.Size(188, 20);
               this.textBoxPhone.TabIndex = 25;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.Transparent;
               this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.White;
               this.label5.Location = new System.Drawing.Point(287, 83);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(97, 34);
               this.label5.TabIndex = 26;
               this.label5.Text = "Key card";
               // 
               // textBoxKeyCard
               // 
               this.textBoxKeyCard.Location = new System.Drawing.Point(379, 85);
               this.textBoxKeyCard.Name = "textBoxKeyCard";
               this.textBoxKeyCard.Size = new System.Drawing.Size(188, 20);
               this.textBoxKeyCard.TabIndex = 27;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Transparent;
               this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label6.Location = new System.Drawing.Point(287, 107);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(94, 34);
               this.label6.TabIndex = 28;
               this.label6.Text = "Location";
               // 
               // textBoxLocation
               // 
               this.textBoxLocation.Location = new System.Drawing.Point(379, 115);
               this.textBoxLocation.Name = "textBoxLocation";
               this.textBoxLocation.Size = new System.Drawing.Size(188, 20);
               this.textBoxLocation.TabIndex = 29;
               // 
               // button8
               // 
               this.button8.BackColor = System.Drawing.Color.Red;
               this.button8.Location = new System.Drawing.Point(548, 9);
               this.button8.Name = "button8";
               this.button8.Size = new System.Drawing.Size(19, 23);
               this.button8.TabIndex = 54;
               this.button8.UseVisualStyleBackColor = false;
               this.button8.Click += new System.EventHandler(this.button8_Click);
               // 
               // FormMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.BackgroundImage = global::myInvoice.Properties.Resources.photo_2021_09_15_20_16_16;
               this.ClientSize = new System.Drawing.Size(579, 488);
               this.Controls.Add(this.button8);
               this.Controls.Add(this.textBoxLocation);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.textBoxKeyCard);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.textBoxPhone);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.button6);
               this.Controls.Add(this.textBoxDate);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBoxName);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.textBoxNumberInvoice);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "home";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox textBoxNumberInvoice;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.TextBox textBoxName;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textBoxDate;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBoxPhone;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox textBoxKeyCard;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox textBoxLocation;
          private System.Windows.Forms.Button button8;
     }
}