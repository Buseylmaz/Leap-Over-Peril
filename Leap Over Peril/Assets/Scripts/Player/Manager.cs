using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    [Header("Score")]
    public int totalScore;
    //[SerializeField] Text scoreText;

    [Space]

    [Header("Heart")]
    public int totalHeart;
    //[SerializeField] Text heartText;


    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

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
        //scoreText.text = totalScore.ToString();
    }


    public void CanvasHeartText()
    {
        //heartText.text = totalHeart.ToString();
    }
}
