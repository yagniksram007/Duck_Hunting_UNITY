using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_indicator : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource GunShotAudioScore;

    void Start()
    {
        Cursor.visible = false;
    }

    void Move()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        this.transform.position = mousePos;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetMouseButton(0))     //0 is left click
        {
            GunShotAudioScore.Play();
        }
    }
}
