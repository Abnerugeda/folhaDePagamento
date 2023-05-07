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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboNome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxFuncao = new System.Windows.Forms.TextBox();
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.checkInss = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboAvPrevio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxDataDemissao = new System.Windows.Forms.MaskedTextBox();
            this.boxData = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGerFolha = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.boxCpfFolha = new System.Windows.Forms.MaskedTextBox();
            this.gridTotal = new System.Windows.Forms.DataGridView();
            this.ColumnTipoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBaseIrrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFgts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimentosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescontosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCalc = new System.Windows.Forms.DataGridView();
            this.ColumnDescEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.boxDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeFim = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboNome
            // 
            this.comboNome.FormattingEnabled = true;
            this.comboNome.Location = new System.Drawing.Point(14, 27);
            this.comboNome.Name = "comboNome";
            this.comboNome.Size = new System.Drawing.Size(173, 23);
            this.comboNome.TabIndex = 0;
            this.comboNome.SelectedIndexChanged += new System.EventHandler(this.comboNome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da Função";
            // 
            // boxFuncao
            // 
            this.boxFuncao.Location = new System.Drawing.Point(193, 27);
            this.boxFuncao.Name = "boxFuncao";
            this.boxFuncao.Size = new System.Drawing.Size(183, 23);
            this.boxFuncao.TabIndex = 4;
            // 
            // boxSalario
            // 
            this.boxSalario.Location = new System.Drawing.Point(382, 27);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(91, 23);
            this.boxSalario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(382, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Período";
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Items.AddRange(new object[] {
            "Diurno",
            "Noturno"});
            this.comboPeriodo.Location = new System.Drawing.Point(479, 27);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(109, 23);
            this.comboPeriodo.TabIndex = 7;
            // 
            // checkInss
            // 
            this.checkInss.AutoSize = true;
            this.checkInss.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkInss.ForeColor = System.Drawing.Color.White;
            this.checkInss.Location = new System.Drawing.Point(119, 110);
            this.checkInss.Name = "checkInss";
            this.checkInss.Size = new System.Drawing.Size(115, 42);
            this.checkInss.TabIndex = 13;
            this.checkInss.Text = " Recolheu Inss\r\n S/13º Salário";
            this.checkInss.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(239, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Av. Prévio Adiantado";
            // 
            // comboAvPrevio
            // 
            this.comboAvPrevio.FormattingEnabled = true;
            this.comboAvPrevio.Location = new System.Drawing.Point(240, 121);
            this.comboAvPrevio.Name = "comboAvPrevio";
            this.comboAvPrevio.Size = new System.Drawing.Size(109, 23);
            this.comboAvPrevio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de Demissão";
            // 
            // boxDataDemissao
            // 
            this.boxDataDemissao.Location = new System.Drawing.Point(14, 121);
            this.boxDataDemissao.Mask = "00/00/0000";
            this.boxDataDemissao.Name = "boxDataDemissao";
            this.boxDataDemissao.Size = new System.Drawing.Size(100, 23);
            this.boxDataDemissao.TabIndex = 12;
            this.boxDataDemissao.ValidatingType = typeof(System.DateTime);
            // 
            // boxData
            // 
            this.boxData.Location = new System.Drawing.Point(363, 121);
            this.boxData.Mask = "00/00/0000";
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(100, 23);
            this.boxData.TabIndex = 17;
            this.boxData.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(363, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data do Aviso";
            // 
            // btnGerFolha
            // 
            this.btnGerFolha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnGerFolha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerFolha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnGerFolha.FlatAppearance.BorderSize = 3;
            this.btnGerFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerFolha.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerFolha.ForeColor = System.Drawing.Color.White;
            this.btnGerFolha.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnGerFolha.IconColor = System.Drawing.Color.White;
            this.btnGerFolha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGerFolha.IconSize = 30;
            this.btnGerFolha.Location = new System.Drawing.Point(479, 104);
            this.btnGerFolha.Name = "btnGerFolha";
            this.btnGerFolha.Size = new System.Drawing.Size(273, 50);
            this.btnGerFolha.TabIndex = 18;
            this.btnGerFolha.Text = "Gerar Folha de Pagamento";
            this.btnGerFolha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerFolha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerFolha.UseVisualStyleBackColor = false;
            this.btnGerFolha.Click += new System.EventHandler(this.btnGerFolha_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(140, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "CPF";
            // 
            // boxCpfFolha
            // 
            this.boxCpfFolha.Location = new System.Drawing.Point(140, 75);
            this.boxCpfFolha.Mask = "000.000.000-00";
            this.boxCpfFolha.Name = "boxCpfFolha";
            this.boxCpfFolha.Size = new System.Drawing.Size(187, 23);
            this.boxCpfFolha.TabIndex = 21;
            this.boxCpfFolha.ValidatingType = typeof(System.DateTime);
            // 
            // gridTotal
            // 
            this.gridTotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipoBase,
            this.ColumnBaseIrrf,
            this.ColumnInss,
            this.ColumnFgts,
            this.ColumnVencimentosTotal,
            this.ColumnDescontosTotal,
            this.ColumnTotalLiquido});
            this.gridTotal.Location = new System.Drawing.Point(12, 352);
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.RowTemplate.Height = 25;
            this.gridTotal.Size = new System.Drawing.Size(792, 142);
            this.gridTotal.TabIndex = 23;
            // 
            // ColumnTipoBase
            // 
            this.ColumnTipoBase.HeaderText = "Tipo Base";
            this.ColumnTipoBase.Name = "ColumnTipoBase";
            // 
            // ColumnBaseIrrf
            // 
            this.ColumnBaseIrrf.HeaderText = "Base do Irrf";
            this.ColumnBaseIrrf.Name = "ColumnBaseIrrf";
            // 
            // ColumnInss
            // 
            this.ColumnInss.HeaderText = "Base do Inss";
            this.ColumnInss.Name = "ColumnInss";
            // 
            // ColumnFgts
            // 
            this.ColumnFgts.HeaderText = "Base do Fgts";
            this.ColumnFgts.Name = "ColumnFgts";
            // 
            // ColumnVencimentosTotal
            // 
            this.ColumnVencimentosTotal.HeaderText = "Vencimentos";
            this.ColumnVencimentosTotal.Name = "ColumnVencimentosTotal";
            // 
            // ColumnDescontosTotal
            // 
            this.ColumnDescontosTotal.HeaderText = "Descontos";
            this.ColumnDescontosTotal.Name = "ColumnDescontosTotal";
            // 
            // ColumnTotalLiquido
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColumnTotalLiquido.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTotalLiquido.HeaderText = "Total Líquido";
            this.ColumnTotalLiquido.Name = "ColumnTotalLiquido";
            this.ColumnTotalLiquido.Width = 200;
            // 
            // gridCalc
            // 
            this.gridCalc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gridCalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCalc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDescEvento,
            this.ColumnQuantidade,
            this.ColumnVencimentos,
            this.ColumnDescontos});
            this.gridCalc.Location = new System.Drawing.Point(14, 150);
            this.gridCalc.Name = "gridCalc";
            this.gridCalc.RowTemplate.Height = 25;
            this.gridCalc.Size = new System.Drawing.Size(792, 205);
            this.gridCalc.TabIndex = 22;
            // 
            // ColumnDescEvento
            // 
            this.ColumnDescEvento.HeaderText = "Descrição do Evento";
            this.ColumnDescEvento.Name = "ColumnDescEvento";
            this.ColumnDescEvento.ToolTipText = "oi";
            this.ColumnDescEvento.Width = 277;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.Width = 150;
            // 
            // ColumnVencimentos
            // 
            this.ColumnVencimentos.HeaderText = "Vencimentos";
            this.ColumnVencimentos.Name = "ColumnVencimentos";
            this.ColumnVencimentos.Width = 150;
            // 
            // ColumnDescontos
            // 
            this.ColumnDescontos.HeaderText = "Descontos";
            this.ColumnDescontos.Name = "ColumnDescontos";
            this.ColumnDescontos.Width = 172;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // boxDataAdmissao
            // 
            this.boxDataAdmissao.Location = new System.Drawing.Point(14, 75);
            this.boxDataAdmissao.Mask = "00/00/0000";
            this.boxDataAdmissao.Name = "boxDataAdmissao";
            this.boxDataAdmissao.Size = new System.Drawing.Size(120, 23);
            this.boxDataAdmissao.TabIndex = 25;
            this.boxDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data de Admissão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(606, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Data Final";
            // 
            // dateTimeFim
            // 
            this.dateTimeFim.Location = new System.Drawing.Point(606, 75);
            this.dateTimeFim.Name = "dateTimeFim";
            this.dateTimeFim.Size = new System.Drawing.Size(110, 23);
            this.dateTimeFim.TabIndex = 27;
            this.dateTimeFim.Value = new System.DateTime(2023, 5, 7, 16, 34, 27, 0);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(464, 75);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(110, 23);
            this.dateTimeInicio.TabIndex = 29;
            this.dateTimeInicio.Value = new System.DateTime(2023, 5, 7, 16, 34, 27, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(464, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Data Inicial";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(582, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "à";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(348, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Dias trabalhados:";
            // 
            // FormFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(811, 513);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimeFim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxDataAdmissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridTotal);
            this.Controls.Add(this.gridCalc);
            this.Controls.Add(this.boxCpfFolha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGerFolha);
            this.Controls.Add(this.boxData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboAvPrevio);
            this.Controls.Add(this.checkInss);
            this.Controls.Add(this.boxDataDemissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxFuncao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNome);
            this.Name = "FormFolha";
            this.Text = "FormFolha";
            ((System.ComponentModel.ISupportInitialize)(this.gridTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboNome;
        private Label label1;
        private Label label2;
        private TextBox boxFuncao;
        private TextBox boxSalario;
        private Label label3;
        private Label label4;
        private ComboBox comboPeriodo;
        private CheckBox checkInss;
        private Label label7;
        private ComboBox comboAvPrevio;
        private Label label6;
        private MaskedTextBox boxDataDemissao;
        private MaskedTextBox boxData;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnGerFolha;
        private Label label9;
        private MaskedTextBox boxCpfFolha;
        private DataGridView gridTotal;
        private DataGridViewTextBoxColumn ColumnTipoBase;
        private DataGridViewTextBoxColumn ColumnBaseIrrf;
        private DataGridViewTextBoxColumn ColumnInss;
        private DataGridViewTextBoxColumn ColumnFgts;
        private DataGridViewTextBoxColumn ColumnVencimentosTotal;
        private DataGridViewTextBoxColumn ColumnDescontosTotal;
        private DataGridViewTextBoxColumn ColumnTotalLiquido;
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
    }
}