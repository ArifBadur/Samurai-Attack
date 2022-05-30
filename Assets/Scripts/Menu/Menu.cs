using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject OButtonEe;
    public void SButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OButton()
    {
        OButtonEe.SetActive(true);
    }
    public void OButtonE()
    {
        OButtonEe.SetActive(false);
    }
    public void QButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
