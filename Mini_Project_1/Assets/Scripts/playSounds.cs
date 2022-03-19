using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSounds : MonoBehaviour
{
    public AudioSource blueSpehere;
    public AudioSource bomb;
    public AudioSource ironBall;
    public AudioSource coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playBomb()
    {
        bomb.Play();
    }

    public void playBlue()
    {
        blueSpehere.Play();
    }

    public void playIron()
    {
        ironBall.Play();
    }

    public void playCoin()
    {
        coin.Play();
    }
}
