using Polimorfism_Exersare;
using service;

internal class Program
{
    private static void Main(string[] args)
    {
        ServiceRestaurant serviceRestaurant = new ServiceRestaurant();

        View view = new View(serviceRestaurant);

        view.play();
    }
}