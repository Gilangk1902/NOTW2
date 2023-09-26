using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : PlayerBehaviour
{
    [SerializeField] private GameObject player_camera, player_GameObject;
    private bool enable = true;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if(enable){
            HorizontalLook();
            VerticalLook();
        }
    }

    private float rotationY  = 0f;
    private void HorizontalLook(){
        float look_sensitivity = getPlayer().getPlayerData().look_sensitivity;

        rotationY += Input.GetAxis("Mouse X") *  look_sensitivity;

        player_GameObject.transform.localRotation = Quaternion.Euler(0, rotationY, 0);
    }


    private float rotationX = 0f;
    private void VerticalLook(){
        float look_sensitivity = getPlayer().getPlayerData().look_sensitivity * -1;
        float maxRotation = 90f;

        rotationX += Input.GetAxis("Mouse Y") *  look_sensitivity;
        rotationX = Mathf.Clamp(rotationX, -maxRotation, maxRotation);

        player_camera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }

    public GameObject getPlayerCamera()
    {
        return player_camera;
    }

    public override void Die()
    {
        enable = false;
    }
}
