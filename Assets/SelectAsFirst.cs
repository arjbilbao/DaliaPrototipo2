using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectAsFirst : MonoBehaviour
{       

    public void SetEventButton(GameObject _button){
                 
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject( _button, new BaseEventData(eventSystem));
        eventSystem.SetSelectedGameObject(_button);
       
                

    }
}
