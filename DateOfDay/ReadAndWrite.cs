using DateofDay.Core;
using System;

namespace DateOfDay
{
    public class ReadAndWrite  // tez zmieniłem na public 
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateDTOS { get; set; }

        public DaysOfTheWeek FinalDayOfTheWeek { get; set; }

        public void Greeter()
        {
            Console.WriteLine("Witaj w programie określającym dzień tygodnia po podaniu daty");
        }
        public void Asker()
        {
            Console.WriteLine("Podaj proszę datę w formacie dd.mm.rrrr");


            var userDate = Console.ReadLine();
            if (DateTimeOffset.TryParse(userDate, out var date))
            {
                UserDateDTOS = date;
                return;
            }

            else
            {
                Console.WriteLine("Podano zły format daty.");
                Asker(); // Wywołuję jeszcze raz tę samą funkcję 

            }

        }
        public void Machine()
        
        {
              Calculator = new DayCalculator();

             FinalDayOfTheWeek = Calculator.CalculateDay(UserDateDTOS);

            
      
        }
        public void Writer ()
        {
            Console.WriteLine("Dzień tygodnia " +  UserDateDTOS + " to " + FinalDayOfTheWeek);
        }

    }
}
