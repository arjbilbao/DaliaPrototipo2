using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingObjectBehavior : MonoBehaviour
{
    public SO_GlobalAlterManager GAM;
    public Sprite [] _sprites;
    public SpriteRenderer sr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


       SpriteSelector(GAM.CurrentAlter);
    }


    private void SpriteSelector(string alter)
             {
                     switch(alter)
        {

            case "Eliad": sr.sprite=_sprites[0];
            break;
            case "The Prisoner":
            sr.sprite=_sprites[1];
            break;
            case "The Outcast":
            sr.sprite=_sprites[2];
            break;
            case "Lagartha":
            sr.sprite=_sprites[3];
            break;
            case "The Doctor":
            sr.sprite=_sprites[4];
            break;
            case "Dalia":
            sr.sprite=_sprites[5];
            break;

            default: break;
        }

             }
}
