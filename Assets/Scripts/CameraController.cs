









































using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float speed = 25;

    public Vector3 initialPos;
    float camY = 270f, camZ = 2.5f;
    private void Start()
    {
        initialPos = new Vector3(0, camY,camZ);
        transform.position = initialPos;
    }
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
