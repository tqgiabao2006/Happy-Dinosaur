using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController character;
    private Vector3 direction;
    public float gravity = 9.81f * 3f;
    public float jumpforce = 7f;

    public AudioSource jump;
    private void Awake()
    {
          character = GetComponent<CharacterController>();
    }
    private void OnEnable()
    {

        direction = Vector3.zero;
    }
  
    // Update is called once per frame
    private void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;   
        if (character.isGrounded)
        {
            direction = Vector3.down;
            if (Input.GetButton("Jump"))
            {
                jump.Play();
                direction = Vector3.up * jumpforce;
            }
        }
        character.Move(direction * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GameManager.instance.GameOver();  
        }
    }
  
}
