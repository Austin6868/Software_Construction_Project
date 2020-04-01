﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float sidewaysForce = 5f;
    private bool shootable = true;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && shootable == true)//this is set to LMB
		{
            if (Equipment.E.EG == 0)
			{
                Shoot();
            }
            if (Equipment.E.EG == 1)
			{
                Shoot2();
			}
		}
        
    }
    void Start()
    {
        
    }
    void Shoot()//the method that instantiate the bullet at the desired firepoint of the gun
	{
        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce , ForceMode2D.Impulse);
        shootable = false;
        Invoke("CanShoot", 0.2f);
    }
    void Shoot2()
	{
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position + firePoint.up * 0.1f, firePoint.rotation);
        GameObject bullet3 = Instantiate(bulletPrefab, firePoint.position - firePoint.up * 0.1f, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        rb2.AddForce(firePoint.right * bulletForce + firePoint.up * 5.0f, ForceMode2D.Impulse);
        rb3.AddForce(firePoint.right * bulletForce - firePoint.up * 5.0f, ForceMode2D.Impulse);
        shootable = false;
        Invoke("CanShoot", 0.5f);
    }
    void CanShoot()
	{
        shootable = true;
	}
}
