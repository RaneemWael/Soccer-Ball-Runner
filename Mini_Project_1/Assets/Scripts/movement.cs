using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed = 2;
    public bool move = true;
    public bool invincible = false;

    private Vector2 fingerStart;
    private Vector2 fingerEnd;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                goRight();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                goLeft();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                goUp();
            }
        }

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerStart = touch.position;
                fingerEnd = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                fingerEnd = touch.position;

            }
            if (touch.phase == TouchPhase.Ended)
            {
                if ((fingerStart.x - fingerEnd.x) > 0)
                {
                    goLeft();
                }
                if ((fingerStart.x - fingerEnd.x) < 0)
                {
                    goRight();
                }
            }
        }
    }

    public void goRight()
    {
        transform.Translate(new Vector3(3.2f, 0, 0));
        if (transform.position.x > 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void goLeft()
    {
        transform.Translate(new Vector3(-3.2f, 0, 0));
        if (transform.position.x < -4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void goUp()
    {
        GetComponent<Rigidbody>().AddForce(0, 7, 0, ForceMode.Impulse);
    }

    public void doubleSpeed()
    {
        speed *= 2;
        Invoke("endDoubleSpeed", 7.0f);
    }

    void endDoubleSpeed()
    {
        speed /= 2;
    }

    public void invincibleMode()
    {
        GetComponent<AudioSource>().Play();
        invincible = true;
        Invoke("endInvincible", 5.0f);
    }

    void endInvincible()
    {
        GetComponent<AudioSource>().Stop();
        invincible = false;
    }
}