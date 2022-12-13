using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{       public Material [] numbers;
        private float timer;
        public float changingtime;
        private int count=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                    

                    if(timer<=changingtime)
                    {
                        timer+=Time.deltaTime;
                    }

                    else
                    {
                        var rend = this.GetComponent<ParticleSystemRenderer>();
                        
                        rend.material = numbers[count];
                        count++;

                        if(count>=numbers.Length)
                        {
                            count=0;
                        }
                        timer=0f;

                    }

    }
}
