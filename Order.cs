using System;
using System.Collections.Generic;

namespace IcecreamMenu
{
    public class Order
    {
        public List<Flavor> BallFlavors { get; set; }
        public List<Toppings> Topp { get; set; }
        public Cups cupType { get; set; }
        public string date { get; set; }
        public int price { get; set; }


        public Order(Cups cup = Cups.Reagular)
        {
            this.price = 0;
            this.Topp = new List<Toppings>();
            this.BallFlavors = new List<Flavor>();
            this.date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        public void chooseCup(Cups typeOfCup)
        {
            //check whice cup the client want 
            this.price += (typeOfCup == Cups.Special) ? 2:
                          (typeOfCup == Cups.Box) ? 5:
                          0;
            this.cupType = typeOfCup;
        }
        public void addTop(Toppings topType)
        {
            //if this reagular cup so you can put two topping
            if(this.cupType == Cups.Reagular && this.Topp.Count == 2)
            {
                throw new Exception("cannot add one morei topp - don't be pig");
            }
            //if order include Chocolate or Mikopelet you can't add HotChocolate
            if (this.BallFlavors.Contains(Flavor.Chocolate) 
                || this.BallFlavors.Contains(Flavor.Mikopelet)
                && topType == Toppings.HotChocolate)
            {
                throw new Exception("cannot add HotChocolate - The chef's dish must not be changed");
            }
            // if order include vannila ball you cannot add a maple topping
            if (this.BallFlavors.Contains(Flavor.Vanilla) 
                && topType == Toppings.Maple)
            {
                throw new Exception("Yuck!");
            }
            Topp.Add(topType);
            this.price += 2;

        }
        

        public void addFlavor(Flavor flav)
        {
            switch (this.BallFlavors.Count) {
                case 1:
                    this.price += 5;
                    break;
                case 0:
                    this.price += 7;
                    break;
                default:
                    if ((this.cupType == Cups.Reagular || this.cupType == Cups.Special)&&this.BallFlavors.Count>=3)
                    {
                        throw new Exception("Can't add more then 3 ice cream balls on regular or speical cups.");
                    }
                    this.price += 6;
                    break;
                }
            this.BallFlavors.Add(flav);
        }
    }
}










































