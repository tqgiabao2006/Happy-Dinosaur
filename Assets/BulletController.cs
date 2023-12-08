using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float lifeTime = 3;

    private void Start()
    {
        
    }
    private void Update()
    {
        Destroy(gameObject,lifeTime);
    }
    private void OnTriggerEnter(Collider other)
    {

       
        other.gameObject.SetActive(false);
            Destroy(gameObject);    
              
        
    }
}
