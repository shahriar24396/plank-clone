using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankScale : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    private int touchCount;
    public GameObject player;
    public GameObject safeRegion;

    void Update()
    {
        if ((Input.touchCount > 0) || (Input.GetKey(KeyCode.UpArrow)) && safeRegion.GetComponent<CheckPlayer>().isTriggered)
        {
            touchCount++;
            //ScoreText.scoreValue = touchCount;
            //Debug.Log(touchCount);
            scalePlank();
        }

        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            StartCoroutine(Rotate(Vector3.right, 90, 1.0f));
        }        
    }

    public void scalePlank()
    {
        transform.localScale = transform.localScale + new Vector3(0, speed * Time.deltaTime, 0);
    }

    IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = transform.rotation;
        Quaternion to = transform.rotation;
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.rotation = to;

        gameObject.GetComponent<PlankScale>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = true;
        Rigidbody gameObjectRigidbody = gameObject.AddComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        //spawnPlatform
    }
}
