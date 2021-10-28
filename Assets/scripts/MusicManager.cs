using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance = null;

    public float volume = 1.0f;

    private void Awake()
    {

        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this);
        }else if(instance != this)
        {
            Destroy(gameObject);
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
