using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotationTowardsObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Create a ray from the mouse cursor position 
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Check if the ray intersects with any collider 
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                Vector3 targetPosition = hit.point;
                targetPosition.y = transform.position.y;
                transform.LookAt(targetPosition);
            }
        }
    }
}