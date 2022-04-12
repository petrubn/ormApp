using App;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Switch
             * n menu
             */

            /* Create new entries */
            
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

                Console.WriteLine("\n");                
                foreach(var p in db.Products) 
                {
                    Console.WriteLine("{0} {1} {2}", p.ProductId, p.Description, p.Price);
                }
    
            }
           
            
            /* Tables show*/
            
            using (var db = new DatabaseContext())
            {
                
                foreach(var p in db.Products) 
                {
                    Console.WriteLine("(id) {0} \t (name) {1} \t (price) {2} \t", p.ProductId, p.Description, p.Price);
                }
                
            }

        }

    }

}