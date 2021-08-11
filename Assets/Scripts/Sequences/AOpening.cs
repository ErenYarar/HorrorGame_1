using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class AOpening : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;
    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine (ScenePlayer());
    }
    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "Ahh .. My head is cracking";
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "What was that.. Did I dream.. But it was very realistic..";
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "I'd better drink water";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
    }
}
