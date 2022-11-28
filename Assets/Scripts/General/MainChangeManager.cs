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
                    for(int i=0;i<TileState.Length-1;i++){

                        if(TileState[i].CanBeChanged==true){
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
