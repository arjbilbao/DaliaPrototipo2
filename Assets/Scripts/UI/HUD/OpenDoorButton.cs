using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenDoorButton : MonoBehaviour
{

    public SceneLoader SceneLoader;
    public DoorBehavior _DoorSO;
   
    public void SetDoorLevelEntrance(LevelEntranceSO levelEntrance)
    {
        
        SceneLoader.levelEntrance=_DoorSO.levelEntrance;
    }
      public void SetDoorScene(SceneSO sceneToLoad)
    {
        SceneLoader.sceneToLoad=_DoorSO.sceneToLoad;
        
    }

    private void OnEnable()
    {   

        SetEventButton(this.gameObject);
        SceneLoader.levelEntrance=_DoorSO.levelEntrance;
        SceneLoader.sceneToLoad=_DoorSO.sceneToLoad;
    }

    public void SetEventButton(GameObject _button){

               var eventSystem = EventSystem.current;
                eventSystem.SetSelectedGameObject( _button, new BaseEventData(eventSystem));

    }
}
