using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bul_speed;

    void Update()
    {
        transform.Translate(Vector2.right * bul_speed);
        Destroy(this.gameObject, 3.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
