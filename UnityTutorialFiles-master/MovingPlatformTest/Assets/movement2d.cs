using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2d : MonoBehaviour
{
    public float movementSpeed = 2f;
    public float height = 1f;
    public bool grounded = false;
    public Transform player;
    
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * movementSpeed;
        if (player.position.y < -4f) 
        {
            FindObjectOfType<gameManager>().Restart();
        }
         
    }
    void Jump() {
        if (Input.GetButtonDown("Jump") && grounded==true) { 
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, height),ForceMode2D.Impulse);
        }
    }
   
}
