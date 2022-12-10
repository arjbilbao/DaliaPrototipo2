using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GlobalLightBehavior : MonoBehaviour
{       
    public bool IsASingleLight;
     public Light2D _light;
     public Color Lizard, prisoner, outcast, doctor, dalia, general;
     public SO_GlobalAlterManager GAM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        if(IsASingleLight==false)
        {

             if(GAM.CurrentAlter=="Lagartha")
        {
            _light.color=Lizard;
        }

        else if (GAM.CurrentAlter=="The Prisoner")
        {

             _light.color=prisoner;
        
        }
        else if (GAM.CurrentAlter=="The Doctor")
        {
            _light.color=doctor;
        }
         else if (GAM.CurrentAlter=="The Outcast")
        {
            _light.color=outcast;
        }
         else if (GAM.CurrentAlter=="Dalia")
        {
            _light.color=dalia;
        }
        else {

            _light.color=general;
        }
    }

        if(IsASingleLight)
        {
            if(GAM.CurrentAlter=="Lagartha")
        {
            _light.color=Lizard;
            _light.enabled=true;
        }
        else {

            _light.enabled=false;
        }

        }



        }
       
}
