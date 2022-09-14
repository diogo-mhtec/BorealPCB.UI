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
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void barBtnCursoPorFuncionario_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCursosPorFuncionarioPesquisa();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}