using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePic : MonoBehaviour
{


    public Sprite [] ProfilePics;
     public Sprite [] ProfileBackgrounds;
    public Image Profile, Background;
    public SO_GlobalAlterManager GAA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Profile.sprite = ProfilePics[GAA.AlterIndex];
        Background.sprite = ProfileBackgrounds[GAA.AlterIndex];
    }
}
