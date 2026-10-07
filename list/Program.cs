namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>();

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("შეიყვანეთ პროდუქტი:");

                
                Product p = new Product();

                Console.Write("სახელი: ");
                p.Name = Console.ReadLine();

                Console.Write("ფასი: ");
                p.Price = Console.ReadLine();

                Console.Write("კატეგორია: ");
                p.Category = Console.ReadLine();

                Console.Write("რაოდენობა: ");
                p.Quantity = Console.ReadLine();

                Console.Write("ბრენდი: ");
                p.Brand = Console.ReadLine();

               
                products.Add(p);

                Console.WriteLine("-----");
            }












        }
    }
}
