﻿using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newPos;
        }
    }

   
}
