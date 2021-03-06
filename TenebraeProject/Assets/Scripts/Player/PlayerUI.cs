﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Player;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Texture2D basicCursor;
    [SerializeField] Texture2D combatCursor;
    [SerializeField] Texture2D interactionCursor;
    public Vector2 hotSpot = Vector2.zero;
    public CursorMode cursorMode = CursorMode.Auto;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Player.PlayerVariables.PlayerGameObject.transform.position;

        RaycastHit hit;

        //Changing the Cursor depending on what the user is hovering
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out hit, Mathf.Infinity))
        {
            //TODO uncomment out later --> weird on windows
            //Interactable Hover
            //if (hit.collider.tag == "Loot" || hit.collider.tag == "NPC")
            //{
            //    Cursor.SetCursor(interactionCursor, hotSpot, cursorMode);
            //    //Interactable click
            //}
            ////Enemy Hover
            //else if (hit.collider.tag == "Enemy")
            //{
            //    Cursor.SetCursor(combatCursor, hotSpot, cursorMode);
            //}
            //Default
            //else { Cursor.SetCursor(basicCursor, hotSpot, cursorMode); }
        }
    }
}

