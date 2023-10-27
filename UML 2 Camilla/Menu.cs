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
       
        public Menu(PizzaListe _pizzaListe)     
            {

            _pizzaListe = pizzaListe;
            
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
            Console.WriteLine("\t---------------CRUD Listoperationer--------------------");
            Console.WriteLine("\t1.\tTilføj Pizza til Pizza Menu");
            Console.WriteLine("\t2.\tUdskriv Pizza menuen");
            Console.WriteLine("\t3.\tSøg efter en Pizza ud fra Nummer");
            Console.WriteLine("\t4.\tFjern Pizza fra Pizza Menuen");
            Console.WriteLine("\t5.\tOpdater Pizzaer i Pizza Menuen");
            Console.WriteLine();
            Console.WriteLine();
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
                        //Metode der indlæser og håndterer add Bog til BookRepositoryList
                        AddPizzaToList();
                        break;
                    case 2: // todo
                        Console.Clear();
                        Console.WriteLine("Pizza Menu");
                        _pizzaListe.PrintPizza();
                        break;
                    case 3: // todo
                        Console.Clear();
                        SearchBookList();
                        break;
                    case 4:
                        Console.Clear();
                        //Console.WriteLine("To be implemented!");
                        DeleteBookFromList();
                        break;
                    case 5:
                        Console.Clear();
                        UpdateBookList();
                        break;
                    case 6: 
                        // TODO
                        break;
                    case 7: 
                        // TODO
                        break;
                    case 8: 
                        // TODO
                        break;
                    case 9: 
                        // TODO
                        break;
                    case 10: 
                        // TODO
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
            Console.WriteLine("Search book");
            Console.WriteLine("Angiv ISBN");
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

    }
}
