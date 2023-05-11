using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjetoPimUnip2023Psemestre.Classes
{
    internal class GerandoPDF
    {
        public void gerandoPdfHolerite(string id_funcionario, string mes)
        {
            Classes.ConexaoBd bd = new Classes.ConexaoBd();

            string salarioDoRegistro = bd.lerDadosFloat("salario", "funcionario_cargo", id_funcionario);
            string nome = bd.consultarOutros("nome", "funcionario", id_funcionario);
            string cargo = bd.lerTableFuncionario_Cargo(id_funcionario);
            string departamento = bd.lerTableFuncionario_Departamento(id_funcionario);

            //string id_cargo = bd.verificaIdCargo(id_funcionario);

            //string dataPagamento = bd.mostrarMesHolerite(id_cargo, mes);
            //string periodo_dias = bd.lerDadosHolerite("periodo_dias", "holerite", id_cargo);
            //string faltas = bd.lerDadosHolerite("faltas", "holerite", id_cargo);
            //string outros_descontos = bd.lerDadosFloatolerite("outros_descontos", "holerite", id_cargo);
            //string inss = bd.lerDadosHolerite("inss", "holerite", id_cargo);



            string nomeArquivo = @"C:\Users\Lucas\Desktop\PIM 1° SEMESTRE\ProjetoPimUnip2023Psemestre\Holerites\Lucas\\holerite.pdf";
            FileStream ArquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, ArquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\\Users\\Lucas\\Desktop\\PIM 1° SEMESTRE\\ProjetoPimUnip2023Psemestre\\Holerites\\Lucas\\logo.png");
            logo.ScaleToFit(100f, 80);

            logo.SetAbsolutePosition(20f, 770f);

            string dados = "";

            //Criando Paragrafos
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_RIGHT;
            //paragrafo.Add("HOLERITE");
            paragrafo.Add("\n");


            //Criando Tabelas 
            PdfPTable tabela1 = new PdfPTable(2);// 3 colunad
            //tabela1.DefaultCell.FixedHeight = 50;
            //Criando celula
            //PdfPCell celula = new PdfPCell(new Phrase("Recibo de pagamento"));
            //tabela1.AddCell(celula);
            //celula.Colspan = 3;


            tabela1.AddCell("Planeta Buguer \nRua XXX \nCNPJ: 11.222.333.4444.00");
            tabela1.AddCell($"Rebibo de pagamento \n{"dataPagamento"}");

            PdfPTable tabela2 = new PdfPTable(5);
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Add("Código");
            paragrafo2.Add("Nome");
            paragrafo3.Add("Data Adimssão");
            paragrafo4.Add("Cargo:");
            paragrafo5.Add("Departamento");
            tabela2.AddCell(paragrafo1);
            tabela2.AddCell(paragrafo2);
            tabela2.AddCell(paragrafo3);
            tabela2.AddCell(paragrafo4);
            tabela2.AddCell(paragrafo5);

            Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph paragrafo7 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph paragrafo8 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph paragrafo9 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph paragrafo10 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            paragrafo6.Add("ID");
            paragrafo7.Add(nome);
            paragrafo8.Add("dataPagamento");
            paragrafo9.Add(cargo);
            paragrafo10.Add(departamento);
            tabela2.AddCell(paragrafo6);
            tabela2.AddCell(paragrafo7);
            tabela2.AddCell(paragrafo8);
            tabela2.AddCell(paragrafo9);
            tabela2.AddCell(paragrafo10);

            PdfPTable tabela3 = new PdfPTable(5);
            Paragraph codigoSAL = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph descricaoSAl = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph referenciaSAl = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph vencimentoSAL = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph descontoSAL = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            codigoSAL.Add("Código");
            descricaoSAl.Add("Descrição");
            referenciaSAl.Add("Referencias");
            vencimentoSAL.Add("Vencimentos:");
            descontoSAL.Add("Desoontos");
            tabela3.AddCell(codigoSAL);
            tabela3.AddCell(descricaoSAl);
            tabela3.AddCell(referenciaSAl);
            tabela3.AddCell(vencimentoSAL);
            tabela3.AddCell(descontoSAL);

            Paragraph nCod = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Regular));
            Paragraph valorDescricao = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Regular));
            Paragraph valorReferencia = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Regular));
            Paragraph valorVencimento = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Regular));
            Paragraph valorDesconto = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, (int)System.Drawing.FontStyle.Regular));
            nCod.Add("xx");//varrial coodigo holerite
            valorDescricao.Add($"SALARIO:{salarioDoRegistro:F2} R$ \nINSS {"inss"}\nIRFF xxxx\n\n\n\n");// variavel descricao holerite
            valorReferencia.Add("xx\nxx\nxxxx\n\n\n\n"); // variavel referencia holerite
            valorVencimento.Add("N Valor\n\n\n\n"); // variavel vencimento do holerite
            valorDesconto.Add($"N {"outros_descontos"}\n\n\n\n"); //varial desconto do holerite
            tabela3.AddCell(nCod);
            tabela3.AddCell(valorDescricao);
            tabela3.AddCell(valorReferencia);
            tabela3.AddCell(valorVencimento);
            tabela3.AddCell(valorDesconto);

            PdfPTable tabela4 = new PdfPTable(5);
            Paragraph salarioBase = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph contrInss = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph calcFGTS = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph fgtsMes = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph baseCalcIRRF = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            salarioBase.Add("Salário base");
            contrInss.Add("Sal. contr. INSS");
            calcFGTS.Add("Calc. FGTS");
            fgtsMes.Add("FGTS do mês:");
            baseCalcIRRF.Add("Base Calc. IRRF");
            tabela3.AddCell(salarioBase);
            tabela3.AddCell(contrInss);
            tabela3.AddCell(calcFGTS);
            tabela3.AddCell(fgtsMes);
            tabela3.AddCell(baseCalcIRRF);

            Paragraph Vsalario = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph VcontrInss = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph VcalcFgts = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph VfgtsMes = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Paragraph VbaseCalcIrrf = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular));
            Vsalario.Add(salarioDoRegistro);//varrial salrio holerite
            VcontrInss.Add("1055");// variavel Inss holerite
            VcalcFgts.Add("150"); // variavel fgts holerite
            VfgtsMes.Add("150r"); // variavel fgts do mes do holerite
            VbaseCalcIrrf.Add("1000"); //varial calc IRRF do holerite
            tabela3.AddCell(Vsalario);
            tabela3.AddCell(VcontrInss);
            tabela3.AddCell(VcalcFgts);
            tabela3.AddCell(VfgtsMes);
            tabela3.AddCell(VbaseCalcIrrf);

            Paragraph Assimatura = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Paragraph dataAssi = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            Assimatura.Alignment = Element.ALIGN_LEFT;
            dataAssi.Alignment = Element.ALIGN_RIGHT;

            Assimatura.Add("Assinatura:____________________________________________");
            dataAssi.Add("  /  /   ");

            doc.Open();
            doc.Add(logo); 
            doc.Add(paragrafo);
            doc.Add(tabela1);
            doc.Add(tabela2);
            doc.Add(tabela3);
            doc.Add(paragrafo);
            doc.Add(Assimatura);
            doc.Add(dataAssi);
            doc.Close();

            System.Diagnostics.Process.Start("C:\\Users\\Lucas\\Desktop\\PIM 1° SEMESTRE\\ProjetoPimUnip2023Psemestre\\Holerites\\Lucas\\\\holerite.pdf");
        }
    }
}
