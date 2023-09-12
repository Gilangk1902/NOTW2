using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewObjectData", menuName = "Game Data/Object Data")]
public class ObjectData : ScriptableObject
{
    public string object_name;
    public int health;
}
