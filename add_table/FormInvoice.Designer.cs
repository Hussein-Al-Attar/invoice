namespace myInvoice
{
     partial class FormInvoice
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
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label1 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.textBoxDiscation = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.textBoxPrice = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.textBoxCount = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.textBoxType = new System.Windows.Forms.TextBox();
               this.textBoxNumber = new System.Windows.Forms.TextBox();
               this.label9 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.button6 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.label10 = new System.Windows.Forms.Label();
               this.numberInvoice = new System.Windows.Forms.Label();
               this.labelSum = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.labelCount = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(12, 156);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(558, 258);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label1.Location = new System.Drawing.Point(205, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(184, 40);
               this.label1.TabIndex = 1;
               this.label1.Text = "Invoice number";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(185, 82);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(0, 13);
               this.label5.TabIndex = 5;
               // 
               // textBoxDiscation
               // 
               this.textBoxDiscation.Location = new System.Drawing.Point(382, 85);
               this.textBoxDiscation.Multiline = true;
               this.textBoxDiscation.Name = "textBoxDiscation";
               this.textBoxDiscation.Size = new System.Drawing.Size(188, 48);
               this.textBoxDiscation.TabIndex = 40;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label2.Location = new System.Drawing.Point(290, 85);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(100, 34);
               this.label2.TabIndex = 39;
               this.label2.Text = "Discation";
               // 
               // textBoxPrice
               // 
               this.textBoxPrice.Location = new System.Drawing.Point(382, 58);
               this.textBoxPrice.Name = "textBoxPrice";
               this.textBoxPrice.Size = new System.Drawing.Size(188, 20);
               this.textBoxPrice.TabIndex = 38;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(290, 55);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(62, 34);
               this.label4.TabIndex = 37;
               this.label4.Text = "Price";
               // 
               // textBoxCount
               // 
               this.textBoxCount.Location = new System.Drawing.Point(97, 113);
               this.textBoxCount.Name = "textBoxCount";
               this.textBoxCount.Size = new System.Drawing.Size(187, 20);
               this.textBoxCount.TabIndex = 36;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.Transparent;
               this.label8.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.Color.White;
               this.label8.Location = new System.Drawing.Point(8, 109);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(69, 34);
               this.label8.TabIndex = 35;
               this.label8.Text = "Count";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.White;
               this.label3.Location = new System.Drawing.Point(10, 82);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(61, 34);
               this.label3.TabIndex = 34;
               this.label3.Text = "Type";
               // 
               // textBoxType
               // 
               this.textBoxType.Location = new System.Drawing.Point(97, 85);
               this.textBoxType.Name = "textBoxType";
               this.textBoxType.Size = new System.Drawing.Size(187, 20);
               this.textBoxType.TabIndex = 33;
               // 
               // textBoxNumber
               // 
               this.textBoxNumber.Location = new System.Drawing.Point(97, 59);
               this.textBoxNumber.Name = "textBoxNumber";
               this.textBoxNumber.Size = new System.Drawing.Size(187, 20);
               this.textBoxNumber.TabIndex = 32;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.BackColor = System.Drawing.Color.Transparent;
               this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.label9.Location = new System.Drawing.Point(10, 58);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(95, 34);
               this.label9.TabIndex = 31;
               this.label9.Text = "Number ";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(181, 55);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(0, 13);
               this.label7.TabIndex = 30;
               // 
               // button6
               // 
               this.button6.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button6.Location = new System.Drawing.Point(296, 432);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(86, 38);
               this.button6.TabIndex = 47;
               this.button6.Text = "Search";
               this.button6.UseVisualStyleBackColor = true;
               this.button6.Click += new System.EventHandler(this.button6_Click);
               // 
               // button5
               // 
               this.button5.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.Location = new System.Drawing.Point(196, 432);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(88, 38);
               this.button5.TabIndex = 46;
               this.button5.Text = "Delete";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button4
               // 
               this.button4.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(106, 432);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(75, 38);
               this.button4.TabIndex = 45;
               this.button4.Text = "Eidt";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(12, 432);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 38);
               this.button2.TabIndex = 43;
               this.button2.Text = "New";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.BackColor = System.Drawing.Color.Transparent;
               this.label10.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.White;
               this.label10.Location = new System.Drawing.Point(388, 445);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(119, 34);
               this.label10.TabIndex = 48;
               this.label10.Text = "Summation";
               // 
               // numberInvoice
               // 
               this.numberInvoice.AutoSize = true;
               this.numberInvoice.BackColor = System.Drawing.Color.Transparent;
               this.numberInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.numberInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.numberInvoice.Location = new System.Drawing.Point(418, 13);
               this.numberInvoice.Name = "numberInvoice";
               this.numberInvoice.Size = new System.Drawing.Size(24, 26);
               this.numberInvoice.TabIndex = 49;
               this.numberInvoice.Text = "0";
               // 
               // labelSum
               // 
               this.labelSum.AutoSize = true;
               this.labelSum.BackColor = System.Drawing.Color.Transparent;
               this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelSum.ForeColor = System.Drawing.Color.White;
               this.labelSum.Location = new System.Drawing.Point(532, 445);
               this.labelSum.Name = "labelSum";
               this.labelSum.Size = new System.Drawing.Size(24, 26);
               this.labelSum.TabIndex = 50;
               this.labelSum.Text = "0";
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Red;
               this.button1.Location = new System.Drawing.Point(552, 9);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(19, 23);
               this.button1.TabIndex = 51;
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Transparent;
               this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(388, 417);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(120, 34);
               this.label6.TabIndex = 52;
               this.label6.Text = "Count price";
               // 
               // labelCount
               // 
               this.labelCount.AutoSize = true;
               this.labelCount.BackColor = System.Drawing.Color.Transparent;
               this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelCount.ForeColor = System.Drawing.Color.White;
               this.labelCount.Location = new System.Drawing.Point(532, 419);
               this.labelCount.Name = "labelCount";
               this.labelCount.Size = new System.Drawing.Size(24, 26);
               this.labelCount.TabIndex = 53;
               this.labelCount.Text = "0";
               // 
               // FormInvoice
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.BackgroundImage = global::myInvoice.Properties.Resources.photo_2021_09_15_20_16_16;
               this.ClientSize = new System.Drawing.Size(583, 479);
               this.Controls.Add(this.labelCount);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.labelSum);
               this.Controls.Add(this.numberInvoice);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.button6);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.textBoxDiscation);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textBoxPrice);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBoxCount);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBoxType);
               this.Controls.Add(this.textBoxNumber);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.dataGridView1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormInvoice";
               this.Text = "FormInvoice";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox textBoxDiscation;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textBoxPrice;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox textBoxCount;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBoxType;
          private System.Windows.Forms.TextBox textBoxNumber;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.Label numberInvoice;
          private System.Windows.Forms.Label labelSum;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label labelCount;
     }
}