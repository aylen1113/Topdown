using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    private Camera mainCam;
    private Vector3 mousePos;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
         
        }
        



    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Quaternion rotation = Quaternion.Euler(0, 0, 90);
        bullet.transform.rotation = rotation;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}