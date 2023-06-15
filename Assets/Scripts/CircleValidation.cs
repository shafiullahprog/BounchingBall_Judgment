using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleValidation : MonoBehaviour
{
    public GameObject dashedCirclePrefab;
    public Transform dashedCircleParent;

    public GameObject dashedCircle;

    private float minCircleRadius = 2f;
    private float maxCircleRadius = 50f;

    public float currentCircleRadius;
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
}
