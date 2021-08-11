using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewSceneTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene ("MainScene02");
        }
    }
}
