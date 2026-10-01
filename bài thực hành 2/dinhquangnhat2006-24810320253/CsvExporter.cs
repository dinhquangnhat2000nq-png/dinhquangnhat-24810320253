using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace dinhquangnhat2006_24810320253
{
    public static class CsvExporter
    {
        public static void ExportToCsv(List<Product> products, string path)
        {
            using var sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.WriteLine("ProductId,ProductName,Category,UnitPrice,Quantity,ImagePath");
            foreach (var p in products)
            {
                string Quote(string v) => "\"" + v + "\"";
                var line = string.Join(",", new string[] {
                    Escape(p.ProductId),
                    Quote(Escape(p.ProductName)),
                    Quote(Escape(p.Category)),
                    p.UnitPrice.ToString("F0", CultureInfo.InvariantCulture),
                    p.Quantity.ToString(CultureInfo.InvariantCulture),
                    Quote(Escape(p.ImagePath))
                });
                sw.WriteLine(line);
            }
        }

        private static string Escape(string s)
        {
            return (s ?? string.Empty).Replace("\"", "\"\"");
        }
    }
}
