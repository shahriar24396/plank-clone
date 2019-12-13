using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    float step = speed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        //}
        spawnPlatform();
    }

    public void spawnPlatform()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
