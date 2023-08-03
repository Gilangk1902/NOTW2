using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private PlayerStateEnum current_state;

    private void Update() {
        
    }

    public void setState(PlayerStateEnum new_state){
        current_state = new_state;
    }

    public PlayerStateEnum getCurrentState(){
        return current_state;
    }
}

public enum PlayerStateEnum
{
    Idle,
    Move,
    Sprint,
    OnAir
}
