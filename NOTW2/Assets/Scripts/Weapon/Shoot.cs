using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : WeaponBehaviour
{
    private float timeSinceLastShot = 0f;
    [SerializeField] private Transform muzzle;
    private float time_interval;

    private void Update() {
        timeSinceLastShot+=Time.deltaTime;
        time_interval = 1.0f / (weapon.getCurrentWeapon().fire_rate/60f);
    }

    public void _Shoot(ShootTypeEnum type){
        if(type == ShootTypeEnum.HitScan && timeSinceLastShot > time_interval){
            Shoot_Hitscan();
            weapon.getWeaponState().setState(WeaponStateEnum.Shoot);
            timeSinceLastShot = 0f;
            StartCoroutine(ResetStateAfterShooting());
        }
    }

    public void Shoot_Hitscan(){
        if(Physics.Raycast(muzzle.position, muzzle.forward, out RaycastHit hit_info, Mathf.Infinity)){
            GameObject object_hit = hit_info.collider.gameObject;
            if (object_hit.GetComponent<IHitable>() != null)
            {
                object_hit.GetComponent<IHitable>()
                          .ModifiyHealth((int)weapon.getCurrentWeapon().damage);
            }
        }
    }

    private IEnumerator ResetStateAfterShooting()
    {
        yield return new WaitForSeconds(time_interval);

        weapon.getWeaponState()
              .setState(WeaponStateEnum.Idle);
    }
}

public enum ShootTypeEnum{
    HitScan,
    Projectiles
}
