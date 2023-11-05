// See https://aka.ms/new-console-template for more information
using EntityFrameworkExamples;

Console.WriteLine("Hello, World!");

NorthwindContext context = new();


#region Group By
var data = context.Products.GroupBy(x => x.SupplierId).Select(x => new 
{
    Count = x.Count()
}).ToList();
#endregion
Console.WriteLine($"Employees: {data}"); 