namespace AradoExtract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 426);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 367);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 6;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 405);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(324, 21);
            progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(13, 144);
            label1.Name = "label1";
            label1.Size = new Size(292, 17);
            label1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 112);
            button2.Name = "button2";
            button2.Size = new Size(159, 24);
            button2.TabIndex = 3;
            button2.Text = "Selecionar Pasta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 49);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Belo Horizonte", "Campinas", "São Paulo", "Todos" });
            comboBox1.Location = new Point(12, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Localidade";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 359);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 0;
            button1.Text = "Extrair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(353, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arado Extract";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
    }
}