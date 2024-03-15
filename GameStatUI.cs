using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStatUI : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;

    public float TimeLimit;

    public float RemainingTime;

    int Score = 0;
    void Start ()
    {
        Birdfly.OnBirdHit += OnBirdHit;
        Score = 0;
        RemainingTime = TimeLimit;
    }

    void OnDestory ()
    {
            Birdfly.OnBirdHit -= OnBirdHit;

    }

    void OnBirdHit ()
    {
        Score += 10;
        PlayerPrefs.SetInt("score", Score);
        ScoreText.text = "Score : " + Score.ToString ();
    }

    // Update is called once per frame
    void Update ()
    {
        RemainingTime -= Time.deltaTime;

        TimeSpan timeSpan = new TimeSpan (0, 0, 0, (int) RemainingTime);

        TimerText.text = "Time : " + timeSpan.ToString ("mm\\:ss");

        if (RemainingTime <= 0)
        {
            SceneManager.LoadScene (2);
        }

    }
}