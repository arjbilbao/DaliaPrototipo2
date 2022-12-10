using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName="New Player Upgrade Manager",menuName="Alter SO/Player Upgrade Manager")]
public class SO_PlayerUpgradesManager : ScriptableObject
{


   public List<AlterSlot> Container = new List<AlterSlot>();
   public void AddAlter(string _item){

       

           Container.Add(new AlterSlot(_item, false));
       
   }
   public void UsedItem(int i){

           Container[i].AddUsed(false);
   }
}

[System.Serializable]
public class AlterSlot{

        public string alter;
        public bool CanBeUsed;
        public AlterSlot(string _alter, bool _CanBeUsed){

           alter=_alter;
            CanBeUsed=_CanBeUsed;
        }
        public void AddUsed(bool value){

                CanBeUsed=value;
        }
}
