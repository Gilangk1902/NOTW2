using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private PlayerStatusHUD player_status_HUD;
    private void Awake()
    {
        player_status_HUD.hud = this;
    }
}
