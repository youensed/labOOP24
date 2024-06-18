namespace OOP_24_
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 80);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 80);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(713, 80);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(50, 273);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(261, 36);
            button1.TabIndex = 3;
            button1.Text = "Запустить поток 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 273);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(264, 36);
            button2.TabIndex = 7;
            button2.Text = "Запустить поток 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(712, 273);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(249, 36);
            button3.TabIndex = 8;
            button3.Text = "Запустить поток 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(50, 317);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(261, 36);
            button4.TabIndex = 9;
            button4.Text = "Зупинить поток 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Red;
            button5.Location = new Point(372, 317);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(264, 36);
            button5.TabIndex = 10;
            button5.Text = "Зупинить поток 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.Red;
            button6.Location = new Point(712, 317);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(249, 36);
            button6.TabIndex = 11;
            button6.Text = "Зупинить поток 3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(50, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 112);
            label1.TabIndex = 12;
            label1.Text = " ";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(372, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(263, 112);
            label2.TabIndex = 13;
            label2.Text = " ";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(712, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(248, 112);
            label3.TabIndex = 14;
            label3.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(78, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 15;
            label4.Text = "SXAL8/MBAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(444, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 16;
            label5.Text = "HAVAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(652, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(335, 32);
            label6.TabIndex = 17;
            label6.Text = "Потоковий шифр Диффи";
            // 
            // button7
            // 
            button7.Location = new Point(191, 368);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(614, 36);
            button7.TabIndex = 18;
            button7.Text = "Запустити всі потоки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.ForeColor = Color.Red;
            button8.Location = new Point(191, 422);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(614, 36);
            button8.TabIndex = 19;
            button8.Text = "Зупинити всі потоки";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4);
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 24";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button7;
        private Button button8;
    }
}
