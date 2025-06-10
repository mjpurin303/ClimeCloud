using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = player.position.y;
        transform.position = pos;

        /*
        transform.position = new Vector3(
            transform.position.x,
            player.position.y,
            transform.position.z
        );
        */
    }
}
