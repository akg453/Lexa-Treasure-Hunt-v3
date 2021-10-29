using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TalkToPlayer : MonoBehaviour
{

    public TMP_Text talk;

    Animator myAnimator;



    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.enabled = false;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerWalk>())
        {
            Debug.Log("work");
            collision.gameObject.GetComponent<PlayerWalk>();
            talk.text = "Hey! I saw some of your drawings around the halls. You should go and find them.";
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
