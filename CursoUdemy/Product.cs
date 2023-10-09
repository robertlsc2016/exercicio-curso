using System.Globalization;

namespace CursoUdemy
{
    class Product
    {
        //ATRIBUTOS
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }


        //CONSTRUTOR
        public Product(string name, double price, int quantity)
        {
            //DEFINIR OS ATRIBUTOS COMO OS DADOS 
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name
        {
            get { return Name; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    Name = value;
                }
            }

        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }





        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 0;
        }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantidade)
        {
            Quantity += quantidade;
        }

        public void RemoveProducts(int quantidade)
        {
            Quantity -= quantidade;
        }

        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}