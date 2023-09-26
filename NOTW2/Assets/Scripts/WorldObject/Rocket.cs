using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : InteractableObject
{
    public override void Activate()
    {
        GetComponent<Rigidbody>().AddForce(20f*Vector3.up*Time.deltaTime, ForceMode.Impulse);
    }
}
