using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


[CreateAssetMenu(fileName="New Tile Data",menuName="Tile SO/Tile Data")]
public class SO_TileData : ScriptableObject
{
    public TileBase [] tiles;
}
