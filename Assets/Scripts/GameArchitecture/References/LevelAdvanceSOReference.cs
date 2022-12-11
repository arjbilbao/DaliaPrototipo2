using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class LevelAdvanceSOReference : BaseReference<LevelAdvanceSO, LevelAdvanceSOVariable>
	{
	    public LevelAdvanceSOReference() : base() { }
	    public LevelAdvanceSOReference(LevelAdvanceSO value) : base(value) { }
	}
}