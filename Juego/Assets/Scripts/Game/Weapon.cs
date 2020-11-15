using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shooter;
    private Transform _firePoint;

    void Awake()
    {
        _firePoint = transform.Find("FirePoint");
    }

    void Start()
    {
        Shoot();
    }

    void Update()
    {
        
    }

    public void Shoot()
    {
        if (bulletPrefab != null && _firePoint != null && shooter != null)
        {
            GameObject myBullet = Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity) as GameObject;
            Bullet bulletComponent = myBullet.GetComponent<Bullet>();

            bulletComponent.direction = (shooter.transform.localScale.x < 0f ? Vector2.left : Vector2.right);
        }
    }
}
