using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearsMovement : MonoBehaviour
{
     [SerializeField]
	float moveSpeed = 5f;

	[SerializeField]
	float frequency = 20f;

	[SerializeField]
	float magnitude = 0.5f;

    [SerializeField]
	float amplitude = 7f;


	bool facingRight = true;
	public bool patroll = false;
	public bool chase = false;
	public bool startChasing =false;

	Vector3 pos, org,localScale;
	
     [SerializeField]
	public GameObject _target;

	// Use this for initialization
	void Start () {
		
		pos = transform.position;
		org = transform.position;

		localScale = transform.localScale;
		StartCoroutine("Movement");

		

	}
	
	// Update is called once per frame
	void Update () {
		
		CheckWhereToFace ();
		

		if(startChasing)
		{	
			startChasing = false;
			chase=true;
			patroll=false;

		moveSpeed=moveSpeed*2f;
			StartCoroutine("Chasing");
			
			
		}
		
	}

	void CheckWhereToFace()
	{
		if (pos.x < -amplitude+org.x)
			facingRight = true;
		
		else if (pos.x > amplitude+org.x)
			facingRight = false;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}

	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}

	public void MoveToTarget()
	{
		Vector2 direction = _target.transform.position - transform.position;
			float xDirection = direction.x;
		transform.Translate((direction.normalized+new Vector2(0,Mathf.Sin(Time.time * frequency) * magnitude)) * moveSpeed * Time.deltaTime);
		
	}

	

	public IEnumerator Movement()
	{
		
			while(patroll)
			{

				if (facingRight)
					MoveRight ();
			
				else
				MoveLeft ();
			
				yield return null;
			}
		


			if(!patroll)
			{

				StopCoroutine("Movement");
			}

	}

	public IEnumerator Chasing()
	{		

			
			while(chase)
			{
				MoveToTarget();
				yield return null;

			}

			if(!chase)
			{
					moveSpeed=moveSpeed/2f;
				StopCoroutine("Chasing");
			}

			

	}
	

}
