using UnityEngine;
using System.Collections.Generic;

public class ExplodableFragments : ExplodableAddon{

    public LayerMask _ground;
    public override void OnFragmentsGenerated(List<GameObject> fragments)
    {
        foreach (GameObject fragment in fragments)
        {
            Explodable fragExp = fragment.AddComponent<Explodable>();
			//fragment.AddComponent<ExplodeOnClick>();
            fragment.AddComponent<DisapearingFragments>();
            this.gameObject.layer=_ground;

            fragExp.shatterType = explodable.shatterType;
            fragExp.fragmentLayer = explodable.fragmentLayer;
            fragExp.sortingLayerName = explodable.sortingLayerName;
            fragExp.orderInLayer = explodable.orderInLayer;

            

            fragExp.fragmentInEditor();
            
        }
    }
}
