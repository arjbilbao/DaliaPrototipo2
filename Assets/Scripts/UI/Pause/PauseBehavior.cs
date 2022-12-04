using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseBehavior : MonoBehaviour
{
     private void OnEnable()
    {   

        SetEventButton(this.gameObject);
        
    }
    private void OnDisable()
    {
        
     
    }

    public void SetEventButton(GameObject _button){
                 
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject( _button, new BaseEventData(eventSystem));
        eventSystem.SetSelectedGameObject(_button);
        Debug.Log("Hello, I am working");

                

    }
}
