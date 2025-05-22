using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services;

StoreAppDatabase database = new StoreAppDatabase();

ProductService productService = new ProductService(database);



Console.WriteLine("Welcome");
Console.WriteLine("1. Add Product");
Console.WriteLine("2. All Products");
Console.WriteLine("3. Get Product by ID");
Console.WriteLine("4. Remove Product");
Console.WriteLine("5.Get Order By ID");
Console.WriteLine("6.All Orders");
Console.WriteLine("7.Remove Order");
Console.WriteLine("8.AddCustomer");
Console.WriteLine("9.GetCustomerById");
Console.WriteLine("10.All Customers");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Enter Product Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Product Description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Product Price:");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Product Quantity:");
        int quantity = int.Parse(Console.ReadLine());
        productService.Add(new Product { Name = name, Price = price,Description= description });
        Console.WriteLine("Product added successfully.");
        break;
    case 2:
        List<Product> products = productService.GetAll();
        foreach (var item in products)
        {
            Console.WriteLine(item);
        }
        break;
}