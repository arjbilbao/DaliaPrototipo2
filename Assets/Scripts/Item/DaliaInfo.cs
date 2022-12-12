using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaliaInfo : MonoBehaviour
{   
    public SO_Dalia _dalia;
    public SO_SoundtrackManager SM;
    public AudioClip _clip;
    public Sprite Pic, BG;
    public SO_AlterAnimator _AlterAnimator;
    public LevelAdvanceSO level;
    public LevelAdvanceChanger levelChanger;
    public SO_TileData tile;
    public SO_TilesSlot tileSlot;

    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){

        if(other.tag=="Player"){

            _AlterAnimator.AddSlot(_dalia._animator);

            for(int i=0; i<_AlterAnimator.Container.Count;i++){
                        if(_AlterAnimator.Container[i].name=="new alter")
                        {       _AlterAnimator.Container[i].name=_dalia._alter;
                               _AlterAnimator.Container[i].index=i;
                               _AlterAnimator.Container[i].CanBeUsed=true;
                               _AlterAnimator.Container[i].Pic=Pic;
                               _AlterAnimator.Container[i].BackGround=BG;
                               _AlterAnimator.Container[i].Tile=tile;

                               Destroy(this.gameObject);
                        }
            }

            SM.Soundtracks.Add(_clip);
            tileSlot.tiles.Add(tile);
            other.gameObject.GetComponent<MainPlayerController>().AlterIndexation();


        }
    }

    private void OnDestroy() 
    {
       levelChanger.SetLevel(level);
    }
}
