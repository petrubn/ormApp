using App;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new DatabaseContext())
            {

                Console.WriteLine("Hi, input price and description: \n");
                Console.WriteLine("Price - ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Description - ");
                string description = Console.ReadLine();
                
                var product = new Product(){ Price = price, Description = description };
                db.Products.Add(product);
                db.SaveChanges();

                foreach(var p in db.Products) 
                {
                    Console.WriteLine("{0} {1} {2}", p.ProductId, p.Description, p.Price);
                }
    
            }
           
            
            using (var db = new DatabaseContext())
            {
                var orders = db.Orders;
                foreach(var order in orders)
                {
                    Console.WriteLine("Order: order.Created");
                }
            }
        }

    }

}