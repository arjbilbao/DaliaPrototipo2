
using UnityEngine;

public class LevelAdvanceChanger : MonoBehaviour
{
    
    [Header("Dependencies")]
    public LevelAdvanceManagerSO levelManager;

    public void SetLevel(LevelAdvanceSO level)
    {
        this.levelManager.SetLevel(level);
    }

    public void RestorePreviousLevel()
    {
        this.levelManager.RestorePreviousLevel();
    }

    public void EstablishPreviousLevel()
    {

        this.levelManager.EstablishPreviousLevel();
    }
}
