using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
   public GameOverScreen gameOverScreen;
   //int enemyValue = 0;


   //public void GameOver()
   //{
       //gameOverScreen.Setup(enemyValue);
   //}

   private void Awake()
   {

   }
   void Start()
   {

   }
   public void RestartButton()
   {
       SceneManager.LoadScene("Game");
   }
   public void ExitButton()
   {
       SceneManager.LoadScene("MainMenu");
   }
   
}
