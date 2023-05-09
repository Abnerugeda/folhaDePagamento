using folhaDePagamento.controller;
using folhaDePagamento.services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace folhaDePagamento.Forms
{
    public partial class FormFolha : Form
    {
  
        private Form currentChildForm;
        public FormFolha()
        {
            InitializeComponent();
            PopularBox();
            dateTimeFim.Format = DateTimePickerFormat.Custom;
            dateTimeFim.CustomFormat = "dd/MM/yyyy";
            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = "dd/MM/yyyy";


        }


        public void PopularBox()
        {
            String[] item = new string[6];
            foreach (ListFuncionarios funcionario in funcionariosAll())
            {
                item[0] = funcionario.Id.ToString();
                item[1] = funcionario.Nome;
                item[2] = funcionario.Cpf;
                item[3] = funcionario.DataAdmissao;
                item[4] = funcionario.Salario;
                item[5]= funcionario.Cargo;
                comboNome.Items.Add(item[1]);
            }
        }
        private List<ListFuncionarios> funcionariosAll(){
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = connect.queryFunc();
            return listFunc;
        }

        private void comboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var funcionarioSelecionado = comboNome.SelectedItem.ToString();
            foreach (ListFuncionarios funcionario in funcionariosAll())
            {
                if (funcionarioSelecionado == funcionario.Nome.ToString())
                {
                    boxDataAdmissao.Text = funcionario.DataAdmissao;
                    boxCpfFolha.Text = funcionario.Cpf;
                    boxSalario.Text = funcionario.Salario;
                    boxFuncao.Text = funcionario.Cargo;
                }
            }
        
        }
        private double calculoInss(double salarioBruto)
        {
            if(salarioBruto < 1302.00){
                return salarioBruto * 0.75;
            }else if(salarioBruto < 2571.29 && salarioBruto > 1302.00)
            {
                return (salarioBruto - 1302.00) * 0.09 + 97.65;
            }else if(salarioBruto < 3856.94 && salarioBruto > 2571.29)
            {
                return (salarioBruto - 2571.29) * 0.12 + 114.24 + 97.65;
            }else
            {
                return (7507.49 - 3856.94) * 0.14 + 114.24 + 97.65 + 154.28;
            }
        }

        private void btnGerFolha_Click(object sender, EventArgs e)
        {

            double salario = double.Parse(boxSalario.Text);
            double inss = calculoInss(salario);
            DateTime data1 = dateTimeFim.Value;
            DateTime data2 = dateTimeInicio.Value;
            gridCalc.AllowUserToAddRows = false;
            gridTotal.AllowUserToAddRows = false;
            double diferencaDias = (data1 - data2).Days;
            double irrf = calculoIrrf(double.Parse(boxSalario.Text));
            if (diferencaDias > 0)
            {
                PopularDataGrip(salario, inss, irrf, diferencaDias);
            }
            else { MessageBox.Show("Os dias trabalhados devem ser maiores do que zero.");}
            CriarPDF();

        }

        private double calculoIrrf(double salarioBase)
        {
            if (salarioBase <= 1903.98)
            {
                return 0;
            }
            else if (salarioBase <= 2826.65)
            {
                return (salarioBase * 0.075) -142.80;
            }
            else if (salarioBase <= 3751.05)
            {
                return (salarioBase * 0.15) - 354.80;
            }
            else if (salarioBase <= 4664.68)
            {
                return (salarioBase * 0.225) - 636.13;
            }
            else
            {
                return (salarioBase * 0.275) - 869.36;
            }
        }

        private void CriarPDF()
        {

        if (gridCalc.Rows.Count > 0)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Result.pdf";
            
            bool ErrorMessage = false;
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(save.FileName))
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage = true;
                        MessageBox.Show("Unable to wride data in disk" + ex.Message);
                    }
                }
                if (!ErrorMessage)
                {
                    try
                    {
                        PdfPTable pTable = new PdfPTable(gridCalc.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in gridCalc.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in gridCalc.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                   
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            PdfPTable pTable2 = new PdfPTable(gridTotal.Columns.Count);
                            pTable2.DefaultCell.Padding = 2;
                            pTable2.WidthPercentage = 100;
                            pTable2.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in gridTotal.Columns)
                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable2.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in gridTotal.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                { 
                                    pTable2.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Add(pTable2);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("PDF salvo com sucesso!", "info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while exporting Data" + ex);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("No Record Found", "Info");
        }
            
        }

        public void PopularDataGrip(double salario, double inss, double irrf, double diferencaDias)
        {
            double salarioDiv= salario / 30;
            double salarioCompleto = salarioDiv * diferencaDias;
            gridCalc.Rows.Add("DIAS TRABALHADOS", diferencaDias, salarioCompleto, "");
            gridCalc.Rows.Add("DESCONTO DE INSS", "", "", inss.ToString("0.00"));
            gridCalc.Rows.Add("DESCONTO DE I.R.F", irrf, "", irrf.ToString("0.00"));
            gridCalc.Rows.Add("", "", "", "");
            gridCalc.Rows.Add("", "", "", "");
            gridCalc.Rows.Add("", "", "", "");
            gridTotal.Rows.Add("Salário", 0, "", salario, salario, inss, (salarioCompleto-inss-irrf).ToString("0.00"));
            gridTotal.Rows.Add("", "","","","","","");
            gridTotal.Rows.Add("", "", "", "Valor do Fgts", "", "", "");
            gridTotal.Rows.Add("", "", "", "0", "", "", "");
        }
        //private void insertFolha()
        //{
        //    ConnectDatabase db = new ConnectDatabase();
        //    MySqlCommand comm = db.connect().CreateCommand();
        //    comm.CommandText = "INSERT INTO FOLHA VALUES (DEFAULT, @IDFUNCIONARIO, @SALARIOLQIUIDO, @SALARIOBRUTO, @FGTS, @VT, @CONVENIO, @IRRF, @INSS, @DESCFALTA);";
        //    comm.Parameters.AddWithValue("@IDFUNCINOARIO", ),
        //    comm.Parameters.AddWithValue("@SALARIOLQIUIDO, ")
        //}
    }
}
