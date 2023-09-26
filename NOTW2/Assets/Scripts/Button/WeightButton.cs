using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightButton : Button
{
    [SerializeField] private InteractableObject interactableObject;

    public override void Activate()
    {
        interactableObject.Activate();
    }

    public override void Deactivate()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.OBJECT))
        {
            Activate();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.OBJECT))
        {
            Deactivate();
        }
    }

    void test()
    {
        Debug.Log("Activate");
    }
}
