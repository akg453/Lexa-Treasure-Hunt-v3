using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class KeyboardKey : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    public KeyCode keyboardButton;

    //drumLoop = null;
        //drum loop is stand in for any audio name

    void PlayKey()
    {
        audioSource.PlayOneShot(audioClip);
    }



    // Update is called once per frame
    void Update()
    {
        audioSource.pitch = Input.GetKey(KeyCode.LeftShift) ? audioSource.pitch = 2.0f : audioSource.pitch = 1.0f;

        //check if leftshift is held down
        //then if key is pressed, left side of colon will be true
        //if key is not pressed, right side of colon will be true

        if (Input.GetKeyDown(keyboardButton))
        {
            PlayKey();
        }

        //DrumInput();

    }
    /*

    void DrumInput()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            drumLoop.Stop();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            drumLoop.Play();
        }

    }
*/
}




