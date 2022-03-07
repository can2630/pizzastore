using System;
namespace pizzastore3
{
    public class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza("salatpizza,",50,"topping: kebab");
            Pizza p2 = new Pizza("hawaipizza,",65, "topping: skinke og ananas");
            Pizza p3 = new Pizza("kyllingpizza,",70,"topping: løg og peberfrugt");
            
            Customer c1 = new Customer(25,"Ole","ole@gmail.com",22335632);
            Customer c2 = new Customer(112,"Jens","jens@gmail.com",44235643);
            Customer c3 = new Customer(16,"Søren","søren@gmail.com",56324356);

            Order o1 = new Order(24,c1, p1);
            Order o2 = new Order(12, c2, p2);
            Order o3 = new Order(6, c3, p3);

            Console.WriteLine(o1.ToString());
            Console.WriteLine(o2.ToString());
            Console.WriteLine(o3.ToString());

            Console.WriteLine();
            Console.ReadLine();





        }
    }
}





