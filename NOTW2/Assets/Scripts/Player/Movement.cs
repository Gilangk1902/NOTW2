using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : PlayerBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerState player_state;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        RefreshCurrentJump();
    }

    public void Walk(){
        Move(1f);
    }

    public void Sprint(){
        float multiplier = getPlayer().getPlayerStat().sprint_multiplier;
        Move(multiplier);
    }

    private void Move(float multiplier){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float movement_speed = getPlayer().getPlayerStat().movement_speed * multiplier;

        Vector3 moveDirection = transform.forward*verticalInput + transform.right * horizontalInput;
        moveDirection.y =  0;

        rb.velocity = new Vector3(
            moveDirection.x * movement_speed, rb.velocity.y, moveDirection.z * movement_speed
        );
    }

    private int current_jump = 0;
    public void Jump(){
        if(player.getPlayerStat().max_numOf_jump-1 > current_jump){
            current_jump++;
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector3.up * player.getPlayerStat().jump_force, ForceMode.Impulse);
        }
    }

    private void RefreshCurrentJump(){
        if(player.isGrounded){
            current_jump=0;
        }
    }

    public override void Die()
    {
        throw new System.NotImplementedException();
    }
}
