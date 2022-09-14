using BorealPCB.Dominio.Funcionarios;
using BorealPCB.Servico.Funcionarios.Interfaces;
using BorealPCB.Servico.Funcionarios.Servicos;
using BorealPCB.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorealPCB.UI.Funcionarios
{
    public partial class frmCursosPorFuncionario : formBaseCadastro
    {
        private ICursoFuncionarioServico _servico = new CursoFuncionarioServico();
        private IFuncionarioServico _servicoFuncionario = new FuncionarioServico();

        private Funcionario _funcionario 
        {
            get { return funcionarioBindingSource.DataSource as Funcionario; }
            set { funcionarioBindingSource.DataSource = value; }
        }
        private List<CursoFuncionario> _cursosFuncionario
        {
            get { return cursosBindingSource.DataSource as List<CursoFuncionario>; }
            set { cursosBindingSource.DataSource = value; }
        }

        public frmCursosPorFuncionario(int funcionarioMatricula)
        {
            InitializeComponent();
            _funcionario = _servicoFuncionario.Obter(funcionarioMatricula);
            _cursosFuncionario = new List<CursoFuncionario>();
            barBtnNovo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            _cursosFuncionario = _servico.PorFuncionario(_funcionario.matricula).ToList();
            cursosBindingSource.ResetBindings(false);
            funcionarioBindingSource.ResetBindings(false);
        }

    }
}
