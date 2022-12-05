using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainChangeManager : MonoBehaviour
{
    public SO_GlobalAlterManager GAA;
    [SerializeField]
      private int Count;
    [SerializeField]
    private SO_TileMapState [] TileState;

    void Update()
    {
        if(GAA.Changing==true)
        {
                    
                  foreach( SO_TileMapState state in TileState)
                  {
                            if(state.CanBeChanged==true){
                                    Count+=1;
                                }
                  }
                    
            if(Count==TileState.Length)
            {
                    GAA.Changing=false;
                    Count=0;

            }
        }
    }
}
