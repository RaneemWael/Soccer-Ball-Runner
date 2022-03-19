using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseAndResume : MonoBehaviour
{
    bool pause = false;
    public movement player;
    public AudioSource backgroundMusic;
    public GameObject pauseMenu;
    public AudioSource pauseMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause)
            {
                pauseGame();
            }
            else
            {
                resumeGame();
            }
        }
    }

    public void pauseGame()
    {
        pauseMusic.UnPause();
        pauseMenu.SetActive(true);
        player.move = false;
        backgroundMusic.Pause();
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    }

    public void resumeGame()
    {
        pauseMusic.Pause();
        pauseMenu.SetActive(false);
        player.move = true;
        backgroundMusic.UnPause();
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
