using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class BlinkIngLight : MonoBehaviour
{
    private Light2D _light;
    public Color [] colors;
    private float timer;
    private int count;
    public float BlinkingTime;
    void Start()
    {
        _light=GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=BlinkingTime)
        {
            timer+=Time.deltaTime;
        }
        else{

                    timer=0f;
                    if(count>=colors.Length)
                    {
                        count=0;
                    }

                    this._light.color = colors[count];
                count+=1;
                
        }
    }
}
