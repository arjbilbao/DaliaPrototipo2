using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingFragments : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
