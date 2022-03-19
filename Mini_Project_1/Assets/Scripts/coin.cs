using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
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
            sounds.playCoin();
            Destroy(gameObject);
            count.addCoinCount();
        }
    }
}
