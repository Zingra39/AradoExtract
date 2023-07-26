using AradoExtract.WebScraping;

namespace AradoExtract
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scraping scraping = new Scraping();
            int localidade;

            //veriifca qual cidade foi escolhida
            switch (comboBox1.Text)
            {
                case ("Belo Horizonte"):
                    localidade = 1;
                    break;
                case ("Campinas"):
                    localidade = 2;
                    break;
                case ("São Paulo"):
                    localidade = 3;
                    break;
                default:
                    localidade = 4;
                    break;
            }

            var planilha = scraping.ExtactLocation(localidade, label1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowser.SelectedPath;
            }
        }
    }
}
