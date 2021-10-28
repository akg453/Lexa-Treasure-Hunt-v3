using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour
{

    float playerWalk = 0;
    public PlayerWalk pWalk;

    // Start is called before the first frame update
    public void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            //pWalk.speed = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
