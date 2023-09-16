using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeTrap : Traps
{
    private bool activated;

    private void Awake()
    {
        activated = true;
    }

    public override void Activate_Deactivate()
    {
        if(activated)
        {
            activated=false;
        }
        else
        {
            activated = true;
        }
    }

    public override void GiveEffects(Condition condition)
    {
        condition.AddDebuff(Debuff_Enum.Slow);
    }

    public override void RemoveEffects(Condition condition)
    {
        StartCoroutine(condition.RemoveCondition(3, Debuff_Enum.Slow));
    }
}
