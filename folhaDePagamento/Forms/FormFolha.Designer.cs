namespace folhaDePagamento.Forms
{
    partial class FormFolha
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
            comboNome = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            boxFuncao = new TextBox();
            boxSalario = new TextBox();
            label3 = new Label();
            btnGerFolha = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            boxCpfFolha = new MaskedTextBox();
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
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            boxDataAdmissao = new MaskedTextBox();
            label5 = new Label();
            label10 = new Label();
            dateTimeFim = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCalc).BeginInit();
            SuspendLayout();
            // 
            // comboNome
            // 
            comboNome.FormattingEnabled = true;
            comboNome.Location = new Point(14, 27);
            comboNome.Name = "comboNome";
            comboNome.Size = new Size(173, 23);
            comboNome.TabIndex = 0;
            comboNome.SelectedIndexChanged += comboNome_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 5);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome do Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 5);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 3;
            label2.Text = "Descrição da Função";
            // 
            // boxFuncao
            // 
            boxFuncao.Location = new Point(193, 27);
            boxFuncao.Name = "boxFuncao";
            boxFuncao.Size = new Size(183, 23);
            boxFuncao.TabIndex = 4;
            // 
            // boxSalario
            // 
            boxSalario.Location = new Point(382, 27);
            boxSalario.Name = "boxSalario";
            boxSalario.Size = new Size(91, 23);
            boxSalario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(382, 5);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 5;
            label3.Text = "Salário";
            // 
            // btnGerFolha
            // 
            btnGerFolha.BackColor = Color.FromArgb(20, 20, 80);
            btnGerFolha.Cursor = Cursors.Hand;
            btnGerFolha.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 74);
            btnGerFolha.FlatAppearance.BorderSize = 3;
            btnGerFolha.FlatStyle = FlatStyle.Flat;
            btnGerFolha.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerFolha.ForeColor = Color.White;
            btnGerFolha.IconChar = FontAwesome.Sharp.IconChar.Pager;
            btnGerFolha.IconColor = Color.White;
            btnGerFolha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGerFolha.IconSize = 30;
            btnGerFolha.Location = new Point(479, 104);
            btnGerFolha.Name = "btnGerFolha";
            btnGerFolha.Size = new Size(273, 50);
            btnGerFolha.TabIndex = 18;
            btnGerFolha.Text = "Gerar Folha de Pagamento";
            btnGerFolha.TextAlign = ContentAlignment.MiddleLeft;
            btnGerFolha.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGerFolha.UseVisualStyleBackColor = false;
            btnGerFolha.Click += btnGerFolha_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(140, 53);
            label9.Name = "label9";
            label9.Size = new Size(33, 19);
            label9.TabIndex = 20;
            label9.Text = "CPF";
            // 
            // boxCpfFolha
            // 
            boxCpfFolha.Location = new Point(140, 75);
            boxCpfFolha.Mask = "000.000.000-00";
            boxCpfFolha.Name = "boxCpfFolha";
            boxCpfFolha.Size = new Size(187, 23);
            boxCpfFolha.TabIndex = 21;
            boxCpfFolha.ValidatingType = typeof(DateTime);
            // 
            // gridTotal
            // 
            gridTotal.BackgroundColor = Color.FromArgb(34, 33, 74);
            gridTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTotal.Columns.AddRange(new DataGridViewColumn[] { ColumnTipoBase, ColumnBaseIrrf, ColumnInss, ColumnVencimentosTotal, ColumnDescontosTotal, ColumnTotalLiquido });
            gridTotal.Location = new Point(12, 352);
            gridTotal.Name = "gridTotal";
            gridTotal.RowTemplate.Height = 25;
            gridTotal.Size = new Size(792, 142);
            gridTotal.TabIndex = 23;
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
            gridCalc.Location = new Point(12, 150);
            gridCalc.Name = "gridCalc";
            gridCalc.RowTemplate.Height = 25;
            gridCalc.Size = new Size(792, 205);
            gridCalc.TabIndex = 22;
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
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // boxDataAdmissao
            // 
            boxDataAdmissao.Location = new Point(14, 75);
            boxDataAdmissao.Mask = "00/00/0000";
            boxDataAdmissao.Name = "boxDataAdmissao";
            boxDataAdmissao.Size = new Size(120, 23);
            boxDataAdmissao.TabIndex = 25;
            boxDataAdmissao.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 53);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 24;
            label5.Text = "Data de Admissão";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(606, 53);
            label10.Name = "label10";
            label10.Size = new Size(70, 19);
            label10.TabIndex = 26;
            label10.Text = "Data Final";
            // 
            // dateTimeFim
            // 
            dateTimeFim.Location = new Point(606, 75);
            dateTimeFim.Name = "dateTimeFim";
            dateTimeFim.Size = new Size(110, 23);
            dateTimeFim.TabIndex = 27;
            dateTimeFim.Value = new DateTime(2023, 5, 7, 16, 34, 27, 0);
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(464, 75);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(110, 23);
            dateTimeInicio.TabIndex = 29;
            dateTimeInicio.Value = new DateTime(2023, 5, 7, 16, 34, 27, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(464, 53);
            label11.Name = "label11";
            label11.Size = new Size(76, 19);
            label11.TabIndex = 28;
            label11.Text = "Data Inicial";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(582, 75);
            label12.Name = "label12";
            label12.Size = new Size(18, 21);
            label12.TabIndex = 30;
            label12.Text = "à";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(348, 76);
            label13.Name = "label13";
            label13.Size = new Size(114, 19);
            label13.TabIndex = 31;
            label13.Text = "Dias trabalhados:";
            // 
            // FormFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(811, 513);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTimeInicio);
            Controls.Add(label11);
            Controls.Add(dateTimeFim);
            Controls.Add(label10);
            Controls.Add(boxDataAdmissao);
            Controls.Add(label5);
            Controls.Add(gridTotal);
            Controls.Add(gridCalc);
            Controls.Add(boxCpfFolha);
            Controls.Add(label9);
            Controls.Add(btnGerFolha);
            Controls.Add(boxSalario);
            Controls.Add(label3);
            Controls.Add(boxFuncao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboNome);
            Name = "FormFolha";
            Text = "FormFolha";
            ((System.ComponentModel.ISupportInitialize)gridTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCalc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboNome;
        private Label label1;
        private Label label2;
        private TextBox boxFuncao;
        private TextBox boxSalario;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGerFolha;
        private Label label9;
        private MaskedTextBox boxCpfFolha;
        private DataGridView gridTotal;
        private DataGridView gridCalc;
        private DataGridViewTextBoxColumn ColumnDescEvento;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnVencimentos;
        private DataGridViewTextBoxColumn ColumnDescontos;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private MaskedTextBox boxDataAdmissao;
        private Label label5;
        private Label label10;
        private DateTimePicker dateTimeFim;
        private DateTimePicker dateTimeInicio;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn ColumnTipoBase;
        private DataGridViewTextBoxColumn ColumnBaseIrrf;
        private DataGridViewTextBoxColumn ColumnInss;
        private DataGridViewTextBoxColumn ColumnVencimentosTotal;
        private DataGridViewTextBoxColumn ColumnDescontosTotal;
        private DataGridViewTextBoxColumn ColumnTotalLiquido;
    }
}