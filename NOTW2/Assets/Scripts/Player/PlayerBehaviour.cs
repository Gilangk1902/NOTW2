using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBehaviour : MonoBehaviour
{
    [HideInInspector] protected bool player_isAlive;
    [HideInInspector] public Player player;

    private int health;

    private void Awake() {
        player_isAlive = true;
    }


    public Player getPlayer(){
        return player;
    }

    public abstract void Die();

}
