namespace HeatAndMassTransferModel
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Vol = new System.Windows.Forms.TextBox();
            this.Mass = new System.Windows.Forms.TextBox();
            this.In = new System.Windows.Forms.TextBox();
            this.Coef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalMass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Date3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Cin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ტბის მოცულობა:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "მაბინძურებლის კონცენტრაციის გაზომვის დრო:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "გაზომვისას მაბინძურებლის მასა:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "წყლის ჩადინების სიხშირე:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "მაბინძურებლის მასის შემცირების კოეფიციენტი:";
            // 
            // Vol
            // 
            this.Vol.Location = new System.Drawing.Point(404, 3);
            this.Vol.Name = "Vol";
            this.Vol.Size = new System.Drawing.Size(200, 20);
            this.Vol.TabIndex = 31;
            this.Vol.TextChanged += new System.EventHandler(this.Temp1_TextChanged);
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(404, 63);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(200, 20);
            this.Mass.TabIndex = 32;
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(404, 93);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(200, 20);
            this.In.TabIndex = 33;
            // 
            // Coef
            // 
            this.Coef.Location = new System.Drawing.Point(404, 153);
            this.Coef.Name = "Coef";
            this.Coef.Size = new System.Drawing.Size(200, 20);
            this.Coef.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(612, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "კმ³";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(612, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "კგ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(612, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "კმ³/წწ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(404, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 24);
            this.button2.TabIndex = 38;
            this.button2.Text = "საპროგნოზო თარიღის დათვლა";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(404, 33);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 45;
            this.Date1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "საპროგნოზო თარიღი:";
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(404, 183);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(1, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 24);
            this.label8.TabIndex = 48;
            this.label8.Text = "შეტანილი დროისათვის ტბის დაბინძურება:";
            // 
            // TotalMass
            // 
            this.TotalMass.Location = new System.Drawing.Point(407, 246);
            this.TotalMass.Name = "TotalMass";
            this.TotalMass.Size = new System.Drawing.Size(197, 20);
            this.TotalMass.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(610, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "კგ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(205, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 24);
            this.button3.TabIndex = 51;
            this.button3.Text = "დაბინძურების მასის დათვლა";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Date3
            // 
            this.Date3.Location = new System.Drawing.Point(407, 274);
            this.Date3.Name = "Date3";
            this.Date3.Size = new System.Drawing.Size(200, 20);
            this.Date3.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(3, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 24);
            this.label12.TabIndex = 52;
            this.label12.Text = "საპროგნოზო თარიღი:";
            // 
            // Cin
            // 
            this.Cin.Location = new System.Drawing.Point(404, 123);
            this.Cin.Name = "Cin";
            this.Cin.Size = new System.Drawing.Size(200, 20);
            this.Cin.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 24);
            this.label13.TabIndex = 54;
            this.label13.Text = "ჩამდინარე მაბინძურებლის მასა:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(612, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "კგ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Date3, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.Vol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalMass, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Date2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Date1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Mass, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Coef, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.In, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 300);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 400);
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "Form3";
            this.Text = "ტბების დაბინძურება";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Vol;
        private System.Windows.Forms.TextBox Mass;
        private System.Windows.Forms.TextBox In;
        private System.Windows.Forms.TextBox Coef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalMass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker Date3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Cin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}