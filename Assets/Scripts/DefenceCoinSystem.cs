using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenceCoinSystem : MonoBehaviour
{
    public GameObject[] defenceValues;
    public int lane;
    private float InsTime = 2;

    void Start()
    {
        StartCoroutine(GKF());
    }

    IEnumerator GK()
    {
        var b = Random.Range(0, 2);
        yield return new WaitForSeconds(0.1f);
        lane = Random.Range(1, 8);

        switch (lane)
        {
            case 1:
                Vector3 posY = new Vector3(0, 5, 0);
                GameObject yeni_sballY = Instantiate(defenceValues[b], posY, Quaternion.Euler(0, 0, 180));
                break;
            case 2:
                Vector3 posX = new Vector3(4, 3, 0);
                GameObject yeni_sballX = Instantiate(defenceValues[b], posX, Quaternion.Euler(0, 0, 145));
                break;
            case 3:
                Vector3 posx = new Vector3(-4, 3, 0);
                GameObject yeni_sballx = Instantiate(defenceValues[b], posx, Quaternion.Euler(0, 0, -145));
                break;
            case 4:
                Vector3 posXy = new Vector3(4, 5, 0);
                GameObject yeni_sballXy = Instantiate(defenceValues[b], posXy, Quaternion.Euler(0, 0, 150));
                break;
            case 5:
                Vector3 posXY = new Vector3(-4, 5, 0);
                GameObject yeni_sballXY = Instantiate(defenceValues[b], posXY, Quaternion.Euler(0, 0, -150));
                break;
            case 6:
                Vector3 posxy = new Vector3(-2, 5, 0);
                GameObject yeni_sballxy = Instantiate(defenceValues[b], posxy, Quaternion.Euler(0, 0, -163));
                break;
            case 7:
                Vector3 posxY = new Vector3(2, 5, 0);
                GameObject yeni_sballxY = Instantiate(defenceValues[b], posxY, Quaternion.Euler(0, 0, 163));
                break;
        }
    }

    IEnumerator GKF()
    {
        for (int i = 10; i < i + 1; i++)
        {
            StartCoroutine(GK());
            yield return new WaitForSeconds(InsTime);
            if (InsTime >= 0.5f)
            {
                InsTime -= 0.02f;
            }
        }
    }
}
