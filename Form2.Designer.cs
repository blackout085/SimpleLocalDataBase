namespace WinFormsApp1
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(178, 208);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(178, 67);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 10;
            label1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(178, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(178, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 31);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.Location = new Point(178, 410);
            button1.Name = "button1";
            button1.Size = new Size(357, 63);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(188, 349);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 12;
            label3.Text = "Already used login";
            label3.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
    }
}