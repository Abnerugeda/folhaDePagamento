namespace folhaDePagamento.Forms
{
    partial class AdicionarFuncionario
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            boxNome = new TextBox();
            boxEmail = new TextBox();
            boxCpf = new MaskedTextBox();
            boxTel = new MaskedTextBox();
            boxDataNasc = new MaskedTextBox();
            boxRg = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            boxLogradouro = new TextBox();
            label11 = new Label();
            boxNumero = new TextBox();
            label12 = new Label();
            boxBairro = new TextBox();
            label13 = new Label();
            boxCep = new MaskedTextBox();
            label14 = new Label();
            boxMunicipio = new TextBox();
            label15 = new Label();
            boxUf = new TextBox();
            btnCadastrar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            boxComplemento = new TextBox();
            label16 = new Label();
            label17 = new Label();
            boxEstadoCivil = new ComboBox();
            boxGenero = new ComboBox();
            label18 = new Label();
            boxTelefoneRes = new MaskedTextBox();
            label19 = new Label();
            label20 = new Label();
            boxNivelAcess = new ComboBox();
            boxPis = new TextBox();
            label21 = new Label();
            label22 = new Label();
            boxDataAdmissao = new MaskedTextBox();
            label1 = new Label();
            boxDDD = new MaskedTextBox();
            boxSalario = new TextBox();
            boxCargo = new TextBox();
            label23 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(600, 117);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 1;
            label2.Text = "RG:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 80);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome Completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(374, 80);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(618, 80);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 4;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(140, 117);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 5;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 345);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 6;
            label7.Text = "Logradouro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(383, 117);
            label8.Name = "label8";
            label8.Size = new Size(132, 21);
            label8.TabIndex = 7;
            label8.Text = "Data Nascimento:";
            // 
            // boxNome
            // 
            boxNome.BackColor = Color.GhostWhite;
            boxNome.Location = new Point(160, 78);
            boxNome.Name = "boxNome";
            boxNome.Size = new Size(198, 23);
            boxNome.TabIndex = 9;
            // 
            // boxEmail
            // 
            boxEmail.BackColor = Color.GhostWhite;
            boxEmail.Location = new Point(431, 78);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(172, 23);
            boxEmail.TabIndex = 10;
            // 
            // boxCpf
            // 
            boxCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxCpf.Location = new Point(666, 80);
            boxCpf.Mask = "999.999.999-99";
            boxCpf.Name = "boxCpf";
            boxCpf.Size = new Size(100, 25);
            boxCpf.TabIndex = 12;
            // 
            // boxTel
            // 
            boxTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxTel.Location = new Point(255, 117);
            boxTel.Mask = "00000-0000";
            boxTel.Name = "boxTel";
            boxTel.Size = new Size(111, 25);
            boxTel.TabIndex = 13;
            // 
            // boxDataNasc
            // 
            boxDataNasc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDataNasc.Location = new Point(518, 117);
            boxDataNasc.Mask = "00/00/0000";
            boxDataNasc.Name = "boxDataNasc";
            boxDataNasc.Size = new Size(69, 25);
            boxDataNasc.TabIndex = 14;
            boxDataNasc.ValidatingType = typeof(DateTime);
            // 
            // boxRg
            // 
            boxRg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxRg.Location = new Point(640, 117);
            boxRg.Mask = "00.000.000.-0";
            boxRg.Name = "boxRg";
            boxRg.Size = new Size(126, 25);
            boxRg.TabIndex = 15;
            boxRg.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Indigo;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(28, 9);
            label9.Name = "label9";
            label9.Size = new Size(241, 48);
            label9.TabIndex = 16;
            label9.Text = "Dados Pessoas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Indigo;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(26, 279);
            label10.Name = "label10";
            label10.Size = new Size(162, 48);
            label10.TabIndex = 17;
            label10.Text = "Endereço";
            // 
            // boxLogradouro
            // 
            boxLogradouro.BackColor = Color.GhostWhite;
            boxLogradouro.Location = new Point(123, 345);
            boxLogradouro.Name = "boxLogradouro";
            boxLogradouro.Size = new Size(216, 23);
            boxLogradouro.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(358, 345);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 19;
            label11.Text = "Número:";
            // 
            // boxNumero
            // 
            boxNumero.BackColor = Color.GhostWhite;
            boxNumero.Location = new Point(435, 345);
            boxNumero.Name = "boxNumero";
            boxNumero.Size = new Size(82, 23);
            boxNumero.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(532, 345);
            label12.Name = "label12";
            label12.Size = new Size(55, 21);
            label12.TabIndex = 21;
            label12.Text = "Bairro:";
            // 
            // boxBairro
            // 
            boxBairro.BackColor = Color.GhostWhite;
            boxBairro.Location = new Point(593, 345);
            boxBairro.Name = "boxBairro";
            boxBairro.Size = new Size(173, 23);
            boxBairro.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(26, 385);
            label13.Name = "label13";
            label13.Size = new Size(40, 21);
            label13.TabIndex = 23;
            label13.Text = "CEP:";
            // 
            // boxCep
            // 
            boxCep.Location = new Point(72, 385);
            boxCep.Mask = "00000-999";
            boxCep.Name = "boxCep";
            boxCep.Size = new Size(77, 23);
            boxCep.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(167, 387);
            label14.Name = "label14";
            label14.Size = new Size(82, 21);
            label14.TabIndex = 25;
            label14.Text = "Município:";
            // 
            // boxMunicipio
            // 
            boxMunicipio.BackColor = Color.GhostWhite;
            boxMunicipio.Location = new Point(255, 387);
            boxMunicipio.Name = "boxMunicipio";
            boxMunicipio.Size = new Size(173, 23);
            boxMunicipio.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(454, 387);
            label15.Name = "label15";
            label15.Size = new Size(32, 21);
            label15.TabIndex = 27;
            label15.Text = "UF:";
            // 
            // boxUf
            // 
            boxUf.BackColor = Color.GhostWhite;
            boxUf.Location = new Point(492, 387);
            boxUf.Name = "boxUf";
            boxUf.Size = new Size(44, 23);
            boxUf.TabIndex = 28;
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
            btnCadastrar.Location = new Point(485, 453);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(168, 50);
            btnCadastrar.TabIndex = 30;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
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
            btnCancelar.Location = new Point(123, 453);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 50);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // boxComplemento
            // 
            boxComplemento.BackColor = Color.GhostWhite;
            boxComplemento.Location = new Point(673, 389);
            boxComplemento.Name = "boxComplemento";
            boxComplemento.Size = new Size(93, 23);
            boxComplemento.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(555, 387);
            label16.Name = "label16";
            label16.Size = new Size(112, 21);
            label16.TabIndex = 32;
            label16.Text = "Complemento:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(26, 157);
            label17.Name = "label17";
            label17.Size = new Size(93, 21);
            label17.TabIndex = 34;
            label17.Text = "Estado Civil:";
            // 
            // boxEstadoCivil
            // 
            boxEstadoCivil.FormattingEnabled = true;
            boxEstadoCivil.Items.AddRange(new object[] { "Solteiro", "Casado", "Viúvo", "Divorciado" });
            boxEstadoCivil.Location = new Point(125, 155);
            boxEstadoCivil.Name = "boxEstadoCivil";
            boxEstadoCivil.Size = new Size(121, 23);
            boxEstadoCivil.TabIndex = 35;
            // 
            // boxGenero
            // 
            boxGenero.FormattingEnabled = true;
            boxGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            boxGenero.Location = new Point(339, 155);
            boxGenero.Name = "boxGenero";
            boxGenero.Size = new Size(121, 23);
            boxGenero.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(269, 157);
            label18.Name = "label18";
            label18.Size = new Size(64, 21);
            label18.TabIndex = 36;
            label18.Text = "Gênero:";
            // 
            // boxTelefoneRes
            // 
            boxTelefoneRes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxTelefoneRes.Location = new Point(640, 157);
            boxTelefoneRes.Mask = "0000-0000";
            boxTelefoneRes.Name = "boxTelefoneRes";
            boxTelefoneRes.Size = new Size(128, 25);
            boxTelefoneRes.TabIndex = 39;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(482, 157);
            label19.Name = "label19";
            label19.Size = new Size(152, 21);
            label19.TabIndex = 38;
            label19.Text = "Telefone Residencial:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(26, 191);
            label20.Name = "label20";
            label20.Size = new Size(120, 21);
            label20.TabIndex = 40;
            label20.Text = "Nível de acesso:";
            // 
            // boxNivelAcess
            // 
            boxNivelAcess.FormattingEnabled = true;
            boxNivelAcess.Items.AddRange(new object[] { "0", "1", "2" });
            boxNivelAcess.Location = new Point(152, 191);
            boxNivelAcess.Name = "boxNivelAcess";
            boxNivelAcess.Size = new Size(128, 23);
            boxNivelAcess.TabIndex = 41;
            // 
            // boxPis
            // 
            boxPis.BackColor = Color.GhostWhite;
            boxPis.Location = new Point(67, 117);
            boxPis.Name = "boxPis";
            boxPis.Size = new Size(52, 23);
            boxPis.TabIndex = 43;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(26, 117);
            label21.Name = "label21";
            label21.Size = new Size(35, 21);
            label21.TabIndex = 42;
            label21.Text = "PIS:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(286, 191);
            label22.Name = "label22";
            label22.Size = new Size(61, 21);
            label22.TabIndex = 44;
            label22.Text = "Salário:";
            // 
            // boxDataAdmissao
            // 
            boxDataAdmissao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDataAdmissao.Location = new Point(588, 193);
            boxDataAdmissao.Mask = "00/00/0000";
            boxDataAdmissao.Name = "boxDataAdmissao";
            boxDataAdmissao.Size = new Size(69, 25);
            boxDataAdmissao.TabIndex = 47;
            boxDataAdmissao.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(465, 193);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 46;
            label1.Text = "Data Admissão:";
            // 
            // boxDDD
            // 
            boxDDD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            boxDDD.Location = new Point(216, 117);
            boxDDD.Mask = "(00)";
            boxDDD.Name = "boxDDD";
            boxDDD.Size = new Size(30, 25);
            boxDDD.TabIndex = 48;
            // 
            // boxSalario
            // 
            boxSalario.BackColor = Color.GhostWhite;
            boxSalario.Location = new Point(347, 193);
            boxSalario.Name = "boxSalario";
            boxSalario.Size = new Size(112, 23);
            boxSalario.TabIndex = 49;
            boxSalario.KeyDown += boxSalario_KeyDown;
            boxSalario.KeyPress += boxSalario_KeyPress;
            // 
            // boxCargo
            // 
            boxCargo.BackColor = Color.GhostWhite;
            boxCargo.Location = new Point(87, 235);
            boxCargo.Name = "boxCargo";
            boxCargo.Size = new Size(372, 23);
            boxCargo.TabIndex = 51;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(26, 233);
            label23.Name = "label23";
            label23.Size = new Size(55, 21);
            label23.TabIndex = 50;
            label23.Text = "Cargo:";
            label23.Click += label23_Click;
            // 
            // AdicionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(800, 524);
            ControlBox = false;
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
            MaximizeBox = false;
            MaximumSize = new Size(816, 563);
            MinimizeBox = false;
            MinimumSize = new Size(816, 540);
            Name = "AdicionarFuncionario";
            Text = "Cadastrar Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox boxNome;
        private TextBox boxEmail;
        private MaskedTextBox boxCpf;
        private MaskedTextBox boxTel;
        private MaskedTextBox boxDataNasc;
        private MaskedTextBox boxRg;
        private Label label9;
        private Label label10;
        private TextBox boxLogradouro;
        private Label label11;
        private TextBox boxNumero;
        private Label label12;
        private TextBox boxBairro;
        private Label label13;
        private MaskedTextBox boxCep;
        private Label label14;
        private TextBox boxMunicipio;
        private Label label15;
        private TextBox boxUf;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox boxComplemento;
        private Label label16;
        private Label label17;
        private ComboBox boxEstadoCivil;
        private ComboBox boxGenero;
        private Label label18;
        private MaskedTextBox boxTelefoneRes;
        private Label label19;
        private Label label20;
        private ComboBox boxNivelAcess;
        private TextBox boxPis;
        private Label label21;
        private Label label22;
        private MaskedTextBox boxDataAdmissao;
        private Label label1;
        private MaskedTextBox boxDDD;
        private TextBox boxSalario;
        private TextBox boxCargo;
        private Label label23;
    }
}