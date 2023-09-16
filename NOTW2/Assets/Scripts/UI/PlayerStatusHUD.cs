using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatusHUD : HUDBehaviour
{
    [SerializeField] private BasicStats player_status;
    [SerializeField] private Condition player_conditions;

    [SerializeField] private TextMeshProUGUI health_text, debuffs_text;

    private void Update()
    {
        setHealthText();    
        setDebuffText();
    }

    private void setHealthText()
    {
        health_text.SetText(player_status.getHealth().ToString());
    }

    private void setDebuffText()
    {
        string text = "";
        
        for(int i = 0; i < player_conditions.getDebuffs().Count; i++)
        {
            text += player_conditions.getDebuffs()[i].ToString().ToUpper();
        }

        debuffs_text.SetText(text);
    }
}
