using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemEffect : ScriptableObject
{
    public int StorePrice; // ������ ����

    public abstract bool ExecuteRole(PlayerStats playerStats);
}