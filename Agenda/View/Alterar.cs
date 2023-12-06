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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void bnt_Buscar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Id = Convert.ToInt32(txb_IdBuscar.Text);
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.BuscarCod();

            txb_Nome.Text = Agenda.Model.Agenda.Nome;
            txb_Email.Text = Agenda.Model.Agenda.Email;
            txb_Celular.Text = Agenda.Model.Agenda.Fone;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Id = Convert.ToInt32(txb_IdBuscar.Text);
            Agenda.Model.Agenda.Nome = txb_Nome.Text;
            Agenda.Model.Agenda.Email = txb_Email.Text;
            Agenda.Model.Agenda.Fone = txb_Celular.Text;

            ManipulaAgenda manipula = new ManipulaAgenda();
            manipula.Atualizar();
        }
    }
}
