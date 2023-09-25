using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponState : MonoBehaviour
{
    private WeaponStateEnum current_state;

    private void Update()
    {
        test();
    }

    public void setState(WeaponStateEnum new_state){
        current_state = new_state;
    }

    public WeaponStateEnum getCurrentState(){
        return current_state;
    }

    public void test()
    {
        Debug.Log(current_state.ToString());
    }
}

public enum WeaponStateEnum{
    Idle,
    Shoot,
    Switch,
    Reload
}
