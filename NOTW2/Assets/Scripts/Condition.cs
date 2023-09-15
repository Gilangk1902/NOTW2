using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [SerializeField] private List<Debuff_Enum> debuffs;
    [SerializeField] private BasicStats stat;
    private bool slowed;

    private void Start()
    {
        slowed = false;
    }

    private void Update()
    {
        ConditionHandling();
        test();
    }

    private void test()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            AddDebuff(Debuff_Enum.Poison);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            AddDebuff(Debuff_Enum.Slow);
        }
    }

    private void ConditionHandling()
    {
        if(debuffs.Contains(Debuff_Enum.Slow) && !slowed)
        {
            Slow();
        }
    }

    private void AddDebuff(Debuff_Enum newDebuff)
    {
        if (!debuffs.Contains(newDebuff))
        {
            debuffs.Add(newDebuff);
        }
    }

    private void Slow()
    {
        stat.setMovementSpeed(stat.getMovementSpeed()/2);
    }

}
