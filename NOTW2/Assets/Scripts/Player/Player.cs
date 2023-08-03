using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerData player_data;
    [SerializeField] private PlayerStat player_stat;

    [SerializeField] private CameraLook camera_look;
    [SerializeField] private Movement movement;
    [SerializeField] private GameObject feet;
    [SerializeField] private PlayerController player_controller;

    public bool isGrounded;
    [SerializeField] private PlayerState player_state;
    void Awake()
    {
        camera_look.player = this;
        movement.player = this;
        player_controller.player = this;
    }

    void Update()
    {
        isGrounded = Physics.Raycast(feet.transform.position, Vector3.down, .1f);
    }

    public Movement getMovement(){
        return movement;
    }

    public PlayerData getPlayerData(){
        return player_data;
    }

    public PlayerStat getPlayerStat(){
        return player_stat;
    }

    public PlayerState getPlayerState(){
        return player_state;
    }
    public void Die(){
        camera_look.Die();
    }
}
