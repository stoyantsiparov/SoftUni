using System;
using System.Collections.Generic;
class Piece
{
    public string Composer { get; set; }
    public string Key { get; set; }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

        for (int i = 0; i < n; i++)
        {
            string[] pieceInfo = Console.ReadLine().Split('|');
            string pieceName = pieceInfo[0];
            string composer = pieceInfo[1];
            string key = pieceInfo[2];
            Piece piece = new Piece
            {
                Composer = composer,
                Key = key
            };
            pieces.Add(pieceName, piece);
        }

        string command;
        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] commandInfo = command.Split('|');
            string action = commandInfo[0];
            string pieceName = commandInfo[1];

            switch (action)
            {
                case "Add":
                    string composer = commandInfo[2];
                    string key = commandInfo[3];
                    AddPiece(pieces, pieceName, composer, key);
                    break;

                case "Remove":
                    RemovePiece(pieces, pieceName);
                    break;

                case "ChangeKey":
                    string newKey = commandInfo[2];
                    ChangePieceKey(pieces, pieceName, newKey);
                    break;

                default:
                    Console.WriteLine("Invalid action!");
                    break;
            }
        }

        // Print all pieces in the collection
        foreach (var kvp in pieces)
        {
            string pieceName = kvp.Key;
            string composer = kvp.Value.Composer;
            string key = kvp.Value.Key;
            Console.WriteLine($"{pieceName} -> Composer: {composer}, Key: {key}");
        }
    }

    static void AddPiece(Dictionary<string, Piece> pieces, string pieceName, string composer, string key)
    {
        if (!pieces.ContainsKey(pieceName))
        {
            Piece piece = new Piece
            {
                Composer = composer,
                Key = key
            };
            pieces.Add(pieceName, piece);
            Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
        }
        else
        {
            Console.WriteLine($"{pieceName} is already in the collection!");
        }
    }

    static void RemovePiece(Dictionary<string, Piece> pieces, string pieceName)
    {
        if (pieces.ContainsKey(pieceName))
        {
            pieces.Remove(pieceName);
            Console.WriteLine($"Successfully removed {pieceName}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
        }
    }

    static void ChangePieceKey(Dictionary<string, Piece> pieces, string pieceName, string newKey)
    {
        if (pieces.ContainsKey(pieceName))
        {
            pieces[pieceName].Key = newKey;
            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
        }
    }
}