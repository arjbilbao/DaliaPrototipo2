using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    public DoorBehavior _DoorSO;

    

    public void SetDoorLevelEntrance(LevelEntranceSO levelEntrance)
    {
       
        _DoorSO.levelEntrance=levelEntrance;
    }
     public void SetDoorScene(SceneSO sceneToLoad)
    {
        _DoorSO.sceneToLoad=sceneToLoad;
        
    }
}
