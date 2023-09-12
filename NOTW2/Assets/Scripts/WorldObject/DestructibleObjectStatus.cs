using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObjectStatus : DestructibleObjectBehaviour
{
    private int health;

    private void Start()
    {
        health = destructible_object.object_data.health;
    }

    public int getHealth()
    {
        return health;
    }

    public void setHealth(int value)
    {
        health = value;
    }
}
