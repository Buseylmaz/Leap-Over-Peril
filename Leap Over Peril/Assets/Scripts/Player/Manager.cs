using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    [Header("Score")]
    public int totalScore;
    [SerializeField] Text scoreText;

    [Space]

    [Header("Heart")]
    public int totalHeart;
    [SerializeField] Text heartText;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    public void CanvasScoreText()
    {
        scoreText.text = totalScore.ToString();
    }


    public void CanvasHeartText()
    {
        heartText.text = totalHeart.ToString();
    }
}
