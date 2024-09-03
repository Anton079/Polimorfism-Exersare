using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare.Restaurant.model
{
    public class Restaurant3 : Restaurant
    {
        private bool _hasGlutenFreeOptions;
        private bool _hasParking;

        public Restaurant3(string typeRestaurant, int id, string name, int phoneNumber, string street, string city, string meniu, string program, int capacitateCustomer, int nrEmployee, bool hasGlutenFreeOptions, bool hasParking)
            : base(typeRestaurant, id, name, phoneNumber, street, city, meniu, program, capacitateCustomer, nrEmployee)
        {
            _hasGlutenFreeOptions = hasGlutenFreeOptions;
            _hasParking = hasParking;
        }

        public Restaurant3(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _hasGlutenFreeOptions = bool.Parse(token[10]);
            _hasParking = bool.Parse(token[11]);
        }

        public bool HasGlutenFreeOptions
        {
            get { return _hasGlutenFreeOptions; }
            set { _hasGlutenFreeOptions = value; }
        }

        public bool HasParking
        {
            get { return _hasParking; }
            set { _hasParking = value; }
        }

        public virtual void AfisareMeniu()
        {
            Console.WriteLine(base.Meniu);
        }

        public virtual void AfisareOrar()
        {
            Console.WriteLine(base.Program);
        }

        public virtual void NrAngjati()
        {
            Console.WriteLine(base.NrEmployee);
        }

        public virtual void AfisareCapacitatePersoane()
        {
            Console.WriteLine(base.CapacityCustomer);
        }

        public override string RestaurantInfo()
        {
            string text = base.RestaurantInfo();
            text += "Has Gluten-Free Options: " + HasGlutenFreeOptions + "\n";
            text += "Has Parking: " + HasParking + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.ToSave() + "," + HasGlutenFreeOptions + "," + HasParking;
        }
    }
}
