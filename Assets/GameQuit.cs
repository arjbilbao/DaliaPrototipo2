using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour
{
        public SO_GlobalAlterManager GAM;
    public void QuitGame()
    {

        Application.Quit();
    }

    private void OnApplicationQuit() {

        //Reset Alters
        GAM.AlterIndex=0;
        GAM.CurrentAlter="Eliad";
        GAM.Changing=false;
        
    }
}
