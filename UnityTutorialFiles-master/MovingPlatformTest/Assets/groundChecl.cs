using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundChecl : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground") {
            Player.GetComponent<movement2d>().grounded = true;
        }
        if (collision.collider.tag == "Platform")
        {
            Player.GetComponent<movement2d>().grounded = true;
            Player.transform.parent = collision.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<movement2d>().grounded = false;
        }
        if (collision.collider.tag == "Platform")
        {
            Player.transform.parent = null;
            Player.GetComponent<movement2d>().grounded = false;
        }

    }
}
