using System;
namespace pizzastore3
{
    class Customer
    {

        private int _customerID;
        private string _name;
        private string _mail;
        private int _tlfnummer;


        public Customer(int customerID, string name, string mail, int tlfnummer)
        {

            _customerID = customerID;
            _name = name;
            _mail = mail;
            _tlfnummer = tlfnummer;


        }

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
            
           public string Mail
        {

            get { return _mail; }
            set { _mail = value; }
        }
        
        
           public int Tlfnummer
        {
            get { return _tlfnummer; }
            set { _tlfnummer = value; }

        }


        public override string ToString()
        {
            return " CustomerID: " + _customerID + " navn: "  + _name + " mail: " + _mail + " nummer: " + _tlfnummer + "  navn på pizza:  ";

        }


    }
}
