using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItemsSpeed : MonoBehaviour
{   //bonus speed 
    public float Speed;// = 50f;

    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigid.velocity = (transform.up * Time.deltaTime * Speed);
    }
    /*
    //bonus collider touch control
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == ("Finish"))
        {
            Speed = 0;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == ("Respawn"))
        {
            Destroy(gameObject);
        }
    }
    */
}
