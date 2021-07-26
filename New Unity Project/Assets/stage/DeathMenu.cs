using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
   public string mainMenuLeavel;

   public void RestartGame()
   {
       FindObjectOfType<GameManager>().Reset();
   }

   public void QuitToMain()
   {
       Application.LoadLevel(mainMenuLeavel);
   }
}
