using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossFadeController : MonoBehaviour
{       

        public SO_GlobalAlterManager GAM;
        public Image Dalia;
        public SO_AlterAnimator dalias;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dalia.sprite=dalias.Container[GAM.AlterIndex].Pic;
    }
}
