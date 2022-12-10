using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
	public float speed = 1f;
	public float minX;
	public float maxX;
	public Animator _animator;
	public float waitingTime = 2f;

	private GameObject _target;
	public BoxCollider2D PatrollArea;
	public GameObject PatrollCenter;


    // Start is called before the first frame update
    void Start()
    {	 _animator = GetComponent<Animator>();
			Centering();
		UpdateTarget();
		StartCoroutine("PatrolToTarget");
	}

    // Update is called once per frame
    void Update()
    {
        
    }


	private void UpdateTarget()
	{
		// If first time, create target in the left
		if (_target  == null) {
			_target = new GameObject("Target");
			_target.transform.position = new Vector2(minX, transform.position.y);
			transform.localScale = new Vector3(-1, 1, 1);
			return;
		}

		// If we are in the left, change target to the right
		if (_target.transform.position.x == minX) {
			_target.transform.position = new Vector2(maxX, transform.position.y);
			transform.localScale = new Vector3(1, 1, 1);
		}

		// If we are in the right, change target to the left
		else if (_target.transform.position.x == maxX) {
			_target.transform.position = new Vector2(minX, transform.position.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}
	}

	private IEnumerator PatrolToTarget()
	{
		// Coroutine to move the enemy
		while(Vector2.Distance(transform.position, _target.transform.position) > 0.05f) {
			// let's move to the target
			Vector2 direction = _target.transform.position - transform.position;
			float xDirection = direction.x;

			transform.Translate(direction.normalized * speed * Time.deltaTime);
			 _animator.SetBool("Run",true);
			_animator.SetBool("Idle",false);

			// IMPORTANT
			yield return null;
		}

		// At this point, i've reached the target, let's set our position to the target's one
		Debug.Log("Target reached");
			_animator.SetBool("Run",false);
			_animator.SetBool("Idle",true);
		transform.position = new Vector2(_target.transform.position.x, transform.position.y);
			
		// And let's wait for a moment
		
		yield return new WaitForSeconds(waitingTime); // IMPORTANT

		// once waited, let's restore the patrol behaviour
	
		UpdateTarget();
		StartCoroutine("PatrolToTarget");
	}


	void Centering(){

      

        minX=PatrollCenter.transform.position.x-(PatrollArea.size.x/2)+0.5f;
        maxX=PatrollCenter.transform.position.x+(PatrollArea.size.x/2)-0.5f;

       
      
      
    }
}
