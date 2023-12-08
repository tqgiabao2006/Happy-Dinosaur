using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    public float life = 1;
    // Start is called before the first frame update
    private void Awake()
    {
         Destroy(gameObject, life); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject); 
    }
}
