using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpTriggerScript : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheZombie;
    public GameObject TheDoor;
    public GameObject demonTrigger;
    public GameObject TheWall;

    void OnTriggerEnter(Collider other) 
    {
        GetComponent<BoxCollider>().enabled = false;       
        DoorBang.Play();
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnim");
        TheZombie.SetActive(true);
        demonTrigger.GetComponent<Animation>().Play("mixamo.com");
        StartCoroutine(PlayJumpMusic());
        StartCoroutine(WallComing());     
    }
    IEnumerator WallComing()
    {
        yield return new WaitForSeconds(1f);
        TheWall.SetActive(true);
        TheWall.GetComponent<Animation>().Play("WallAnim");
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();
    }
}