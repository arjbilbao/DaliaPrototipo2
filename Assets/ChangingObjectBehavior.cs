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
        sr.sprite=_sprites[GAM.AlterIndex];
    }
}
