using System;
using System.Collections.Generic;

namespace class5f
{
    // Implement the generic IComparable<T> interface. 
    class Product : IComparable<Product>
    {
        string name;
        decimal price;

        public Product(string produceName, decimal itemPrice)
        {
            name = produceName;
            price = itemPrice;
        }
        public void DisplayProductInformation()
        {
            Console.Write("   Product:  " + name + "   ");
            Console.WriteLine("Price:  " + price.ToString("C"));
        }
        // This method is required by the IComparable<T> interface. 
        public int CompareTo(Product obj)
        {
            return name.CompareTo(obj.name);  // Sort by name attribute.
        }
    }
    class Program
    {
        static void ShowProducts(string caption, List<Product> products)
        {
            Console.WriteLine(caption);
            foreach (Product product in products)
            {
                product.DisplayProductInformation();
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("carrots", 0.48m));
            products.Add(new Product("dates", 0.62m));
            products.Add(new Product("apples", 0.98m));
            products.Add(new Product("bananas", 0.88m));

            ShowProducts("Before sorting:", products);
            products.Sort(); // Apply the Sort() method of the List class.
            ShowProducts("After sorting:", products);

            Console.ReadLine();
        }
    }

}
