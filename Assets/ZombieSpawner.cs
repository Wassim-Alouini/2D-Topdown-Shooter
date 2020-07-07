using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public int number = 1;


    private void Start()
    {
        InvokeRepeating("Spawn", .5f, 4);
    }
    void Spawn()
    {
        Vector2 position = RandomCircle(Vector3.zero, 20);
        for (int i = 0; i < number; i++)
        {
            Instantiate(zombiePrefab, position, Quaternion.identity);
        }
        number++;
        
    }
    Vector3 RandomCircle (Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
