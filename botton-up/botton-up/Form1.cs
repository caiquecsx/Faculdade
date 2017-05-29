using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;
using botton_up.Class;

namespace botton_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Barra> lista = RetornaListaTxt("text1.txt");
            txtResultado.Text = cutRod(lista).ToString();
        }

        public static List<Barra> RetornaListaTxt(string nomeArquivo)
        {
            try
            {
                string sLine = string.Empty;
                List<Barra> arrText = new List<Barra>();
                int id = 1;
                string caminhoArquivo = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                caminhoArquivo = caminhoArquivo.Replace("\\bin\\Debug", "") + "\\arquivos\\" + nomeArquivo;
                StreamReader objReader = new StreamReader(caminhoArquivo);

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        Barra arr = new Barra();
                        arr.tamanho = id.ToString();
                        arr.valor = Convert.ToInt32(sLine);
                        arrText.Add(arr);
                    }
                    id++;
                }
                objReader.Dispose();
                return arrText;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int cutRod(List<Barra> piece)
        {
            int lenght = piece.Count();
            int[] r = new int[lenght + 1];
            r[0] = 0;

            for (int i = 1; i <= lenght; i++)
            {
                int q = int.MinValue;

                for (int j = 0; j < i; j++)
                {
                    q = Math.Max(q, piece[j].valor + r[i - j - 1]);
                }
                r[i] = q;
            }

            return r[lenght];
        }
    }
}
