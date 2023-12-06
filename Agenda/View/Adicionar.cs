using Agenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.View
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Nome = txb_Nome.Text;
            Agenda.Model.Agenda.Fone = mtxb_Celular.Text;
            Agenda.Model.Agenda.Email = txb_Email.Text;

            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.Adicionar();
        }
    }
}
