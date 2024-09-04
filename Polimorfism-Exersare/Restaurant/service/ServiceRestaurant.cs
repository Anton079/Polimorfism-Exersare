using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polimorfism_Exersare.Restaurant;
using Polimorfism_Exersare.Restaurant.model;


namespace service
{
    public class ServiceRestaurant
    {
        private List<Restaurant> _restaurantList;

        public ServiceRestaurant()
        {
            _restaurantList = new List<Restaurant>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string type = line.Split(',')[0];

                        switch (type)
                        {

                            case "Restaurant1": _restaurantList.Add(new Restaurant1(line)); break;

                            case "Restaurant2": _restaurantList.Add(new Restaurant2(line)); break;

                            case "Restaurant3": _restaurantList.Add(new Restaurant3(line)); break;

                            case "Restaurant4": _restaurantList.Add(new Restaurant4(line)); break;

                            default: break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "Restaurant");

            return file;
        }

        public string ToSaveAll()
        {
            string save = "";

            for (int i = 0; i < _restaurantList.Count; i++)
            {
                save += _restaurantList[i].ToSave();

                if (i < _restaurantList.Count - 1)
                {
                    save += "\n";
                }
            }

            return save;
        }


        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    sw.WriteLine(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AfisareMeniu()
        {
            foreach (Restaurant restaurant in _restaurantList)
            {
                Console.WriteLine(restaurant.AfisareMeniu());
            }
        }

        public void AfisareProgram()
        {
            foreach(Restaurant restaurant in _restaurantList)
            {
                Console.WriteLine(restaurant.AfisareOrar());
            }
        }

        public void AfisareNrAngajati()
        {
            foreach (Restaurant restaurant in _restaurantList)
            {
                Console.WriteLine(restaurant.NrAngjati());
            }
        }

        public void AfisareCapacitateClienti()
        {
            foreach (Restaurant restaurant in _restaurantList)
            {
                Console.WriteLine(restaurant.AfisareCapacitatePersoane());
            }
        }

    }
}
