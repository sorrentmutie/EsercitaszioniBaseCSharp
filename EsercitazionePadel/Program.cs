#region CircoloPadel

//IMyConfiguration myConfiguration = new MyConfiguration();
//IGestioneCircoliPadel gestione = 
//    new GestioneCircoliPadelSuFile(myConfiguration);

//gestione.AggiungiCircolo(new CircoloPadel { Id = 3, Nome ="Circolo Roma 1"});
//gestione.AggiungiCircolo(new CircoloPadel { Id = 4, Nome = "Circolo Roma 2" });
//gestione.AggiungiCircolo(new CircoloPadel { Id = 5, Nome = "Circolo Roma 3" });



//var circolo = gestione.CercaPerId(3);
//Console.WriteLine(circolo?.Nome);
//if (circolo != null)
//{
//    circolo.Nome = "Circolo Roma 1 Modificato";
//    gestione.ModificaCircolo(circolo);
//}


//var ricerca = gestione.Cerca("Rom");
//if(ricerca != null)
//{
//    foreach (var circ in ricerca)
//    {
//        Console.WriteLine(circ.Nome);
//    }
//}

//var tuttiICircoli = gestione.EstraiTuttiICircoli();
//tuttiICircoli?.ForEach(c => Console.WriteLine(c.Nome));


//var circoli = gestione.EstraiTuttiICircoli();
//foreach (var item in circoli)
//{
//    Console.WriteLine(item.Nome);
//}

#endregion


using EsercitazionePadel.Data;
using Microsoft.EntityFrameworkCore;

DbContextOptions<DatabaseNorthwind> options =
     new DbContextOptionsBuilder<DatabaseNorthwind>()
    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Northwind;Trusted_Connection=True;")
    .Options;

var database = new DatabaseNorthwind(options);
    
var categories = database.Categories
    .Include(c => c.Products)
    .ThenInclude(p => p.Supplier)
    .Where(c => c.CategoryName.StartsWith("B"))
    .ToList();
foreach (var category in categories)
{
    Console.WriteLine($"{category.CategoryName} {category.CategoryId}");
    var products = category.Products;
    foreach (var product in products)
    {
        Console.WriteLine($"\t{product.ProductName}");
        Console.WriteLine(product.Supplier.CompanyName);
    }
}

