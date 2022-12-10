using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearsArea : MonoBehaviour
{
    public SO_Enemy Fears;
   

    public void Attack()
    {
            Fears.OnPatroll=false;
            Fears.OnChasing=true;
        
    }
    public void StepBack()
    {       
            Fears.OnChasing=false;
            Fears.OnPatroll=true;
            

    }


}
