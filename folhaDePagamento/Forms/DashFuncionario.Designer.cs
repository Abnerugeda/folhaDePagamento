namespace folhaDePagamento.Forms
{
    partial class DashFuncionario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridTotal = new DataGridView();
            ColumnTipoBase = new DataGridViewTextBoxColumn();
            ColumnBaseIrrf = new DataGridViewTextBoxColumn();
            ColumnInss = new DataGridViewTextBoxColumn();
            ColumnVencimentosTotal = new DataGridViewTextBoxColumn();
            ColumnDescontosTotal = new DataGridViewTextBoxColumn();
            ColumnTotalLiquido = new DataGridViewTextBoxColumn();
            gridCalc = new DataGridView();
            ColumnDescEvento = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnVencimentos = new DataGridViewTextBoxColumn();
            ColumnDescontos = new DataGridViewTextBoxColumn();
            label4 = new Label();
            comboNomeFunc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCalc).BeginInit();
            SuspendLayout();
            // 
            // gridTotal
            // 
            gridTotal.BackgroundColor = Color.FromArgb(34, 33, 74);
            gridTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTotal.Columns.AddRange(new DataGridViewColumn[] { ColumnTipoBase, ColumnBaseIrrf, ColumnInss, ColumnVencimentosTotal, ColumnDescontosTotal, ColumnTotalLiquido });
            gridTotal.Location = new Point(5, 367);
            gridTotal.Name = "gridTotal";
            gridTotal.RowTemplate.Height = 25;
            gridTotal.Size = new Size(799, 142);
            gridTotal.TabIndex = 25;
            // 
            // ColumnTipoBase
            // 
            ColumnTipoBase.HeaderText = "Tipo Base";
            ColumnTipoBase.Name = "ColumnTipoBase";
            ColumnTipoBase.Width = 110;
            // 
            // ColumnBaseIrrf
            // 
            ColumnBaseIrrf.HeaderText = "Base do Irrf";
            ColumnBaseIrrf.Name = "ColumnBaseIrrf";
            // 
            // ColumnInss
            // 
            ColumnInss.HeaderText = "Base do Inss";
            ColumnInss.Name = "ColumnInss";
            // 
            // ColumnVencimentosTotal
            // 
            ColumnVencimentosTotal.HeaderText = "Vencimentos";
            ColumnVencimentosTotal.Name = "ColumnVencimentosTotal";
            // 
            // ColumnDescontosTotal
            // 
            ColumnDescontosTotal.HeaderText = "Descontos";
            ColumnDescontosTotal.Name = "ColumnDescontosTotal";
            // 
            // ColumnTotalLiquido
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            ColumnTotalLiquido.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnTotalLiquido.HeaderText = "Total Líquido";
            ColumnTotalLiquido.Name = "ColumnTotalLiquido";
            ColumnTotalLiquido.Width = 240;
            // 
            // gridCalc
            // 
            gridCalc.BackgroundColor = Color.FromArgb(34, 33, 74);
            gridCalc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCalc.Columns.AddRange(new DataGridViewColumn[] { ColumnDescEvento, ColumnQuantidade, ColumnVencimentos, ColumnDescontos });
            gridCalc.Location = new Point(5, 165);
            gridCalc.Name = "gridCalc";
            gridCalc.RowTemplate.Height = 25;
            gridCalc.Size = new Size(799, 205);
            gridCalc.TabIndex = 24;
            // 
            // ColumnDescEvento
            // 
            ColumnDescEvento.HeaderText = "Descrição do Evento";
            ColumnDescEvento.Name = "ColumnDescEvento";
            ColumnDescEvento.ToolTipText = "oi";
            ColumnDescEvento.Width = 277;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.Width = 150;
            // 
            // ColumnVencimentos
            // 
            ColumnVencimentos.HeaderText = "Vencimentos";
            ColumnVencimentos.Name = "ColumnVencimentos";
            ColumnVencimentos.Width = 150;
            // 
            // ColumnDescontos
            // 
            ColumnDescontos.HeaderText = "Descontos";
            ColumnDescontos.Name = "ColumnDescontos";
            ColumnDescontos.Width = 172;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 74);
            label4.Name = "label4";
            label4.Size = new Size(194, 19);
            label4.TabIndex = 27;
            label4.Text = "NOME FUNCIONARIO - DATA";
            // 
            // comboNomeFunc
            // 
            comboNomeFunc.FormattingEnabled = true;
            comboNomeFunc.Items.AddRange(new object[] { "Diurno", "Noturno" });
            comboNomeFunc.Location = new Point(5, 96);
            comboNomeFunc.Name = "comboNomeFunc";
            comboNomeFunc.Size = new Size(794, 23);
            comboNomeFunc.TabIndex = 26;
            comboNomeFunc.SelectedIndexChanged += comboNomeFunc_SelectedIndexChanged;
            // 
            // DashFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(811, 513);
            Controls.Add(label4);
            Controls.Add(comboNomeFunc);
            Controls.Add(gridTotal);
            Controls.Add(gridCalc);
            MaximumSize = new Size(827, 552);
            MinimumSize = new Size(827, 552);
            Name = "DashFuncionario";
            ((System.ComponentModel.ISupportInitialize)gridTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCalc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTotal;
        private DataGridViewTextBoxColumn ColumnTipoBase;
        private DataGridViewTextBoxColumn ColumnBaseIrrf;
        private DataGridViewTextBoxColumn ColumnInss;
        private DataGridViewTextBoxColumn ColumnVencimentosTotal;
        private DataGridViewTextBoxColumn ColumnDescontosTotal;
        private DataGridViewTextBoxColumn ColumnTotalLiquido;
        private DataGridView gridCalc;
        private DataGridViewTextBoxColumn ColumnDescEvento;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnVencimentos;
        private DataGridViewTextBoxColumn ColumnDescontos;
        private Label label4;
        private ComboBox comboNomeFunc;
    }
}