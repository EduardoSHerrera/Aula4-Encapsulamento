using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4_Encapsulamento
{
    public partial class TelaFiolme : Form
    {
        public TelaFiolme()
        {
            InitializeComponent();
        }

        Filme f = new Filme(); //instanciando objeto
        Filme[] vet = new Filme[5]; // declaração do valor dos objetos
        int i = 0;

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if(i== 5)
            {
                MessageBox.Show("não é possivel gravar");
            }
            else
            {
                f.Titulo = TxtTitulo.Text;
                f.Classificacao = TxtClassificacao.Text;
                f.Sinopse = TxtSinopse.Text;
                f.Genero = TxtGenero.Text;
                vet[i] = f;
                i++;
            }
        }
    }
}
