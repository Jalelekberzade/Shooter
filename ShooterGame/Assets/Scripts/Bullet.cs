using UnityEngine;

public class Bullet : MonoBehaviour
{
    Player player;
    [SerializeField] GameObject BulletObject;
     GameObject SpawnBullet;
    public LayerMask layer;
    RaycastHit hit;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        Fire();
    }
    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            SpawnBullet = Instantiate(BulletObject, player.transform.position, player.transform.rotation);
            SpawnBullet.AddComponent<MovePlayerBullet>();
            SpawnBullet.AddComponent<DestroyBullet>();
            SpawnBullet.gameObject.tag = "playerBullet";
        }
    }
}
