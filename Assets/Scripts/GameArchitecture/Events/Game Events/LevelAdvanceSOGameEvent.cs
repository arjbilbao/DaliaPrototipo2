using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "LevelAdvanceSOGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Advance",
	    order = 120)]
	public sealed class LevelAdvanceSOGameEvent : GameEventBase<LevelAdvanceSO>
	{
	}
}