using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimationHandler : WeaponBehaviour
{
    [HideInInspector] public Animator anim;
    [SerializeField] private Animator  AR;
    private bool oneTimeReload = false, oneTimeSwitch = false;
    private void Start()
    {
        anim = AR;
    }
    void Update()
    {
        if (weapon.getWeaponState().getCurrentState() == WeaponStateEnum.Shoot)
        {
            anim.Play("Shoot");
        }
        else if (weapon.getWeaponState().getCurrentState() == WeaponStateEnum.Idle && weapon.getWeaponState().getCurrentState() != WeaponStateEnum.Shoot)
        {
            anim.Play("Idle");
        }
    }
}
