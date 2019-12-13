using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTriggered;
    public GameObject plankObject;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isTriggered = true;
            ScoreText.scoreValue += 1;
            plankObject.GetComponent<PlankScale>().enabled = true;
            player.GetComponent<Rigidbody>().useGravity = false;
        }            
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            isTriggered = false;
    }
}
