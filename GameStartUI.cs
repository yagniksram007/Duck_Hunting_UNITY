using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartUI : MonoBehaviour
{

    public void Start ()
    {

        Cursor.visible = true;
    }

    public TextMeshProUGUI ScoreText;
    public void OnClickStart ()
    {
        SceneManager.LoadScene (1);
    }

}