using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerData player_data;
    [SerializeField] private BasicStats stats;

    [SerializeField] private CameraLook camera_look;
    [SerializeField] private Movement movement;
    [SerializeField] private GameObject feet;
    [SerializeField] private PlayerController player_controller;
    [SerializeField] private PlayerInteraction player_interaction;

    public bool isGrounded;
    [SerializeField] private PlayerState player_state;

    private void Start()
    {
        
    }

    void Awake()
    {
        camera_look.player = this;
        movement.player = this;
        player_controller.player = this;
        player_interaction.player = this;
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

    public BasicStats getPlayerStat() { return stats; }

    public PlayerState getPlayerState() { return player_state; }
    public CameraLook getCameraLook() { return camera_look; }

    public PlayerInteraction getPlayerInteraction(){return player_interaction;}

    public void Die(){
        camera_look.Die();
    }
}
