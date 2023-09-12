using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour, IHitable
{
    [SerializeField] private DestructibleObjectStatus object_status;
    [SerializeField] public ObjectData object_data;

    private void Start()
    {

    }

    private void Update()
    {
        test();
    }

    private void Awake()
    {
        object_status.destructible_object = this;
    }

    public void ModifiyHealth(int value)
    {
        object_status.setHealth(
            object_status.getHealth()-value
        );
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void CriticalCondition()
    {
        //change asset to the critical condition version
    }

    private void test()
    {
        Debug.Log(object_status.getHealth());
    }
}
