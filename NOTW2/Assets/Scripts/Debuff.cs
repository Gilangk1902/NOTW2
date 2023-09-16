using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff
{
    public static void Slow(BasicStats  stat, int multiplier)
    {
        stat.setMovementSpeed(stat.getMovementSpeed()/multiplier);
    }
}

public enum Debuff_Enum
{
    Slow,
    Poison
}