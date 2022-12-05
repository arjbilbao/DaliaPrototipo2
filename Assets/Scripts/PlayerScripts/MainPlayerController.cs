 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;


public class MainPlayerController : MonoBehaviour
{   //Global variables
        public GameStateChanger GSC;
        public bool _paused=false;
        public GameStateSO _pausedStated;
        public SO_GlobalAlterManager GAA;
        public GrapplingMouth grappling;
        private Controls controls;
        private Vector2 leftstick;
        private Rigidbody2D rb;
        public float speed, _climbingSpeed;
        public Transform groundCheck;
        public Transform wallCheck;
        public float groundCheckRadius;
        public LayerMask groundLayer, wallLayer;
        public float jumpForce;
        public SO_AlterAnimator SO_AlterAnimator;
        public float _BreakTimer=0f;
        [SerializeField]
        private bool _isGrounded, _isOnWall;
         [HideInInspector]
        public Animator _animator;
      
        
        [HideInInspector]
        public float _jumpsAvailable, _maxJumps=1;
         [HideInInspector]
        public int alterIndex;
        public string _alter;
         [HideInInspector]
        public bool _isHooked;

        public SpriteMask Vision;
        public bool _isTonguelaunched, _isTongueHeld,_isPantuflaOn;
        public bool _isRat=false;
        [SerializeField]
        private GameObject prefab;
        [SerializeField]
          public Transform LaunchPoint;



    
    private void Awake() 
    {   
        
        controls = new Controls(); 
    }
    void Start()
    {     

       
        alterIndex=GAA.AlterIndex;
       
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _isPantuflaOn=true;
          _animator.SetBool("IsPantuflaOn",true);
           

          AlterChanger();

        //Input System Callings ---------------------------------
        
            controls.Pcontroller.LeftStick.performed += ctx => leftstick = ctx.ReadValue<Vector2>();
         controls.Pcontroller.LeftStick.canceled += ctx => leftstick = new Vector2(0f,0f);
         controls.Pcontroller.South.performed += ctx => Jumping();
         controls.Pcontroller.North.performed += ctx => AlterIndexation();

          controls.Pcontroller.RB.started += ctx => _isTonguelaunched = true;
          
          controls.Pcontroller.RB.started += ctx => _isTongueHeld = true;
          controls.Pcontroller.RB.canceled += ctx => _isTongueHeld = false;



          controls.Pcontroller.East.performed += ctx => SpecialSkillController();
          controls.Pcontroller.East.canceled += ctx => DoctorsVision();

          
          controls.Pcontroller.West.performed += ctx => Attacking();
          controls.Pcontroller.West.canceled += ctx =>speed=150f;
          controls.Pcontroller.West.canceled += ctx =>_BreakTimer=0f;


        
        
          controls.Pcontroller.Menu.performed += ctx => Pausing();
          
        // ------------------------------------------------------
    }

    void Update()
    {   GAA.CurrentAlter =_alter;

    if(_paused==false)
    {
        GroundChecker();
        AlterSkillsManager();

    }
        
        
    }

    void FixedUpdate()
    {
            
          if(_paused==false)
          {
                Running();
        WallClimber();

          }  
    
        
            
        
    }

     void LateUpdate()
    {   if(_paused==false)
    {
            AnimatorMachineState();
    }
        
    }


    // Method called for character basic movement ---> Running.
    private void Running()
    {
            
        
        if((_isTongueHeld==false&&_isRat==false)||_isTongueHeld&&grappling.breakable)
            {
                rb.velocity=new Vector2 (leftstick.x*speed*Time.deltaTime, rb.velocity.y) ;
            }


        if(_isTongueHeld&&grappling.breakable==false)
        {
            rb.velocity=new Vector2 (leftstick.x*speed*0.1f*Time.deltaTime+rb.velocity.x, rb.velocity.y) ;

        }
        if(_isRat)
        {
            rb.velocity=new Vector2(0f,0f);
        }
        
    }
    // Method called for character basic movement ---> Jumping
    private void Jumping()
    {

       

        if(_isGrounded||(_isGrounded!&&_isOnWall))
        {

             _jumpsAvailable=_maxJumps;
        }

        if(_jumpsAvailable>0&&_isOnWall==false)
        {
                rb.AddForce(Vector2.up*(jumpForce-rb.velocity.y) , ForceMode2D.Impulse);
                _jumpsAvailable-=1;
            
        }
     

        if(_jumpsAvailable>0&&_isOnWall)
        {       Vector2 move = new Vector2 (1f,0f);
                rb.AddForce(move*(jumpForce), ForceMode2D.Impulse);
                _jumpsAvailable-=1;
            
        }
    }

    private void TongueHodling()
    {

            _isTongueHeld=true;
    }
   

    private void WallClimber()
    {

        if(_isOnWall&&SO_AlterAnimator.Container[alterIndex].name=="Lagartha")
        {       
            if(leftstick.y!=0)
            {
                    rb.velocity=new Vector2 (rb.velocity.x, leftstick.y*_climbingSpeed*Time.deltaTime) ;
            }
            else 
            {
                rb.velocity=new Vector2 (rb.velocity.x, -rb.velocity.y);
            }
                

        }
    }
    private void WallChecker()
    {       
        _isOnWall = Physics2D.OverlapCircle(wallCheck.position,groundCheckRadius,wallLayer);
    }
    private void GroundChecker()
    {

                 _isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,groundLayer);
    }
    private void AnimatorMachineState()
    {
            if(_isGrounded)
            {
                     if(leftstick.x!=0&&_isRat==false)
                    {
                            _animator.SetBool("Idle",false);
                            _animator.SetBool("Run",true);

                            if(leftstick.x<0)
                            {
                                transform.rotation = Quaternion.Euler(0f,180f,0f);
                            }
                            else if(leftstick.x>0)
                            {
                                transform.rotation = Quaternion.Euler(0f,0f,0f);
                            }
                    }
                    else if (leftstick.x==0||_isRat)
                    {
                            _animator.SetBool("Idle",true);
                            _animator.SetBool("Run",false);
                    }
            }

            else
            {
                            _animator.SetBool("Idle",true);
                            _animator.SetBool("Run",false);
            }
       
    }

  
    private void AlterChanger()
    {
            _animator.runtimeAnimatorController =SO_AlterAnimator.Container[alterIndex]._animator;
            _alter = SO_AlterAnimator.Container[alterIndex].name;
            GAA.Changing=true;
             
    }
    private void AlterIndexation()
    {
        alterIndex+=1;
        if(alterIndex>(SO_AlterAnimator.Container.Count-1))
        {
            alterIndex=0;
        }
        GAA.AlterIndex=alterIndex;
        AlterChanger();
    }

    private void AlterSkillsManager()
    {
        //OnJumping
        if(_alter=="The Prisoner"){
            _maxJumps=2;
        }
        else{ _maxJumps=1;}

        if(_alter=="Lagartha")
        {
            WallChecker();
        }
        
    }

    private void SpecialSkillController()
    {

        if(_alter=="The Outcast")
        {
            RatSwitching();
        }
        if(_alter=="The Doctor")
        {
                Vision.enabled=true;
        }
    }

    private void DoctorsVision()
    {
            if(_alter=="The Doctor")
            {
                Vision.enabled=false;
            }
        
    }
   

    public void RatSwitching()
    {
            if(_alter=="The Outcast")
            {
            if(_isRat==false)
        {
          

                        GameObject RAT= GameObject.FindWithTag("Rat");
                        if(RAT!=null)
                        {
                              _isRat=true;
                             GameObject vcam = GameObject.FindWithTag("Vcam");
                       var cam = vcam.GetComponent<CinemachineVirtualCamera>();
                       cam.m_Lens.OrthographicSize=0.8f;
                       cam.Follow = RAT.transform; 
                        }
                        else
                        {
                            _isRat=false;
                        }
                        
        } else if(_isRat==true)
        {
            _isRat=false;
            GameObject vcam = GameObject.FindWithTag("Vcam");
                       var cam = vcam.GetComponent<CinemachineVirtualCamera>();
                       cam.m_Lens.OrthographicSize=1.5f;
                       cam.Follow = this.transform; 
        }

            }
        
    }
    private void Attacking()
    {
        if(_alter=="Dalia"&&_isPantuflaOn)
        {

            _animator.SetTrigger("Attack");
            
        }
        if(_alter=="The Prisoner")
        {
                speed=300f;
                _BreakTimer=+Time.deltaTime;
        }

    }
    private void Launching()
    {
           
            _animator.SetBool("IsPantuflaOn",false);
            _isPantuflaOn=false;
             _animator.ResetTrigger("Attack");
            Shoot();

    }
    private void Shoot()
	{
        if(prefab!=null)
        {
                GameObject BunnyBullet = Instantiate(prefab, LaunchPoint.position, Quaternion.identity) as GameObject;

			BunnyBullet BunnyComponent = BunnyBullet.GetComponent<BunnyBullet>();

			if (transform.rotation.y != 0f) {
				// Left
                Debug.Log("Lanzando a La Izquierda");
				BunnyComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else  {
				// Right
                Debug.Log("Lanzando a La Derecha");
				BunnyComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}

        }
			
		
	}

    private void Pausing()
    {

        if(_paused==false)
        {
            GSC.SetGameState(_pausedStated);
            _paused=true;
        }
         else if(_paused==true)
        {
            GSC.RestorePreviousState();
            _paused=false;
        }
    }
    public void BackFromPause()
    {
        _paused=false;
    }
    private void OnEnable() 
    {
        controls.Enable(); 
    }
    private void OnDisable() 
    {
        controls.Disable(); 
    }
}
