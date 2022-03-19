using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGround : MonoBehaviour
{
    public GameObject player;

    public GameObject ironBall;
    public GameObject blueSphere;
    public GameObject bomb;
    public GameObject coin;

    float offset = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        reSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > transform.position.z)
        {
            transform.Translate(new Vector3(0, 0, 100));
            ironBall.transform.Translate(new Vector3(0, 0, 200));
            blueSphere.transform.Translate(new Vector3(0, 0, 200));
            bomb.transform.Translate(new Vector3(0, 0, 200));
            coin.transform.Translate(new Vector3(0, 0, 200));
            offset += 100.0f;
            reSpawn();
        }
    }

    void reSpawn()
    {
        for (float i = -150f; i < -30f; i += 30f)
        {
            for (float j = -3.2f; j < 4f; j+=3.2f)
            {
                var position = new Vector3(j, 0.54f, i + offset);
                int randomObj = Random.Range(1, 8);

                if (randomObj == 1)
                {
                    Instantiate(ironBall, position, Quaternion.identity);
                }
                else if (randomObj == 3)
                {
                    Instantiate(blueSphere, position, Quaternion.identity);
                }
                else if (randomObj == 5)
                {
                    Instantiate(bomb, position, Quaternion.identity);
                }
                else if (randomObj == 7)
                {
                    Instantiate(coin, position, transform.rotation * Quaternion.Euler(90f, 0f, 0f));
                }
            }
        }
    }
}
