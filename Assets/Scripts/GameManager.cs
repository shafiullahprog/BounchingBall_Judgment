using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float ActualSizeOfCirlce;
    public float ActualSizeOfBasketBalls;
    public float minWinningScore, maxWinningScore;
    public float TotalScore;
    private void Start()
    {
        if (PlayerPrefs.HasKey("totalscore"))
        {
            TotalScore = PlayerPrefs.GetFloat("totalscore");
        }
    }

    [ContextMenu("Get Score")]
    public void GetScore()
    {
        float score = (ActualSizeOfBasketBalls / ActualSizeOfCirlce) * 100;
        if(score >= minWinningScore && score <= maxWinningScore)
        {
            Debug.Log("Won");
            TotalScore += score;
            PlayerPrefs.SetFloat("totalscore", TotalScore);
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("Lose");
            TotalScore = 0;
            PlayerPrefs.SetFloat("totalscore", TotalScore);
            SceneManager.LoadScene(0);
        }
    }
}
