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
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.boxDDD = new System.Windows.Forms.MaskedTextBox();
            this.boxDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.boxPis = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.boxNivelAcess = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.boxTelefoneRes = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.boxGenero = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.boxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.boxComplemento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.boxUf = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.boxMunicipio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.boxCep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boxBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.boxNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxRg = new System.Windows.Forms.MaskedTextBox();
            this.boxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.boxTel = new System.Windows.Forms.MaskedTextBox();
            this.boxCpf = new System.Windows.Forms.MaskedTextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxSalario
            // 
            this.boxSalario.BackColor = System.Drawing.Color.GhostWhite;
            this.boxSalario.Location = new System.Drawing.Point(350, 201);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(112, 23);
            this.boxSalario.TabIndex = 94;
            // 
            // boxDDD
            // 
            this.boxDDD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxDDD.Location = new System.Drawing.Point(219, 125);
            this.boxDDD.Mask = "(00)";
            this.boxDDD.Name = "boxDDD";
            this.boxDDD.Size = new System.Drawing.Size(30, 25);
            this.boxDDD.TabIndex = 93;
            // 
            // boxDataAdmissao
            // 
            this.boxDataAdmissao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxDataAdmissao.Location = new System.Drawing.Point(591, 201);
            this.boxDataAdmissao.Mask = "00/00/0000";
            this.boxDataAdmissao.Name = "boxDataAdmissao";
            this.boxDataAdmissao.Size = new System.Drawing.Size(69, 25);
            this.boxDataAdmissao.TabIndex = 92;
            this.boxDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 91;
            this.label1.Text = "Data Admissão:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(289, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 21);
            this.label22.TabIndex = 90;
            this.label22.Text = "Salário:";
            // 
            // boxPis
            // 
            this.boxPis.BackColor = System.Drawing.Color.GhostWhite;
            this.boxPis.Location = new System.Drawing.Point(75, 125);
            this.boxPis.Name = "boxPis";
            this.boxPis.Size = new System.Drawing.Size(52, 23);
            this.boxPis.TabIndex = 89;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(34, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 21);
            this.label21.TabIndex = 88;
            this.label21.Text = "PIS:";
            // 
            // boxNivelAcess
            // 
            this.boxNivelAcess.FormattingEnabled = true;
            this.boxNivelAcess.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.boxNivelAcess.Location = new System.Drawing.Point(155, 199);
            this.boxNivelAcess.Name = "boxNivelAcess";
            this.boxNivelAcess.Size = new System.Drawing.Size(128, 23);
            this.boxNivelAcess.TabIndex = 87;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(29, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 21);
            this.label20.TabIndex = 86;
            this.label20.Text = "Nível de acesso:";
            // 
            // boxTelefoneRes
            // 
            this.boxTelefoneRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxTelefoneRes.Location = new System.Drawing.Point(643, 165);
            this.boxTelefoneRes.Mask = "0000-0000";
            this.boxTelefoneRes.Name = "boxTelefoneRes";
            this.boxTelefoneRes.Size = new System.Drawing.Size(128, 25);
            this.boxTelefoneRes.TabIndex = 85;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(485, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 21);
            this.label19.TabIndex = 84;
            this.label19.Text = "Telefone Residencial:";
            // 
            // boxGenero
            // 
            this.boxGenero.FormattingEnabled = true;
            this.boxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.boxGenero.Location = new System.Drawing.Point(342, 163);
            this.boxGenero.Name = "boxGenero";
            this.boxGenero.Size = new System.Drawing.Size(121, 23);
            this.boxGenero.TabIndex = 83;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(272, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 21);
            this.label18.TabIndex = 82;
            this.label18.Text = "Gênero:";
            // 
            // boxEstadoCivil
            // 
            this.boxEstadoCivil.FormattingEnabled = true;
            this.boxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo",
            "Divorciado"});
            this.boxEstadoCivil.Location = new System.Drawing.Point(128, 163);
            this.boxEstadoCivil.Name = "boxEstadoCivil";
            this.boxEstadoCivil.Size = new System.Drawing.Size(121, 23);
            this.boxEstadoCivil.TabIndex = 81;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(29, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 21);
            this.label17.TabIndex = 80;
            this.label17.Text = "Estado Civil:";
            // 
            // boxComplemento
            // 
            this.boxComplemento.BackColor = System.Drawing.Color.GhostWhite;
            this.boxComplemento.Location = new System.Drawing.Point(676, 370);
            this.boxComplemento.Name = "boxComplemento";
            this.boxComplemento.Size = new System.Drawing.Size(93, 23);
            this.boxComplemento.TabIndex = 79;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(558, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 21);
            this.label16.TabIndex = 78;
            this.label16.Text = "Complemento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(126, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 50);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 3;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnCadastrar.IconColor = System.Drawing.Color.White;
            this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrar.IconSize = 25;
            this.btnCadastrar.Location = new System.Drawing.Point(488, 434);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(168, 50);
            this.btnCadastrar.TabIndex = 76;
            this.btnCadastrar.Text = "Alterar Dados";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // boxUf
            // 
            this.boxUf.BackColor = System.Drawing.Color.GhostWhite;
            this.boxUf.Location = new System.Drawing.Point(495, 368);
            this.boxUf.Name = "boxUf";
            this.boxUf.Size = new System.Drawing.Size(44, 23);
            this.boxUf.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(457, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 21);
            this.label15.TabIndex = 74;
            this.label15.Text = "UF:";
            // 
            // boxMunicipio
            // 
            this.boxMunicipio.BackColor = System.Drawing.Color.GhostWhite;
            this.boxMunicipio.Location = new System.Drawing.Point(258, 368);
            this.boxMunicipio.Name = "boxMunicipio";
            this.boxMunicipio.Size = new System.Drawing.Size(173, 23);
            this.boxMunicipio.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(170, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 21);
            this.label14.TabIndex = 72;
            this.label14.Text = "Município:";
            // 
            // boxCep
            // 
            this.boxCep.Location = new System.Drawing.Point(75, 366);
            this.boxCep.Mask = "00000-999";
            this.boxCep.Name = "boxCep";
            this.boxCep.Size = new System.Drawing.Size(77, 23);
            this.boxCep.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 21);
            this.label13.TabIndex = 70;
            this.label13.Text = "CEP:";
            // 
            // boxBairro
            // 
            this.boxBairro.BackColor = System.Drawing.Color.GhostWhite;
            this.boxBairro.Location = new System.Drawing.Point(596, 326);
            this.boxBairro.Name = "boxBairro";
            this.boxBairro.Size = new System.Drawing.Size(173, 23);
            this.boxBairro.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(535, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 68;
            this.label12.Text = "Bairro:";
            // 
            // boxNumero
            // 
            this.boxNumero.BackColor = System.Drawing.Color.GhostWhite;
            this.boxNumero.Location = new System.Drawing.Point(438, 326);
            this.boxNumero.Name = "boxNumero";
            this.boxNumero.Size = new System.Drawing.Size(82, 23);
            this.boxNumero.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(361, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 66;
            this.label11.Text = "Número:";
            // 
            // boxLogradouro
            // 
            this.boxLogradouro.BackColor = System.Drawing.Color.GhostWhite;
            this.boxLogradouro.Location = new System.Drawing.Point(126, 326);
            this.boxLogradouro.Name = "boxLogradouro";
            this.boxLogradouro.Size = new System.Drawing.Size(216, 23);
            this.boxLogradouro.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Indigo;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(29, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 48);
            this.label10.TabIndex = 64;
            this.label10.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Indigo;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(31, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 48);
            this.label9.TabIndex = 63;
            this.label9.Text = "Dados Pessoas";
            // 
            // boxRg
            // 
            this.boxRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxRg.Location = new System.Drawing.Point(643, 125);
            this.boxRg.Mask = "00.000.000.-0";
            this.boxRg.Name = "boxRg";
            this.boxRg.Size = new System.Drawing.Size(126, 25);
            this.boxRg.TabIndex = 62;
            this.boxRg.ValidatingType = typeof(System.DateTime);
            // 
            // boxDataNasc
            // 
            this.boxDataNasc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxDataNasc.Location = new System.Drawing.Point(521, 125);
            this.boxDataNasc.Mask = "00/00/0000";
            this.boxDataNasc.Name = "boxDataNasc";
            this.boxDataNasc.Size = new System.Drawing.Size(69, 25);
            this.boxDataNasc.TabIndex = 61;
            this.boxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // boxTel
            // 
            this.boxTel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxTel.Location = new System.Drawing.Point(258, 125);
            this.boxTel.Mask = "00000-0000";
            this.boxTel.Name = "boxTel";
            this.boxTel.Size = new System.Drawing.Size(111, 25);
            this.boxTel.TabIndex = 60;
            // 
            // boxCpf
            // 
            this.boxCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxCpf.Location = new System.Drawing.Point(669, 88);
            this.boxCpf.Mask = "999.999.999-99";
            this.boxCpf.Name = "boxCpf";
            this.boxCpf.Size = new System.Drawing.Size(100, 25);
            this.boxCpf.TabIndex = 59;
            // 
            // boxEmail
            // 
            this.boxEmail.BackColor = System.Drawing.Color.GhostWhite;
            this.boxEmail.Location = new System.Drawing.Point(434, 86);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(172, 23);
            this.boxEmail.TabIndex = 58;
            // 
            // boxNome
            // 
            this.boxNome.BackColor = System.Drawing.Color.GhostWhite;
            this.boxNome.Location = new System.Drawing.Point(163, 86);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(198, 23);
            this.boxNome.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(386, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Data Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Logradouro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(143, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(621, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "RG:";
            // 
            // AlterarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.boxDDD);
            this.Controls.Add(this.boxDataAdmissao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.boxPis);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.boxNivelAcess);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.boxTelefoneRes);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.boxGenero);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.boxEstadoCivil);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.boxComplemento);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.boxUf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.boxMunicipio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.boxCep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.boxBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boxNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boxLogradouro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxRg);
            this.Controls.Add(this.boxDataNasc);
            this.Controls.Add(this.boxTel);
            this.Controls.Add(this.boxCpf);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(816, 540);
            this.MinimumSize = new System.Drawing.Size(816, 540);
            this.Name = "AlterarDados";
            this.ShowIcon = false;
            this.Text = "Alterar Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}