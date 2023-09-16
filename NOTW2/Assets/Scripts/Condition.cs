using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private List<Debuff_Enum> debuffs;
    [SerializeField] private BasicStats stat;

    private bool slowed;
    private float slowed_time;

    private void Start()
    {
        slowed = false;
        slowed_time = 3f;
    }

    private void Update()
    {
        ConditionHandling();
    }


    private void ConditionHandling()
    {
        if(debuffs.Contains(Debuff_Enum.Slow) && !slowed)
        {
            Debuff.Slow(stat, 4);
            slowed = true;
        }
        else if(!debuffs.Contains(Debuff_Enum.Slow) && slowed)
        {
            slowed = false;
        }
    }

    public IEnumerator RemoveCondition(float time, Debuff_Enum debuff)
    {
        yield return new WaitForSeconds(time);
        RemoveDebuff(debuff);
    }

    public void AddDebuff(Debuff_Enum newDebuff)
    {
        if (!debuffs.Contains(newDebuff))
        {
            debuffs.Add(newDebuff);
        }
    }

    public void RemoveDebuff(Debuff_Enum debuff)
    {
        if (debuffs.Contains(debuff))
        {
            debuffs.Remove(debuff);
            stat.Refresh();
        }
    }

    public List<Debuff_Enum> getDebuffs() 
    {
        return debuffs;
    }


}
