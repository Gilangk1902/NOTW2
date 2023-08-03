using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : WeaponBehaviour
{
    private float timeSinceLastShot = 0f;
    [SerializeField] private Transform muzzle;
    private void Update() {
        timeSinceLastShot+=Time.deltaTime;
    }

    public void _Shoot(ShootTypeEnum type){
        if(type == ShootTypeEnum.HitScan){
            Shoot_Hitscan();
        }
    }

    public void Shoot_Hitscan(){
        if(Physics.Raycast(muzzle.position, muzzle.forward, out RaycastHit hit_info, Mathf.Infinity)){
            Debug.Log(hit_info.collider.gameObject.name);
        }
    }
}

public enum ShootTypeEnum{
    HitScan,
    Projectiles
}
