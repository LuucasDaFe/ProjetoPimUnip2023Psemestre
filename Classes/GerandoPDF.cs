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
        public void abrirPdfHolerite()
        {
            string nomeArquivo = @"C:\Users\Lucas\Desktop\PIM 1° SEMESTRE\ProjetoPimUnip2023Psemestre\Holerites\Lucas\\holerite.pdf";
            FileStream ArquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, ArquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\\Users\\Lucas\\Desktop\\PIM 1° SEMESTRE\\ProjetoPimUnip2023Psemestre\\Holerites\\Lucas\\logo.png");
            logo.ScaleToFit(140f, 120);

            logo.SetAbsolutePosition(100f, 700f);

            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("HOLERITE");

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Close();
        }
    }
}
