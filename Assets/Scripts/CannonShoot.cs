using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiCikisNoktasi : MonoBehaviour
{
    public GameObject dusmanMermisi;
    public Transform projectileSpawnPoint;
    public float atesHizi;
    public float atesMax = 10;
    public float atesMin = 5;
    public float bulletSpeed = 25;
    void Start()
    {
        atesHizi = Random.Range(atesMin, atesMax);
    }
    void Update()
    {
        atesHizi -= Time.deltaTime;
        if (atesHizi <= 0)
        {
            Shoot();
            atesHizi = Random.Range(atesMin, atesMax);
        }
    }

   
    void Shoot()
    {
        GameObject projectile = Instantiate(dusmanMermisi, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        Rigidbody bulletRb = projectile.GetComponent<Rigidbody>();

        if (bulletRb != null)
        {
            // Adjust the speed as needed
            bulletRb.AddForce(projectile.transform.forward * bulletSpeed, ForceMode.VelocityChange);
        }
    }
}