using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanSkor : MonoBehaviour
{
    public GameObject bg, bgg, death, characterr, damage, deadPanel, healtBar, shield, capsule, arrowsCode, bonusCode, can, stage, coinText;
    public Slider healthBar;
    public int maxHealth = 3;
    public int currentHealth;

    public bool shieldBool;

    public Text coinT;

    public HighScore scoreValue;

    private void Start()
    {
        currentHealth = maxHealth;
        SetMaxHealth(maxHealth);
        shield.SetActive(false);
        capsule.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Respawn"))
        {
            if (shieldBool == false)
            {
                if (currentHealth > 1)
                {
                    healtBar.SetActive(true);
                    currentHealth--;
                    SetHealth(currentHealth);
                    StartCoroutine(DMG());
                }
                else
                {
                    //shield false
                    shield.SetActive(false);
                    capsule.SetActive(false);

                    //dead panel on
                    healtBar.SetActive(false);
                    scoreValue.scoreActive = false;
                    StartCoroutine(DP());
                    characterr.SetActive(false);
                    bg.SetActive(false);
                    bgg.SetActive(true);
                    death.SetActive(true);
                    stage.SetActive(false);
                    currentHealth = 0;

                    //arrows and bonus clear 
                    Destroy(arrowsCode);
                    Destroy(bonusCode);
                    Destroy(can.GetComponent<CapsuleCollider2D>());
                }
            } 
        }
        //shield power
        if (collision.gameObject.name == ("Shield1_Img 1(Clone)"))
        {
            shield.SetActive(true);
            capsule.SetActive(true);
            shieldBool = true;
            StartCoroutine(SB());
        }
        //heal power
        if (collision.gameObject.name == ("Heart_Img (1)(Clone)"))
        {
            if(currentHealth < 3 && currentHealth !=0)
            {
                currentHealth++;
                SetHealth(currentHealth);
            }
        }
        //Coins add and text
        if (collision.gameObject.name == ("Coin5(Clone)"))
        {
            scoreValue.scoreAmount += 5;
            coinText.SetActive(true);
            coinT.text = "+ 5";
            StartCoroutine(CT());
        }
        if (collision.gameObject.name == ("Coin10(Clone)"))
        {
            scoreValue.scoreAmount += 10;
            coinText.SetActive(true);
            coinT.text = "+ 10";
            StartCoroutine(CT());
        }
        if (collision.gameObject.name == ("Coin20(Clone)"))
        {
            scoreValue.scoreAmount += 20;
            coinText.SetActive(true);
            coinT.text = "+ 20";
            StartCoroutine(CT());
        }
        if (collision.gameObject.name == ("Coin50(Clone)"))
        {
            scoreValue.scoreAmount += 50;
            coinText.SetActive(true);
            coinT.text = "+ 50";
            StartCoroutine(CT());
        }
    }

    //damage - hit
    IEnumerator DMG()
    {
        damage.SetActive(true);
        characterr.SetActive(false);
        yield return new WaitForSeconds(.1f);
        damage.SetActive(false);
        characterr.SetActive(true);
    }

    //dead panel on
    IEnumerator DP()
    {
        yield return new WaitForSeconds(1f);
        deadPanel.SetActive(true);
    }

    //coint text time
    IEnumerator CT()
    {
        yield return new WaitForSeconds(1f);
        coinText.SetActive(false);
    }

    //shiled time
    IEnumerator SB()
    {
         yield return new WaitForSeconds(5f);
         shieldBool = false;
         shield.SetActive(false);
         capsule.SetActive(false);
    }

    //max health
    public void SetMaxHealth(int hp)
    {
        healthBar.maxValue = hp;
        healthBar.value = hp;
    }

    //health value
    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
