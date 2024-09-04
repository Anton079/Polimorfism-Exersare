using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare.Restaurant.model
{
    public class Restaurant4 : Restaurant
    {
        private bool _hasLiveMusic;

        public Restaurant4(string typeRestaurant, int id, string name, int phoneNumber, string street, string city, string meniu, string program, int capacitateCustomer, int nrEmployee, bool hasLiveMusic)
            : base(typeRestaurant, id, name, phoneNumber, street, city, meniu, program, capacitateCustomer, nrEmployee)
        {
            _hasLiveMusic = hasLiveMusic;
        }

        public Restaurant4(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _hasLiveMusic = bool.Parse(token[10]);
        }

        public bool HasLiveMusic
        {
            get { return _hasLiveMusic; }
            set { _hasLiveMusic = value; }
        }

        public override string AfisareMeniu()
        {
            return Meniu;
        }

        public override string AfisareOrar()
        {
            return Program;
        }

        public override int NrAngjati()
        {
            return NrEmployee;
        }

        public override int AfisareCapacitatePersoane()
        {
            return CapacityCustomer;
        }

        public override string RestaurantInfo()
        {
            string text = base.RestaurantInfo();
            text += "Has Live Music: " + HasLiveMusic + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.ToSave() + "," + HasLiveMusic;
        }
    }
}
