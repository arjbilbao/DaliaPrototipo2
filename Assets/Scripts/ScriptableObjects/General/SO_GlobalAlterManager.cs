using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Global Alter Manager",menuName="Alter SO/Global Alter Manager")]
public class SO_GlobalAlterManager : ScriptableObject
{
    public string CurrentAlter;
    public bool Changing;
    public int AlterIndex;
}
