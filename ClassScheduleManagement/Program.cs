using System;
using System.Collections.Generic;

namespace Models1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of Scheds to store multiple schedules
            List<Scheds> schedules = new List<Scheds>
            {
                new Scheds { Class = "BSIT 2-1", Day = "Monday", Subject = "PATHFIT", Time = "3:00-5:00 PM", Professor = "Ms. Noemi Apostol" },
                new Scheds { Class = "BSIT 2-1", Day = "Monday", Subject = "Quantitative Methods with Modeling and Stimulation", Time = "6:00-9:00 PM", Professor = "Mr. Rowell Marquina" },
                new Scheds { Class = "BSIT 2-1", Day = "Tuesday", Subject = "Quantitative Methods with Modeling and Stimulation", Time = "7:00-9:00 PM", Professor = "Mr. Rowell Marquina" },
                new Scheds { Class = "BSIT 2-1", Day = "Tuesday", Subject = "Network Administration", Time = "5:00-8:00 PM", Professor = "Mr. Aaron Atienza" },
                new Scheds { Class = "BSIT 2-1", Day = "Tuesday", Subject = "Information Management", Time = "8:00-12:30 PM", Professor = "Mr. Michael Miguel" },
                new Scheds { Class = "BSIT 2-1", Day = "Wednesday", Subject = "Free Elective 2", Time = "2:00-5:00 PM", Professor = "Ms. Abigail Verterra" },
                new Scheds { Class = "BSIT 2-1", Day = "Wednesday", Subject = "Human-Computer Interaction", Time = "5:00-8:00 PM", Professor = "Mr. Ramon Almazan" },
                new Scheds { Class = "BSIT 2-1", Day = "Saturday", Subject = "Object Oriented Programming", Time = "8:00-12:30 PM", Professor = "Mr. Ed Dela Cruz" },
                new Scheds { Class = "BSIT 2-1", Day = "Saturday", Subject = "Integrative Programming Technologies 1", Time = "2:00-7:00 PM", Professor = "Ms. Indaleen Quinsayas" }
            };

            // Display the schedule details
            foreach (var schedule in schedules)
            {
                Console.WriteLine($"Class: {schedule.Class}");
                Console.WriteLine($"Day: {schedule.Day}");
                Console.WriteLine($"Subject: {schedule.Subject}");
                Console.WriteLine($"Time: {schedule.Time}");
                Console.WriteLine($"Professor: {schedule.Professor}");
                Console.WriteLine(new string('-', 50)); // Separator for readability
            }
        }
    }
}
