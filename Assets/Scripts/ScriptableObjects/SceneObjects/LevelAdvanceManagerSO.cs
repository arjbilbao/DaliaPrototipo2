using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "GameManager", menuName = "Scriptable Objects/Adavance/Level Advance Manager")]
public class LevelAdvanceManagerSO : ScriptableObject 
{
   public LevelAdvanceSO currentLevel;

    [Header("Broadcasting Events")]
    public LevelAdvanceSOGameEvent levelChanged;


    private LevelAdvanceSO _previousLevel;

    public void SetLevel(LevelAdvanceSO level)
    {
        if (this.currentLevel != null)
            this._previousLevel = this.currentLevel;

        this.currentLevel = level;

        if (this.levelChanged != null)
            this.levelChanged.Raise(level);
    }

    public void RestorePreviousLevel()
    {
        this.SetLevel(this._previousLevel);
    }

    public void EstablishPreviousLevel()

    {
        this._previousLevel=this.currentLevel;
    }
}
