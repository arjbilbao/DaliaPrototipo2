using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Animator Inventory",menuName="Alter SO/Animator Inventory")]


public class SO_AlterAnimator : ScriptableObject
{

   
   public List<AnimatorSlot> Container = new List<AnimatorSlot>();
   public void AddSlot(RuntimeAnimatorController _item){

       

           Container.Add(new AnimatorSlot(_item, 0, false, "new alter"));
       
   }
   public void UsedAlter(int i){

           Container[i].AddUsed(true);
   }
   public void IndexAlter(int i){

           Container[i].AddIndex(i);
   }
    public void NameAlter(int i){

           Container[i].AddName("new alter");
   }
}

[System.Serializable]
public class AnimatorSlot{

        public RuntimeAnimatorController _animator;
        public bool CanBeUsed;
        public int index;
        public string name;
        public AnimatorSlot(RuntimeAnimatorController _anim, int _index, bool _CanBeUsed, string _name){

            _animator=_anim;
            CanBeUsed=_CanBeUsed;
            index=_index;
            name=_name;
        }
        public void AddUsed(bool value){

                CanBeUsed=value;
        }
        public void AddIndex(int value){

                index=value;
        }
        public void AddName(string value){

                name=value;
        }
        
}
