using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSOs : MonoBehaviour
{       

    public SO_GlobalAlterManager GAM;
    public SO_AlterAnimator AA;
    public RuntimeAnimatorController Animator;
    public Sprite PIC, BG;
    public SO_TileData TileData;
    public SO_SoundtrackManager SM;
    public AudioClip clip;
    public SO_TilesSlot TS;
    // Start is called before the first frame update
    public void ResetAll()
    {

        GAM.CurrentAlter="Eliad";
        GAM.AlterIndex =0;
        GAM.Changing=true;

        AA.Container.Clear();
        AA.Container.Add(new AnimatorSlot(Animator, 0, false, "Eliad", PIC, BG, TileData));
        SM.Soundtracks.Clear();
        SM.Soundtracks.Add(clip);
        TS.tiles.Clear();
        TS.tiles.Add(TileData);


    }


}
