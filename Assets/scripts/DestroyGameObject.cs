using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour{


    public Collider2D player;
    public Collider2D umbrella;
    // Start is called before the first frame update
    void Start()
    {
        

    }
   

    // Update is called once per frame
    void Update()
    {
        if (player.IsTouching(umbrella))
        {
            Debug.Log("works");
            Destroy(gameObject);
        }
    }
}
