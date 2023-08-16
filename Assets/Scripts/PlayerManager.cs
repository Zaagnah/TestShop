using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public enum GearType
    {
        Helm,
        Armor,
        Legs,
        Weapon,
    }

    [SerializeField]
    public float goldAmount = 50f;
    ItemManager itemManager;

    

    private GameObject equippedHelmet; // Текущий шлем
    private GameObject equippedArmor; // Текущая броня

    void Start()
    {
        itemManager = new ItemManager();
    }

    


}
