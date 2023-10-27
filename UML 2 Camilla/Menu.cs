using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Camilla
{
    public class Menu
    {
        private PizzaListe _pizzaListe;
        private CustomerListe _customerListe;

        public Menu(PizzaListe pizzaListe, CustomerListe customerListe)
        {

            _pizzaListe = pizzaListe;
            _customerListe= customerListe;


        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------Velkommen hos Big Mamma Gastronomia--------------------");
            Console.WriteLine("\t1.\tTilføj Pizza til Pizza Menu");
            Console.WriteLine("\t2.\tUdskriv Pizza Menuen");
            Console.WriteLine("\t3.\tSøg efter en Pizza ud fra Nummer");
            Console.WriteLine("\t4.\tFjern Pizza fra Pizza Menuen");
            Console.WriteLine("\t5.\tOpdater Pizzaer i Pizza Menuen");
            Console.WriteLine("\t6.\tOpdater en Kunde til listen af kunder");
            Console.WriteLine("\t7.\tTilføj  en Kunde på listen af kunder");
            Console.WriteLine("\t8.\tSøg efter en Kunde");
            Console.WriteLine("\t9.\tFjern en Kunde i systemet");
            Console.WriteLine("\t10.\tPrint en liste over registret kunder");
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        //Metode der indlæser og håndterer add pizza til PizzaList
                        AddPizzaToMenu();
                        break;
                    case 2: // Metode der Printer Pizza menuen. (Pizzalisten)
                        Console.Clear();
                        Console.WriteLine("Print Menuen");
                        _pizzaListe.PrintPizza();
                        break;
                    case 3: // todo
                        Console.Clear();
                        SearchPizzaMenu();
                        break;
                    case 4:
                        Console.Clear();
                        //Console.WriteLine("To be implemented!");
                        DeletePizzaFromMenu();
                        break;
                    case 5:
                        //
                        Console.Clear();
                        UpdatePizzaMenu();
                        break;
                    case 6:
                        // TODO
                        Console.Clear();
                        UpdateCustomerList();
                        break;
                    case 7:
                        // TODO
                        Console.Clear();
                        AddCustomerToList();
                        break;
                    case 8:
                        // TODO
                        Console.Clear();
                        SearchCustomerListe();
                        break;
                    case 9:
                        // TODO
                        Console.Clear();
                        DeleteCustomerFromList();
                        break;
                    case 10:
                        // TODO
                        Console.Clear();
                        Console.WriteLine("Print Kundeliste");
                        _customerListe.PrintCustomer();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();

            }

        }

        private void AddPizzaToMenu()
        {
            Console.WriteLine("Add Pizza");
            Console.WriteLine("Angiv nummer");
            string number = Console.ReadLine();
            Console.WriteLine("Angiv navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv størrelse");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv bund");
            int bottom = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv ingredienser");
            string ingredients = (Console.ReadLine());
            Pizza b = new Pizza(number, name, size, bottom, ingredients);
            _pizzaListe.AddPizza(b);
        }
        private void DeletePizzaFromMenu()
        {
            Console.WriteLine("Delete Pizza");
            Console.WriteLine("Angiv nummer");
            string number = Console.ReadLine();
            _pizzaListe.DeletePizza(number);
        }

        private void SearchPizzaMenu()
        {
            Console.WriteLine("Search Pizza");
            Console.WriteLine("Angiv Nummer");
            string number = Console.ReadLine();
            Pizza pizza = _pizzaListe.LookupPizza(number);
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen eksisterer ikke");
            }
            else
            {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }

        private void UpdatePizzaMenu()
        {
            Console.WriteLine("Update Pizza");
            Console.WriteLine("Angiv nummer på den pizza der skal opdateres");
            string numberOld = Console.ReadLine();
            Pizza pizza = _pizzaListe.LookupPizza(numberOld);
            if (pizza == null)
            {
                Console.WriteLine("Pizzaen du prøver at opdatere eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Add Pizza");
                Console.WriteLine("Angiv nummer");
                string number = Console.ReadLine();
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv størrelse");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Angiv bund");
                int bottom = int.Parse(Console.ReadLine());
                Console.WriteLine("Angiv ingredienser");
                string ingredients = (Console.ReadLine());

               Pizza updatedPizza = new Pizza(number, name, size, bottom, ingredients);

                _pizzaListe.UpdatePizza(numberOld, updatedPizza);
                Console.WriteLine("Pizzaen er opdateret");
                Console.ReadLine();
            }
        }
        private void AddCustomerToList()
        {
            Console.WriteLine("Add Customer");
            Console.WriteLine("Angiv telefon nummer");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv email");
            string email = Console.ReadLine();
            Console.WriteLine("Angiv adresse");
            string address = Console.ReadLine();
            Customer b = new Customer(phone, name, email, false, address);
            _customerListe.AddCustomer(b);
        }
        private void DeleteCustomerFromList()
        {
            Console.WriteLine("Delete Customer");
            Console.WriteLine("Angiv navn");
            string navn = Console.ReadLine();
            _customerListe.DeleteCustomer(navn);
        }

        private void SearchCustomerListe()
        {
            Console.WriteLine("Search Customer");
            Console.WriteLine("Angiv Navn");
            string navn = Console.ReadLine();
            Customer customer = _customerListe.LookupCustomer(navn);
            if (customer == null)
            {
                Console.WriteLine("Kunden eksisterer ikke");
            }
            else
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }

        private void UpdateCustomerList()
        {
            Console.WriteLine("Update Kunde");
            Console.WriteLine("Angiv navn på den kunde der skal opdateres");
            string nameOld = Console.ReadLine();
            Customer customer = _customerListe.LookupCustomer(nameOld);
            if (customer == null)
            {
                Console.WriteLine("Kunden du prøver at opdatere eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Add Customer");
                Console.WriteLine("Angiv telefon nummer");
                int phone = int.Parse(Console.ReadLine());
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv email");
                string email =Console.ReadLine();
                Console.WriteLine("Angiv adresse");
                string address =Console.ReadLine();
                Customer updatedCustomer = new Customer(phone, name, email, false, address);
                _customerListe.UpdateCustomer(nameOld, updatedCustomer);
                Console.WriteLine("Kunden er opdateret");
                Console.ReadLine();
            }
        }
    }
}
