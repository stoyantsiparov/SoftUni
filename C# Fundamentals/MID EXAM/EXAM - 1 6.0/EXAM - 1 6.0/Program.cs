double neededExperience = double.Parse(Console.ReadLine());
int battleCount = int.Parse(Console.ReadLine());

double totalExperienceGained = 0;

for (int i = 1; i <= battleCount; i++)
{
    double experiencePerBattleGained = double.Parse(Console.ReadLine());

    if (i % 15 == 0)
    {
        experiencePerBattleGained *= 1.05;
    }
    else if (i % 5 == 0)
    {
        experiencePerBattleGained *= 0.9;
    }
    else if (i % 3 == 0)
    {
        experiencePerBattleGained *= 1.15;
    }

    totalExperienceGained += experiencePerBattleGained;

    if (totalExperienceGained >= neededExperience)
    {
        Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
        return;
    }
}

double neededExperienceToGain = neededExperience - totalExperienceGained;
Console.WriteLine($"Player was not able to collect the needed experience, {neededExperienceToGain:F2} more needed.");
