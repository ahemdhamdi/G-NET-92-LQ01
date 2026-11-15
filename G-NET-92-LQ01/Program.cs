#region Adding Files
// Ading DataSourcce
//Adding Models
#endregion

using LINQ.DataSources;

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