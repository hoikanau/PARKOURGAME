using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNavigator : MonoBehaviour
{
    public GameObject levelSelector;
    public void levelSelect()
    {
        gameObject.SetActive(false);
        levelSelector.SetActive(true);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
        public void levelOne()
    {
        SceneManager.LoadScene("Level 1");
        
    }
    public void levelTwo()
    {
        SceneManager.LoadScene("Level 2");
        
    }
}
