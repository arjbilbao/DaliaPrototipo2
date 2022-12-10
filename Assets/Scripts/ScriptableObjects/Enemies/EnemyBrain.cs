using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyBrain", menuName = "Enemies/EnemyBrain", order = 0)]
public abstract class EnemyBrain : ScriptableObject
{
    
    public abstract void OnPatrollBehaviour(Thinker thinker);
    public abstract void OnChasingBehaviour(Thinker thinker);
    public abstract void OnAttackBehaviour(Thinker thinker);
    public abstract void OnSpawnBehaviour(Thinker thinker);
    public abstract void OnWaveBehaviour(Thinker thinker);
    public abstract void OnDyingBehaviour(Thinker thinker);


}
