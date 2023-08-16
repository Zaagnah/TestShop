using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadShop : MonoBehaviour
{
    public List<ItemManager> items = new List<ItemManager>();

	PlayerManager playerManager;
	ItemManager itemManager;

	//public float itemPrice = 30f;
		

	void Start()
    {
		playerManager = new PlayerManager();
		itemManager = new ItemManager();
		
	}

	public void Remove(ItemManager item)
	{
		if (playerManager.goldAmount > item.price)
		{
			playerManager.goldAmount = playerManager.goldAmount - item.price;
			Debug.Log(" You bought " + " " + item.id );
			items.Remove(item);
			
		}
		else
			Debug.Log(" Not enough gold");
		
	}
	
		

}
