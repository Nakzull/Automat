using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Wares
    {
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        public Wares(string Name, int Price, int Stock)
        {
            name = Name;
            price = Price;
            stock = Stock;
        }
        // Here I create my objects from my Wares class and I create variables used to count the money the user inserted and how much money is in the machine..
        static Wares soda = new Wares("Soda", 20, 10);
        static Wares icetea = new Wares("Icetea", 15, 8);
        static Wares chocolate = new Wares("Chocolate", 22, 5);
        static Wares candy = new Wares("Candy", 10, 20);
        static Wares fruit = new Wares("Fruit", 13, 12);
        static int userMoney = 0;
        static int moneyInMachine = 0;
        static List<Wares> wares = new List<Wares>();
        
        public static void AddToList()
        {
            wares.Add(soda);
            wares.Add(icetea);
            wares.Add(chocolate);
            wares.Add(candy);
            wares.Add(fruit);
        }
        public static void Logic()
        {
            // This part prints my menu of items to the console along with asking for the users choice and storing that for later.
            Console.WriteLine(" ===================================================================================================================");
            Console.WriteLine("|                                                                                                                   |");
            Console.WriteLine("|                                            Vending machine                                                        |");
            Console.WriteLine("|                                                                                                                   |");
            Console.WriteLine(" ===================================================================================================================");
            Console.WriteLine("                                                                                                     Money count: {0}        ", userMoney);
            for (int i = 0; i < wares.Count; i++)
            {
                Console.WriteLine((i + 1) + " {0} price: {1}kr stock: {2}", wares[i].name, wares[i].price, wares[i].stock);
            }
            Console.WriteLine("\n9. Insert money");
            Console.WriteLine("0. Administration");
            int choice = Convert.ToInt32(Console.ReadLine());
            // This part is cycling through the user choice made earlier to see which part of the vending machine should be used.
            switch (choice)
            {
                case 1:
                    // First I check to see if the item is in stock then I check if the user have inserted enough money to buy the product
                    // and then I check if the user gets any change back.
                    Console.Clear();
                    if (soda.stock > 0)
                    {
                        if (userMoney >= soda.price)
                        {
                            Console.WriteLine("You have bought one soda");
                            soda.stock--;
                            int change = userMoney - soda.price;
                            if (change > 0)
                            {
                                Console.WriteLine("Don't forget your change of {0}kr", change);
                                userMoney = 0;
                                moneyInMachine -= change;
                            }
                        }
                        else
                            Console.WriteLine("You haven't inserted enough money to buy a {0}", soda.name);
                    }
                    else
                        Console.WriteLine("Unfortunately that product is sold out");
                    return;
                case 2:
                    if (icetea.stock > 0)
                    {
                        Console.Clear();
                        if (userMoney >= icetea.price)
                        {
                            Console.WriteLine("You have bought one icetea");
                            icetea.stock--;
                            int change = userMoney - icetea.price;
                            if (change > 0)
                            {
                                Console.WriteLine("Don't forget your change of {0}kr", change);
                                userMoney = 0;
                                moneyInMachine -= change;
                            }
                        }
                        else
                            Console.WriteLine("You haven't inserted enough money to buy a {0}", icetea.name);
                    }
                    else
                        Console.WriteLine("Unfortunately that product is sold out");
                    return;
                case 3:
                    if (chocolate.stock > 0)
                    {
                        Console.Clear();
                        if (userMoney >= chocolate.price)
                        {
                            Console.WriteLine("You have bought one icetea");
                            chocolate.stock--;
                            int change = userMoney - chocolate.price;
                            if (change > 0)
                            {
                                Console.WriteLine("Don't forget your change of {0}kr", change);
                                userMoney = 0;
                                moneyInMachine -= change;
                            }
                        }
                        else
                            Console.WriteLine("You haven't inserted enough money to buy a {0}", chocolate.name);
                    }
                    else
                        Console.WriteLine("Unfortunately that product is sold out");
                    return;
                case 4:
                    if (candy.stock > 0)
                    {
                        Console.Clear();
                        if (userMoney >= candy.price)
                        {
                            Console.WriteLine("You have bought one icetea");
                            candy.stock--;
                            int change = userMoney - candy.price;
                            if (change > 0)
                            {
                                Console.WriteLine("Don't forget your change of {0}kr", change);
                                userMoney = 0;
                                moneyInMachine -= change;
                            }
                        }
                        else
                            Console.WriteLine("You haven't inserted enough money to buy a {0}", candy.name);
                    }
                    else
                        Console.WriteLine("Unfortunately that product is sold out");
                    return;
                case 5:
                    if (fruit.stock > 0)
                    {
                        Console.Clear();
                        if (userMoney >= fruit.price)
                        {
                            Console.WriteLine("You have bought one icetea");
                            fruit.stock--;
                            int change = userMoney - fruit.price;
                            if (change > 0)
                            {
                                Console.WriteLine("Don't forget your change of {0}kr", change);
                                userMoney = 0;
                                moneyInMachine -= change;
                            }
                        }
                        else
                            Console.WriteLine("You haven't inserted enough money to buy a {0}", fruit.name);
                    }
                    else
                        Console.WriteLine("Unfortunately that product is sold out");
                    return;
                case 9:
                    {
                        for (; ; )
                        {
                            // This part lets the user insert money into the machine.
                            Console.Clear();
                            Console.WriteLine("Which coin do you wanna insert?");
                            Console.WriteLine("                                                                                                     Money count: {0}\n1. 1kr\n2. 2kr\n5. 5kr\n10. 10kr\n\n0. Done inserting money", userMoney);
                            int moneyInserted = Convert.ToInt32(Console.ReadLine());
                            if (moneyInserted == 1)
                            {
                                userMoney += 1;
                                moneyInMachine += 1;
                            }
                            else if (moneyInserted == 2)
                            {
                                moneyInMachine += 2;
                                userMoney += 2;
                            }
                            else if (moneyInserted == 5)
                            {
                                moneyInMachine += 5;
                                userMoney += 5;
                            }
                            else if (moneyInserted == 10)
                            {
                                moneyInMachine += 10;
                                userMoney += 10;
                            }
                            else if (moneyInserted == 0)
                                break;
                            else
                                Console.WriteLine("Please select a valid input (1, 2, 5, 10, 0");
                        }
                        break;
                    }
                case 0:
                    {
                        for (; ; )
                        {
                            // This is the menu for the administration where an admin can change names, prices and stock of each item or remvoe money from the machine.
                            Console.Clear();
                            Console.WriteLine("Welcome to administration. Which item do you wish to adjust?");
                            for (int i = 0; i < wares.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " {0} price: {1}kr stock: {2}", wares[i].name, wares[i].price, wares[i].stock);
                            }
                            Console.WriteLine("6. Remove money in machine                                                                 Coin count: {0}", moneyInMachine);
                            Console.WriteLine("9. Return to previous menu");
                            int adminChoice = Convert.ToInt32(Console.ReadLine());
                            if (adminChoice == 1)
                            {
                                for (; ; )
                                {
                                    Console.WriteLine("Current price of {0}: {1} Number in stock: {2}", soda.name, soda.price, soda.stock);
                                    Console.WriteLine("What do you wish to adjust?");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Price");
                                    Console.WriteLine("3. Stock");
                                    Console.WriteLine("4. Return to previous menu");
                                    int adminChoiceMenu = Convert.ToInt32(Console.ReadLine());
                                    if (adminChoiceMenu == 1)
                                    {
                                        Console.WriteLine("What do you wish the new name to be?");
                                        soda.name = Console.ReadLine();
                                    }
                                    else if (adminChoiceMenu == 2)
                                    {
                                        Console.WriteLine("What do you wish the new price to be?");
                                        soda.price = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 3)
                                    {
                                        Console.WriteLine("What do you wish the new stock to be?");
                                        soda.stock = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 4)
                                    {
                                        break;
                                    }
                                    else Console.WriteLine("Please select a valid option (1, 2, 3, 4)");
                                }
                            }
                            else if (adminChoice == 2)
                            {
                                for (; ; )
                                {
                                    Console.WriteLine("Current price of {0}: {1} Number in stock: {2}", icetea.name, icetea.price, icetea.stock);
                                    Console.WriteLine("What do you wish to adjust?");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Price");
                                    Console.WriteLine("3. Stock");
                                    Console.WriteLine("4. Return to previous menu");
                                    int adminChoiceMenu = Convert.ToInt32(Console.ReadLine());
                                    if (adminChoiceMenu == 1)
                                    {
                                        Console.WriteLine("What do you wish the new name to be?");
                                        icetea.name = Console.ReadLine();
                                    }
                                    else if (adminChoiceMenu == 2)
                                    {
                                        Console.WriteLine("What do you wish the new price to be?");
                                        icetea.price = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 3)
                                    {
                                        Console.WriteLine("What do you wish the new stock to be?");
                                        icetea.stock = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 4)
                                    {
                                        break;
                                    }
                                    else Console.WriteLine("Please select a valid option (1, 2, 3, 4)");
                                }
                            }
                            else if (adminChoice == 3)
                            {
                                for (; ; )
                                {
                                    Console.WriteLine("Current price of {0}: {1} Number in stock: {2}", chocolate.name, chocolate.price, chocolate.stock);
                                    Console.WriteLine("What do you wish to adjust?");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Price");
                                    Console.WriteLine("3. Stock");
                                    Console.WriteLine("4. Return to previous menu");
                                    int adminChoiceMenu = Convert.ToInt32(Console.ReadLine());
                                    if (adminChoiceMenu == 1)
                                    {
                                        Console.WriteLine("What do you wish the new name to be?");
                                        chocolate.name = Console.ReadLine();
                                    }
                                    else if (adminChoiceMenu == 2)
                                    {
                                        Console.WriteLine("What do you wish the new price to be?");
                                        chocolate.price = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 3)
                                    {
                                        Console.WriteLine("What do you wish the new stock to be?");
                                        chocolate.stock = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 4)
                                    {
                                        break;
                                    }
                                    else Console.WriteLine("Please select a valid option (1, 2, 3, 4)");
                                }
                            }
                            else if (adminChoice == 4)
                            {
                                for (; ; )
                                {
                                    Console.WriteLine("Current price of {0}: {1} Number in stock: {2}", candy.name, candy.price, candy.stock);
                                    Console.WriteLine("What do you wish to adjust?");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Price");
                                    Console.WriteLine("3. Stock");
                                    Console.WriteLine("4. Return to previous menu");
                                    int adminChoiceMenu = Convert.ToInt32(Console.ReadLine());
                                    if (adminChoiceMenu == 1)
                                    {
                                        Console.WriteLine("What do you wish the new name to be?");
                                        candy.name = Console.ReadLine();
                                    }
                                    else if (adminChoiceMenu == 2)
                                    {
                                        Console.WriteLine("What do you wish the new price to be?");
                                        candy.price = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 3)
                                    {
                                        Console.WriteLine("What do you wish the new stock to be?");
                                        candy.stock = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 4)
                                    {
                                        break;
                                    }
                                    else Console.WriteLine("Please select a valid option (1, 2, 3, 4)");
                                }
                            }
                            else if (adminChoice == 5)
                            {
                                for (; ; )
                                {
                                    Console.WriteLine("Current price of {0}: {1} Number in stock: {2}", fruit.name, fruit.price, fruit.stock);
                                    Console.WriteLine("What do you wish to adjust?");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Price");
                                    Console.WriteLine("3. Stock");
                                    Console.WriteLine("4. Return to previous menu");
                                    int adminChoiceMenu = Convert.ToInt32(Console.ReadLine());
                                    if (adminChoiceMenu == 1)
                                    {
                                        Console.WriteLine("What do you wish the new name to be?");
                                        fruit.name = Console.ReadLine();
                                    }
                                    else if (adminChoiceMenu == 2)
                                    {
                                        Console.WriteLine("What do you wish the new price to be?");
                                        fruit.price = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 3)
                                    {
                                        Console.WriteLine("What do you wish the new stock to be?");
                                        fruit.stock = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (adminChoiceMenu == 4)
                                    {
                                        break;
                                    }
                                    else Console.WriteLine("Please select a valid option (1, 2, 3, 4)");
                                }
                            }
                            else if (adminChoice == 6)
                            {
                                Console.WriteLine("Current amount of money in machine: {0}kr", moneyInMachine);
                                Console.WriteLine("Do you wish to withdraw all the money? (yes/no)");
                                string adminChoiceMenu = Console.ReadLine();
                                if (adminChoiceMenu == "yes")
                                {
                                    Console.WriteLine("You have withdrawn {0}kr", moneyInMachine);
                                    moneyInMachine = 0;
                                    Console.ReadKey();
                                }
                                else if (adminChoiceMenu == "no")
                                {
                                    Console.WriteLine("No money has been removed");
                                    Console.ReadKey();
                                }
                            }
                            else if (adminChoice == 9)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please select a valid option (1, 2, 3, 4, 5, 6, 9");
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select a valid option (1, 2, 3, 4, 5, 9, 10");
                        return;
                    }
            }
        }
    }

}
