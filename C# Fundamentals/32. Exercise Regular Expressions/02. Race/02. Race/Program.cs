using System.Text;
using System.Text.RegularExpressions;

class Participant
{
    public string Name { get; set; }
    public uint Distance { get; set; }
}

internal class Program
{
    public static void Main(string[] args)
    {
        List<Participant> participants = new List<Participant>();
        string[] nameArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < nameArr.Length; i++)
        {
            Participant participant = new Participant();
            participant.Name = nameArr[i];
            participant.Distance = 0;
            participants.Add(participant);
        }

        string lettersPattern = @"[A-Za-z]";
        string digitsPattern = @"\d";

        string command;
        while ((command = Console.ReadLine()) != "end of race")
        {
            StringBuilder name = new StringBuilder();

            foreach (Match match in Regex.Matches(command, lettersPattern))
            {
                name.Append(match.Value);
            }

            uint distance = 0;
            foreach (Match match in Regex.Matches(command, digitsPattern))
            {
                distance += uint.Parse(match.Value);
            }

            Participant foundParticipant = participants.FirstOrDefault(p => p.Name == name.ToString());
            if (foundParticipant != null)
            {
                foundParticipant.Distance += distance;
            }
        }

        List<Participant> orderedParticipants = participants
            .OrderByDescending(p => p.Distance)                             // Подреждам съзтезателите по изминати километри -> най-много към най-малко
            .Take(3)                                                        // Взимам първите 3ма
            .ToList();

        if (participants.Count >= 3)
        {
            Console.WriteLine($"1st place: {orderedParticipants[0].Name}");
            Console.WriteLine($"2nd place: {orderedParticipants[1].Name}");
            Console.WriteLine($"3rd place: {orderedParticipants[2].Name}");
        }
    }
}
