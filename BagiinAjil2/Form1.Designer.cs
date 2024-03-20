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
            SuspendLayout();
            // 
            // fromDate
            // 
            fromDate.Location = new Point(68, 63);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(200, 23);
            fromDate.TabIndex = 0;
            // 
            // toDate
            // 
            toDate.Location = new Point(454, 63);
            toDate.Name = "toDate";
            toDate.Size = new Size(200, 23);
            toDate.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(321, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // differenceText
            // 
            differenceText.Location = new Point(217, 209);
            differenceText.Name = "differenceText";
            differenceText.Size = new Size(402, 187);
            differenceText.TabIndex = 4;
            differenceText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(differenceText);
            Controls.Add(button1);
            Controls.Add(toDate);
            Controls.Add(fromDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker fromDate;
        private DateTimePicker toDate;
        private Button button1;
        private RichTextBox differenceText;
    }
}
