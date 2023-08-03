using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : WeaponBehaviour
{
    void Update()
    {
        WeaponSwitching();
        if(weapon.getWeaponState().getCurrentState() != WeaponStateEnum.Switch){
            Shooting();
        }
    }

    private void Shooting(){
        if(Input.GetKey(KeyCode.Mouse0)){
            weapon.getShoot()._Shoot(ShootTypeEnum.HitScan);
        }
    }

    private void WeaponSwitching(){
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            weapon.getWeaponSwitch()
                  .Switch(weapon.getLoadout().getPrimary());
            weapon.getWeaponState()
              .setState(WeaponStateEnum.Switch);
            
            StartCoroutine(ResetStateAfterSwitching());
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            weapon.getWeaponSwitch()
                  .Switch(weapon.getLoadout().getSecondary());

            weapon.getWeaponState()
              .setState(WeaponStateEnum.Switch);
            
            StartCoroutine(ResetStateAfterSwitching());
        }
    }

    private IEnumerator ResetStateAfterSwitching(){
        yield return new WaitForSeconds(1f);
        
        weapon.getWeaponState()
              .setState(WeaponStateEnum.Idle);
    }
}
