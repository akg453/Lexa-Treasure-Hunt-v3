using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().enabled = false;
    }

   
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerWalk>()) {
            
            Debug.Log("works");
            collision.gameObject.GetComponent<PlayerWalk>().drawings++;
            GetComponent<AudioSource>().enabled = true;
            Destroy(gameObject);
            

        }
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
