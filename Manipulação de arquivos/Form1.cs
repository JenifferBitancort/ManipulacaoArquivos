using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulação_de_arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void BtnAdicArqRem_Click_1(object sender, EventArgs e)
        {
            if (BtnAdicRem.Text == "+")
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    string arquivo = openFileDialog1.FileName;
                    FileInfo info = new FileInfo(arquivo);
                    labArq.Text = info.Name;
                    BtnAdicRem.BackColor = Color.Green;
                    BtnAdicRem.Text = "-";
                }
            }

            else
            {
                labArq.Text = "";
                BtnAdicRem.BackColor = Color.Orange;
                BtnAdicRem.Text = "+";
            }

        }

        private void buttonLer_Click(object sender, EventArgs e)
        {
            if(labArq.Text == null)
            {
                MessageBox.Show("Arquivo.txt não selecionado");
            }
 
                textBoxEscr.Clear();

                textBoxEscr.ReadOnly = true;

                string arquivo = openFileDialog1.FileName;

                StreamReader ler = new StreamReader(arquivo);

                string texto = ler.ReadToEnd();

                textBoxEscr.Text = texto;

                ler.Close();
            
        }

        private void buttonEdi_Click(object sender, EventArgs e)
        {
            if (labArq.Text == null)
            {
                MessageBox.Show("Arquivo.txt não selecionado");
            }
            if(textBoxEscr.Text == null)
            {
                MessageBox.Show("Para editar um arquivo primeiro é preciso carrega-lo -- Cliquei em Ler.txt ");
            }

            textBoxEscr.ReadOnly = false;
        }

        private void buttonEscrever_Click(object sender, EventArgs e)
        {

            if (labArq.Text == null)
            {
                MessageBox.Show("Arquivo.txt não selecionado");
            }
            if (textBoxEscr.Text == null)
            {
                MessageBox.Show("Para atualizar um arquivo primeiro é preciso carrega-lo -- Cliquei em Ler.txt ");
            }

            string arquivo = openFileDialog1.FileName;

            StreamWriter atualizar = new StreamWriter(arquivo);

            atualizar.Write(textBoxEscr.Text);

            atualizar.Close();
        }
    }
}
