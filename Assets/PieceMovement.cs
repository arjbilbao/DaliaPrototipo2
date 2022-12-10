using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieceMovement : MonoBehaviour
{
    public Image [,] slots = new Image [4,4];
    public Image [] row1, row2, row3, row4;
    void Start()
    {
        for (int i=0;i==3;i++)
        {
            for(int j=0;j==3;i++)
            {
                
                
                if(i==0)
                slots[j,i]=row1[j];
                else if(i==1)
                slots[j,i]=row2[j];
                else if(i==2)
                slots[j,i]=row3[j];
                else if(i==3)
                slots[j,i]=row4[j];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Código de Movimiento de la pieza

    //código de selección de la pieza
}
