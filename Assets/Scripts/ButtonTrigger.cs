using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject buttonForFire;
    [SerializeField]
    GameObject candles;
    bool buttonActive = false;
    bool candlesActive = false;
    InteractionButton interactionButton;

    void Start()
    {
        buttonActive = false;
        candlesActive = false;
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.gameObject.tag == "Player" )
        {
            if (candlesActive == false)
            {
                buttonForFire.SetActive(true);
                buttonActive = true;
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        buttonForFire.SetActive(false);
        buttonActive = false;
    }

    void Update() 
    {
        if (buttonActive && Input.GetKey("e"))
        {
            candles.SetActive(true);
            candlesActive = true;
            buttonForFire.SetActive(false);
        }
    }
}
