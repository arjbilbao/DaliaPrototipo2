using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine.Events;
using UnityEngine;

public class GameAdvanceManager : MonoBehaviour
{
    [Header("Listening to Events")]
    public LevelAdvanceSOGameEvent levelChangedEvent;

    [Header("Enabled & Disabled Shortcuts")]
    public MonoBehaviour[] components;
    public List<LevelAdvanceSO> enabledLevels;
    public List<LevelAdvanceSO> disabledLevels;

    [Header("Actions")]
    public UnityEvent onEliadLevel;
    public UnityEvent onThePrisonerLevel;
    public UnityEvent onTheOutCastLevel;
    public UnityEvent onLizardQueenLevel;
    public UnityEvent onTheDoctorLevel;
    public UnityEvent onDaliaLevel;
    public UnityEvent onAllLevel;

      private void OnEnable()
    {
        this.levelChangedEvent.AddListener(LevelChanged);
    }

    private void OnDisable()
    {
        this.levelChangedEvent.RemoveListener(LevelChanged);
    }

     private void LevelChanged(LevelAdvanceSO newLevelAdvance)
    {
        InvokeShortcuts(newLevelAdvance);
        InvokeActions(newLevelAdvance);
    }

    private void InvokeShortcuts(LevelAdvanceSO newLevelAdvance)
    {
        foreach (var component in this.components)
        {
            if (this.enabledLevels.Contains(newLevelAdvance))
            {
                component.enabled = true;
            }

            if (this.enabledLevels.Contains(newLevelAdvance))
            {
                component.enabled = false;
            }
        }
    }

    private void InvokeActions(LevelAdvanceSO newLevelAdvance)
    {
        if (newLevelAdvance.levelName == "Eliad" && this.onEliadLevel != null)
            this.onEliadLevel.Invoke();

        if (newLevelAdvance.levelName == "The Prisoner" && this.onThePrisonerLevel != null)
            this.onThePrisonerLevel.Invoke();

        if (newLevelAdvance.levelName == "The Outcast" && this.onTheOutCastLevel != null)
            this.onTheOutCastLevel.Invoke();

        if (newLevelAdvance.levelName == "Lizard Queen" && this.onLizardQueenLevel != null)
            this.onLizardQueenLevel.Invoke();

        if (newLevelAdvance.levelName == "The Doctor" && this.onTheDoctorLevel != null)
            this.onTheDoctorLevel.Invoke();

        if (newLevelAdvance.levelName == "Dalia" && this.onDaliaLevel != null)
            this.onDaliaLevel.Invoke();

        if (newLevelAdvance.levelName == "All" && this.onAllLevel != null)
            this.onAllLevel.Invoke();
    }
}
