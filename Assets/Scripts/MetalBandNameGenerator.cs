using System.Collections;

public class MetalBandNameGenerator
{
    /// chance in a range of 0 to 1. 0 means it will not appear, 1 means it will always appear.
    public static string Generate(string input, float prefixChance, float suffixChance)
    {
        //TODO: scramble
        // TODO: apply chance

        string prefix = MetalAffix.getPrefixes().GetRandomElement<string>();
        string suffix = MetalAffix.getSuffixes().GetRandomElement<string>();

        return $"{prefix}{input}{suffix}";
    }
}
