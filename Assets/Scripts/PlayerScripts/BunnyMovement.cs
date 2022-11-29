using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMovement : MonoBehaviour
{

     private Rigidbody2D _rb;
     public float _speed;
     public Transform groundCheck;
     public float groundCheckRadius=0.02f;
     public LayerMask groundLayer;
     [SerializeField]
     private bool _isGrounded;
     private GameObject Foot;
    // Start is called before the first frame update
    
  void Awake() 
    {
       Foot = GameObject.FindWithTag("Foot");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   GroundChecker();
        Movement();
    }
     private void GroundChecker()
    {

                 _isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,groundLayer);
                 
    }
    private void Movement()
    {       
        Vector2 footPosition = new Vector2(Foot.transform.position.x,transform.position.y);
        Vector2 bunnyPosition = new Vector2(transform.position.x,transform.position.y);

        if(_isGrounded){
    
            transform.position= Vector2.MoveTowards(bunnyPosition, footPosition, _speed * Time.deltaTime);
        }
         if(bunnyPosition.x<footPosition.x)
                            {
                                transform.rotation = Quaternion.Euler(0f,0f,0f);
                            }
                            else 
                            {
                                transform.rotation = Quaternion.Euler(0f,180f,0f);
                            }
    }

    void OnTriggerEnter2D(Collider2D other) {
       if(other.tag=="Foot")
       {
        GameObject _player = GameObject.FindWithTag ("Player");
        _player.GetComponent<MainPlayerController>()._animator.SetBool("IsPantuflaOn",true);
        _player.GetComponent<MainPlayerController>()._isPantuflaOn=true;
        Destroy(this.gameObject);
       }
    }
}
