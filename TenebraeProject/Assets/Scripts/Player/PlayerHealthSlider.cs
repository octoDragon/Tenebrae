﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class PlayerHealthSlider : MonoBehaviour
{
    float RotateValuez = 0f; //small adjustment removing slight slant
    GameObject player;

    private void Start()
    {
        player = Player.PlayerVariables.PlayerGameObject;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerPosition = player.transform.position;
        playerPosition.y = 6.52f;
        transform.position = playerPosition;
        transform.LookAt(Camera.main.transform);
        //transform.rotation = fixedRotation;
        transform.Rotate(0f, 180f, RotateValuez);
        //change the y position
    }
}
