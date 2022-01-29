using System.Collections.Generic;

public class MetalAffix
{
    // should this be a scriptable object?
    // I included the spaces to make it easier

    
    public static List<string> getPrefixes()
    {
        return new List<string>()
        {
            "Death",
            "Dead ",
            "Deth",
            "Det",
            "Under",
            "Skull",
            "Bone",
            "Hate ",
            "Brutal ",
            "Ancient ",
            "Dark ",
            "Awakened ",
            "Steel ",
            "Lord of ",
            "Frozen ",
            "Burning ",
            "Molten ",
            "Destroyer of " 
        };
    }

    public static List<string> getSuffixes()
    {
        return new List<string>()
        {
            "God",
            "Heim",
            " Eternity",
            " Cannibal",
            " Beast",
            " Demon",
            " Darkness",
            " Goat",
            " Slayer",
            " Era",
            " Blood",
            " Powerplant",
            "Lord",
            " Devourer"
        };
    }
}