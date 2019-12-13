using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTarget.transform.position.x, transform.position.y, playerTarget.transform.position.z);
    }
}
