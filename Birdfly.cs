using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Birdfly : MonoBehaviour
{
    public static event Action OnBirdHit;
    public float Speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //get the SpriteRenderer component attached to Bird 
        //and set the flip direction accordingly
        GetComponent<SpriteRenderer>().flipX = Speed > 0;
    }

     void Fly ()
    {
        //Setting the bird's position based on speed and time passed
        transform.Translate (new Vector3 (Speed, 0, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    public AudioSource BirdHitSound;

    void OnMouseUp()
    {
        GetComponent<Rigidbody2D>().gravityScale = 4f;
        GetComponent<Animator>().enabled = false;

        BirdHitSound.Play();

        OnBirdHit?.Invoke(); //I have been hit

    }
}
