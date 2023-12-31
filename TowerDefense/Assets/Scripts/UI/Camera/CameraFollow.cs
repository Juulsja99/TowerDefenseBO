using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public int boundary;
    public int moveSpeed;
    public float leftLimit;
    public float rightLimit;
  

    private void Update()
    {

        // move right
        if (transform.position.x < rightLimit && Input.mousePosition.x > Screen.width - boundary)
        {
            transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        // move left
        if (transform.position.x > leftLimit && Input.mousePosition.x < boundary)
        {
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }

    }
}
