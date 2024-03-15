using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreupdate : MonoBehaviour
{
    // Start is called before the first frame update
     public TextMeshProUGUI text;
    void Start()
    {
        int score=PlayerPrefs.GetInt("score");
        text.text= "Score : " + score.ToString ();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
