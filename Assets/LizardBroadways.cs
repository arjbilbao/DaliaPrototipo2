using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardBroadways : MonoBehaviour
{       public SO_GlobalAlterManager GAM;
        public SpriteRenderer sr;
        public GameObject video;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GAM.CurrentAlter=="Lagartha")
        {
                sr.enabled=true;
                video.SetActive(true);

        }
        else{
            sr.enabled=false;
            video.SetActive(false);
        }
    }
}
