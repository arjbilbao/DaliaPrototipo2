using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileChangingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public SO_GlobalAlterManager GAA;
    public bool firstTime;
    public float TileTimer;
    public float ChangeTime;
    public int tileindex;
    private int x,p,w,z, v;
    private Vector3Int PointOfChange;
     [SerializeField]
    SO_TileMapState state;
    [SerializeField]
    private bool spreading;
    [SerializeField]
    private int AlterIndex;
    [SerializeField]
    private Tilemap map;

     [SerializeField]
    private TileMapManager tileMapManager;

    [SerializeField]
    public  List<SO_TileData> tiles = new List<SO_TileData>();
    public SO_TilesSlot tilesSlot;


    private float stoptimer;

    

     void Start() 
     {
        //player= GameObject.FindWithTag("Player");
        firstTime=true;
        state.CanBeChanged=true;
        Debug.Log("This is the size of the map"+map.size.x);
     }

     void Update()

     {        AlterIndex=GAA.AlterIndex;


     if(stoptimer<=8f&&spreading)
     {
        stoptimer+=Time.deltaTime;
     }
     else 
     {
        state.CanBeChanged=true;
        spreading=false;
        Debug.Log("Spreading is false");
        w=0;
        firstTime=true;
        GAA.Changing=true;
        stoptimer=0f;

     }

            tiles=tilesSlot.tiles;
               
               
               
                    //This section controls the process of changing of the Tile Map
               if(GAA.Changing==true)
                {          
                    if(firstTime){
                            firstTime=false;
                                state.CanBeChanged=false;
                                 spreading=true;
                                      //This section establishes the initial paramether to be used for the tile chaging process.

                                      PointOfChange = tileMapManager.InitialChange(); 
                                      x=PointOfChange.x;
                                      v=PointOfChange.y;
                                      z=x+2;
                                      p=2*x;
                                
                                      
                    }
                     if(TileTimer==0&&w<=map.size.x&&spreading==true)
                        {       //This section controls the duration of the expantion in a given tilemap
                            SpreadChange(PointOfChange);
                        }
                    
                        TileTimer+=Time.deltaTime;

                        if(TileTimer>=ChangeTime){
                                //this section controls the speed of the change.
                            TileTimer=0.0f;
                        }

                        if(w>=map.size.x){
                                //this sections tells to the Scriptable Object that the change has been completed.
                            state.CanBeChanged=true;
                            spreading=false;
                            Debug.Log("Spreading is false");
                            w=0;
                            firstTime=true;
                            GAA.Changing=true;
                        }
                                
                   
                } 

     }

     void FixedUpdate()
     {
             

     }


   internal void ChangingTile(Vector3Int position, int index1, int index2)
   {
            //This method choses the exact tile for which another must be changed
        map.SetTile(position,tiles[index1].tiles[index2]);

   }

   private void SpreadChange(Vector3Int position)
   {                    //This method ranges throught the Tilemap, tile by tile.
               
                w+=1;
            {        //The X variable controls the expansion over the Horizontal Axis
                    for(int y=position.y-v;y<position.y+w;y++){
                                //The Y variable controls the expansion over the Vertical Axis in any given X position.
                            for(int q=z-2;q<Mathf.Abs(x)+2;q++){
                                        //The q Variable controls the expansion horizontally on any given Y position, allowing the creation of ever expanding square function.
                                if(x>=z){
                                        //This conditions limits the square function in any Y iteraction.
                                            ChangeCurrentTile(new Vector3Int (q,y,0)); 
                                            ChangeCurrentTile(new Vector3Int (-q+p,-y,0));  
                                            ChangeCurrentTile(new Vector3Int (-q+p,y,0)); 
                                            ChangeCurrentTile(new Vector3Int (q,-y,0)); 
                                }
                                        
                    ChangeCurrentTile(new Vector3Int (x,y,0));
               
                    ChangeCurrentTile(new Vector3Int (-x+p,-y,0)); 
                    
                    ChangeCurrentTile(new Vector3Int (-x+p,y,0));
                
                    ChangeCurrentTile(new Vector3Int (x,-y,0)); 
                   

                            }
                        
                 
                    // IMPORTANT NOTE: Any negative variable allows the function to grow simetrically in any direction.
                    
                }
               
            
                x+=1; //X variable
               
               

            }

         
          

            void ChangeCurrentTile(Vector3Int tileposition){
                    //this method changes the information of a tile in any given position.
                    
                SO_TileData data = tileMapManager.GetTileData(tileposition);
                if(data!=null){
                    
                    
                    TileBase thistile = map.GetTile(tileposition);
                    string thistilename = thistile.name;

                    for(int i=0;i<data.tiles.Length;i++)
                    {       //This section looks for the equivalent tile within a given matrix.
                            if(data.tiles[i].name == thistilename)
                            {
                                tileindex=i;
                            }

                    }
                
                    
                    ChangingTile(tileposition,AlterIndex,tileindex);
                   
                }
            }


   }

}

