using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerStat", menuName = "Game Data/Player Stat")]
public class PlayerStat : ScriptableObject
{
    public float movement_speed;
    public float sprint_multiplier;
    public float jump_force;
    public float max_numOf_jump;
}
