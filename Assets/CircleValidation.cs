using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleValidation : MonoBehaviour
{
    public GameObject dashedCirclePrefab; // Prefab for the dashed circle UI
    public Transform dashedCircleParent; // Parent transform for the dashed circle UI

    private GameObject dashedCircle;

    private float minCircleRadius = 2f;
    private float maxCircleRadius = 50f;

    private float currentCircleRadius;
    private int currentScore = 0;

    private void Start()
    {
        StartNewLevel();
    }

    private void StartNewLevel()
    {
        currentCircleRadius = Random.Range(minCircleRadius, maxCircleRadius);

        dashedCircle = Instantiate(dashedCirclePrefab, dashedCircleParent);
        dashedCircle.transform.localScale = Vector3.one * currentCircleRadius;
        Debug.Log("Size: "+ currentCircleRadius);
    }
    public void SpawnBasketball(GameObject basketball)
    {
        // Check if the spawned basketball falls within the dashed circle
        float basketballRadius = basketball.GetComponent<Renderer>().bounds.extents.magnitude;
        float distance = Vector3.Distance(basketball.transform.position, dashedCircle.transform.position);
        if (distance <= currentCircleRadius - basketballRadius)
        {
            // Calculate the score based on how accurately the basketball lines up with the dashed circle
            float accuracy = 1f - (distance / (currentCircleRadius - basketballRadius));
            int score = Mathf.RoundToInt(accuracy * 100);

            currentScore += score;
            Debug.Log("Score: " + score);

            // Continue to the next level
            //StartNewLevel();
        }
        else
        {
            // Player fails the level
            Debug.Log("Level failed");

            // Reset the score
            currentScore = 0;
        }
    }
}
