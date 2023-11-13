namespace AppDay3
{
    internal class Program
    {
        const int TEENAGER = 13;
        const int YOUNGADULT = 20;
        const int ADULT = 25;
        const int OLDERCITIZEN = 65;
        static void Main(string[] args)
        {
            bool moreParticipants = false;
            int totalParticipants = 0;
            int oldestAge = int.MinValue;
            int youngestAge = int.MaxValue;

            // Variables to track oldest and youngest participants for each age bracket
            int youngestOlderCitizen = int.MaxValue;
            int oldestAdult = int.MinValue;
            int youngestAdult = int.MaxValue;
            int oldestYoungAdult = int.MinValue;
            int youngestYoungAdult = int.MaxValue;
            int oldestTeenager = int.MinValue;
            int youngestTeenager = int.MaxValue;
            int oldestChild = int.MinValue;

            //Variables to track number of participants in each category
            int totalOldest = 0;
            int totalAdults = 0;
            int totalYoungAdults = 0;
            int totalTeenagers = 0;
            int totalChildren = 0;

            //Variables to store the total ages to get mean value
            float totalAge = 0;
            float totalOlderAge = 0;
            float totalAdultAge = 0;
            float totalYoungAdultAge = 0;
            float totalTeenagerAge = 0;
            float totalChildrenAge = 0;
            do
            {
                Console.Write("Enter participant's age > ");
                int participantAge = Convert.ToInt32(Console.ReadLine());
                totalParticipants++;
                if (participantAge < youngestAge) 
                { 
                    youngestAge = participantAge;
                }
                totalAge += participantAge;

                string participantAgeBracket;
                if (participantAge >= OLDERCITIZEN)
                {
                    participantAgeBracket = "An Older Citizen";
                    totalOldest++;
                    totalOlderAge += participantAge;
                    // Check for oldest and youngest within the Older Citizen category
                    if (participantAge > oldestAge)
                        oldestAge = participantAge;

                    if (participantAge < youngestOlderCitizen)
                        youngestOlderCitizen = participantAge;

                }
                else if (participantAge >= ADULT)
                {
                    participantAgeBracket = "An Adult";
                    totalAdults++;
                    totalAdultAge += participantAge;
                    // Check for oldest and youngest within the Adult category
                    if (participantAge > oldestAdult)
                        oldestAdult = participantAge;

                    if (participantAge < youngestAdult)
                        youngestAdult = participantAge;

                }
                else if (participantAge >= YOUNGADULT)
                {
                    participantAgeBracket = "A Young Adult";
                    totalYoungAdults++;
                    totalYoungAdultAge += participantAge;
                    // Check for oldest and youngest within the Young Adult category
                    if (participantAge > oldestYoungAdult)
                        oldestYoungAdult = participantAge;

                    if (participantAge < youngestYoungAdult)
                        youngestYoungAdult = participantAge;
                }
                else if (participantAge >= TEENAGER)
                {
                    participantAgeBracket = "A Teenager";
                    totalTeenagers++;
                    totalTeenagerAge += participantAge;
                    // Check for oldest and youngest within the Teenager category
                    if (participantAge > oldestTeenager)
                        oldestTeenager = participantAge;

                    if (participantAge < youngestTeenager)
                        youngestTeenager = participantAge;
                }
                else
                {
                    participantAgeBracket = "A Child";
                    totalChildren++;    
                    totalChildrenAge += participantAge;
                    // Check for oldest and youngest within the Child category
                    if (participantAge > oldestChild)
                        oldestChild = participantAge;
                    if (participantAge < youngestAge)
                    {
                        youngestAge = participantAge;
                    }
                }
                Console.WriteLine($"At the age of {participantAge} particiant is {participantAgeBracket}");
                Console.WriteLine("Press Y to add another participant or press any key to exit");
                string anotherParticipant = Console.ReadLine().ToUpper();
                moreParticipants = (anotherParticipant == "Y");
            }
            while (moreParticipants);

            if (totalParticipants > 0)
            {
                Console.WriteLine($"Total poll participants: {totalParticipants}");
                Console.WriteLine($"Oldest Participant: {oldestAge}");
                Console.WriteLine($"Youngest Participant: {youngestAge}");

                Console.WriteLine($"Total Older Citizen: {totalOldest}");
                float meanOlderAge = totalOlderAge / totalOldest;
                Console.WriteLine($"Mean age of Older citizens: {meanOlderAge}");

                Console.WriteLine($"Total Adults: {totalAdults}");
                float meanAdultAge = totalAdultAge / totalAdults;
                Console.WriteLine($"Mean age of Adults: {meanAdultAge}");

                Console.WriteLine($"Total Young Adults: {totalYoungAdults}");
                float meanYoungAdultAge = totalYoungAdultAge / totalYoungAdults;
                Console.WriteLine($"Mean age of Young Adults: {meanYoungAdultAge}");

                Console.WriteLine($"Total Teenagers: {totalTeenagers}");
                float meanTeenageAge = totalTeenagerAge / totalTeenagers;
                Console.WriteLine($"Mean age of Teenagers: {meanTeenageAge}");

                Console.WriteLine($"Total Children: {totalChildren}");
                float meanChildAge = totalChildrenAge / totalChildren;
                Console.WriteLine($"Mean age of Children: {meanChildAge}");
                

                float meanAge = totalAge / totalParticipants;
                Console.WriteLine($"Mean age of participants: {meanAge}");
                Console.WriteLine($"Mean age of participants: {meanAge} years, {meanAge % 1 * 365} days");
            }
            else 
            {
                Console.WriteLine("No participants in this poll");
            }
            Console.WriteLine("Goodbye");
        }
    }
}