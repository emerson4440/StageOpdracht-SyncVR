using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeVideo : MonoBehaviour
{

    //SceneLoader
    public void Changescene1()
    {
        SceneManager.LoadScene("Cave");
    }

    public void Changescene2()
    {
        SceneManager.LoadScene("Forest");
    }

    public void ChangeMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
