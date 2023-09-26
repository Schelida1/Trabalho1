using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text textodepontuacao;
    public int pontosagr;
    public GameObject QUEBRA; 


    //private void OnDisable()
    //{
     //   PlayObserverManeger.OnPlayer NotImplementedException();
   // }

    private void Awake() // primeiro metodo a ser rodado 
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //pontosagr = 0;
        //textodepontuacao.text = "Pontuação: " + pontosagr;
        //LoadScene("MainMenu"); // Assim que o jogo iniciar aparecerá a função Menu
        SceneManager.LoadScene( "MainMenu");
       //SceneManager.LoadSceneAsync("MainMenu").completed += OnMainMenuLoaded;
    }

    private void OnMainMenuLoaded(AsyncOperation operation)
    {
        // Verifique se o prefab do jogador está configurado.
        if (QUEBRA != null)
        {
            //  instanciar o jogador.
            Transform spawnPoint = GameObject.Find("PlayerSpawnPoint").transform;

            // Instancie o jogador no ponto desejado.
            Instantiate(QUEBRA, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogError("Prefab do jogador não configurado no GameManager!");
        }
    }
    

    
        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

   
    public void LoadScene(string MainMenu)
    {
     SceneManager.LoadScene(MainMenu); 
    }

   public void Aumentarpont(int ganharpont)
   {
       pontosagr += ganharpont;
       textodepontuacao.text = "Pontuação: " + pontosagr;
       
   }

   public void LoadLevel( )
   {
       SceneManager.LoadScene("GUI");
    //   SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
       SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive).completed += OnMainMenuLoaded;
       // SceneManager.LoadSceneAsync("MainMenu").completed += OnMainMenuLoaded;
       {
        
           Vector3 Bola =GameObject.FindWithTag("InstancePlayer").transform.position;
           Instantiate (QUEBRA, Bola, Quaternion.identity);
       };
   }
}
