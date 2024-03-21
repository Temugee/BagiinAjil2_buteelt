namespace BagiinAjil2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fromDate = new DateTimePicker();
            toDate = new DateTimePicker();
            button1 = new Button();
            differenceText = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            fromDateUniversity = new DateTimePicker();
            toDateUniversity = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            universityText = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            toDateUniversity2000 = new DateTimePicker();
            fromDateUniversity2000 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            toDate2000 = new DateTimePicker();
            fromDate2000 = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            universityText2000 = new RichTextBox();
            label13 = new Label();
            label14 = new Label();
            txtJishih = new RichTextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // fromDate
            // 
            fromDate.Location = new Point(44, 100);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(200, 23);
            fromDate.TabIndex = 0;
            // 
            // toDate
            // 
            toDate.Location = new Point(44, 152);
            toDate.Name = "toDate";
            toDate.Size = new Size(200, 23);
            toDate.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 403);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // differenceText
            // 
            differenceText.Location = new Point(12, 493);
            differenceText.Name = "differenceText";
            differenceText.Size = new Size(168, 210);
            differenceText.TabIndex = 4;
            differenceText.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 82);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 5;
            label1.Text = "Дунд сургуульд элсэн орсон огноо";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 134);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 6;
            label2.Text = "Дунд сургууль төгссөн огноо";
            // 
            // fromDateUniversity
            // 
            fromDateUniversity.Location = new Point(44, 217);
            fromDateUniversity.Name = "fromDateUniversity";
            fromDateUniversity.Size = new Size(200, 23);
            fromDateUniversity.TabIndex = 7;
            fromDateUniversity.Value = new DateTime(1988, 9, 1, 0, 0, 0, 0);
            // 
            // toDateUniversity
            // 
            toDateUniversity.Location = new Point(44, 269);
            toDateUniversity.Name = "toDateUniversity";
            toDateUniversity.Size = new Size(200, 23);
            toDateUniversity.TabIndex = 8;
            toDateUniversity.Value = new DateTime(1993, 6, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 199);
            label3.Name = "label3";
            label3.Size = new Size(199, 15);
            label3.TabIndex = 9;
            label3.Text = "Дээд сургуульд элсэн орсон огноо";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 251);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 10;
            label4.Text = "Дээд сургууль төгссөн огноо";
            // 
            // universityText
            // 
            universityText.Location = new Point(199, 493);
            universityText.Name = "universityText";
            universityText.Size = new Size(372, 40);
            universityText.TabIndex = 11;
            universityText.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 475);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "Overall";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 475);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 13;
            label6.Text = "University 1980";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 251);
            label7.Name = "label7";
            label7.Size = new Size(167, 15);
            label7.TabIndex = 21;
            label7.Text = "Дээд сургууль төгссөн огноо";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 199);
            label8.Name = "label8";
            label8.Size = new Size(199, 15);
            label8.TabIndex = 20;
            label8.Text = "Дээд сургуульд элсэн орсон огноо";
            // 
            // toDateUniversity2000
            // 
            toDateUniversity2000.Location = new Point(633, 269);
            toDateUniversity2000.Name = "toDateUniversity2000";
            toDateUniversity2000.Size = new Size(200, 23);
            toDateUniversity2000.TabIndex = 19;
            toDateUniversity2000.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // fromDateUniversity2000
            // 
            fromDateUniversity2000.Location = new Point(633, 217);
            fromDateUniversity2000.Name = "fromDateUniversity2000";
            fromDateUniversity2000.Size = new Size(200, 23);
            fromDateUniversity2000.TabIndex = 18;
            fromDateUniversity2000.Value = new DateTime(2018, 9, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(633, 134);
            label9.Name = "label9";
            label9.Size = new Size(168, 15);
            label9.TabIndex = 17;
            label9.Text = "Дунд сургууль төгссөн огноо";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(633, 82);
            label10.Name = "label10";
            label10.Size = new Size(200, 15);
            label10.TabIndex = 16;
            label10.Text = "Дунд сургуульд элсэн орсон огноо";
            // 
            // toDate2000
            // 
            toDate2000.Location = new Point(633, 152);
            toDate2000.Name = "toDate2000";
            toDate2000.Size = new Size(200, 23);
            toDate2000.TabIndex = 15;
            // 
            // fromDate2000
            // 
            fromDate2000.Location = new Point(633, 100);
            fromDate2000.Name = "fromDate2000";
            fromDate2000.Size = new Size(200, 23);
            fromDate2000.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(54, 15);
            label11.Name = "label11";
            label11.Size = new Size(93, 30);
            label11.TabIndex = 22;
            label11.Text = "1980 он";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(674, 15);
            label12.Name = "label12";
            label12.Size = new Size(93, 30);
            label12.TabIndex = 23;
            label12.Text = "2000 он";
            // 
            // universityText2000
            // 
            universityText2000.Location = new Point(199, 573);
            universityText2000.Name = "universityText2000";
            universityText2000.Size = new Size(372, 38);
            universityText2000.TabIndex = 24;
            universityText2000.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(199, 555);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 25;
            label13.Text = "University 2000";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(289, 251);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 26;
            label14.Text = "5 жил нэмэх";
            // 
            // txtJishih
            // 
            txtJishih.Location = new Point(860, 493);
            txtJishih.Name = "txtJishih";
            txtJishih.Size = new Size(177, 180);
            txtJishih.TabIndex = 27;
            txtJishih.Text = "";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(860, 475);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 28;
            label15.Text = "Ялгаа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 715);
            Controls.Add(label15);
            Controls.Add(txtJishih);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(universityText2000);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(toDateUniversity2000);
            Controls.Add(fromDateUniversity2000);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(toDate2000);
            Controls.Add(fromDate2000);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(universityText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(toDateUniversity);
            Controls.Add(fromDateUniversity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(differenceText);
            Controls.Add(button1);
            Controls.Add(toDate);
            Controls.Add(fromDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fromDate;
        private DateTimePicker toDate;
        private Button button1;
        private RichTextBox differenceText;
        private Label label1;
        private Label label2;
        private DateTimePicker fromDateUniversity;
        private DateTimePicker toDateUniversity;
        private Label label3;
        private Label label4;
        private RichTextBox universityText;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker toDateUniversity2000;
        private DateTimePicker fromDateUniversity2000;
        private Label label9;
        private Label label10;
        private DateTimePicker toDate2000;
        private DateTimePicker fromDate2000;
        private Label label11;
        private Label label12;
        private RichTextBox universityText2000;
        private Label label13;
        private Label label14;
        private RichTextBox txtJishih;
        private Label label15;
    }
}
