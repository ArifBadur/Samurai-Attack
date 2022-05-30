using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public GameObject idle;
    public GameObject[] attack;
    public int attackTypeR, attackTypeL;

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (finger.deltaPosition.x < -20)
            {
                idle.SetActive(false);
                attack[attackTypeL].SetActive(true);

                attack[2].SetActive(false);
                attack[3].SetActive(false);
                attack[4].SetActive(false);
            }
     
            if (finger.deltaPosition.x > 20)
            {
                idle.SetActive(false);
                attack[attackTypeR].SetActive(true);

                attack[0].SetActive(false);
                attack[1].SetActive(false);
                attack[4].SetActive(false);
            }
        
            if (finger.deltaPosition.y > 20)
            {
                idle.SetActive(false);
                attack[4].SetActive(true);

                attack[0].SetActive(false);
                attack[1].SetActive(false);
                attack[2].SetActive(false);
                attack[3].SetActive(false);
            }
        }
        else
        {
            idle.SetActive(true);
            attack[0].SetActive(false);
            attack[1].SetActive(false);
            attack[2].SetActive(false);
            attack[3].SetActive(false);
            attack[4].SetActive(false);
            attackTypeL = Random.Range(0, 2);
            attackTypeR = Random.Range(2, 4);
        }
    }
}
