using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSoundController : MonoBehaviour
{
    public AudioClip check;
    public AudioClip leave;
    public AudioClip drag;
    bool alreadyPlayed = false;
    public bool groundCheck;

    AudioSource AudioSource;
    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        Cursor.visible = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objects")
        {
            AudioSource.PlayOneShot(check);

        }
        if (other.gameObject.tag == "Ground")
        {
            AudioSource.PlayOneShot(leave);
            groundCheck = true;
        }
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log(alreadyPlayed);
    //    if (other.gameObject.tag == "Ground" && alreadyPlayed == false)
    //    {
    //        if (Input.GetKey(KeyCode.W))
    //        {
    //            AudioSource.PlayOneShot(drag);
    //            alreadyPlayed = true;
    //        }
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            alreadyPlayed = false;
            groundCheck = false;
        }
    }
}
