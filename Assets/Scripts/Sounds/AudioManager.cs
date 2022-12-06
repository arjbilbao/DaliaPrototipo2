using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AudioManager : MonoBehaviour
{
    public SO_SoundtrackManager [] _soundtrackManagers;
    public AudioSource [] _audioSource;
    public SO_GlobalAlterManager GAM;
    private bool playing=false;
    private bool fading=false;
    public bool _SountrackOn, _MainMenuIsOn=true;
     private Controls controls;
     public float fadingTime;
     public float maxAudio;
     public int SountrackManagerIndex;
     public bool running;


    
   
     private void Awake() 
    {   
        
        controls = new Controls(); 
    }
    void Start()
    {
        controls.Pcontroller.North.performed += ctx => fading =true;
        _MainMenuIsOn=true;
    }

    // Update is called once per frame
    void Update()
    {

        if(_SountrackOn)
        {
             MainSoundTrackManager();
        }
        if(_MainMenuIsOn)
        {
                PlayMainMenu();
        }
       
    }
    private void FixedUpdate() {
        
    }

    public void SetSountrackActive(bool active)
    {

            _SountrackOn=active;
            
    }
     public void SetMainMenuActive(bool active)
    {

            _MainMenuIsOn=active;
    }

    public void PlayMainMenu()
    {

          _audioSource[1].clip=_soundtrackManagers[1].Soundtracks[0];
            if(playing==false){

                 _audioSource[1].Play();
                 playing=true;
            }
    }
     public void PauseAny(int index)
    {

           
            _audioSource[index].Pause();
            playing=false;
    }
    


    

    public void MainSoundTrackManager()
    {           
                FadingChecking(_soundtrackManagers[0]);

            if(_soundtrackManagers[SountrackManagerIndex].fading==false)
            {

            _audioSource[0].clip=_soundtrackManagers[0].Soundtracks[GAM.AlterIndex];
            if(playing==false){

                 _audioSource[0].Play();
                 playing=true;
            }
            }
            if(_soundtrackManagers[0].fading==true)
            {
                FadingSountracks(_soundtrackManagers[0].Soundtracks[GAM.AlterIndex],_audioSource[0],fadingTime,_soundtrackManagers[0]);
                fading=false;
                
                }
            
            
    }

    public void RunningSounds()
    {       
        

        _audioSource[2].clip=_soundtrackManagers[2].Soundtracks[0];
        _audioSource[2].Play();
    }
    public void StopRunning()
    {

        _audioSource[2].Stop();
    }
    
    
    public void FadingChecking(SO_SoundtrackManager SO_STM)
        {
            if(fading)
            {
              
                SO_STM.fading=true;
                SO_STM.control=true;
            }
        }


        public void FadingSountracks(AudioClip final, AudioSource audiosource, float fadingTime,SO_SoundtrackManager SO_STM)
    {       
            
               

            if(audiosource.volume==maxAudio&&SO_STM.control==true)
            {
                SO_STM.decreasing=true;
                SO_STM.increasing=false;
                SO_STM.control=false;
            }
            if(audiosource.volume==0f&&SO_STM.increasing==false)
            {

                SO_STM.decreasing=false;
                SO_STM.increasing=true;
                audiosource.clip=final;
                audiosource.Play();
                StopCoroutine("FadeAudioSource.StartFade");
            }
            if(SO_STM.decreasing)
                {
                        StartCoroutine(FadeAudioSource.StartFade(audiosource,fadingTime,0f));
                }
            
            if(SO_STM.increasing)
            {
               
               
                StartCoroutine(FadeAudioSource.StartFade(audiosource,fadingTime*4f,maxAudio));

                if(audiosource.volume==maxAudio)
                {
                        SO_STM.fading=false;
                        SO_STM.increasing=false;
                        StopCoroutine("FadeAudioSource.StartFade");
                }

                     
            }
           
                    

                             
                           
                    
           
           

            }
            

    


     public void OnEnable() 
    {
        controls.Enable(); 
    }
    private void OnDisable() 
    {
        controls.Disable(); 
    }
    
}
