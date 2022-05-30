using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusItems : MonoBehaviour
{
    public GameObject[] bonusss;

    //bonus spawn lane
    public int lane;

    //bonus spawn time
    private float InsTime = 7;

    void Start()
    {
        StartCoroutine(GKF());
    }

    //bonus spawn lane
    IEnumerator BonusLane()
    {
        var bonusType = Random.Range(0, 6);
        yield return new WaitForSeconds(0.1f);
        lane = Random.Range(1, 4);

        switch (lane)
        {
            case 1:
                Vector3 posY = new Vector3(0, 5, 0);
                GameObject newY = Instantiate(bonusss[bonusType], posY, Quaternion.Euler(0, 0, 180));
                break;
            case 2:
                Vector3 posxy = new Vector3(-2, 5, 0);
                GameObject newxy = Instantiate(bonusss[bonusType], posxy, Quaternion.Euler(0, 0, -163));
                break;
            case 3:
                Vector3 posxY = new Vector3(2, 5, 0);
                GameObject newxY = Instantiate(bonusss[bonusType], posxY, Quaternion.Euler(0, 0, 163));
                break;
        }
    }

    //bonus spawn time & infinty bonus
    IEnumerator GKF()
    {
        for (int i = 10; i < i + 1; i++)
        {
            yield return new WaitForSeconds(InsTime);
            StartCoroutine(BonusLane());
        }
    }

}
