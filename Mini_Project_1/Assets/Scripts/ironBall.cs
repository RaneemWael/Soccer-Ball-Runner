using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ironBall : MonoBehaviour
{
    public movement player;
    public counter count;
    public playSounds sounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > transform.position.z)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            if (!player.invincible)
            {
                sounds.playIron();
                count.subScore();
            }
            Destroy(gameObject);
        }
    }
}
