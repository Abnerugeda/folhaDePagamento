namespace folhaDePagamento.Forms
{
    partial class AlterarDados
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
            boxSalario = new TextBox();
            boxDDD = new MaskedTextBox();
            boxDataAdmissao = new MaskedTextBox();
            label1 = new Label();
            label22 = new Label();
            boxPis = new TextBox();
            label21 = new Label();
            boxNivelAcess = new ComboBox();
            label20 = new Label();
            boxTelefoneRes = new MaskedTextBox();
            label19 = new Label();
            boxGenero = new ComboBox();
            label18 = new Label();
            boxEstadoCivil = new ComboBox();
            label17 = new Label();
            boxComplemento = new TextBox();
            label16 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            boxUf = new TextBox();
            label15 = new Label();
            boxMunicipio = new TextBox();
            label14 = new Label();
            boxCep = new MaskedTextBox();
            label13 = new Label();
            boxBairro = new TextBox();
            label12 = new Label();
            boxNumero = new TextBox();
            label11 = new Label();
            boxLogradouro = new TextBox();
            label10 = new Label();
            label9 = new Label();
            boxRg = new MaskedTextBox();
            boxDataNasc = new MaskedTextBox();
            boxTel = new MaskedTextBox();
            boxCpf = new MaskedTextBox();
            boxEmail = new TextBox();
            boxNome = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            boxCargo = new TextBox();
            label23 = new Label();
            SuspendLayout();
            // 
            // boxSalario
            // 
            boxSalario.BackColor = Color.GhostWhite;
            boxSalario.Location = new Point(350, 201);
            boxSalario.Name = "boxSalario";
            boxSalario.Size = new Size(112, 23);
            boxSalario.TabIndex = 94;
            // 
            // boxDDD
            // 
            boxDDD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDDD.Location = new Point(219, 125);
            boxDDD.Mask = "(00)";
            boxDDD.Name = "boxDDD";
            boxDDD.Size = new Size(30, 25);
            boxDDD.TabIndex = 93;
            // 
            // boxDataAdmissao
            // 
            boxDataAdmissao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDataAdmissao.Location = new Point(591, 201);
            boxDataAdmissao.Mask = "00/00/0000";
            boxDataAdmissao.Name = "boxDataAdmissao";
            boxDataAdmissao.Size = new Size(69, 25);
            boxDataAdmissao.TabIndex = 92;
            boxDataAdmissao.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(468, 201);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 91;
            label1.Text = "Data Admissão:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(289, 199);
            label22.Name = "label22";
            label22.Size = new Size(61, 21);
            label22.TabIndex = 90;
            label22.Text = "Salário:";
            // 
            // boxPis
            // 
            boxPis.BackColor = Color.GhostWhite;
            boxPis.Location = new Point(75, 125);
            boxPis.Name = "boxPis";
            boxPis.Size = new Size(52, 23);
            boxPis.TabIndex = 89;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(34, 125);
            label21.Name = "label21";
            label21.Size = new Size(35, 21);
            label21.TabIndex = 88;
            label21.Text = "PIS:";
            // 
            // boxNivelAcess
            // 
            boxNivelAcess.FormattingEnabled = true;
            boxNivelAcess.Items.AddRange(new object[] { "0", "1", "2" });
            boxNivelAcess.Location = new Point(155, 199);
            boxNivelAcess.Name = "boxNivelAcess";
            boxNivelAcess.Size = new Size(128, 23);
            boxNivelAcess.TabIndex = 87;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(29, 199);
            label20.Name = "label20";
            label20.Size = new Size(120, 21);
            label20.TabIndex = 86;
            label20.Text = "Nível de acesso:";
            // 
            // boxTelefoneRes
            // 
            boxTelefoneRes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxTelefoneRes.Location = new Point(643, 165);
            boxTelefoneRes.Mask = "0000-0000";
            boxTelefoneRes.Name = "boxTelefoneRes";
            boxTelefoneRes.Size = new Size(128, 25);
            boxTelefoneRes.TabIndex = 85;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(485, 165);
            label19.Name = "label19";
            label19.Size = new Size(152, 21);
            label19.TabIndex = 84;
            label19.Text = "Telefone Residencial:";
            // 
            // boxGenero
            // 
            boxGenero.FormattingEnabled = true;
            boxGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            boxGenero.Location = new Point(342, 163);
            boxGenero.Name = "boxGenero";
            boxGenero.Size = new Size(121, 23);
            boxGenero.TabIndex = 83;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(272, 165);
            label18.Name = "label18";
            label18.Size = new Size(64, 21);
            label18.TabIndex = 82;
            label18.Text = "Gênero:";
            // 
            // boxEstadoCivil
            // 
            boxEstadoCivil.FormattingEnabled = true;
            boxEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Viúvo", "Divorciado" });
            boxEstadoCivil.Location = new Point(128, 163);
            boxEstadoCivil.Name = "boxEstadoCivil";
            boxEstadoCivil.Size = new Size(121, 23);
            boxEstadoCivil.TabIndex = 81;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(29, 165);
            label17.Name = "label17";
            label17.Size = new Size(93, 21);
            label17.TabIndex = 80;
            label17.Text = "Estado Civil:";
            // 
            // boxComplemento
            // 
            boxComplemento.BackColor = Color.GhostWhite;
            boxComplemento.Location = new Point(676, 391);
            boxComplemento.Name = "boxComplemento";
            boxComplemento.Size = new Size(93, 23);
            boxComplemento.TabIndex = 79;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(558, 389);
            label16.Name = "label16";
            label16.Size = new Size(112, 21);
            label16.TabIndex = 78;
            label16.Text = "Complemento:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(20, 20, 80);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 74);
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(126, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 50);
            btnCancelar.TabIndex = 77;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(20, 20, 80);
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 74);
            btnCadastrar.FlatAppearance.BorderSize = 3;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnCadastrar.IconColor = Color.White;
            btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrar.IconSize = 25;
            btnCadastrar.Location = new Point(488, 455);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(168, 50);
            btnCadastrar.TabIndex = 76;
            btnCadastrar.Text = "Alterar Dados";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // boxUf
            // 
            boxUf.BackColor = Color.GhostWhite;
            boxUf.Location = new Point(495, 389);
            boxUf.Name = "boxUf";
            boxUf.Size = new Size(44, 23);
            boxUf.TabIndex = 75;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(457, 389);
            label15.Name = "label15";
            label15.Size = new Size(32, 21);
            label15.TabIndex = 74;
            label15.Text = "UF:";
            // 
            // boxMunicipio
            // 
            boxMunicipio.BackColor = Color.GhostWhite;
            boxMunicipio.Location = new Point(258, 389);
            boxMunicipio.Name = "boxMunicipio";
            boxMunicipio.Size = new Size(173, 23);
            boxMunicipio.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(170, 389);
            label14.Name = "label14";
            label14.Size = new Size(82, 21);
            label14.TabIndex = 72;
            label14.Text = "Município:";
            // 
            // boxCep
            // 
            boxCep.Location = new Point(75, 387);
            boxCep.Mask = "00000-999";
            boxCep.Name = "boxCep";
            boxCep.Size = new Size(77, 23);
            boxCep.TabIndex = 71;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(29, 387);
            label13.Name = "label13";
            label13.Size = new Size(40, 21);
            label13.TabIndex = 70;
            label13.Text = "CEP:";
            // 
            // boxBairro
            // 
            boxBairro.BackColor = Color.GhostWhite;
            boxBairro.Location = new Point(596, 347);
            boxBairro.Name = "boxBairro";
            boxBairro.Size = new Size(173, 23);
            boxBairro.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(535, 347);
            label12.Name = "label12";
            label12.Size = new Size(55, 21);
            label12.TabIndex = 68;
            label12.Text = "Bairro:";
            // 
            // boxNumero
            // 
            boxNumero.BackColor = Color.GhostWhite;
            boxNumero.Location = new Point(438, 347);
            boxNumero.Name = "boxNumero";
            boxNumero.Size = new Size(82, 23);
            boxNumero.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(361, 347);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 66;
            label11.Text = "Número:";
            // 
            // boxLogradouro
            // 
            boxLogradouro.BackColor = Color.GhostWhite;
            boxLogradouro.Location = new Point(126, 347);
            boxLogradouro.Name = "boxLogradouro";
            boxLogradouro.Size = new Size(216, 23);
            boxLogradouro.TabIndex = 65;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Indigo;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(29, 281);
            label10.Name = "label10";
            label10.Size = new Size(162, 48);
            label10.TabIndex = 64;
            label10.Text = "Endereço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Indigo;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(31, 17);
            label9.Name = "label9";
            label9.Size = new Size(241, 48);
            label9.TabIndex = 63;
            label9.Text = "Dados Pessoas";
            // 
            // boxRg
            // 
            boxRg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxRg.Location = new Point(643, 125);
            boxRg.Mask = "00.000.000.-0";
            boxRg.Name = "boxRg";
            boxRg.Size = new Size(126, 25);
            boxRg.TabIndex = 62;
            boxRg.ValidatingType = typeof(DateTime);
            // 
            // boxDataNasc
            // 
            boxDataNasc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDataNasc.Location = new Point(521, 125);
            boxDataNasc.Mask = "00/00/0000";
            boxDataNasc.Name = "boxDataNasc";
            boxDataNasc.Size = new Size(69, 25);
            boxDataNasc.TabIndex = 61;
            boxDataNasc.ValidatingType = typeof(DateTime);
            // 
            // boxTel
            // 
            boxTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxTel.Location = new Point(258, 125);
            boxTel.Mask = "00000-0000";
            boxTel.Name = "boxTel";
            boxTel.Size = new Size(111, 25);
            boxTel.TabIndex = 60;
            // 
            // boxCpf
            // 
            boxCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxCpf.Location = new Point(669, 88);
            boxCpf.Mask = "999.999.999-99";
            boxCpf.Name = "boxCpf";
            boxCpf.Size = new Size(100, 25);
            boxCpf.TabIndex = 59;
            // 
            // boxEmail
            // 
            boxEmail.BackColor = Color.GhostWhite;
            boxEmail.Location = new Point(434, 86);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(172, 23);
            boxEmail.TabIndex = 58;
            // 
            // boxNome
            // 
            boxNome.BackColor = Color.GhostWhite;
            boxNome.Location = new Point(163, 86);
            boxNome.Name = "boxNome";
            boxNome.Size = new Size(198, 23);
            boxNome.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(386, 125);
            label8.Name = "label8";
            label8.Size = new Size(132, 21);
            label8.TabIndex = 56;
            label8.Text = "Data Nascimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 347);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 55;
            label7.Text = "Logradouro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(143, 125);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 54;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(621, 88);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 53;
            label5.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(377, 88);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 52;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 51;
            label3.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(603, 125);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 50;
            label2.Text = "RG:";
            // 
            // boxCargo
            // 
            boxCargo.BackColor = Color.GhostWhite;
            boxCargo.Location = new Point(90, 230);
            boxCargo.Name = "boxCargo";
            boxCargo.Size = new Size(372, 23);
            boxCargo.TabIndex = 96;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(29, 228);
            label23.Name = "label23";
            label23.Size = new Size(55, 21);
            label23.TabIndex = 95;
            label23.Text = "Cargo:";
            // 
            // AlterarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 524);
            Controls.Add(boxCargo);
            Controls.Add(label23);
            Controls.Add(boxSalario);
            Controls.Add(boxDDD);
            Controls.Add(boxDataAdmissao);
            Controls.Add(label1);
            Controls.Add(label22);
            Controls.Add(boxPis);
            Controls.Add(label21);
            Controls.Add(boxNivelAcess);
            Controls.Add(label20);
            Controls.Add(boxTelefoneRes);
            Controls.Add(label19);
            Controls.Add(boxGenero);
            Controls.Add(label18);
            Controls.Add(boxEstadoCivil);
            Controls.Add(label17);
            Controls.Add(boxComplemento);
            Controls.Add(label16);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(boxUf);
            Controls.Add(label15);
            Controls.Add(boxMunicipio);
            Controls.Add(label14);
            Controls.Add(boxCep);
            Controls.Add(label13);
            Controls.Add(boxBairro);
            Controls.Add(label12);
            Controls.Add(boxNumero);
            Controls.Add(label11);
            Controls.Add(boxLogradouro);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(boxRg);
            Controls.Add(boxDataNasc);
            Controls.Add(boxTel);
            Controls.Add(boxCpf);
            Controls.Add(boxEmail);
            Controls.Add(boxNome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximumSize = new Size(816, 563);
            MinimumSize = new Size(816, 540);
            Name = "AlterarDados";
            ShowIcon = false;
            Text = "Alterar Dados";
            Load += AlterarDados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxSalario;
        private MaskedTextBox boxDDD;
        private MaskedTextBox boxDataAdmissao;
        private Label label1;
        private Label label22;
        private TextBox boxPis;
        private Label label21;
        private ComboBox boxNivelAcess;
        private Label label20;
        private MaskedTextBox boxTelefoneRes;
        private Label label19;
        private ComboBox boxGenero;
        private Label label18;
        private ComboBox boxEstadoCivil;
        private Label label17;
        private TextBox boxComplemento;
        private Label label16;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private TextBox boxUf;
        private Label label15;
        private TextBox boxMunicipio;
        private Label label14;
        private MaskedTextBox boxCep;
        private Label label13;
        private TextBox boxBairro;
        private Label label12;
        private TextBox boxNumero;
        private Label label11;
        private TextBox boxLogradouro;
        private Label label10;
        private Label label9;
        private MaskedTextBox boxRg;
        private MaskedTextBox boxDataNasc;
        private MaskedTextBox boxTel;
        private MaskedTextBox boxCpf;
        private TextBox boxEmail;
        private TextBox boxNome;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox boxCargo;
        private Label label23;
    }
}