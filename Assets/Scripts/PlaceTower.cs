using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameObject currentPlaceBuffer;
    private Camera cam;
    private bool isPlacing;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void placeFrog(Vector3 pos)
    {
        pos.z = -5;
        Instantiate(currentPlaceBuffer.gameObject, pos, Quaternion.identity);
    }
    public void StartPlace(GameObject f)
    {
        currentPlaceBuffer = f;
        isPlacing = true;
        StartCoroutine(place());
    }

    IEnumerator place()
    {
        //GameObject ghost = Instantiate(currentPlaceBuffer.mesh, Vector3.zero, Quaternion.identity);
        //GameObject radius = Instantiate(currentPlaceBuffer.radiusDisplay, Vector3.zero, Quaternion.identity);
        //radius.transform.localScale = new Vector2(currentPlaceBuffer.radius * 2, currentPlaceBuffer.radius * 2);
        while (isPlacing)
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            //ghost.transform.position = mousePos;
            //radius.transform.position = mousePos;

            if (Input.GetMouseButtonDown(0))
            {
                placeFrog(mousePos);
                
                currentPlaceBuffer = null;
                isPlacing = false;

                //Destroy(ghost);
                //Destroy(radius);
            }

            yield return null;
        }
    }
}
