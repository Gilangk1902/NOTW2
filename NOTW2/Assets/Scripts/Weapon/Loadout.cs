using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadout : WeaponBehaviour
{
    [SerializeField] private WeaponData primary, secondary;

    public WeaponData getPrimary(){
        return primary;
    }
    
    public WeaponData getSecondary(){
        return secondary;
    }
}
