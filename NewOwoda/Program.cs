using System;

namespace NewOwoda


{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Ticket();
            double money = customer.GenTicket();
            double amountForOga = money * 0.65;
            double forSelf = money;
            Console.WriteLine("Total amount for oga is now\n" + amountForOga + "\n Amount for self is now\n" + forSelf);
            double[] ticketIds = { };
            int totalT = 0;
            // This line is actually my issue,I'm trying to copy the return
            // from the customer.GenTicketId() into the newly created ticketIds
            ticketIds = (double[])(customer.GenTicketId()).Clone();


            // minor manipulations ------Array.Resize(ref ticketIds, totalT+ 1);
            // Array.Copy(customer.GenTicketId(),ticketIds,totalT+1);

            totalT += 1;
            Console.WriteLine(totalT);  
            Console.ReadKey();
            Console.WriteLine(ticketIds);
       
         




        }

    }
    public class Ticket
    {

        public int totalTicket = 0;
        public double totalAmount = 0;
        public Random rmd = new Random();
        public double[] ticketId = { };
        public double GenTicket()
        {
            // method to get the tickets type and amount,method works fine
            Console.WriteLine("Enter type of ticket you wish to buy");
            string ticketType = Console.ReadLine();
            switch (ticketType)
            {
                case "month": totalAmount = totalAmount + 1000; break;
                case "day": totalAmount = totalAmount + 500; break;
                default: totalAmount = totalAmount + 0; break;
            }
   
            return totalAmount;

        }
        public double[] GenTicketId()
        {
          //this method is meant to generate a unique ticket id,
          //check it with stored tickets id and return it to the main
            double newId = rmd.Next(100);
            if (totalTicket > 0)
            {
                foreach (double i in ticketId)
                {
                    {
                        while (newId == i)         //trying to iterate throught the stored tickets 
                        { newId = rmd.Next(100); }  // to prevent future repetition
                    }
                }
            }
            ticketId[totalTicket] = newId;
            totalTicket += 1;
            return ticketId;
        }






    }

}





