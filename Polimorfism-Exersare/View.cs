using Polimorfism_Exersare.Restaurant.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism_Exersare
{
    public class View
    {
        private ServiceRestaurant serviceRestaurant;

        public View(ServiceRestaurant serviceRestaurant)
        {
            this.serviceRestaurant = serviceRestaurant;
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa meniul! ");
            Console.WriteLine("Apasati tasta 2 pentru a afisa programul! ");
            Console.WriteLine("Apasati tasta 3 pentru a afisa numarul de angajati! ");
            Console.WriteLine("Apasati tasta 4 pentru a edita programul unu restaurant! ");
            Console.WriteLine("Apasati tasta 5 pentru a edita meniul unui resturant! ");
            Console.WriteLine("Apasati tasta 6 pentru a edita numarul de angajati al unui restaurant! ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
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

                }
            }
        }



    }
}
