using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item Data")]
public class ItemManager : ScriptableObject
{
    public string id;
    public Sprite icon;
    public GameObject prefab;
    public float price;
}
