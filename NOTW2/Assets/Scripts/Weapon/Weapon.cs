using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Shoot shoot;
    [SerializeField] private Loadout loadout;
    [SerializeField] private WeaponSwitch weapon_switch;
    [SerializeField] private WeaponData current_weapon;
    [SerializeField] private WeaponController weapon_controller;
    [SerializeField] private WeaponState weapon_state;
    [SerializeField] private WeaponAnimationHandler weapon_animation_handler;

    void Awake(){
        current_weapon = loadout.getPrimary();
        shoot.weapon = this;
        loadout.weapon = this;
        weapon_switch.weapon = this;
        weapon_controller.weapon = this;
        weapon_animation_handler.weapon = this;
        weapon_state.setState(WeaponStateEnum.Idle);
    }

    public WeaponSwitch getWeaponSwitch(){
        return weapon_switch;
    }

    public WeaponData getCurrentWeapon(){
        return current_weapon;
    }

    public void setCurrentWeapon(WeaponData weapon){
        this.current_weapon = weapon;
    }

    public Loadout getLoadout(){
        return loadout;
    }

    public WeaponState getWeaponState(){
        return weapon_state;
    }

    public Shoot getShoot(){
        return shoot;
    }
}
