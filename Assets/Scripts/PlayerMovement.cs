using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;

    private float screenBorder;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        float combinedSpeed = Mathf.Abs(movement.x) + Mathf.Abs(movement.y);
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        PreventOffScreen();
    }

    private void PreventOffScreen()
    {
        Vector2 screenPosition = cam.WorldToScreenPoint(transform.position);

        if ((screenPosition.x < screenBorder && rb.velocity.x < 0) ||
            (screenPosition.x > cam.pixelWidth - screenBorder && rb.velocity.x > 0))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if ((screenPosition.y < screenBorder && rb.velocity.y < 0) ||
            (screenPosition.y > cam.pixelHeight - screenBorder && rb.velocity.y > 0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Coin"))
    //    {
    //        CollectCoin(collision.gameObject);
    //    }
    //}

    //private void CollectCoin(GameObject coin)
    //{


    //    Destroy(coin);
}
