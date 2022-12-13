using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialTilesTransitions : MonoBehaviour
{
    public GameObject Producers, Signature, DisclaimerTitle, DisclaimerContent, panel;
    public MainMenuAnimationTransitions MMAT;
    private float timer, MaxTime;
    private bool _start, _producers, _disclaimer;
    void Start()
    {
        MaxTime=3f;
        _start=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_start)
        {

            if(timer<MaxTime)
            {
                timer+=Time.deltaTime;
            }
            else{

                _start = false;
                timer=0f;
                Signature.SetActive(false);
                Producers.SetActive(true);
                _producers=true;
                MaxTime=5f;
            }
        }

        if(_producers)
        {

            if(timer<MaxTime)
            {
                timer+=Time.deltaTime;
            }
            else{

                _producers = false;
                timer=0f;
                Producers.SetActive(false);
                DisclaimerTitle.SetActive(true);
                DisclaimerContent.SetActive(true);
                _disclaimer=true;
                MaxTime=7f;
            }

             }

            if(_disclaimer)
        {

            if(timer<MaxTime)
            {
                timer+=Time.deltaTime;
            }
            else{

                _disclaimer = false;
                timer=0f;
                
                panel.SetActive(false);
              
                MMAT._transitionEnabled=true;
            }
        }
    }
}
