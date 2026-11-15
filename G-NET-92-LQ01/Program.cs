#region Adding Files
// Ading DataSourcce
//Adding Models
#endregion

using LINQ.DataSources;
using LINQ.Models;
using System.Text.RegularExpressions;
using System.Xml.Linq;

#region Question_01
//1.Get all products from the "Seafood" category. Print each
//product's name and price.

////Method Syntax:-
//var SeafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood")
//                                 .Select(p => new { p.ProductName, p.UnitPrice });

//foreach (var item in SeafoodProducts)
//{   
//    Console.WriteLine(item);
//}

////Query Syntax:-
//SeafoodProducts = from P in Source.ProductList
//                  where P.Category == "Seafood"
//                  select new { P.ProductName, P.UnitPrice };


#endregion

#region Question_02
//2.Get a list of only the product names from ProductList. Print
//each name.

//////Method Syntax:-
//var ProductNames = Source.ProductList.Select(p => new {p.ProductName});

///// Query Syntax:-
//ProductNames = from p in Source.ProductList
//               select new { p.ProductName };

//foreach (var item in ProductNames)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Question_03
//3.Sort all products by UnitPrice (ascending). Print each
//product's name and price.

////Method Syntax
//var ProductPrices = Source.ProductList.Select(p => new {p.ProductName,p.UnitPrice })
//                                      .OrderBy(p => p.UnitPrice);

////Query Syntax
//var ProductPrices1 = from p in Source.ProductList
//                orderby p.UnitPrice ascending
//                select new { p.ProductName, p.UnitPrice };

#endregion

#region Question_04
//4.Get all products where UnitPrice is between 10 and 30

////Method Syntax:-
//var ProductPriceWithRang = Source.ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30)
//                                             .Select(p => p);
//foreach (var item in ProductPriceWithRang)
//{
//    Console.WriteLine(item);
//}

////Query Syntax:-
//ProductPriceWithRang = from p in Source.ProductList
//                       where p.UnitPrice > 10 && p.UnitPrice < 30
//                       select p;

#endregion

#region Question_05
//5.Get all products that are in stock (UnitsInStock > 0) and
//belong to the "Condiments" category.

//var CondimentsProductsInStock = Source.ProductList.Where(p => p.UnitsInStock > 0 && Regex.IsMatch(p.Category, "Condiments"))
//                                                  .Select(p => p);

//foreach (var item in CondimentsProductsInStock)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Question_06
//6.Create a new anonymous type with three properties:
//● Name → the product name
//● Price → the unit price
//● StockStatus → a string: "Available" if UnitsInStock > 0,
//otherwise "Out of Stock"
//● Print the result.


//var CheckProducts = Source.ProductList.Select(p => new
//{
//    Name = p.ProductName ,
//    Price = p.UnitPrice ,
//    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
//});


//foreach (var product in CheckProducts)
//{
//    Console.WriteLine(
//        $"{product.Name} | {product.Price} | {product.StockStatus}"
//    );
//}


#endregion

#region Question_07
//7.Print each product's name along with its position (1-based)
//in the list. Expected format: 1.Chai, 2.Chang, etc.


//var ProductsPosition = Source.ProductList.Select((p, i) => $"{i+1}.{p.ProductName}");


//foreach (var item in ProductsPosition)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Question_08
//8.Sort ProductList by Category ascending, then within each
//category, sort by UnitPrice descending.

//var SortedProductByCatAndUnitPrice = Source.ProductList.Select(p => p)
//    .OrderBy(p => p.Category)
//    .ThenByDescending(p => p.UnitPrice);
#endregion

#region Question_09
//9.Get all products from the "Beverages" category, sorted by
//UnitsInStock descending. Print name and stock.

//var BeveragesProduct = Source.ProductList.Where(p => p.Category== "Beverages")
//    .OrderByDescending(p => p.UnitsInStock)
//    .Select(p => new { p.ProductName, p.UnitsInStock });


//foreach (var item in BeveragesProduct)
//{
//    Console.WriteLine(item);
//}
#endregion


#region Question_10
//10.Using QUERY SYNTAX with a compound from clause, list
//all orders placed in 1997 or later showing CustomerID and
//OrderDate.

//var Result =
//    from C in Source.CustomerList
//    from O in C.Orders
//    where O.OrderDate.Year >= 1997
//    select new
//    {
//        C.CustomerID,
//        O.OrderDate
//    };

//foreach (var item in Result)
//{
//    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
//}

#endregion