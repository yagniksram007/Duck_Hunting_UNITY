using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    void Start ()
    {

        Cursor.visible = true;

        ScoreText.text = "Score : " + (10).ToString ();
    }

    public void OnClickRestart ()
    {
        SceneManager.LoadScene (0);
    }

}