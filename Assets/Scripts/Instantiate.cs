using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    public NumValidate numValidate;
    public CircleValidation circleValidation;
    public GameObject basketBall;
    public int scoreMultiplier=100;
    public void BallSpawner()
    {
        float minRadius = 1f; 
        float radiusIncrement = 2.5f; 
        float radius = minRadius + radiusIncrement * (numValidate.numVal - 1);
        float radiusForCircle = minRadius + 1 * (numValidate.numVal - 1);
        float angleIncrement = 360f / numValidate.numVal;
        for (int i = 0; i < numValidate.numVal; i++)
        {
            float angle = i * angleIncrement;
            float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            float y = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
            // Debug.Log(angle + "Angle");
            Vector3 position = new Vector3(x, 0f, y);
            Instantiate(basketBall, position, Quaternion.identity);
        }
        //Debug.Log(numValidate.numVal + "noOf "+radiusForCircle 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}