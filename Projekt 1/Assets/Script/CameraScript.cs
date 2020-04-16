using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    public GameObject player;
    public Vector3 offset;


    void Start()
    {
        
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
