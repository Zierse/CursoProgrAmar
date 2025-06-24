namespace stringBuilder_01_30082023
{
    partial class frm_01_30082023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_30082023));
            this.lstbxPreferencias = new System.Windows.Forms.ListBox();
            this.btnDesvCond = new System.Windows.Forms.Button();
            this.btnImpTxtWhile = new System.Windows.Forms.Button();
            this.btnBdCon = new System.Windows.Forms.Button();
            this.btnBdDesc = new System.Windows.Forms.Button();
            this.btnConsultarBd = new System.Windows.Forms.Button();
            this.btnIncluirBd = new System.Windows.Forms.Button();
            this.btnExcluirBd = new System.Windows.Forms.Button();
            this.btnAlterarBd = new System.Windows.Forms.Button();
            this.dtgdvwPreferencias = new System.Windows.Forms.DataGridView();
            this.bndnavPreferencias = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bndnavbtnConfirmar = new System.Windows.Forms.ToolStripButton();
            this.bndnavtxtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.bndnavbtnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.bndsrcPreferencias = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnavPreferencias)).BeginInit();
            this.bndnavPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxPreferencias
            // 
            this.lstbxPreferencias.FormattingEnabled = true;
            this.lstbxPreferencias.Location = new System.Drawing.Point(277, 1);
            this.lstbxPreferencias.Name = "lstbxPreferencias";
            this.lstbxPreferencias.Size = new System.Drawing.Size(402, 251);
            this.lstbxPreferencias.TabIndex = 0;
            // 
            // btnDesvCond
            // 
            this.btnDesvCond.Location = new System.Drawing.Point(3, 1);
            this.btnDesvCond.Name = "btnDesvCond";
            this.btnDesvCond.Size = new System.Drawing.Size(268, 65);
            this.btnDesvCond.TabIndex = 1;
            this.btnDesvCond.Text = "Desvio Condicional";
            this.btnDesvCond.UseVisualStyleBackColor = true;
            this.btnDesvCond.Click += new System.EventHandler(this.btnDesvCond_Click);
            // 
            // btnImpTxtWhile
            // 
            this.btnImpTxtWhile.Location = new System.Drawing.Point(3, 71);
            this.btnImpTxtWhile.Name = "btnImpTxtWhile";
            this.btnImpTxtWhile.Size = new System.Drawing.Size(268, 65);
            this.btnImpTxtWhile.TabIndex = 2;
            this.btnImpTxtWhile.Text = "Importar txt While";
            this.btnImpTxtWhile.UseVisualStyleBackColor = true;
            this.btnImpTxtWhile.Click += new System.EventHandler(this.btnImpTxtWhile_Click);
            // 
            // btnBdCon
            // 
            this.btnBdCon.Location = new System.Drawing.Point(3, 141);
            this.btnBdCon.Name = "btnBdCon";
            this.btnBdCon.Size = new System.Drawing.Size(268, 65);
            this.btnBdCon.TabIndex = 3;
            this.btnBdCon.Text = "Banco de Dados Conectado";
            this.btnBdCon.UseVisualStyleBackColor = true;
            this.btnBdCon.Click += new System.EventHandler(this.btnBdCon_Click);
            // 
            // btnBdDesc
            // 
            this.btnBdDesc.Location = new System.Drawing.Point(3, 211);
            this.btnBdDesc.Name = "btnBdDesc";
            this.btnBdDesc.Size = new System.Drawing.Size(268, 65);
            this.btnBdDesc.TabIndex = 4;
            this.btnBdDesc.Text = "Banco de Dados Desconectado";
            this.btnBdDesc.UseVisualStyleBackColor = true;
            this.btnBdDesc.Click += new System.EventHandler(this.btnBdDesc_Click);
            // 
            // btnConsultarBd
            // 
            this.btnConsultarBd.Location = new System.Drawing.Point(3, 291);
            this.btnConsultarBd.Name = "btnConsultarBd";
            this.btnConsultarBd.Size = new System.Drawing.Size(268, 65);
            this.btnConsultarBd.TabIndex = 5;
            this.btnConsultarBd.Text = "Consultar Banco de Dados";
            this.btnConsultarBd.UseVisualStyleBackColor = true;
            this.btnConsultarBd.Click += new System.EventHandler(this.btnConsultarBd_Click);
            // 
            // btnIncluirBd
            // 
            this.btnIncluirBd.Location = new System.Drawing.Point(3, 361);
            this.btnIncluirBd.Name = "btnIncluirBd";
            this.btnIncluirBd.Size = new System.Drawing.Size(268, 65);
            this.btnIncluirBd.TabIndex = 6;
            this.btnIncluirBd.Text = "Incluir Banco de Dados";
            this.btnIncluirBd.UseVisualStyleBackColor = true;
            this.btnIncluirBd.Click += new System.EventHandler(this.btnIncluirBd_Click);
            // 
            // btnExcluirBd
            // 
            this.btnExcluirBd.Location = new System.Drawing.Point(3, 431);
            this.btnExcluirBd.Name = "btnExcluirBd";
            this.btnExcluirBd.Size = new System.Drawing.Size(268, 65);
            this.btnExcluirBd.TabIndex = 7;
            this.btnExcluirBd.Text = "Excluir Banco de Dados";
            this.btnExcluirBd.UseVisualStyleBackColor = true;
            this.btnExcluirBd.Click += new System.EventHandler(this.btnExcluirBd_Click);
            // 
            // btnAlterarBd
            // 
            this.btnAlterarBd.Location = new System.Drawing.Point(3, 501);
            this.btnAlterarBd.Name = "btnAlterarBd";
            this.btnAlterarBd.Size = new System.Drawing.Size(268, 65);
            this.btnAlterarBd.TabIndex = 8;
            this.btnAlterarBd.Text = "Alterar Banco de Dados";
            this.btnAlterarBd.UseVisualStyleBackColor = true;
            this.btnAlterarBd.Click += new System.EventHandler(this.btnAlterarBd_Click);
            // 
            // dtgdvwPreferencias
            // 
            this.dtgdvwPreferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdvwPreferencias.Location = new System.Drawing.Point(277, 302);
            this.dtgdvwPreferencias.Name = "dtgdvwPreferencias";
            this.dtgdvwPreferencias.Size = new System.Drawing.Size(402, 260);
            this.dtgdvwPreferencias.TabIndex = 9;
            this.dtgdvwPreferencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdvwPreferencias_CellClick);
            // 
            // bndnavPreferencias
            // 
            this.bndnavPreferencias.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndnavPreferencias.BindingSource = this.bndsrcPreferencias;
            this.bndnavPreferencias.CountItem = this.bindingNavigatorCountItem;
            this.bndnavPreferencias.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndnavPreferencias.Dock = System.Windows.Forms.DockStyle.None;
            this.bndnavPreferencias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bndnavbtnConfirmar,
            this.bndnavtxtPesquisar,
            this.bndnavbtnPesquisar});
            this.bndnavPreferencias.Location = new System.Drawing.Point(277, 274);
            this.bndnavPreferencias.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndnavPreferencias.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndnavPreferencias.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndnavPreferencias.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndnavPreferencias.Name = "bndnavPreferencias";
            this.bndnavPreferencias.PositionItem = this.bindingNavigatorPositionItem;
            this.bndnavPreferencias.Size = new System.Drawing.Size(434, 25);
            this.bndnavPreferencias.TabIndex = 10;
            this.bndnavPreferencias.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bndnavbtnConfirmar
            // 
            this.bndnavbtnConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavbtnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("bndnavbtnConfirmar.Image")));
            this.bndnavbtnConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavbtnConfirmar.Name = "bndnavbtnConfirmar";
            this.bndnavbtnConfirmar.Size = new System.Drawing.Size(23, 22);
            this.bndnavbtnConfirmar.Text = "toolStripButton1";
            this.bndnavbtnConfirmar.Click += new System.EventHandler(this.bndnavbtnConfirmar_Click);
            // 
            // bndnavtxtPesquisar
            // 
            this.bndnavtxtPesquisar.Name = "bndnavtxtPesquisar";
            this.bndnavtxtPesquisar.Size = new System.Drawing.Size(100, 25);
            // 
            // bndnavbtnPesquisar
            // 
            this.bndnavbtnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bndnavbtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("bndnavbtnPesquisar.Image")));
            this.bndnavbtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bndnavbtnPesquisar.Name = "bndnavbtnPesquisar";
            this.bndnavbtnPesquisar.Size = new System.Drawing.Size(23, 22);
            this.bndnavbtnPesquisar.Text = "toolStripButton2";
            this.bndnavbtnPesquisar.Click += new System.EventHandler(this.bndnavbtnPesquisar_Click);
            // 
            // frm_01_30082023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 565);
            this.Controls.Add(this.bndnavPreferencias);
            this.Controls.Add(this.dtgdvwPreferencias);
            this.Controls.Add(this.btnAlterarBd);
            this.Controls.Add(this.btnExcluirBd);
            this.Controls.Add(this.btnIncluirBd);
            this.Controls.Add(this.btnConsultarBd);
            this.Controls.Add(this.btnBdDesc);
            this.Controls.Add(this.btnBdCon);
            this.Controls.Add(this.btnImpTxtWhile);
            this.Controls.Add(this.btnDesvCond);
            this.Controls.Add(this.lstbxPreferencias);
            this.Name = "frm_01_30082023";
            this.Text = "Formulario feito em 30/08/2023";
            this.Load += new System.EventHandler(this.frm_01_30082023_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdvwPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndnavPreferencias)).EndInit();
            this.bndnavPreferencias.ResumeLayout(false);
            this.bndnavPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsrcPreferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxPreferencias;
        private System.Windows.Forms.Button btnDesvCond;
        private System.Windows.Forms.Button btnImpTxtWhile;
        private System.Windows.Forms.Button btnBdCon;
        private System.Windows.Forms.Button btnBdDesc;
        private System.Windows.Forms.Button btnConsultarBd;
        private System.Windows.Forms.Button btnIncluirBd;
        private System.Windows.Forms.Button btnExcluirBd;
        private System.Windows.Forms.Button btnAlterarBd;
        private System.Windows.Forms.DataGridView dtgdvwPreferencias;
        private System.Windows.Forms.BindingSource bndsrcPreferencias;
        private System.Windows.Forms.BindingNavigator bndnavPreferencias;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bndnavbtnConfirmar;
        private System.Windows.Forms.ToolStripTextBox bndnavtxtPesquisar;
        private System.Windows.Forms.ToolStripButton bndnavbtnPesquisar;
    }
}

