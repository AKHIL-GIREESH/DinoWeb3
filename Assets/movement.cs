using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   Rigidbody2D rb;
   public bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
       
       rb = GetComponent<Rigidbody2D>();
  
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("Collided");
            isJumping = false;
        }
        else
        {
            isJumping = true;
        }

    }

    
    // Update is called once per frame
    void Update()
    {
        if (isJumping==false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x,15f);
                isJumping=true;
            }    
        }
        
    }




}