using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class LevelAdvanceSOEvent : UnityEvent<LevelAdvanceSO> { }

	[CreateAssetMenu(
	    fileName = "LevelAdvanceSOVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Advance",
	    order = 120)]
	public class LevelAdvanceSOVariable : BaseVariable<LevelAdvanceSO, LevelAdvanceSOEvent>
	{
	}
}