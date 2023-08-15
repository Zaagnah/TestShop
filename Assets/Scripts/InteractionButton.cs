using System.Collections;
using UnityEngine;

public class InteractionButton : MonoBehaviour
{
    [SerializeField]
    GameObject gameobject;
    
    void Update()
       {
           if(Input.GetKey("e")) 
           gameobject.SetActive(true); 
       }
}
