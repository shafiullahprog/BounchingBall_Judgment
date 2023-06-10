using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleValidation : MonoBehaviour
{
    public GameObject dashedCirclePrefab; // Prefab for the dashed circle UI
    public Transform dashedCircleParent; // Parent transform for the dashed circle UI

    public GameObject dashedCircle;

    private float minCircleRadius = 2f;
    private float maxCircleRadius = 50f;

    public float currentCircleRadius;
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
        Debug.Log("Size: "+ currentCircleRadius *2);
    }
}
