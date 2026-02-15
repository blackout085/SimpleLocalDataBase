namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.Location = new Point(197, 419);
            button1.Name = "button1";
            button1.Size = new Size(357, 63);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(197, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(197, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 31);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(197, 76);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(197, 217);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(663, 438);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 25);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel2;
    }
}
