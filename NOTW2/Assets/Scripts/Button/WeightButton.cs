using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightButton : Button
{
    private bool activated = false;
    private void Update()
    {
        if(activated)
        {
            Activate();
        }
    }

    public override void Activate()
    {
        test();
    }

    public override void Deactivate()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.OBJECT))
        {
            activated= true;
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
