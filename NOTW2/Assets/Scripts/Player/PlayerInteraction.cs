using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerInteraction : PlayerBehaviour
{
    [SerializeField] private Transform hand;
    private GameObject object_grab;
    [SerializeField] private WeaponState weapon_state;
    private void Awake()
    {
        object_grab = null;
    }

    private void Update()
    {
        if(weapon_state.getCurrentState()==WeaponStateEnum.Grab)
        {
            FollowTargetWitouthRotation();
        }
    }

    public void ResetGrab()
    {
        weapon_state.setState(WeaponStateEnum.Idle);
        object_grab.GetComponent<Rigidbody>().useGravity = true;
        object_grab = null;
    }

    public void Interact(RaycastHit hit_info)
    {
        GameObject game_object = CheckCollider(hit_info);
        if (game_object != null)
        {
            CheckObject(hit_info);
        }
    }

    public void Grab(RaycastHit hit_info)
    {
        if(weapon_state.getCurrentState() != WeaponStateEnum.Grab)
        {
            object_grab = hit_info.collider.gameObject;
            object_grab.GetComponent<Rigidbody>().useGravity= false;
            weapon_state.setState(WeaponStateEnum.Grab);
        }
    }

    void FollowTargetWitouthRotation()
    {
        object_grab.GetComponent<Rigidbody>().position = hand.position;
    }

    public GameObject CheckCollider(RaycastHit hit_info)
    {
        if (hit_info.collider.gameObject.CompareTag("Object"))
        {
            return hit_info.collider.gameObject;
        }
        return null;
    }

    public void CheckObject(RaycastHit hit_info)
    {
        if(hit_info.collider.gameObject.layer == 6 && //6 is Grab_Able
            hit_info.collider.gameObject.GetComponent<Rigidbody>() != null)
        {
            Grab(hit_info);
        }
    }

    public GameObject getObjectGrab()
    {
        return object_grab;
    }

    public override void Die()
    {
        throw new System.NotImplementedException();
    }
}
