using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CarShop
{

    internal class InvoiceTemplate
    {
        public static iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.NORMAL);
        public InvoiceTemplate() { }
        public PdfPTable invoiceLogo(string imagePath)
        {
            PdfPTable logoTable = new PdfPTable(1);
            logoTable.WidthPercentage = 80;
            PdfPCell image = new PdfPCell();
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
            logo.ScaleToFit(100f, 100f);
            image.AddElement(logo);
            image.Border = iTextSharp.text.Rectangle.NO_BORDER;
            logoTable.AddCell(image);

            return logoTable;
        }
        public Paragraph invoiceHeader(string header)
        {
            Paragraph invoiceHeader = new();
            invoiceHeader.Add(new Chunk(header.ToUpper(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24f, iTextSharp.text.Font.BOLD)));
            invoiceHeader.Alignment = Element.ALIGN_CENTER;
            return invoiceHeader;
        }
        public Paragraph invoiceEnter()
        {
            return new Paragraph("\n");
        }
        public PdfPCell invoiceCellTable(string cellStuff)
        {
            PdfPCell CompanyNameCell = new PdfPCell();
            CompanyNameCell.HorizontalAlignment = Element.ALIGN_LEFT;
            CompanyNameCell.AddElement(new Paragraph(new Chunk(cellStuff + "\n", standardFont)));
            return CompanyNameCell;
        }
        public PdfPTable invoiceTwoColumns(string companyName, string addressOne, string addressTwo, string invoiceNumber, string date, string dueDate)
        {
            List<string> cells = new List<string> { companyName, invoiceNumber, addressOne, date, addressTwo, dueDate };

            PdfPTable tableAbove = new PdfPTable(2);
            tableAbove.WidthPercentage = 80;
            foreach (string cell in cells)
            {
                PdfPCell createdCell = this.invoiceCellTable(cell);
                createdCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tableAbove.AddCell(createdCell);
            }
            tableAbove.HorizontalAlignment = Element.ALIGN_CENTER;

            return tableAbove;
        }
        public PdfPTable invoiceCustomer(string customerName, string address, string addressTwo)
        {
            List<string> args = new List<string> { "Bill to: ", customerName, address, addressTwo };
            PdfPTable CustomerTable = new PdfPTable(1);
            CustomerTable.WidthPercentage = 80;

            foreach (string cell in args)
            {
                PdfPCell createdCell = this.invoiceCellTable(cell);
                createdCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                CustomerTable.AddCell(createdCell);
            }

            CustomerTable.HorizontalAlignment = Element.ALIGN_CENTER;

            return CustomerTable;
        }
        public PdfPTable invoiceItems(List<Item> itemList)
        { // Add a table to the document with columns for item name, amount, and price
            PdfPTable table = new PdfPTable(4);
            table.AddCell("Item Name");
            table.AddCell("Amount");
            table.AddCell("Price per Item");
            table.AddCell("Total");

            // Loop through the list of items and add a row for each item to the table
            foreach (Item item in itemList)
            {
                table.AddCell(item.Name);
                table.AddCell(item.Amount);
                table.AddCell(item.PricePerItem);
                table.AddCell(item.PriceTotal);
            }
            return table;
        }
        public PdfPTable invoiceComments(string comments)
        {
            PdfPTable commentTable = new PdfPTable(1);
            commentTable.WidthPercentage = 80;

            // Create the left cell and add the left-aligned paragraph
            PdfPCell commentCell = this.invoiceCellTable("Notes:" + comments);
            commentCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            commentCell.PaddingTop = 20f;
            commentTable.HorizontalAlignment = Element.ALIGN_CENTER;
            commentTable.AddCell(commentCell);

            return commentTable;
        }
        public PdfPTable invoiceTotals(string subtotal, string tax, string total)
        {
            PdfPTable bottomTotalsTable = new PdfPTable(2);
            bottomTotalsTable.WidthPercentage = 50;
            bottomTotalsTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            bottomTotalsTable.PaddingTop = 24f;

            List<string> args = new List<string> { "Subotal: " , subtotal, "Tax: " , tax, "Total: " , total };

            foreach (string cell in args)
            {
                PdfPCell createdCell = this.invoiceCellTable(cell);
                createdCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                bottomTotalsTable.AddCell(createdCell);
            }
            return bottomTotalsTable;
        }
    }
}
