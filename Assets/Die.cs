using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public float time = 3;
    private void Update()
    {
        Destroy(gameObject, time);
    }
}
