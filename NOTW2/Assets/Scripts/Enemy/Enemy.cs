using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHitable
{
    private EnemyStatus enemy_status;

    private void Awake()
    {
        enemy_status.enemy = this;
    }

    public void ModifiyHealth(int value)
    {
        enemy_status.setHealth(
                enemy_status.getHealth() + value
            );
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void CriticalCondition()
    {
        //give debuff
    }
}
