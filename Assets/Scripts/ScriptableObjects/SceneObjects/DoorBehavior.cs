using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoorBehavior", menuName = "General SO/Door", order = 0)]
public class DoorBehavior : ScriptableObject 

{
    public SceneSO sceneToLoad;
    public LevelEntranceSO levelEntrance;
    public bool _isDoorOpen;
}
