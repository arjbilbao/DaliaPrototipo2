using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class OpenDoorButton : MonoBehaviour
{

    public SceneLoader SceneLoader;
    public GlobalDoorBehaviorManager GDBM;
    public DoorBehavior _DoorSO;
    public Button _thisButton;
    public Image _thisImage;
    public TextMeshProUGUI TextMesh;
    public GameObject _GoButton;
   
   
    public void SetDoorLevelEntrance(LevelEntranceSO levelEntrance)
    {
        
        SceneLoader.levelEntrance=_DoorSO.levelEntrance;
    }
      public void SetDoorScene(SceneSO sceneToLoad)
    {
        SceneLoader.sceneToLoad=_DoorSO.sceneToLoad;
        
    }

    public void OpenAndClosedDoor(bool _status)
    {
        _DoorSO._isDoorOpen=_status;
    }

    private void OnEnable()
    {   
       _DoorSO=GDBM._DoorSO;
       if(_DoorSO!=null)
       {
            if(_DoorSO._isDoorOpen==true)
            {
                _thisButton.enabled=false;
                _thisImage.enabled=false;
                TextMesh.enabled=false;
                _GoButton.SetActive(true);
                SetEventButton(_GoButton);
            }
            else{
                _thisButton.enabled=true;
                _thisImage.enabled=true;
                TextMesh.enabled=true;
                _GoButton.SetActive(false);
                 SetEventButton(this.gameObject);
                }
       
        SceneLoader.levelEntrance=_DoorSO.levelEntrance;
        SceneLoader.sceneToLoad=_DoorSO.sceneToLoad;

       }
            
    }
    private void OnDisable()
    {
        
        SceneLoader.levelEntrance=null;
        SceneLoader.sceneToLoad=null;
    }

    public void SetEventButton(GameObject _button){
                 
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject( _button, new BaseEventData(eventSystem));
        eventSystem.SetSelectedGameObject(_button);
        Debug.Log("Hello, I am working");

                

    }
}
