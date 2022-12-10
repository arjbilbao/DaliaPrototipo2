using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SO_Enemy", menuName = "Enemies/SO_Enemy", order = 1)]

public class SO_Enemy : EnemyBrain
{
    public int damage;
    public string targetTag;
    public bool test;
   
   
    public bool OnPatroll =true;
  
    public bool OnChasing ;

    public bool OnAttack;
 
    public bool OnSpawn; 
    public bool OnWave; 
    public bool OnDying;

    
    private void Update() {
      OnConditionsStates();
    }

    public void OnConditionsStates()
    {

        
       
       
    }
    public override void OnPatrollBehaviour(Thinker thinker)
    {   
            if(OnPatroll)
            {   OnChasing=false;
                  var Movement = thinker.gameObject.GetComponent<FearsMovement>();
                            if(Movement.patroll==false)
                            {       
                               Movement.chase=false;
                               Movement.patroll=true;
                               

                               Movement.StartCoroutine("Movement");

                            }  
            }
    }
    public override void OnChasingBehaviour(Thinker thinker)
    {       
            if(OnChasing)
            {   
                    GameObject target = GameObject.FindGameObjectWithTag(targetTag);
                 
                    if(target)
                    {   
                        var Movement = thinker.gameObject.GetComponent<FearsMovement>();
                            if(Movement.chase==false)
                            
                            {     
                                
                            
  
                                Movement.chase=true;
                               Movement.patroll=false;
                                Movement._target=target;
                                 Movement.StopCoroutine("Movement");
                                
                                Movement.startChasing=true;
                            }
                    }
            }
           
    }
    public override void OnAttackBehaviour(Thinker thinker)
    { 
             if(OnAttack)
            {
                
            }
    }
    public override void OnSpawnBehaviour(Thinker thinker)
    {   
             if(OnSpawn)
            {
                
            }
    }
    public override void OnWaveBehaviour(Thinker thinker)
    { 
             if(OnWave)
            {
                
            }
    }
    public override void OnDyingBehaviour(Thinker thinker)
    { 
             if(OnDying)
            {
                
            }
    }

    
    
}



