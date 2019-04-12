using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    public GameObject[] enemy = new GameObject[3];
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            int num = Random.Range(0, 2);
            switch (num)
            {
                case 0:
                    Instantiate(enemy[Random.Range(0, 3)], transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }
        }
    }
}
