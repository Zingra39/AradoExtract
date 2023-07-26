namespace AradoExtract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(51, 274);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Usuário";
            textBox1.Size = new Size(254, 22);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 317);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "   Senha";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(51, 372);
            button1.Name = "button1";
            button1.Size = new Size(254, 37);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 243);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 426);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(357, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arado Extract";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}