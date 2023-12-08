using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Player player;
    public float boost = 15f;
  
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public void Update()
    { 
       
            player.jumpforce = boost;
        
            
       
       
    }
}
