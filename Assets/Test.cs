using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject basketballPrefab;
    public int minBasketballs = 1;
    public int maxBasketballs = 100;
    public NumValidate numValidate;

   
    public void Spawner()
    {
        int numBasketballs = numValidate.numVal;
        float radius = CalculateRadius(numBasketballs);
        CreateCircularPattern(numBasketballs, radius);
    }
    private float CalculateRadius(int numBasketballs)
    {
        float minRadius = 2f; // Minimum radius for one basketball
        float radiusIncrement = 1f; // Radius increment per additional basketball

        float radius = minRadius + radiusIncrement * (numBasketballs - 1);
        return radius;
    }

    private void CreateCircularPattern(int numBasketballs, float radius)
    {
        float angleIncrement = 360f / numBasketballs;

        for (int i = 0; i < numBasketballs; i++)
        {
            float angle = i * angleIncrement;
            float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            float y = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

            Vector3 position = new Vector3(x, 0f, y);
            Instantiate(basketballPrefab, position, Quaternion.identity);
        }
    }
}


