using System;
using System.Collections;

namespace NewOwoda


{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Ticket();
            double money = customer.GenTicket();

            for (int i = 0; i > -1; i++)  //loop till eternity
            {
                Console.WriteLine("Total sales is now\n" + money);
                Console.WriteLine(" Total amount for oga is now\n" + (money) * 0.65 + "\n Amount for self is now\n" + (money * 0.35));
                customer.GenTicketId();
                money = customer.GenTicket();
            }

        }

    }
    public class Ticket
    {

        public int totalTicket = 0;
        public double totalAmount = 0;
        public Random rmd = new Random();
        ArrayList ticketId = new ArrayList();

        public double GenTicket()
        {
            // method to get the tickets type and amount,method works fine
            Console.WriteLine("\n Enter type of ticket you wish to buy");
            string ticketType = Console.ReadLine();
            switch (ticketType)
            {
                case "month": totalAmount = totalAmount + 1000; break;
                case "day": totalAmount = totalAmount + 500; break;
                default: totalAmount = totalAmount + 0; break;
            }

            return totalAmount;

        }
        public void GenTicketId()
        {
            double newId = rmd.Next(100);      // Arraylist
            if (totalTicket > 0)              //this method is meant to generate a unique ticket id,
            {                                   //check it with stored tickets id and return it to the main
                foreach (double i in ticketId)
                {
                    {
                        while (newId == i)               //trying to iterate throught the stored tickets 
                        { newId = rmd.Next(100); }       // to prevent future repetition
                    }
                }
            }
            ticketId.Add(newId);
            totalTicket += 1;
            Console.WriteLine("Total ticket is now \n" + totalTicket + " and the tickets ids are\n");
            for (int i = 0; i < totalTicket; i++)
            {
                Console.WriteLine((i + 1) + "   " + ticketId[i]);
            }

        }






    }

}





