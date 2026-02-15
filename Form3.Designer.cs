namespace WinFormsApp1
{
    partial class MainWindow
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 57);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Hello";
            label1.UseMnemonic = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(570, 590);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Base";
            linkLabel1.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(974, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(974, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(974, 116);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(974, 194);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "Level";
            label3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(986, 278);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Give level";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindow";
            Text = "Main Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}