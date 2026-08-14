using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;

public class InvoiceDocument : IDocument
{
    public string CustomerName { get; set; }
    public string TaxNumber { get; set; }
    public DataGridView Data { get; set; }
    public float Total { get; set; }
    public float TaxRate { get; set; }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public DocumentSettings GetSettings() => DocumentSettings.Default;

    private IContainer CellStyle(IContainer container)
    {
        return container
            .BorderBottom(1)
            .PaddingVertical(5)
            .PaddingHorizontal(5);
    }

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(30);

            page.Content().Column(col =>
            {
                // عنوان الفاتورة
                col.Item()
                    .PaddingBottom(10)
                    .Text("فاتورة شراء")
                    .FontSize(26)
                    .Bold()
                    .AlignCenter();

                // التاريخ
                col.Item()
                    .PaddingBottom(10)
                    .Text($"التاريخ: {DateTime.Now:yyyy/MM/dd}")
                    .FontSize(14)
                    .AlignRight();

                // معلومات العميل
                col.Item()
                    .BorderBottom(1)
                    .PaddingBottom(10)
                    .Column(info =>
                    {
                        info.Item().Text($" اسم العميل {CustomerName}")
                            .FontSize(14)
                            .AlignRight();

                        info.Item().Text($"الرقم الضريبي {TaxNumber}")
                            .FontSize(14)
                            .AlignRight();
                    });

                col.Item().PaddingVertical(15);

                // جدول الأصناف
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1);   // الصنف
                        columns.RelativeColumn(1);   // السعر
                        columns.RelativeColumn(1);   // الكمية
                        columns.RelativeColumn(2);   // الإجمالي
                    });

                    // رأس الجدول
                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).Text("الإجمالي").Bold().AlignRight();
                        header.Cell().Element(CellStyle).Text("الكمية").Bold().AlignRight();
                        header.Cell().Element(CellStyle).Text("السعر").Bold().AlignRight();
                        header.Cell().Element(CellStyle).Text("الصنف").Bold().AlignRight();
                    });

                    // محتوى الجدول
                    foreach (DataGridViewRow row in Data.Rows)
                    {
                        if (row.IsNewRow) continue;

                        table.Cell().Element(CellStyle).Text(row.Cells[3].Value.ToString()).AlignRight();
                        table.Cell().Element(CellStyle).Text(row.Cells[1].Value.ToString()).AlignRight();
                        table.Cell().Element(CellStyle).Text(row.Cells[2].Value.ToString()).AlignRight();
                        table.Cell().Element(CellStyle).Text(row.Cells[0].Value.ToString()).AlignRight();
                    }
                });

                col.Item().PaddingVertical(20);

                // الحسابات النهائية
                float tax = Total * TaxRate;
                float totalWithoutTax = Total - tax;

                col.Item().Column(sum =>
                {
                    sum.Item()
                        .PaddingBottom(5)
                        .Text($"إجمالي بدون ضريبة: {totalWithoutTax:F2}")
                        .FontSize(14)
                        .AlignRight();

                    sum.Item()
                        .PaddingBottom(5)
                        .Text($"الضريبة: {tax:F2}")
                        .FontSize(14)
                        .AlignRight();

                    sum.Item()
                        .PaddingTop(10)
                        .Text($"الإجمالي شامل الضريبة: {Total:F2}")
                        .FontSize(16)
                        .Bold()
                        .AlignRight();
                });
            });
        });
    }
}
