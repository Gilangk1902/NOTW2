using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : WeaponBehaviour
{
    [SerializeField] private GameObject weapon_models_holder;
    private void setWeaponModel(string _name){
        for(int i=0;i<weapon_models_holder.transform.childCount;i++){
            if(weapon_models_holder.transform.GetChild(i).name.Equals(_name)){
                weapon_models_holder.transform.GetChild(i).gameObject.SetActive(true);
            }
            else{
                weapon_models_holder.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void Switch(WeaponData weaponData){
        if(weaponData!=weapon.getCurrentWeapon()){
            weapon.setCurrentWeapon(weaponData);
            setWeaponModel(weaponData.weapon_name);
        }
    }
}
