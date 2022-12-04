using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{           public GameObject Target1, Target2;
            public float speed;
            public bool target2=false, target1=true, wait=false;
            private float _timeSinceStarted, _startingTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if(target1){

                    movingTarget1();
            }
            if(target2){

                    movingTarget2();
            }
    

        
    }

void movingTarget1(){


         transform.position= Vector2.MoveTowards(transform.position,Target1.transform.position,speed*Time.deltaTime);
        
        
        if(Vector2.Distance(transform.position,Target1.transform.position)<=0.5f){

            if(!wait){

                    wait=true;
                    _startingTime=Time.time;
            }

            _timeSinceStarted=Time.time - _startingTime;
            if(_timeSinceStarted>2f){

              target2=true;
              target1=false;
              wait=false;
            }
            
                
         }

    }

    void movingTarget2(){

            transform.position= Vector2.MoveTowards(transform.position,Target2.transform.position,speed*Time.deltaTime);
        if(Vector2.Distance(transform.position,Target2.transform.position)<=0.5f){

            if(!wait){

                    wait=true;
                    _startingTime=Time.time;
            }

            _timeSinceStarted=Time.time - _startingTime;
            if(_timeSinceStarted>2f){

              target2=false;
              target1=true;
              wait=false;
            }

    }
    }

    void OnCollisionEnter2D(Collision2D other){

            if(other.gameObject.tag=="Player"){

                     other.gameObject.transform.SetParent(transform);
            }
                                                                                                               
    }

    void OnCollisionExit2D(Collision2D other){

            if(other.gameObject.tag=="Player"){

                   other.gameObject.transform.SetParent(GameObject.Find("PlayerContainer").transform);
            }
    }
}
