using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class BasicStats : MonoBehaviour
{
    [SerializeField] private PlayerStat player_stat;

    [SerializeField] private int health;
    [SerializeField] private float movement_speed;
    [SerializeField] private float jump_force;
    [SerializeField] private float sprint_multiplier;
    [SerializeField] private int max_num_of_jump;
    private void Start()
    {
        health = 100;
        movement_speed = player_stat.movement_speed;
        jump_force = player_stat.jump_force;
        sprint_multiplier = player_stat.sprint_multiplier;
        max_num_of_jump = player_stat.max_numOf_jump;
    }

    public void setMovementSpeed(float value) 
    {
        movement_speed = value;
    }
    public float getMovementSpeed()
    {
        return movement_speed;
    }

    public float getJumpForce()
    {
        return jump_force;
    }

    public float getSprintMultiplier()
    {
        return sprint_multiplier;
    }

    public float getNumOfJump()
    {
        return max_num_of_jump;
    }
}
