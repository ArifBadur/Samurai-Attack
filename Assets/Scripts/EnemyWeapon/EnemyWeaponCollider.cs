using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponCollider : MonoBehaviour
{
    //arrows collider touch control
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject, 0.01f);
        }

        if (collision.gameObject.tag == ("Finish"))
        {
           // Speed = 0;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == ("bonusT"))
        {
            Destroy(gameObject);
        }
    }
}
