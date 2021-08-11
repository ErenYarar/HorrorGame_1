using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTriggerFirst : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashImg;

    private void OnTriggerEnter() 
    {
        GetComponent<BoxCollider>().enabled = false;
        Scream.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        FlashImg.SetActive(true);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(2.0f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        FlashImg.SetActive(false);
    }
}