using System;


namespace ObligatoriskOpgave_9marts2022
{
   
   
   public class Car
    {
        private static int idCounter = 0;
        private readonly int id;
        private string model;
        private int price;
        private string licensePlate;

        public int Id
        {
            get { return this.id; } 
            init 
            { 
            
                this.id = ++idCounter;
            }
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length > 4)
                    model = value;
                else
                    throw new ArgumentOutOfRangeException("mærket skal være mindst 5 karakterer langt");
            }
        }
        public int Price
        {
            get { return this.price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("prisen skal være større end nul");
            }
        }
        public string LicensePlate
        {
            get { return this.licensePlate; }
            set
            {
                if (value.Length >= 2 && value.Length <= 7)
                    licensePlate = value;
                else
                    throw new ArgumentOutOfRangeException("nummerpladen skal være mindst 2 og maks 7 karakterer lang");
                
            }
        }
        
        public Car(string aModel, int aPrice, string aLicensePlate)
        {
            Id = id;
            Model = aModel;
            Price = aPrice;
            LicensePlate = aLicensePlate;
        }
    }
}
