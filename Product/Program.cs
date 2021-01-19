using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();



            product1.ProductName = "Computer";
            product1.ProductId = 1;
            product1.Price = 3000;

            product2.ProductName = "Mobile Phone";
            product2.ProductId = 2;
            product2.Price = 2000;

            product3.ProductName = "Mouse";
            product3.ProductId = 3;
            product3.Price = 100;



            Product[] products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product. ProductId + " :"+product. ProductName +" :" +product. Price );
              

            }
            for (int i = 0; i <products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId + " :" + products[i].ProductName + ":" + products[i].Price);

            }
            int counter = 0;
            while(counter<products.Length)
            {
                Console.WriteLine(products[counter].ProductId + " :" + products[counter].ProductName + ":" + products[counter].Price);
                counter++;
            }
        }
    }
    class Product
    {
        public string ProductName{ get; set; }
        public int Price { get; set; }

        public int ProductId { get; set; }
    }
}
