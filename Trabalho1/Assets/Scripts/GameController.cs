using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text HeathText;

    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int value)
    {
//         HeathText.text ="x " + value.ToString();
         
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
