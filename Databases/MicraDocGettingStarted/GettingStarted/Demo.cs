namespace GettingStarted
{
    using MigraDoc.DocumentObjectModel;
    using MigraDoc.DocumentObjectModel.Tables;
    using MigraDoc.Rendering;
    using PdfSharp.Pdf;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Demo
    {
        static void Main()
        {
            //var document = new Document();

            //Section section = document.AddSection();
            //section.AddParagraph("Hello, World!");
            //section.AddParagraph();

            //Paragraph paragraph = section.AddParagraph();
            //paragraph.Format.Font.Color = Color.FromCmyk(100, 30, 20, 50);
            //paragraph.AddFormattedText("Hello, World!", TextFormat.Underline);

            //FormattedText ft = paragraph.AddFormattedText("Small text", TextFormat.Bold);
            //ft.Font.Size = 6;

            //PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false, PdfFontEmbedding.Always);
            //pdfRenderer.Document = document;

            //pdfRenderer.RenderDocument();

            //string filename = "HelloWorld.pdf";
            //pdfRenderer.PdfDocument.Save(filename);

            //Process.Start(filename);

            Document document = new Document();
            document.Info.Author = "Rolf Baxter";
            document.Info.Keywords = "MigraDoc, Examples, C#";

            // Get the A4 page size
            Unit width, height;
            PageSetup.GetPageSize(PageFormat.A4, out width, out height);

            // Add a section to the document and configure it such that it will be in the centre
            // of the page
            Section section = document.AddSection();
            section.PageSetup.PageHeight = height;
            section.PageSetup.PageWidth = width;
            section.PageSetup.LeftMargin = 0;
            section.PageSetup.RightMargin = 0;
            section.PageSetup.TopMargin = height / 2;

            // Create a table so that we can draw the horizontal lines
            Table table = new Table();
            table.Borders.Width = 1; // Default to show borders 1 pixel wide Column
            var column = table.AddColumn(width);
            column.Format.Alignment = ParagraphAlignment.Center;

            double fontHeight = 36;
            Font font = new Font("Times New Roman", fontHeight);

            // Add a row with a single cell for the first line
            Row row = table.AddRow();
            Cell cell = row.Cells[0];

            cell.Format.Font.Color = Colors.Black;
            cell.Format.Font.ApplyFont(font);
            cell.Borders.Left.Visible = false;
            cell.Borders.Right.Visible = false;
            cell.Borders.Bottom.Visible = false;

            cell.AddParagraph("Hello, World!");

            // Add a row with a single cell for the second line
            row = table.AddRow();
            cell = row.Cells[0];

            cell.Format.Font.Color = Colors.Black;
            cell.Format.Alignment = ParagraphAlignment.Left;
            cell.Format.Font.ApplyFont(font);
            cell.Borders.Left.Visible = false;
            cell.Borders.Right.Visible = false;
            cell.Borders.Top.Visible = false;

            cell.AddParagraph("This is some long text that *will* auto-wrap when the edge of the page is reached");

            document.LastSection.Add(table);

            // Create a renderer
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();

            // Associate the MigraDoc document with a renderer
            pdfRenderer.Document = document;

            // Layout and render document to PDF
            pdfRenderer.RenderDocument();

            // Save and show the document
            pdfRenderer.PdfDocument.Save

            ("TestDocument.pdf");
            Process.Start("TestDocument.pdf");
        }
    }
}
