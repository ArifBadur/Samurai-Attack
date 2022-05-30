using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItemsCollider : MonoBehaviour
{
    //bonus collider touch control
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == ("Finish"))
        {
            //Speed = 0;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == ("Respawn"))
        {
            Destroy(gameObject);
        }
    }
}
