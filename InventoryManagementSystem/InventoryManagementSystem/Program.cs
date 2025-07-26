namespace InventoryManagementSystem
{
    internal class Program
    {


        //add product
        //update product
        //view products ==> id,name,quantity,price
        //remove product
        //exit


        const int NumberOfProducts = 50;
        static string[,] Products = new string[NumberOfProducts, 3];
        static int Productscount = 0;




        static void Main(string[] args)
        {

            Console.WriteLine("=======================================");
            Console.WriteLine("Welcome to Inventory Management System");
            ViewOptions();

            while (true)
            {
                Console.WriteLine("Enter your Choice from 0 to 5 only");
                Console.WriteLine("=======================================");

                bool validateChoice = int.TryParse(Console.ReadLine(), out int UserChoice);

                if (validateChoice)
                {
                    switch (UserChoice)
                    {
                        case 0:
                            ViewOptions();
                            break;
                        case 1:
                            //add product
                            AddProduct();
                            break;
                        case 2:
                            //update product
                            UpdateProduct();

                            break;
                        case 3:
                            ViewProducts();
                            break;
                        case 4:
                            RemoveProduct();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error...");
                }
            }
        }


        private static void ViewOptions()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("[0]- View Options");
            Console.WriteLine("[1]- add Product");
            Console.WriteLine("[2]- Update Product");
            Console.WriteLine("[3]- View Products");
            Console.WriteLine("[4]- Remove Product");
            Console.WriteLine("[5]- Exit ");
            Console.WriteLine("=======================================");

        }
        private static void AddProduct()
        {
            if (Productscount == 50)
            {
                Console.WriteLine("The list is full.");
                Console.WriteLine("=======================================");
            }
            else
            {
                Console.Write("Enter product name: ");
                Products[Productscount, 0] = Console.ReadLine();

                Console.Write("Enter product Quantity: ");
                bool validQuantity = int.TryParse(Console.ReadLine(), out int quantity);

                Console.Write("Enter product Price: ");
                bool validPrice = int.TryParse(Console.ReadLine(), out int price);

                if (!validQuantity)
                {
                    Console.WriteLine("Invalid Quantity. Product not added.");
                    return;
                }
                if (!validPrice)
                {
                    Console.WriteLine("Invalid Price. Product not added.");
                    return;
                }

                Products[Productscount, 1] = quantity.ToString();
                Products[Productscount, 2] = price.ToString();

                Productscount++;

                Console.WriteLine("Product added successfully.");
                Console.WriteLine("=======================================");
            }
        }

        private static void ViewProducts()
        {
            if (Productscount > 0)
            {
                Console.WriteLine("Products List:-");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine($"Product ID | Product Name | Product Quantity | Product Price");
                Console.WriteLine("-----------------------------------------------------------------");
                for (int i = 0; i < Productscount; i++)
                {

                    Console.WriteLine($" {i} \t\t{Products[i, 0]}\t\t {Products[i, 1]}\t\t {Products[i, 2]}");
                    Console.WriteLine("-----------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("There are no products available to show.");

            }


        }
        private static void UpdateProduct()
        {
            if (Productscount > 0)
            {
                Console.WriteLine("Please enter the product ID to update:");
                bool isValid = int.TryParse(Console.ReadLine(), out int id);

                if (!isValid || id < 0 || id >= Productscount)
                {
                    Console.WriteLine("Invalid ID. Please try again.");
                }
                else
                {
                    Console.Write("Enter New Product Name : ");
                    Products[id, 0] = Console.ReadLine();

                    Console.Write("Enter New product Quantity: ");
                    bool validQuantity = int.TryParse(Console.ReadLine(), out int quantity);

                    Console.Write("Enter New product Price: ");
                    bool validPrice = int.TryParse(Console.ReadLine(), out int price);

                    if (!validQuantity)
                    {
                        Console.WriteLine("Invalid Quantity. Product not updated.");
                        return;
                    }
                    if (!validPrice)
                    {
                        Console.WriteLine("Invalid Price. Product not updated.");
                        return;
                    }

                    Products[id, 1] = quantity.ToString();
                    Products[id, 2] = price.ToString();


                    Console.WriteLine("Product Updated Successfully.");
                    Console.WriteLine("=======================================");
                }
            }
            else
            {
                Console.WriteLine("There are no products available to update.");

            }

        }
        private static void RemoveProduct()
        {
            if (Productscount > 0)
            {
                Console.WriteLine("Please enter the product ID to remove:");
                bool isValid = int.TryParse(Console.ReadLine(), out int id);

                if (!isValid || id < 0 || id >= Productscount)
                {
                    Console.WriteLine("Invalid ID. Please try again.");
                }
                else
                {
                    if (id == Productscount - 1)
                    {
                        Productscount--;
                    }
                    else
                    {
                        for (int i = id; i < Productscount - 1; i++)
                        {
                            Products[i, 0] = Products[i + 1, 0];
                            Products[i, 1] = Products[i + 1, 1];
                            Products[i, 2] = Products[i + 1, 2];
                        }
                        Productscount--;
                    }
                    Console.WriteLine("Product removed successfully.");
                    Console.WriteLine("=======================================");


                }

            }
            else
            {
                Console.WriteLine("There are no products available to remove.");

            }

        }

    }
}
