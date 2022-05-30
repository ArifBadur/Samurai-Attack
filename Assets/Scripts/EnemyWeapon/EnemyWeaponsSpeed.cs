using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponsSpeed : MonoBehaviour
{
    //arrows speed
    public float Speed;//=100f;

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
    //arrows collider touch control
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject,0.01f);
        }
        
        if (collision.gameObject.tag == ("Finish"))
        {
            Speed = 0;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == ("bonusT"))
        {
            Destroy(gameObject);
        }
    }
    */
}
