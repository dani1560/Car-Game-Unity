using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offsetObj;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offsetObj;
    }
}
