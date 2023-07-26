namespace AradoExtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGray;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if(textBox1.Text == "PedroNeto23" && textBox2.Text == "Arado@2023")
                {
                    Form2 form = new Form2();
                    form.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário/Senha invalidos!!");
                }
            }
        }
    }
}