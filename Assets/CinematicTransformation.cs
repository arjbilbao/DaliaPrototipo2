using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;
using Cinemachine;

public class CinematicTransformation : MonoBehaviour
{
    public SO_AlterAnimator _AlterAnimator;
    public SO_GlobalAlterManager GAM;
    public SO_SoundtrackManager SM;
    public BoolGameEvent Prisoner;
    public SO_TilesSlot tileSlot;
    private bool count, count2;
    private float ChangeTime;
    private float timer;

    private void Update()
    {

        if(count)
        {

            if(timer<=ChangeTime)
            {

                timer+=Time.deltaTime;
            }
            else
            {
                    count=false;
                    timer=0f;
                    GameObject _player = GameObject.FindWithTag("Player");
                     _player.GetComponent<MainPlayerController>()._dialogue=false;
                     GameObject _rat = GameObject.FindWithTag("Rat");
                    SetCameraObject(_rat.transform);
            }
        }

         if(count2)
        {

            if(timer<=ChangeTime)
            {

                timer+=Time.deltaTime;
            }
            else
            {
                    count2=false;
                    timer=0f;
                    GameObject _player = GameObject.FindWithTag("Player");
                     _player.GetComponent<MainPlayerController>()._dialogue=false;
                   
                    SetCameraObject(_player.transform);
            }
        }
    }
    

    public void DeleteAlterFromList(int AlterSlot)
    {
        _AlterAnimator.Container.RemoveAt(AlterSlot);
        SM.Soundtracks.RemoveAt(AlterSlot);
        tileSlot.tiles.RemoveAt(AlterSlot);
        GameObject _player = GameObject.FindWithTag("Player");
            GAM.AlterIndex=0;
        _player.GetComponent<MainPlayerController>().alterIndex=0;

        _AlterAnimator.Container[0].index=0;
        Prisoner.Raise(true);
    }

    public void RegularTransformation()
    {
        Prisoner.Raise(true); 
    }



    public void ChangeTargetToRat()
    {

         GameObject _player = GameObject.FindWithTag("Player");
         _player.GetComponent<MainPlayerController>()._isOnCinematic=true;
         _player.GetComponent<MainPlayerController>().RatSwitching();

    }
    public void ChangeToPlayer()
    {
        GameObject _player = GameObject.FindWithTag("Player");
      
         _player.GetComponent<MainPlayerController>().RatSwitching();
            _player.GetComponent<MainPlayerController>()._isOnCinematic=false;
    }

    public void ChangeRatPosition(Transform _pos)
    {
        GameObject _rat = GameObject.FindWithTag("Rat");

        _rat.transform.position = _pos.position;

        
    }


    public void SetCameraTimer(float _timer)
    {
            count=true;
            ChangeTime=_timer;
              GameObject _player = GameObject.FindWithTag("Player");
         _player.GetComponent<MainPlayerController>()._dialogue=true;


            
    }

      public void SetCameraTimer2(float _timer)
    {
            count2=true;
            ChangeTime=_timer;
              GameObject _player = GameObject.FindWithTag("Player");
         _player.GetComponent<MainPlayerController>()._dialogue=true;


            
    }

    public void SetCameraObject(Transform _object)
    {
                GameObject vcam = GameObject.FindWithTag("Vcam");
                       var cam = vcam.GetComponent<CinemachineVirtualCamera>();
                       cam.Follow = _object; 
    }


    public void BlockDalia()
    {

       
         GameObject _player = GameObject.FindWithTag("Player");
         _player.GetComponent<MainPlayerController>()._FightEliad=true;
         _player.GetComponent<MainPlayerController>().alterIndex=_AlterAnimator.Container.Count-1;
         _player.GetComponent<MainPlayerController>().AlterChanger();

    }
}
