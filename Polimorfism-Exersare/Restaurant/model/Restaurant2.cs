using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare.Restaurant.model
{
    public class Restaurant2 : Restaurant
    {
        private bool _hasVeganOptions;
        private bool _hasWiFi;

        public Restaurant2(string typeRestaurant, int id, string name, int phoneNumber, string street, string city, string meniu, string program, int capacitateCustomer, int nrEmployee, bool hasVeganOptions, bool hasWiFi)
            : base(typeRestaurant, id, name, phoneNumber, street, city, meniu, program, capacitateCustomer, nrEmployee)
        {
            _hasVeganOptions = hasVeganOptions;
            _hasWiFi = hasWiFi;
        }

        public Restaurant2(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _hasVeganOptions = bool.Parse(token[10]);
            _hasWiFi = bool.Parse(token[11]);
        }

        public bool HasVeganOptions
        {
            get { return _hasVeganOptions; }
            set { _hasVeganOptions = value; }
        }

        public bool HasWiFi
        {
            get { return _hasWiFi; }
            set { _hasWiFi = value; }
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
            text += "Has Vegan Options: " + HasVeganOptions + "\n";
            text += "Has WiFi: " + HasWiFi + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.ToSave() + "," + HasVeganOptions + "," + HasWiFi;
        }
    }
}
