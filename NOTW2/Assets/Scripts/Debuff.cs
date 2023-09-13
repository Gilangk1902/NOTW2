using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff
{
    public static void Slow(float movement_speed)
    {
        movement_speed = movement_speed / 4;
    }
}

public enum Debuff_Enum
{
    Slow,
    Poison
}