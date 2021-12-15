using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Selector : MonoBehaviour
{
    RaycastHit hit;

    int int_Owned_Hex = 0;

    // Update is called once per frame
    void Update()
    {

        //Sends out a ray from the mouse to return the object it hits
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            
            //Create a game object based on the collision of the ray
            GameObject go_Hit_Object = hit.collider.transform.gameObject;

            if (Input.GetMouseButtonDown(0)) {

                //If the left mouse button is pressed, find the mesh renderer thats hit
                MeshRenderer hitRenderer = go_Hit_Object.GetComponentInChildren<MeshRenderer>();
                hitRenderer.material.color = Color.red;

            }

            if (Input.GetMouseButtonUp(0)) {

                MeshRenderer releaseRenderer = go_Hit_Object.GetComponentInChildren<MeshRenderer>();
                releaseRenderer.material.color = Color.white;
                int_Owned_Hex++;

                //Check if tile is owned - if yes dont move - else move
                //If yes check player stats against tile stats - if player_stats > tile_stats move else dont move

            }

        }
    }
}
