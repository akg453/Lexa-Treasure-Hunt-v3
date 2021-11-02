using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerWalk : MonoBehaviour
{

    public float speed = 3.0f;
    Animator myAnimator;

    public int drawings;

    public TMP_Text talking;

    public SpriteRenderer spriteRenderer;


    

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent takes a lot of processing time - assign function to call
        myAnimator = GetComponent<Animator>();
        myAnimator.enabled = false;
        
    }

    void MoveObject() {
        if (Input.GetKey(KeyCode.A)) {
            
            //animation start
            myAnimator.enabled = true;
            //movement
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
            //changed x and y values to match conditions needed for animator
            myAnimator.SetInteger("x", -1);
            myAnimator.SetInteger("y", 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            myAnimator.enabled = true;
            transform.Translate((Vector2.down * Time.deltaTime) * speed);
            myAnimator.SetInteger("x", 0);
            myAnimator.SetInteger("y", -1);
            
        }
        else if (Input.GetKey(KeyCode.W))
        {
            myAnimator.enabled = true;
            transform.Translate((Vector2.up * Time.deltaTime) * speed);
            myAnimator.SetInteger("x", 0);
            myAnimator.SetInteger("y", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myAnimator.enabled = true;
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
            myAnimator.SetInteger("x", 1);
            myAnimator.SetInteger("y", 0);
            spriteRenderer.flipX = false;
        }
        else 
        {
            myAnimator.SetInteger("x", 0);
            myAnimator.SetInteger("y", 0);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        //call
        MoveObject();

        
    }
}
