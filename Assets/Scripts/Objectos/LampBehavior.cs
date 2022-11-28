using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LampBehavior : MonoBehaviour
{       

    public Sprite RegularLamp, BrokenLamp;
    public SpriteRenderer _lamp;
    public Light2D _light;
    public bool broken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(broken)
        {
                _lamp.sprite=BrokenLamp;
                _light.enabled=false;
        }
        if(!broken)
        {

             _lamp.sprite=RegularLamp;
             _light.enabled=true;
        }
    }
}
