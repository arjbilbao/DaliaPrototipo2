using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thinker : MonoBehaviour
{
    public EnemyBrain brain;
    void Update()
    {
        brain.OnPatrollBehaviour(this);
        brain.OnChasingBehaviour(this);
        brain.OnAttackBehaviour(this);
        brain.OnSpawnBehaviour(this);
        brain.OnWaveBehaviour(this);
        brain.OnDyingBehaviour(this);
    
    }
}
