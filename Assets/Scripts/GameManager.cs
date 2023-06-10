using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject GameLoss;
    public GameObject GameWon;

    public float ActualSizeOfCircle;
    public float ActualSizeOfBasketBalls;
    public float minWinningScore, maxWinningScore;
    public float TotalScore;
    
    public Text score;
    
    public CircleValidation validation;
    public Instantiate instantiateBall;
    private void Start()
    {
        if (PlayerPrefs.HasKey("totalscore"))
        {
            TotalScore = PlayerPrefs.GetFloat("totalscore");
        } 
        ActualSizeOfCircle = validation.currentCircleRadius *2;
    }

    public void GetScore()
    {
        ActualSizeOfBasketBalls = instantiateBall.radiusForCalculation;
        if (validation.currentCircleRadius != 0 && instantiateBall.radiusForCalculation!=0)
        {
            float score = (ActualSizeOfBasketBalls / ActualSizeOfCircle) * 100;
            Debug.Log(score + " score");
            if(score >= minWinningScore && score <= maxWinningScore)
            {
                Debug.Log("Won" + score);
                TotalScore += score;
                NewLevel();
            }
            else
            {
                Debug.Log("Lose" + score);
                GameOver();
            }
        }
    }

    public void GameOver()
    {
        TotalScore = 0;
        PlayerPrefs.SetFloat("totalscore", TotalScore);
        GameLoss.SetActive(true);
        score.text = "Score: " + TotalScore.ToString("0");
    }

    public void NewLevel()
    {
        PlayerPrefs.SetFloat("totalscore", TotalScore);
        score.text = "Score: " + TotalScore.ToString("0");
        GameWon.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
