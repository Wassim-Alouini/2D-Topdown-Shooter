using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;



    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector2 ShootingPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        Instantiate(bulletPrefab, new Vector3(ShootingPosition.x, ShootingPosition.y, 0), transform.rotation);
    }
}
