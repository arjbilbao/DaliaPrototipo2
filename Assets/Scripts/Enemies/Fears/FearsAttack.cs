using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearsAttack : MonoBehaviour
{       
    public SO_PlayerInfo playerInfo;
    public SO_Enemy thisEnemy;
    public FearsMovement fearsMov;
   


   


    public void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.tag=="Player")
        {       
             fearsMov.chase=false;
             thisEnemy.OnChasing=false;
            this.transform.SetParent(other.gameObject.transform);
            
            
        }
    }

    public void OnCollisionExit2D (Collision2D other)
    {
         if(other.gameObject.tag=="Player")
        {       
             
            this.transform.SetParent(null);
            
            
        }

    }
}
