using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class RatController : MonoBehaviour
{       private Controls controls;
        private Vector2 leftstick;
        public Transform groundCheck, wallCheck;
        public float groundCheckRadius;
        public LayerMask groundLayer, ClimberLayer, RatGroundLayer;
        public float jumpForce;
        private Rigidbody2D rb;
        public float speed, _climbingSpeed;
        public MainPlayerController _mPC;
        public bool _isGrounded, _isRatGrounded, _isOnWall;
        private bool _hasRatLeft;
        public GameObject RatClimber, RatGround;
        public float ratGroundTimer;
    // Start is called before the first frame update

     private void Awake() 
    {   
        
        controls = new Controls(); 
        GameObject player = GameObject.FindWithTag("Player");
        _mPC=player.GetComponent<MainPlayerController>();
        RatClimber = GameObject.FindWithTag("RatClimber");
        RatGround = GameObject.FindWithTag("RatGround");
    }
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        //Input System Callings ---------------------------------
         controls.Pcontroller.LeftStick.performed += ctx => leftstick = ctx.ReadValue<Vector2>();
         controls.Pcontroller.LeftStick.canceled += ctx => leftstick = new Vector2(0f,0f);
         controls.Pcontroller.South.performed += ctx => Jumping();
    }

    // Update is called once per frame
    void Update()
    {
        GroundChecker();
        RatGroundController();
        WallChecker();
    }
    void FixedUpdate() 
    {
        Running();
        WallClimber();
     
        
    }
    void LateUpdate()
    {

        AnimatorMachineState();
    }

    void Jumping()
    {
             if(_isGrounded||_isRatGrounded)
        {

             rb.AddForce(Vector2.up*(jumpForce-rb.velocity.y) , ForceMode2D.Impulse);
        }

    }
    private void GroundChecker()
    {

                 _isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,groundLayer);
                 
    }
    private void RatGroundController()
    {
            
        if(_hasRatLeft)
        {
                _isRatGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,RatGroundLayer);
                if(_isRatGrounded==false)
                {
                    ratGroundTimer+=Time.deltaTime;
                        if(ratGroundTimer>=2f)
                        {
                                _hasRatLeft=false;
                                 RatGround.GetComponent<BoxCollider2D>().isTrigger=true;
                                 ratGroundTimer=0f;
                        }
                }
        }
    }
     private void Running()
    {
            
        
        if(_mPC._isRat)
            {
                rb.velocity=new Vector2 (leftstick.x*speed*Time.deltaTime, rb.velocity.y) ;
            }
            else{
                
                rb.velocity=new Vector2 (0f,0f);
            }

        
    }
    private void WallClimber()
    {

        if(_isOnWall)
        {       
            if(leftstick.y!=0)
            {
                    rb.velocity=new Vector2 (leftstick.x*speed*Time.deltaTime, leftstick.y*_climbingSpeed*Time.deltaTime) ;
            }
            else 
            {
                rb.velocity=new Vector2 (rb.velocity.x, rb.velocity.y);
            }
                

        }
    }
    private void WallChecker()
    {       
        _isOnWall = Physics2D.OverlapCircle(wallCheck.position,groundCheckRadius,ClimberLayer);
    }

    private void AnimatorMachineState()
    {
            if(_isGrounded)
            {
                     if(leftstick.x!=0)
                    {
                            //_animator.SetBool("Idle",false);
                            //_animator.SetBool("Run",true);

                            if(leftstick.x<0)
                            {
                                transform.rotation = Quaternion.Euler(0f,0f,0f);
                            }
                            else if(leftstick.x>0)
                            {
                                transform.rotation = Quaternion.Euler(0f,180f,0f);
                            }
                    }
                
            }

          
       
    }
      private void OnEnable() 
    {
        controls.Enable(); 
    }
    private void OnDisable() 
    {
        controls.Disable(); 
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if(other.tag=="RatClimber")
        {
               WallChecker();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if(other.tag=="RatGround")
        {
               
                RatGround.GetComponent<BoxCollider2D>().isTrigger=false;
                _hasRatLeft=true;
        }
    }
}
