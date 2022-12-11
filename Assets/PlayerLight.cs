using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerLight : MonoBehaviour
{

    public Light2D _light;
    public SpriteRenderer playerR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _light.lightCookieSprite = playerR.sprite;
    }
}
