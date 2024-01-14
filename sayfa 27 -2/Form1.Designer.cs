namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            sonucbox = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 44);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Cinsiyetinizi girin       :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 118);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 4;
            label2.Text = "Boyunuzu girin         : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 202);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Kilonuzu girin             :";
            // 
            // button1
            // 
            button1.Location = new Point(360, 253);
            button1.Name = "button1";
            button1.Size = new Size(100, 63);
            button1.TabIndex = 6;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sonucbox
            // 
            sonucbox.Location = new Point(228, 337);
            sonucbox.Name = "sonucbox";
            sonucbox.Size = new Size(388, 23);
            sonucbox.TabIndex = 7;
            sonucbox.TextChanged += TextBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sonucbox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public Label label1;
        public Label label2;
        public Label label3;
        public Button button1;
        public TextBox sonucbox;
    }
}