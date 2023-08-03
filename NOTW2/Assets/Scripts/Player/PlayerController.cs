using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerBehaviour
{
    void Update()
    {
        MovementController();
        JumpController();
    }

    void MovementController(){
        if(Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0)
        {
            if(player.isGrounded){
                player.getMovement().Walk();
                player.getPlayerState().setState(PlayerStateEnum.Move);
            }
            else{
                player.getMovement().Walk();
                player.getPlayerState().setState(PlayerStateEnum.OnAir);
            }
            
        }
        else if (Input.GetAxis("Horizontal")==0 && Input.GetAxis("Vertical")==0){
            if(player.isGrounded){
                player.getPlayerState().setState(PlayerStateEnum.Idle);
            }
            else{
                player.getPlayerState().setState(PlayerStateEnum.OnAir);
            }
        }
    }

    void JumpController(){
        if(Input.GetKeyDown(KeyCode.Space)){
            player.getMovement().Jump();
        }
    }

    public override void Die()
    {
        throw new System.NotImplementedException();
    }
}
