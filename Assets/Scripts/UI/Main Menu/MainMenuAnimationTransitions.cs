using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimationTransitions : MonoBehaviour
{
    public ParticleSystem ps;
    public SpriteRenderer sr;
    public CanvasGroup cg;
    public GameObject Menu;
    public bool _transitionEnabled;
    public int AlterIndex;
    public Material [] dalias;
    public bool increasing, decreasing, control;
    public float fadingTime;
    public float radius;
    void Start()
    {
        ps=GetComponent<ParticleSystem>();
        control=true;
        ps.Play();
        _transitionEnabled=true;
    }

    // Update is called once per frame
    void Update()
    {
            
        if(_transitionEnabled)
        {       GetComponent<ParticleSystemRenderer>().material = dalias[AlterIndex];
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

        if(shape.radius==radius&&decreasing==false)
            {

                decreasing=true;
                increasing=false;
             
                StopCoroutine("FadeTransitions.StartFade");
                StopCoroutine("FadeTransitions.SpriteFade");
                StopCoroutine("FadeTransitions.CanvasFade");
            }

            if(increasing)
            {
               
              
            
                StartCoroutine(FadeTransitions.StartFade(ps,fadingTime,radius));
                StartCoroutine(FadeTransitions.CanvasFade(cg,2*fadingTime,1f));
                

                
             }
            if(decreasing)
                {      
                        StartCoroutine(FadeTransitions.StartFade(ps,2*fadingTime,0.0001f));
                        StartCoroutine(FadeTransitions.SpriteFade(sr,2*fadingTime, new Color (1f,1f,1f,1f)));
                        StartCoroutine(FadeTransitions.CanvasFade(cg,2*fadingTime,0f));
                        

                        if(shape.radius<=0.0001f)
                {
                        
                        decreasing=false;
                        control=true;
                        StopCoroutine("FadeTransitions.StartFade");
                        StopCoroutine("FadeTransitions.SpriteFade");
                        StopCoroutine("FadeTransitions.CanvasFade");
                        _transitionEnabled=false;
                        ps.Stop();
                        Menu.SetActive(true);
                }
                }
            
            


    }
}
