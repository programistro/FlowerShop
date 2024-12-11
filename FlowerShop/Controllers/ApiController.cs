using ClosedXML.Excel;
using FlowerShop.Core;
using FlowerShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private readonly ILogger<ApiController> _logger;
    
    private readonly AppDbContext _context;

    public ApiController(ILogger<ApiController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [HttpGet("export-flowers")]
    public IActionResult ExportFlowersToExcel()
    {
        var list = _context.Flowers.ToList();

        using (XLWorkbook workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Цветы");

            worksheet.Cell("A1").Value = "Имя";
            worksheet.Cell("B1").Value = "Цена";
            worksheet.Row(1).Style.Font.Bold = true;

            //нумерация строк/столбцов начинается с индекса 1 (не 0)
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = list[i].Name;
                worksheet.Cell(i + 2, 2).Value = list[i].Price; // Исправлено на столбец B
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Position = 0;

                return File(
                    fileContents: stream.ToArray(),
                    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileDownloadName: $"flowers_{DateTime.UtcNow.ToString("yyyyMMdd_HHmmss")}.xlsx"
                );
            }
        }
    }
    
    [HttpGet("export-toys")]
    public IActionResult ExportToysToExcel()
    {
        var list = _context.Toys.ToList();

        using (XLWorkbook workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Игрушки");

            worksheet.Cell("A1").Value = "Имя";
            worksheet.Cell("B1").Value = "Цена";
            worksheet.Row(1).Style.Font.Bold = true;

            //нумерация строк/столбцов начинается с индекса 1 (не 0)
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = list[i].Name;
                worksheet.Cell(i + 2, 2).Value = list[i].Price; // Исправлено на столбец B
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Position = 0;

                return File(
                    fileContents: stream.ToArray(),
                    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileDownloadName: $"flowers_{DateTime.UtcNow.ToString("yyyyMMdd_HHmmss")}.xlsx"
                );
            }
        }
    }
    
    [HttpGet("export-packs")]
    public IActionResult ExportPacksToExcel()
    {
        var list = _context.Packs.ToList();

        using (XLWorkbook workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Упаковки");

            worksheet.Cell("A1").Value = "Имя";
            worksheet.Cell("B1").Value = "Цена";
            worksheet.Row(1).Style.Font.Bold = true;

            //нумерация строк/столбцов начинается с индекса 1 (не 0)
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = list[i].Name;
                worksheet.Cell(i + 2, 2).Value = list[i].Price; // Исправлено на столбец B
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Position = 0;

                return File(
                    fileContents: stream.ToArray(),
                    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    fileDownloadName: $"flowers_{DateTime.UtcNow.ToString("yyyyMMdd_HHmmss")}.xlsx"
                );
            }
        }
    }
}