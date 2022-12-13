using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStateTimer : MonoBehaviour
{       
    [Header("Events")]
    public UnityEvent onStateChanged;
     [Header("States References")]
    public GameStateChanger GSC;
    public GameStateSO GameState;
    private float timer;
    private float  maxtime;
    private bool start;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            if(timer<=maxtime)
            {

                timer+=Time.deltaTime;
            }
            else{

                timer=0;
                start=false;
                GSC.SetGameState(GameState);
                if (onStateChanged != null)
                onStateChanged.Invoke();
            }
        }
    }


    public void SetGameState(GameStateSO gameS)
    {
        GameState=gameS;
    }
    public void SetTime(float _time)
    {
        maxtime=_time;
        start=true;
    }
}
