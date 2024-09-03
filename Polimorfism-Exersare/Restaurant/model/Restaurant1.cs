using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare.Restaurant.model
{
    public class Restaurant1 : Restaurant
    {
        private bool _hasVegetarianOptions;
        private bool _hasOutdoorSeating;

        public Restaurant1(string typeRestaurant, int id, string name, int phoneNumber, string street, string city, string meniu, string program, int capacitateCustomer, int nrEmployee, bool hasVegetarianOptions, bool hasOutDoorSeating)
            : base( typeRestaurant, id, name, phoneNumber, street, city, meniu, program, capacitateCustomer, nrEmployee)
        {
            _hasVegetarianOptions = hasVegetarianOptions;
            _hasOutdoorSeating = hasOutDoorSeating;
        }

        public Restaurant1(string proprietati)
            : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _hasVegetarianOptions = bool.Parse(token[10]);
            _hasOutdoorSeating = bool.Parse(token[11]);
        }

        public bool HadVegetarianOptions
        {
            get { return _hasVegetarianOptions; }
            set { _hasVegetarianOptions = value; }
        }

        public bool HasOutDoorSeating
        {
            get { return _hasOutdoorSeating; }
            set { _hasOutdoorSeating = value; }
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

            text += "Has Vegetarin Options " + HadVegetarianOptions + "\n";
            text += "Has Out Door Seating " + HasOutDoorSeating + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.ToSave() + "," + HadVegetarianOptions + "," + HasOutDoorSeating;
        }
    }
}
