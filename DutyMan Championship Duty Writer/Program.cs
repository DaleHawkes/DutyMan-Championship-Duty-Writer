using System;
using System.Collections.Generic;

namespace DutyMan_Championship_Duty_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            // Get all the info, this should be in a method called GetInfo()
            Console.WriteLine("What is the Event?");
            var nameEvent = Console.ReadLine();
            Console.WriteLine(nameEvent);

            Console.WriteLine("What is the Duty Date?");
            var dutyDate = Console.ReadLine();
            Console.WriteLine(dutyDate);

            Console.WriteLine("What is the time volunteers need to be at the club (24 Hour Clock)?");
            var dutyTime = Console.ReadLine();
            Console.WriteLine(dutyTime);

            Console.WriteLine("How many people will we need on the committee boat?");
            var peopleCommitteeBoat = Console.ReadLine();
            Console.WriteLine(peopleCommitteeBoat);

            Console.WriteLine("How many RIBs will we need?");
            var ribsNeeded = Console.ReadLine();
            Console.WriteLine(ribsNeeded);

            Console.WriteLine("How many helpers will we need ashore?");
            var ashoreHelpersNeeded = Console.ReadLine();
            Console.WriteLine(ashoreHelpersNeeded);

            // Collect all the data and work out the maths etc, should be in its own method

            //COMMITTEE BOAT SECTION - NEEDS ITS OWN METHOD
            // Convert the string from RIBSNeeded to an int

            int peopleCommitteeBoatTotal;
            Int32.TryParse(peopleCommitteeBoat, out peopleCommitteeBoatTotal);

            var onWaterCommitteeBoatList = new List<string>();
            i = 0;
            do
            {
                var outputOnWaterCommitteeBoat = dutyDate + " " + dutyTime + " " + nameEvent + " " + "Committee Boat";
                Console.WriteLine(outputOnWaterCommitteeBoat);
                onWaterCommitteeBoatList.Add(outputOnWaterCommitteeBoat);
                i++;
            }
            while (i < peopleCommitteeBoatTotal);

            //ON WATER SUPPORT SECTION - NEEDS ITS OWN METHOD
            // Convert the string from RIBSNeeded to an int
            int ribsNeededInt;
            Int32.TryParse(ribsNeeded, out ribsNeededInt);
            // Lets say we have 5 RIBS we need 10 people to drive/crew them, so we need 10 people to help
            var ribsNeededTotal = ribsNeededInt * 2;

            //OnWaterVolunteersList - lets store our string to be outputted in an array for now
            var onWaterVolunteersList = new List<string>();

            i = 0;
            do
            {
                var outputOnWaterSupport = dutyDate + " " + dutyTime + " " + nameEvent + " " + "On Water Helper";
                Console.WriteLine(outputOnWaterSupport);
                onWaterVolunteersList.Add(outputOnWaterSupport);
                i++;
            }
            while (i < ribsNeededTotal);

            //ASHORE SECTION - NEEDS ITS OWN METHOD
            // Convert the string from RIBSNeeded to an int

            int ashoreHelpersNeededTotal;
            Int32.TryParse(ashoreHelpersNeeded, out ashoreHelpersNeededTotal);

            var ashoreList = new List<string>();
            i = 0;
            do
            {
                var outputOffWater = dutyDate + " " + dutyTime + " " + nameEvent + " " + "Off Water Helper";
                Console.WriteLine(outputOffWater);
                ashoreList.Add(outputOffWater);
                i++;
            }
            while (i < ashoreHelpersNeededTotal);

            Console.ReadLine();

        }

        //GetInfo();
        //public string GetInfo(string DutyDate)
        //{
        //    Console.WriteLine("What is the Duty Date?");
        //    DutyDate = Console.ReadLine();
        //    Console.WriteLine(DutyDate);

        //    return DutyDate;
        //}
    }
}

