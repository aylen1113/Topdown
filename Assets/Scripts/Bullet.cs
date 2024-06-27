using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletLifetime = 5f;

    // Start is called before the first frame update
    void Start()
    {


        Destroy(gameObject, bulletLifetime);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}