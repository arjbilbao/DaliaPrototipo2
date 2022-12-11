using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "LevelAdvanceSO")]
	public sealed class LevelAdvanceSOGameEventListener : BaseGameEventListener<LevelAdvanceSO, LevelAdvanceSOGameEvent, LevelAdvanceSOUnityEvent>
	{
	}
}