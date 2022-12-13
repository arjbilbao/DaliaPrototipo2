using UnityEngine;
using System.Collections;
using ScriptableObjectArchitecture;

[RequireComponent(typeof(Explodable))]
public class ExplodeOnClick : MonoBehaviour {
	 [Header("Broadcasting on channels")]
        public BoolGameEvent Breaking;
		public BoolGameEvent StopRunning;
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
			
				if(_alter=="The Prisoner"&&_thisIsTime>=0.05f&&other.gameObject.GetComponentInParent<MainPlayerController>()._isGrounded&&this.gameObject.tag!="Platform")
				{
					Debug.Log ("El Alter es "+ _alter);

					_explodable.explode();
					ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
					Breaking.Raise(true);
				
						//ef.doExplosion(transform.position);
				}

				if(_alter=="The Prisoner"&&other.gameObject.GetComponentInParent<MainPlayerController>()._canBreakGround==true)
				{	GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
						_explodable.explode();
					ExplosionForce ef = GameObject.FindObjectOfType<ExplosionForce>();
					Breaking.Raise(true);
					

				}
				
			
		
		}
		
	}
}
