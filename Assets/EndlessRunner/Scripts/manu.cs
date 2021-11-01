using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manu :PlayerInput
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject roads;
    [SerializeField] Button Play;
    public void PlayGame()
    {
        Debug.Log("Start is Working");
        player.gameObject.SetActive(true);
        roads.gameObject.SetActive(true);
        Play.gameObject.SetActive(false);

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Restart is Working");
        
    }
    public void MainManu()
    {
        SceneManager.LoadScene("MainMunu");
        Debug.Log("MainMunu is Working");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit is Working");
    }
    
   
}
