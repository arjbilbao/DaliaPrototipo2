using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName="New Tiles Slot",menuName="Alter SO/Tiles Slot")]
public class SO_TilesSlot : ScriptableObject
{
    public  List<SO_TileData> tiles = new List<SO_TileData>();
}
