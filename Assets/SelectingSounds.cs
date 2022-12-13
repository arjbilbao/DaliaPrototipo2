using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingSounds : MonoBehaviour
{
    public AudioClip [] Effects;
    public AudioSource EffectsPlayer;
    public SO_GlobalAlterManager GAM;
    


    public void SetEffect()
    {
            


                 switch(GAM.CurrentAlter)
        {

            case "Eliad": EffectsPlayer.clip=Effects[0];
            break;
            case "The Prisoner":
            EffectsPlayer.clip=Effects[1];
            break;
            case "The Outcast":
            EffectsPlayer.clip=Effects[2];
            break;
            case "Lagartha":
            EffectsPlayer.clip=Effects[3];
            break;
            case "The Doctor":
            EffectsPlayer.clip=Effects[4];
            break;
            case "Dalia":
            EffectsPlayer.clip=Effects[5];
            break;

            default: break;
        }
           

    }
}
