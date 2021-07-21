using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void play(string scene_name)
   {
       Application.LoadLevel(scene_name);
   }
}
