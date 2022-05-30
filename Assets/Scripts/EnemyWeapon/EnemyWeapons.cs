using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWeapons: MonoBehaviour
{
    public GameObject[] arrowss;

    //arrows lane
    public int lane;

    //arrows spawn time
    private float InsTime = 2;

    //stage
    public Text stage;
    public GameObject stageo;

    void Start()
    {
        StartCoroutine(GKF());
    }

    // arrows spawn lane
    IEnumerator GK()
    {
        var arrowType = Random.Range(0, 3);
        yield return new WaitForSeconds(0.1f);
        lane = Random.Range(1, 5);
        
        switch (lane)
        {
            case 1:
                Vector3 posX = new Vector3(4, 3, 0);
                GameObject newX = Instantiate(arrowss[arrowType], posX, Quaternion.Euler(0, 0, 145));
                break;
            case 2:
                Vector3 posx = new Vector3(-4, 3, 0);
                GameObject newx = Instantiate(arrowss[arrowType], posx, Quaternion.Euler(0, 0, -145));
                break;
            case 3:
                Vector3 posXy = new Vector3(4, 5, 0);
                GameObject newXy = Instantiate(arrowss[arrowType], posXy, Quaternion.Euler(0, 0, 150));
                break;
            case 4:
                Vector3 posXY = new Vector3(-4, 5, 0);
                GameObject newXY = Instantiate(arrowss[arrowType], posXY, Quaternion.Euler(0, 0, -150));
                break;
        }
    }
    //infiniti arrows / stage time
    IEnumerator GKF()
    {
        for (int i = 10; i <i+1; i++)
        {
            StartCoroutine(GK());
            yield return new WaitForSeconds(InsTime);
            if(InsTime>=0.8f)
            {
                InsTime -= 0.02f;
            }
            if(i%10==0)
            {
                stage.text = "STAGE " + i/10 ;
                StartCoroutine(stageg());
                stageo.SetActive(true);
            }
        }
    }
    //stage text time
    IEnumerator stageg()
    {
        yield return new WaitForSeconds(2.1f);
        stageo.SetActive(false);
    }
}
