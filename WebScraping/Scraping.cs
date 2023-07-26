using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AradoExtract.WebScraping
{
    public class Scraping
    {

        private ChromeDriver driver;

        public Scraping()
        {
            #region Config Driver
            //Configuração do navegador
            ChromeOptions op = new ChromeOptions();
            op.AddArgument("--window-size=600,750"); //define tamanho da janela 
            op.AddArgument("headless"); //Config Tela segundo plano
            driver = new ChromeDriver(op); //Inicia driver com config
            #endregion
        }

        public string ExtactLocation(int localidade, string filePath)
        {
            #region Contadores
            int contLinha = 1; //conta linhas do excel
            int start = 0; //Começo do laço for
            int end = 0; //Final laço for
            #endregion

            #region Config Excel
            //Cria novo pacote do excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();

            //Cria aba no excel
            ExcelWorksheet novaAba = excelPackage.Workbook.Worksheets.Add("Arado_Produtos");

            // definir as colunas da planilha
            novaAba.Cells[1, 1].Value = "Descrição";
            novaAba.Cells[1, 2].Value = "Preço";
            novaAba.Cells[1, 3].Value = "Desconto";
            novaAba.Cells[1, 4].Value = "Preço com Desconto";
            novaAba.Cells[1, 5].Value = "Unidade";
            novaAba.Cells[1, 6].Value = "Cidade";
            #endregion

            //URL que guia até a pagina requesitada
            driver.Navigate().GoToUrl("https://arado.com.br/");

            //Clica em continuar assim que o site abre
            driver.FindElement(By.XPath("/html/body/div[7]/div/div[1]/div/div/button")).Click();
            WaitElement("/html/body/div[5]/div/div[3]/div[1]/div[2]/div[1]");

            //Valida localização inserida pelo usuário 
            if (localidade == 4)
            {
                start = 1;
                end = 3;
            }
            else
            {
                start = localidade;
                end = localidade;
            }

            //Faz com que o WebScraping passe por todas as localidades 
            for (int i = start; i <= end; i++)
            {
                #region DADOS CARD
                string descricao = "";
                float preco = 0;
                float precoDesconto = 0;
                string unidade = "";
                float desconto = 0;
                #endregion

                //variavel que valida fluxo
                bool retorno = true;

                //contador de cards 
                int contCard = 1;

                #region Seleciona Cidade
                driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/div[1]/div[2]/div[1]")).Click();
                string cidade = driver.FindElement(By.XPath($"//html/body/div[5]/div/div[3]/div[1]/div[2]/div[2]/div[{i}]")).Text;
                driver.FindElement(By.XPath($"/html/body/div[5]/div/div[3]/div[1]/div[2]/div[2]/div[{i}]")).Click();
                //WaitElement("//*[@id=\"__nuxt\"]/div/div[4]/div[2]/div[2]/div");
                Thread.Sleep(2000);
                #endregion

                //laço do-while para resgatar as informações dos cards
                do
                {
                    //verifica se elemento está visivel
                    if (IsElementVisible(contCard))
                    {
                        //vai tentar extrai os valores dos cards de um jeito, caso der errado
                        //vai para o catch onde sera extraido de outra maneira 
                        try
                        {
                            //Resgata o elemento HTML pelo Xpath
                            var elementDescricao = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div/div[3]"));
                            var elementDesconto = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[3]")).Text.Replace("-", "").Replace("%", "").Trim();
                            var elementPreco = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div/div[1]")).Text.Replace("R$", "").Replace("x kg", "").Replace("x un", "").Replace("x 12un", "").Replace("x 30un", "").Trim();
                            var elementTipo = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div/div[2]/span[2]")).Text.Replace("x", "").Trim(); ;

                            //faz atribuição, conversão e formatação do dados extraidos do site
                            descricao = elementDescricao.Text;
                            preco = float.Parse(elementPreco);
                            unidade = elementTipo;
                            desconto = float.Parse(elementDesconto) / 100;
                            precoDesconto = preco * (1 - desconto);
                        }
                        catch (NoSuchElementException)
                        {
                            //Resgata o elemento HTML pelo Xpath
                            var elementDescricao = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div[2]/div[2]"));
                            var elementPreco = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div/div[1]")).Text.Replace("R$", "").Replace("x kg", "").Replace("x un", "").Replace("x 12un", "").Replace("x 30un", "").Replace("x 360un", "").Trim();
                            var elementTipo = driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{contCard}]/div[1]/div[2]/div[1]/span[2]")).Text.Replace("x", "").Trim();

                            //faz atribuição, conversão e formatação do dados extraidos do site
                            descricao = elementDescricao.Text;
                            preco = float.Parse(elementPreco);
                            unidade = elementTipo;
                            precoDesconto = preco;
                            desconto = 0;
                        }
                        finally // cuidara da inserção na planilha
                        {
                            #region Inserir dados Planilha
                            // adicionar dados à planilha
                            novaAba.Cells[1 + contLinha, 1].Value = descricao;
                            novaAba.Cells[1 + contLinha, 2].Value = Math.Round(preco, 2);
                            novaAba.Cells[1 + contLinha, 3].Value = Math.Round(desconto, 2);
                            novaAba.Cells[1 + contLinha, 4].Value = Math.Round(precoDesconto, 2);
                            novaAba.Cells[1 + contLinha, 5].Value = unidade;
                            novaAba.Cells[1 + contLinha, 6].Value = cidade;

                            //acrescenta no contLinha para proximo card
                            contLinha++;
                            #endregion
                        }
                    }
                    else
                    {
                        //caso não tenha mais nenhum elemento, o retorno fica falso
                        retorno = false;
                    }

                    //faz contagem do card, fazendo com que ele leia 1 por 1
                    contCard++;

                    //laço quebra quando (retorno = false) e continua quando (retone = true)
                } while (retorno);
            }

            //cria nome da planilha e depois salva ela e os dados no caminho passado
            string planilha = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            filePath = filePath + $"\\arado-{planilha}.xlsx";

            // Salvar as alterações no arquivo Excel
            excelPackage.SaveAs(new FileInfo(filePath));


            //conta linha mais um vez para não deixar uma informação em cima da outra 
            contLinha++;

            //fecha navegador 
            driver.Quit();

            return filePath;
        }

        public bool IsElementVisible(int cont)
        {
            List<IWebElement> listaCards = driver.FindElements(By.XPath("/html/body/div[5]/div/div[4]/div[2]/div[2]/div")).ToList();
            var lastPosition = listaCards.Count() - 6;
            bool isSmall = cont < lastPosition;
            bool retorno = false;
            
            if (!isSmall && ElementExist($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{cont}]"))
            {
                Thread.Sleep(1000);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{cont}]")));
            }

            return ElementExist($"/html/body/div[5]/div/div[4]/div[2]/div[2]/div[{cont}]");
        }

        public bool ElementExist(string xpath)
        {
            try
            {
                driver.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public IWebElement WaitElement(string xpath, int time = 30)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }
    }
}
