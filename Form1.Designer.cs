namespace Record_Temperatures
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 286);
            button1.Name = "button1";
            button1.Size = new Size(350, 29);
            button1.TabIndex = 0;
            button1.Text = "Press to see if today's temperatures are a record!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 339);
            button2.Name = "button2";
            button2.Size = new Size(442, 29);
            button2.TabIndex = 1;
            button2.Text = "Press to see if this month's average temperatures are a record!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 25);
            label1.Name = "label1";
            label1.Size = new Size(316, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter the number of the current month (1-12)...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 72);
            label2.Name = "label2";
            label2.Size = new Size(297, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter the number of the current day (1-31)...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 180);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 4;
            label3.Text = "Enter today's daily high temperature...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 224);
            label4.Name = "label4";
            label4.Size = new Size(253, 20);
            label4.TabIndex = 5;
            label4.Text = "Enter today's daily low temperature...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 286);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 339);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(456, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(456, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(456, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(644, 173);
            button3.Name = "button3";
            button3.Size = new Size(94, 85);
            button3.TabIndex = 12;
            button3.Text = "Input into database!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
    }
}
