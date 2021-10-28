using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour
{

    float playerWalk = 0;

    public class PlayerWalk : MonoBehaviour
    {
        public float speed = 3.0f;
    }

    // Start is called before the first frame update
    public void Start()
    {
        GameObject player = GameObject.Find("player");
        PlayerWalk playerWalk = player.GetComponent<PlayerWalk>();
        playerWalk.speed = 3.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            playerWalk.speed = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
