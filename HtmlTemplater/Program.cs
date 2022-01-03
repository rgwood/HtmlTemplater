Console.WriteLine("Hello, World! Here's some HTML:");

var rows = new List<string>() { "row 1", "row 2", "row 3" };
Console.WriteLine(HtmlTemplaterLib.HtmlGenerator.GetTableHtml(rows));