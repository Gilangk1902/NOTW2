using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHitable
{
    public void ModifiyHealth(int value);
    public void CriticalCondition();
    public void Die();
}
