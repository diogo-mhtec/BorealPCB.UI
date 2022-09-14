
namespace BorealPCB.UI.Funcionarios
{
    partial class frmCursosPorFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursosPorFuncionario));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcod_curso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCursos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colpontuacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_conclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExcluir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riExcluir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbon.SearchEditItem.AccessibleName = "Search Item";
            this.ribbon.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbon.SearchEditItem.EditWidth = 150;
            this.ribbon.SearchEditItem.Id = -5000;
            this.ribbon.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(1129, 132);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.grd);
            this.dataLayoutControl1.Controls.Add(this.textEdit2);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.DataSource = this.funcionarioBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 132);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1129, 498);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // grd
            // 
            this.grd.DataSource = this.cursosBindingSource;
            this.grd.Location = new System.Drawing.Point(5, 78);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbon;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCursos,
            this.riExcluir});
            this.grd.Size = new System.Drawing.Size(1119, 415);
            this.grd.TabIndex = 6;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataSource = typeof(BorealPCB.Dominio.Funcionarios.CursoFuncionario);
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcod_curso,
            this.colpontuacao,
            this.coldata_conclusao,
            this.colDescricaoCurso,
            this.colExcluir});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.NewItemRowText = "Novo";
            this.grv.OptionsNavigation.AutoFocusNewRow = true;
            this.grv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grv.OptionsView.ShowFooter = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colcod_curso
            // 
            this.colcod_curso.Caption = "Código Curso";
            this.colcod_curso.ColumnEdit = this.riCursos;
            this.colcod_curso.FieldName = "cod_curso";
            this.colcod_curso.Name = "colcod_curso";
            this.colcod_curso.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colcod_curso.Visible = true;
            this.colcod_curso.VisibleIndex = 0;
            this.colcod_curso.Width = 97;
            // 
            // riCursos
            // 
            this.riCursos.AutoHeight = false;
            this.riCursos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.riCursos.Name = "riCursos";
            this.riCursos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colpontuacao
            // 
            this.colpontuacao.Caption = "Pontuação";
            this.colpontuacao.FieldName = "pontuacao";
            this.colpontuacao.Name = "colpontuacao";
            this.colpontuacao.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pontuacao", "{0:0.##}")});
            this.colpontuacao.Visible = true;
            this.colpontuacao.VisibleIndex = 3;
            this.colpontuacao.Width = 82;
            // 
            // coldata_conclusao
            // 
            this.coldata_conclusao.Caption = "Data Conclusão";
            this.coldata_conclusao.FieldName = "data_conclusao";
            this.coldata_conclusao.Name = "coldata_conclusao";
            this.coldata_conclusao.Visible = true;
            this.coldata_conclusao.VisibleIndex = 2;
            this.coldata_conclusao.Width = 101;
            // 
            // colDescricaoCurso
            // 
            this.colDescricaoCurso.Caption = "Descrição";
            this.colDescricaoCurso.FieldName = "descricao";
            this.colDescricaoCurso.Name = "colDescricaoCurso";
            this.colDescricaoCurso.OptionsColumn.AllowEdit = false;
            this.colDescricaoCurso.OptionsColumn.AllowFocus = false;
            this.colDescricaoCurso.OptionsColumn.TabStop = false;
            this.colDescricaoCurso.Visible = true;
            this.colDescricaoCurso.VisibleIndex = 1;
            this.colDescricaoCurso.Width = 779;
            // 
            // colExcluir
            // 
            this.colExcluir.ColumnEdit = this.riExcluir;
            this.colExcluir.MaxWidth = 35;
            this.colExcluir.MinWidth = 35;
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Visible = true;
            this.colExcluir.VisibleIndex = 4;
            this.colExcluir.Width = 35;
            // 
            // riExcluir
            // 
            this.riExcluir.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(16, 16);
            this.riExcluir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riExcluir.Name = "riExcluir";
            this.riExcluir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Nome", true));
            this.textEdit2.Location = new System.Drawing.Point(150, 48);
            this.textEdit2.MenuManager = this.ribbon;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(968, 20);
            this.textEdit2.StyleController = this.dataLayoutControl1;
            this.textEdit2.TabIndex = 5;
            this.textEdit2.TabStop = false;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(BorealPCB.Dominio.Funcionarios.Funcionario);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "matricula", true));
            this.textEdit1.Location = new System.Drawing.Point(11, 48);
            this.textEdit1.MenuManager = this.ribbon;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(135, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 4;
            this.textEdit1.TabStop = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1129, 498);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup2.Size = new System.Drawing.Size(1123, 73);
            this.layoutControlGroup2.Text = "Funcionário";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(139, 40);
            this.layoutControlItem1.Text = "Matricula";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(139, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(972, 40);
            this.layoutControlItem2.Text = "Nome";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.grd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1123, 419);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmCursosPorFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 654);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmCursosPorFuncionario";
            this.Text = "Cursos Por Funcionário";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_curso;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riCursos;
        private DevExpress.XtraGrid.Columns.GridColumn colpontuacao;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_conclusao;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoCurso;
        private DevExpress.XtraGrid.Columns.GridColumn colExcluir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riExcluir;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}