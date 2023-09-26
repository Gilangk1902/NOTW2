using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerBehaviour
{
    public float PLAYER_VIEW_RADIUS = 100f;
    public float PLAYER_VIEW_DISTANCE = 100f;
    private int layer_mask;
    private void Awake()
    {
        layer_mask = ~LayerMask.GetMask("Player");
    }

    void Update()
    {
        MovementController();
        JumpController();
        InteractionController();
    }

    private void InteractionController()
    {
        Transform player_camera = player.getCameraLook()
                                        .getPlayerCamera()
                                        .transform;
        if (Physics.Raycast(player_camera.position, player_camera.forward, 
            out RaycastHit hit_info, PLAYER_VIEW_DISTANCE, layer_mask))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (player.getPlayerInteraction().getObjectGrab() == null)
                {
                    player.getPlayerInteraction().Interact(hit_info);
                }
                else
                {
                    player.getPlayerInteraction().ResetGrab();
                }   
            }
        }
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
