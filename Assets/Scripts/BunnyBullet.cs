using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBullet : MonoBehaviour
{
	public float speed = 2f;
	public Vector2 direction;

	public float livingTime = 3f;

	private float _startingTime;

     [SerializeField]
        private GameObject prefab;
      

	void Awake()
	{
		
	}

	// Start is called before the first frame update
	void Start()
    {
		//  Save initial time
		_startingTime = Time.time;

		// Destroy the bullet after some time
		Destroy(gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
		//  Move object
		Vector2 movement = direction.normalized * speed * Time.deltaTime;
		transform.Translate(movement);

	
    }
   void OnDestroy() 
   {
        GameObject Bunny = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
    }
}

