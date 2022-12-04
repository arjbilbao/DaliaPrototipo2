using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	public Explodable _explodable;

	void Start()
	{
		_explodable=GetComponent<Explodable>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag=="Door")
		{
			if(other.gameObject.GetComponentInParent<MainPlayerController>()._alter=="The Prisoner")
			{
					_explodable.explode();
		ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
		//ef.doExplosion(transform.position);
			}
		
		}
		
	}
}
