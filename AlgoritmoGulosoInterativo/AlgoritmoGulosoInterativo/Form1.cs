using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using botton_up.Class;
using System.IO;
using System.Reflection;

namespace AlgoritmoGulosoInterativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TempoInicioFim> lista = RetornaListaTxt("text2.txt");
            /* Filtro para o fim ser maior que a hora inicial*/
            lista = lista.Where(c => c.fim > c.inicio).ToList();
            /*Escolha gulosa*/
            var escolha = lista.FirstOrDefault();
            txtRespotaEscolhaGulosa.Text = "Linha: " + escolha.linha + " Inicio: " + escolha.inicio + " Fim: " + escolha.fim;
            txtListaOrdenada.Text = Textos(lista);
            txtMelhoresItens.Text = Textos(RetornaMelhoresItens(lista));
        }

        public static List<TempoInicioFim> RetornaListaTxt(string nomeArquivo)
        {
            /*Neste primeiro metodo pega o arquivo txt e inseri na lista do objeto arrText definindo a linha e 
             * adicionando o tempo inicio e fim no final, liberando o arquivo com o dispose e retornando a lista ordenada pelo tempo final */
            try
            {
                string sLine = string.Empty;
                List<TempoInicioFim> arrText = new List<TempoInicioFim>();
                int id = 1;

                string caminhoArquivo = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                caminhoArquivo = caminhoArquivo.Replace("\\bin\\Debug", "") + "\\arquivos\\" + nomeArquivo;
                StreamReader objReader = new StreamReader(caminhoArquivo);

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        if (sLine.Contains(";"))
                        {
                            string[] array = sLine.Split(';');

                            TempoInicioFim arr = new TempoInicioFim();
                            arr.linha = id;
                            arr.inicio = Convert.ToInt32(array[0]);
                            arr.fim = Convert.ToInt32(array[1]);
                            arrText.Add(arr);
                        }
                    id++;
                }
                objReader.Dispose();
                return arrText.OrderBy(c => c.fim).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }            
        }

        public static List<TempoInicioFim> RetornaMelhoresItens(List<TempoInicioFim> listaOriginal)
        {
            List<TempoInicioFim> lista = new List<TempoInicioFim>();
            TempoInicioFim escolhaGulosa = listaOriginal.FirstOrDefault();
            lista.Add(escolhaGulosa);            

            for (int i = 0; i < listaOriginal.Count(); i++)
            {
                if (escolhaGulosa != null)
                {
                    TempoInicioFim novaEscolha = listaOriginal.Where(c => c.inicio >= escolhaGulosa.fim).FirstOrDefault();
                    listaOriginal.Remove(escolhaGulosa);
                    escolhaGulosa = novaEscolha;
                    if (novaEscolha != null)
                        lista.Add(novaEscolha);

                }
            }
            return lista;
        }

        public static string Textos(List<TempoInicioFim> lista)
        {
            string retorno = string.Empty;

            foreach (TempoInicioFim escolha in lista)
            {
                retorno += "Linha: " + escolha.linha + " Inicio: " + escolha.inicio + " Fim: " + escolha.fim + "\r\n";
            }

            return retorno;
        }
    }
}
