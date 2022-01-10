using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// <para>TileSelector - Nathaniel Ford</para>
/// The TileSelector is used to determine what tile the mouse is currently hovered over.
/// It uses a single quad for raycasts, and then calculates the tile position from the collision position.
/// </summary>
public class TileSelector : MonoBehaviour
{

    [Header("Unity Refs")]
    public GameObject mapCollider;
    public GameObject selectorObject;
    public Camera mainCamera;

    private DK2Map activeMap;
    private Vector2 previousMousePos;

    public void setActiveMap(DK2Map map)
    {
        activeMap = map;
        resizeMapCollider();
    }

    private void resizeMapCollider()
    {
        mapCollider.transform.localScale = new Vector3(activeMap.terrain.GetLength(0), 1, activeMap.terrain.GetLength(1));
    }

    private void Update()
    {
        //If mouse hasn't moved, do nothing.
        if (Input.mousePosition.x == previousMousePos.x && Input.mousePosition.y == previousMousePos.y) return;

        //If mouse has moved, then check for collision.
        previousMousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Ray r = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit h;

        //Test for mouse collision using a raycast.
        if (Physics.Raycast(r, out h))
        {
            //We found something...
            //Map starts at -0.5, -0.5
            Vector3 local = h.point + h.collider.transform.localPosition;
            Vector2Int tile = new Vector2Int((int)local.x, (int)local.z);
            selectorObject.transform.localPosition = new Vector3(tile.x, 0, tile.y);
        }

    }


}
