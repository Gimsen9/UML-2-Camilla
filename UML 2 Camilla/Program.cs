// See https://aka.ms/new-console-template for more information
using UML_2_Camilla;

CustomerListe customerListe = new CustomerListe();

Customer customer = new Customer(
    47167684,
    "Helle Dahl",
    "hoj@mail,dk",
    true,
    "Hejrevej 5 8927 Kanada");

customerListe.AddCustomer(customer);

Customer customer1 = new Customer(
    58596847, 
    "John Ole", 
    "spif@ofir.dk", 
    false, 
    "Holmen 8 5462 Christianshavn");

customerListe.AddCustomer(customer1);

PizzaListe pizzaListe = new PizzaListe();
Pizza pizza = new Pizza("1", "Magarita", 1, 1, "Tomat, Ost, Basilikum, Hvede, Gær, Salt og Olivenolie");
pizzaListe.AddPizza(pizza);

Pizza pizza1 = new Pizza("2", "Capricciosa", 1, 1, "Tomat, Ost, Champignoner, Skinke (Gris), Olivenolie, Gær, Salt, Hvede");
pizzaListe.AddPizza(pizza1);

Pizza pizza2 = new Pizza("3", "Bianca con Patate", 1, 1, "Mascapone, Kartofler, Bacon (Skinke), Rosmarin, Olivenolie, Gær, Salt, Hvede");
pizzaListe.AddPizza(pizza2);


Menu menu = new Menu(pizzaListe, customerListe);
menu.Run();


