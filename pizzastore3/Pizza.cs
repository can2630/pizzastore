using System;
namespace pizzastore3
{
    class Pizza
    {
        private string _name;
        private int _price;
        private string _toppings;


        public Pizza(string name, int price, string toppings)
        {

            _name = name;
            _price = price;
            _toppings = toppings;

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }

        }

        public override string ToString()
        {
            return _name + " " + _toppings + " " + _price + " ";
        }


    }





}