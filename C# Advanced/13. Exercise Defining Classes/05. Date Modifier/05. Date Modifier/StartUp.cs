namespace DateModifier;

public class StartUp
{
    static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        // {DateModifier} е статичен клас и затова мога да го извиквам като {Console}
        int differanceInDays = DateModifier.GetDifferenceInDays(start, end);

        Console.WriteLine(differanceInDays);
    }
}