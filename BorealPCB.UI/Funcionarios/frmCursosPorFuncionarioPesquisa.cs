using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Servico.Funcionarios.Interfaces;
using BorealPCB.Servico.Funcionarios.Servicos;
using BorealPCB.UI.Funcionarios;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorealPCB.UI
{
    public partial class frmCursosPorFuncionarioPesquisa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IFuncionarioServico _servico = new FuncionarioServico();

        public List<Funcionario> Lista 
        {
            get { return funcionarioBindingSource.DataSource as List<Funcionario>; }
            set { funcionarioBindingSource.DataSource = value; }
        }

        public frmCursosPorFuncionarioPesquisa()
        {
            InitializeComponent();
            Lista = new List<Funcionario>();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Pesquisar();
        }

        private void Pesquisar()
        {
            Lista = _servico.Todos().ToList();
            funcionarioBindingSource.ResetBindings(false);
        }

        private void riEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var linha = (Funcionario)grv.GetRow(grv.FocusedRowHandle);
            if (linha == null)            
                return;

            var frm = new frmCursosPorFuncionario(linha.matricula);
            frm.ShowDialog();            
        }
    }
}