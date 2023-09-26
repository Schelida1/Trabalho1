using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public string SnaceName;
   public void LoadGame()
   {
     // SceneManager.LoadScene(1);
      GameManager.instance.LoadLevel();
   }
   
}
