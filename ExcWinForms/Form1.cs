using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcWinForms
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private string strPatchFile = @"C:\Users\Public\ArquivoExemplo.txt";
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange400, Primary.DeepOrange500, Primary.Orange100, Accent.DeepOrange400, TextShade.WHITE) ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = File.Create(strPatchFile))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write("Texto adicionado ao exemplo!");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Arquivo criado com sucesso!!!");
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(strPatchFile))
                {
                    System.Diagnostics.Process.Start(strPatchFile);//Abre o arquivo
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(strPatchFile))
                {
                    using (StreamWriter sw = File.AppendText(strPatchFile)) 
                    {
                        sw.Write("\nTexto adicionado ao final do arquivo");
                    }
                    MessageBox.Show("Arquivo atualizado!");
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
