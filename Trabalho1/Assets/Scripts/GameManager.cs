using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(transform);
        }
        else 
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    { 
        LoadScene("MainMenu"); // Assim que o jogo iniciar aparecerá a função Menu
    }

    // Update is called once per frame
    void Update()
    {  
    }

   public void LoadScene(string sceneName)
    {
     SceneManager.LoadScene(sceneName); 
    }
}
