using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {

	public Explodable _explodable;
	private float _thisIsTime,_highJump;

	void Start()
	{
		_explodable=GetComponent<Explodable>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag=="BreakableChecker")
		{		
			
			_thisIsTime = other.gameObject.GetComponentInParent<MainPlayerController>()._BreakTimer;
			_highJump = other.gameObject.GetComponentInParent<MainPlayerController>()._jumpsAvailable;
			
				string _alter = other.gameObject.GetComponentInParent<MainPlayerController>()._alter;
			
				if(_alter=="The Prisoner"&&_thisIsTime>=0.05f)
				{
					Debug.Log ("El Alter es "+ _alter);

					_explodable.explode();
					ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
						//ef.doExplosion(transform.position);
				}
				
			
		
		}
		
	}
}
