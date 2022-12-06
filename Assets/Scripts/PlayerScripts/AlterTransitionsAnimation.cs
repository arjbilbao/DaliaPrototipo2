using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterTransitionsAnimation : MonoBehaviour
{
    public ParticleSystem ps;
    public SpriteRenderer sr;
    public MainPlayerController pController;
    public SO_GlobalAlterManager GAM;
    public Material [] dalias;
    public bool increasing, decreasing, control;
    public float fadingTime;
    public float radius;
    void Start()
    {
        ps=GetComponent<ParticleSystem>();
        control=true;
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
            
        if(pController._transitionEnabled)
        {       GetComponent<ParticleSystemRenderer>().material = dalias[GAM.AlterIndex];
            Transition();
        }
    
    }

    public void Transition()
    {
             var shape = ps.shape;
            

         if(shape.radius==0.0001f&&control==true)
            {   
                increasing=true;
                decreasing=false;
                control=false;
            }

        if(shape.radius==1.22f&&decreasing==false)
            {

                decreasing=true;
                increasing=false;
             
                StopCoroutine("FadeTransitions.StartFade");
                StopCoroutine("FadeTransitions.SpriteFade");
            }

            if(increasing)
            {
               
              
            
                StartCoroutine(FadeTransitions.StartFade(ps,fadingTime,1.22f));
                

                
             }
            if(decreasing)
                {      
                        StartCoroutine(FadeTransitions.StartFade(ps,2*fadingTime,0.0001f));
                        StartCoroutine(FadeTransitions.SpriteFade(sr,fadingTime, new Color (1f,1f,1f,1f)));
                        

                        if(shape.radius<=0.0001f)
                {
                        
                        decreasing=false;
                        control=true;
                        StopCoroutine("FadeTransitions.StartFade");
                        StopCoroutine("FadeTransitions.SpriteFade");
                        pController._transitionEnabled=false;
                        ps.Stop();
                }
                }
            
            


    }


}
