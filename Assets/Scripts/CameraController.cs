using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float speed = 25;
    void Update()
    {
        MoveCamera();
    }
    void MoveCamera()
    {
        Vector3 movementAmount = new Vector3(0, 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        transform.Translate(movementAmount);
    }
}
