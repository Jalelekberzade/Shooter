using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerBullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 8f * Time.deltaTime));
    }
}
