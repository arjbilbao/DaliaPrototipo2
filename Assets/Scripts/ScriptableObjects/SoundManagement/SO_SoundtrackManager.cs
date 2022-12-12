using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_SoundtrackManager", menuName = "General/SO_SoundtrackManager", order = 2)]
public class SO_SoundtrackManager : ScriptableObject

{       
        public bool fading;
        public bool increasing;
        public bool decreasing;
        public bool control;
        public List<AudioClip> Soundtracks = new List<AudioClip>();

        

   
     
}

