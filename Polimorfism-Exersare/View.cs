using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare
{
    public class View
    {
        private ServiceRestaurant _serviceRestaurant;

        public View(ServiceRestaurant serviceRestaurant)
        {
            _serviceRestaurant = serviceRestaurant;
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa meniul! ");
            Console.WriteLine("Apasati tasta 2 pentru a afisa programul! ");
            Console.WriteLine("Apasati tasta 3 pentru a afisa numarul de angajati! ");
            Console.WriteLine("Apasati tasta 4 pentru a afisa capacitatea de clienti!");
        }

        public void play()
        {
            bool running = true;

            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _serviceRestaurant.AfisareMeniu();
                        break;

                    case "2":
                        _serviceRestaurant.AfisareProgram();
                        break;

                    case "3":
                        _serviceRestaurant.AfisareNrAngajati();
                        break;

                    case "4":
                        _serviceRestaurant.AfisareCapacitateClienti();
                        break;
                }
            }
        }


    }
}
