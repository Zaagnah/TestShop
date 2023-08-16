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
    public GameObject player;

    [SerializeField]
    public float goldAmount = 50f;
    ItemManager itemManager;

    


    void Start()
    {
        itemManager = new ItemManager();
    }

    


}
