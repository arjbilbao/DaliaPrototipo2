using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardsMovement : MonoBehaviour
{
     [SerializeField]
	float moveSpeed = 5f;

    [SerializeField]
	float amplitude = 7f;

    public float waitingTime;
	bool facingRight = true;
	public bool patroll = false;
	public bool chase = false;
	public bool startChasing =false;
    private float counting;
    private Animator _animator;

	Vector3 pos, org,localScale;
	
     [SerializeField]
	public GameObject _target;

	// Use this for initialization
	void Start () {
		
		pos = transform.position;
		org = transform.position;
        _animator = GetComponent<Animator>();
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
		if (pos.x <= -amplitude+org.x)
        {

            facingRight = true;
            _animator.SetBool("Run",false);
			_animator.SetBool("Idle",true);
            StopCoroutine("Movement");
            StartCoroutine("IdleTime");
        
        }
			
		
		else if (pos.x >= amplitude+org.x)
        {
                facingRight = false;
                _animator.SetBool("Run",false);
			_animator.SetBool("Idle",true);
             StopCoroutine("Movement");
              StartCoroutine("IdleTime");
        }
			

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos;
	}

	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos;

        }

	public void MoveToTarget()
	{
		Vector2 direction = _target.transform.position - transform.position;
			float xDirection = direction.x;
		transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
		
	}

	private IEnumerator IdleTime()
    {       
           while(counting<waitingTime)
           {
                counting+=Time.deltaTime;
                yield return null;
           }
            StopCoroutine("IdleTime");
           StartCoroutine("Movement");
           counting=0f;

    }

	public IEnumerator Movement()
	{
		
			while(patroll)
			{

				if (facingRight)
					{MoveRight ();
                     _animator.SetBool("Run",true);
			        _animator.SetBool("Idle",false);}
            
			
				else
                
                {MoveLeft ();
                 _animator.SetBool("Run",true);
			    _animator.SetBool("Idle",false);}
			
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
