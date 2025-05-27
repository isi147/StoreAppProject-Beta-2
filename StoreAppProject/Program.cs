using StoreAppProject.Database;
using StoreAppProject.Exceptions;
using StoreAppProject.Helper;
using StoreAppProject.Models;
using StoreAppProject.Services;

StoreAppDatabase database = new StoreAppDatabase();

ProductService productService = new ProductService(database);

while (true)
{
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
    Console.Write("Choice:");
    int choice = int.Parse(Console.ReadLine());
    try
    {

        switch (choice)
        {
            case 1:

                productService.Add(ProductConsoleInput.ConsoleInput());
                Console.WriteLine("Product added successfullyy.");
                break;
            case 2:
          
                break;
            case 3:
                Console.WriteLine("Enter Product ID:");
                int id = int.Parse(Console.ReadLine());
                Product product = productService.GetById(id);
                if (product != null)
                {
                    Console.WriteLine(product);
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
                break;
        }
    }
    catch (InvalidPriceException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (ProductNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An unexpected error occurred: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Thank you for using the Store App!");
    }
}

