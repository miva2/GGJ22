using System.Collections;
using System;

public class MetalBandNameGenerator
{
    /// chance in a range of 0 to 1. 0 means it will not appear, 1 means it will always appear.
    public static string Generate(string input, float prefixChance, float suffixChance)
    {
        //TODO: scramble (should I still do this?)
        // TODO: apply chance
        Random random = new Random();
        float prefixValue = (float)random.NextDouble();
        float suffixValue = (float)random.NextDouble();


        string prefix = prefixChance >= prefixValue ? MetalAffix.getPrefixes().GetRandomElement<string>() : "";
        string suffix = suffixChance >= suffixValue ? MetalAffix.getSuffixes().GetRandomElement<string>() : "";

        return $"{prefix}{input}{suffix}";
    }
}
