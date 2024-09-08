using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare.Restaurant.model
{
    public class Restaurant
    {
        private string _nrRestaurant;
        private string _typeRestaurant;
        private int _id;
        private string _name;
        private int _phoneNumber;
        private string _street;
        private string _city;
        private string _meniu;
        private string _program;
        private int _capacityCustomer;
        private int _nrEmployee;



        public virtual string AfisareMeniu()
        {
            return null;
        }

        public virtual string AfisareOrar()
        {
            return null;
        }

        public virtual int NrAngjati()
        {
            return -1;
        }

        public virtual int AfisareCapacitatePersoane()
        {
            return -1;
        }

        public Restaurant(string nrRestaurant, string typeRestaurant, int id, string name, int phoneNumber, string street, string city, string meniu, string program, int capacitateCustomer, int nrEmployee)
        {
            _nrRestaurant = nrRestaurant;
            _typeRestaurant = typeRestaurant;
            _id = id;
            _name = name;
            _phoneNumber = phoneNumber;
            _street = street;
            _city = city;
            _meniu = meniu;
            _program = program;
            _capacityCustomer = capacitateCustomer;
            _nrEmployee = nrEmployee;
        }

        public Restaurant(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _nrRestaurant = token[0];
            _typeRestaurant = token[1];
            _id = int.Parse(token[2]);
            _name = token[3];
            _phoneNumber = int.Parse(token[4]);
            _street = token[5];
            _city = token[6];
            _meniu = token[7];
            _program = token[8];
            _capacityCustomer = int.Parse(token[9]);
            _nrEmployee = int.Parse(token[10]);
        }

        public string NrRestaurant
        {
            get { return _nrRestaurant; }
            set { _nrRestaurant = value; }
        }

        public string TypeRestaurant
        {
            get { return _typeRestaurant; }
            set { _typeRestaurant = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Meniu
        {
            get { return _meniu; }
            set { _meniu = value; }
        }

        public string Program
        {
            get { return _program; }
            set { _program = value; }
        }

        public int CapacityCustomer
        {
            get { return _capacityCustomer; }
            set { _capacityCustomer = value; }
        }

        public int NrEmployee
        {
            get { return _nrEmployee; }
            set { _nrEmployee = value; }
        }

        public virtual string RestaurantInfo()
        {
            string text = " ";
            text += "Nr Restaurant" + _nrRestaurant + "\n";
            text += "TypeRestaurant" + TypeRestaurant + "\n";
            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "PhoneNumber " + PhoneNumber + "\n";
            text += "Stret name " + Street + "\n";
            text += "City " + City + "\n";
            text += "Meniu " + Meniu + "\n";
            text += "Program " + Program + "\n";
            text += "Capacity de clienti " + CapacityCustomer + "\n";
            text += "Nr de angajati " + NrEmployee + "\n";
            return text;
        }

        public virtual string ToSave()
        {
            return NrRestaurant + "," + TypeRestaurant + "," + Id + "," + Name + "," + PhoneNumber + "," + Street + "," + City + "," + Meniu + "," + Program + "," + CapacityCustomer + "," + NrEmployee;
        }
    }
}
