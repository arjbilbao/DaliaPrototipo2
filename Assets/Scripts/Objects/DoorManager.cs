using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public DoorBehavior _DoorSO;

     public SpriteRenderer _spriteRenderer;
    public Sprite _closedDoor, _openedDoor;
    public GameObject _whenDoorOpens;

    public void SetDoorLevelEntrance(LevelEntranceSO levelEntrance)
    {
       
        _DoorSO.levelEntrance=levelEntrance;
    }
     public void SetDoorScene(SceneSO sceneToLoad)
    {
        _DoorSO.sceneToLoad=sceneToLoad;
        
    }
       public void Update()
    {

         if(_DoorSO._isDoorOpen==false)
         {
            _spriteRenderer.sprite=_closedDoor;
            _whenDoorOpens.GetComponent<SpriteRenderer>().enabled=false;

         }
         else{
            _spriteRenderer.sprite=_openedDoor;
            _whenDoorOpens.GetComponent<SpriteRenderer>().enabled=true;
         }   
    }

}
