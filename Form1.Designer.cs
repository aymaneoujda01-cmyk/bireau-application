namespace Bireau_application
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
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(189, 400);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "AFICHER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 400);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "EFFACER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 75);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 2;
            label1.Text = "NOM DE CLIENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 134);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "VILLE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 409);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 29);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "JAVA";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(21, 95);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 29);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "PHP";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(494, 203);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(102, 29);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Homme";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(494, 241);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 29);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femme";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Location = new Point(119, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 150);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 510);
            Controls.Add(panel1);
            Controls.Add(radioButton2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
    }
}
