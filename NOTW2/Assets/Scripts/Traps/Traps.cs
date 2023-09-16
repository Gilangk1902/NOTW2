using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Traps : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.PLAYER))
        {
            Condition condition = collision.gameObject.GetComponent<Condition>();
            GiveEffects(condition);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag(Tags.PLAYER))
        {
            Condition condition = collision.gameObject.GetComponent<Condition>();
            RemoveEffects(condition);
        }
    }
    public abstract void Activate_Deactivate();
    public abstract void GiveEffects(Condition condition);
    public abstract void RemoveEffects(Condition condition);
}
