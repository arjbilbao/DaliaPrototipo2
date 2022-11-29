using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TileMapManager : MonoBehaviour
{
    
    [SerializeField]
    private Tilemap map;

    [SerializeField]
     private GameObject Player;

    [SerializeField]
    private List<SO_TileData> tileDatas;

    public bool AlterChanges;

    private Dictionary<TileBase,SO_TileData> dataFromTiles;

    private void Awake() 

    {       
        
        
        
        
        //This section allows to get all the Data from the tiles;
            dataFromTiles = new Dictionary<TileBase,SO_TileData>();

            foreach(var SO_TileData in tileDatas)
            {
                    foreach(var tile in SO_TileData.tiles)
                    {
                            if(SO_TileData!=null){

                                 dataFromTiles.Add(tile,SO_TileData);
                            }
                           
                    }
            }

    }
      

    void Start()
    {
        AlterChanges=false;


         Player= GameObject.FindWithTag("DefaultEntrance");
        
    }

    // Update is called once per frame
    void Update()
    {
                if(GameObject.FindWithTag("Player")!=null)
                {
                    Player = GameObject.FindWithTag("Player");
                }
                
                
                if(AlterChanges)
                {
                        AlterChanges=false;
                       
                      

                }
    }


    public Vector3Int InitialChange(){
            //This method allows to get the closet tile to center of the Player Game Object in order to star the change in this point.
        Vector3Int gridPosition = map.WorldToCell (Player.transform.position);

        return gridPosition;
    }


    public SO_TileData GetTileData(Vector3Int tileposition)
    {
            //This method gets the information within the Scriptable Object associated to the consulted tile.
            TileBase tile = map.GetTile(tileposition);

            if(tile==null)
                return null;

            else 
                return dataFromTiles[tile];

    }
}

