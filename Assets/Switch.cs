using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
   public GameObject slot1;
    public GameObject slot2;
 
   
    private void Update()
    {
        if (Input.GetKey("1"))
        {
            slot1.SetActive(true);
            slot2.SetActive(false);
          
            
        }
        if (Input.GetKey("2"))
        {
            slot1.SetActive(false);
            slot2.SetActive(true);
            
            
            
        }
       
    }
}
