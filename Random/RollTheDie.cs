using System;
public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        return rand.Next(1, 18);
    }
    public double GenerateSpellStrength()
    {
        Random spellStrength = new Random();
        return spellStrength.NextDouble();
    }
}
