using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    Player player;
    static int count;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.rotation *= Quaternion.Euler(0f, 1f, 0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
            count++;
            Debug.Log(count);
            Debug.Log(player.health);
            if (count >= 5 && player.health < 100)
            {
                player.health += 10;
                count = 0;
            }

        }
    }
}