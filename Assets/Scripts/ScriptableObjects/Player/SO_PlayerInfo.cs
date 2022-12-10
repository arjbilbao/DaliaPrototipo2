using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_PlayerInfo", menuName = "Player/SO_PlayerInfo", order = 0)]
public class SO_PlayerInfo : ScriptableObject {

    public int light;
    public int maxLight;
    

    public void TakeDamage(int _damage)
    {
            light-=_damage;
    }
    public void LightUp(int _light) 
    {
        light+=_light;

        if(light<0)
        {
            light =0;
        }
        if(light>maxLight)
        {
            light=maxLight;
        }
    }

    public void SetMaxLight(int _new)
    {
        maxLight=_new;
    }

    
}
