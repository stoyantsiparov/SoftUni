﻿namespace PlayersAndMonsters;

public abstract class Hero
{
    protected Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public string Username { get; set; }
    public int Level { get; set; }

    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}