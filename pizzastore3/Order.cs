using System;
namespace pizzastore3
{
     class Order
    {
        private int _orderID;
        private double totalprice;
        private Pizza pizza;
        private Customer customer;

    
      
        

        public Order(int orderID, Customer customer, Pizza pizza) 
            
        {
            _orderID = orderID;
            this.pizza = pizza;
            Totalprice(this.pizza.Price);
            this.customer = customer;
        }

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }



        public void Totalprice(double price)
        {
            double totalprice = price + 40;
            double taxes = 0.25 * price;
            this.totalprice = totalprice + taxes;
        }

        public double GetoTalPrice()
        {

            return this.totalprice;


        }


        public override string ToString()
        {
            return "orderID" + "  " + _orderID +"   "+ customer + " " + pizza + " kr " + " = " + totalprice + " kr. incl. levering ";
        }






    }
}
