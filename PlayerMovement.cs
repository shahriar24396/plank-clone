using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Transform playerTarget;
    public float speed = 2f;
    public GameManager gameManager;
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    float step = speed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //}
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerTarget.position, step);
        gameObject.GetComponent<Rigidbody>().useGravity = true;

        if(gameObject.transform.position.y < -1)
        {
            gameManager.GetComponent<GameManager>().EndGame();
        }
    }    

    public void movementStatus()
    {
        Debug.Log("Movement complete");
    }
}
