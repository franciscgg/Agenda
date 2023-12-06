using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class MenuAgenda : Form
    {
        public MenuAgenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar adicionar = new Adicionar();
            adicionar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Apagar apagar = new Apagar();
            apagar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarCod buscarCod = new BuscarCod();
            buscarCod.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarNome buscarNome = new BuscarNome();
            buscarNome.Show();
        }
    }
}
