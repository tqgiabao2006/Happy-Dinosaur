    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] public GameObject bulletPrefabs;
    public float bSpeed = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var bullet = Instantiate(bulletPrefabs, point.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = point.right * bSpeed;
        }
    }
}
