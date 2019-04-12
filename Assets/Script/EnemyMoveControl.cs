using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveControl : MonoBehaviour
{
    float speed = 3;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
