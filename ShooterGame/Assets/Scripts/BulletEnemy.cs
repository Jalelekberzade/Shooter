using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject SpawnBullet;
    [SerializeField] GameObject Point;

  void Start()
    {
        StartCoroutine(nameof(Fire));
    }
    private void Update()
    {
        
    }
    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            SpawnBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            SpawnBullet.AddComponent<MoveEnemyBullet>();
            SpawnBullet.gameObject.tag = "enemyBullet";
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "playerBullet")
        {
            Instantiate(Point).transform.position = transform.position;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
