using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{
    public int sphereCount = 0;
    public int coinCount = 0;
    public int scoreCount = 0;
    public Text spheres;
    public Text coins;
    public Text score;
    public movement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addSphereCount()
    {
        sphereCount++;
        scoreCount += 10;
        if (sphereCount % 3 == 0)
        {
            player.doubleSpeed();
        }
        spheres.text = "Blue Sphere Collected: " + sphereCount;
        score.text = "Score: " + scoreCount;
    }

    public void addCoinCount()
    {
        coinCount++;
        scoreCount += 15;
        if (coinCount % 3 == 0)
        {
            player.invincibleMode();
        }
        coins.text = "Coins Collected: " + coinCount;
        score.text = "Score: " + scoreCount;
    }

    public void subScore()
    {
        scoreCount -= 10;
        score.text = "Score: " + scoreCount;
        if (scoreCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
