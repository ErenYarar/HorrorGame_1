using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class NoteScript : MonoBehaviour
{
    public GameObject playerObject;
    public Image noteImage;
    public Image blood;
    public GameObject TextNote;

    public AudioClip pickupSound;
    public AudioClip putAwaySound;

    ////
    public float TheDistance;
    public GameObject ActionNoteDisplay;
    //public GameObject ActionNoteText;
    public GameObject ExtraCross;

    void Start()
    {
        noteImage.enabled = false;  
        blood.enabled = false; 
        TextNote.SetActive(false);  
    }

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    private void OnMouseOver() 
    {
        if(TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionNoteDisplay.SetActive(true);
            //ActionNoteText.SetActive(true);
        }
        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 2){
                //ExtraCross.SetActive(false);
                ActionNoteDisplay.SetActive(false);
                //ActionNoteText.SetActive(false);
                ShowNoteImage();
            }
        } 
        else if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            HideNoteImage();
        }      
    }

    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        blood.enabled = true;
        TextNote.SetActive(true);
        ExtraCross.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        playerObject.GetComponent<FirstPersonController>().enabled = false;
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        blood.enabled = false;
        TextNote.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);
        playerObject.GetComponent<FirstPersonController>().enabled = true;
    }

    private void OnMouseExit() {
        ExtraCross.SetActive(false);
        ActionNoteDisplay.SetActive(false);
        //ActionNoteText.SetActive(false);
    }
 
}