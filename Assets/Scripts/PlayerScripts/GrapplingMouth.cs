using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingMouth : MonoBehaviour
{      public GameObject _player;
        public SpriteRenderer _spriteRenderer;
      
        public Sprite _closedMouth, _openMouth;
        public LayerMask GrapplingLayer;
    [Header("Scripts Ref:")]
    public GrapplingTongue grappleRope;

    [Header("Layers Settings:")]
    [SerializeField] private bool grappleToAll = false;
    [SerializeField] private int grappableLayerNumber = 9;

    [Header("Main Camera:")]
    public Camera m_camera;

    [Header("Transform Ref:")]
    public Transform gunHolder;
    public Transform gunPivot;
    public Transform firePoint;

    [Header("Physics Ref:")]
    public SpringJoint2D m_springJoint2D;
    public Rigidbody2D m_rigidbody;

    [Header("Rotation:")]
    [SerializeField] private bool rotateOverTime = true;
    [Range(0, 60)] [SerializeField] private float rotationSpeed = 4;

    [Header("Distance:")]
    [SerializeField] private bool hasMaxDistance = false;
    [SerializeField] private float maxDistnace = 20;

    private enum LaunchType
    {
        Transform_Launch,
        Physics_Launch
    }

    [Header("Launching:")]
    [SerializeField] private bool launchToPoint = true;
    [SerializeField] private LaunchType launchType = LaunchType.Physics_Launch;
    [SerializeField] private float launchSpeed = 1;

    [Header("No Launch To Point")]
    [SerializeField] private bool autoConfigureDistance = false;
    [SerializeField] private float targetDistance = 3;
    [SerializeField] private float targetFrequncy = 1;

    [HideInInspector] public Vector2 grapplePoint;
    [HideInInspector] public Vector2 grappleDistanceVector;

    public bool breakable;
    private float breakingtimer;

    private void Start()
    {
        grappleRope.enabled = false;
        m_springJoint2D.enabled = false;
        _spriteRenderer.enabled=false;

    }

    private void Update()
    {       if( _player.GetComponent<MainPlayerController>()._alter=="Lagartha"){
                        transform.rotation = transform.parent.rotation;
        if (_player.GetComponent<MainPlayerController>()._isTonguelaunched)
        {
            SetGrapplePoint();
            _player.GetComponent<MainPlayerController>()._isTonguelaunched=false;
           
        }
        else if (_player.GetComponent<MainPlayerController>()._isTongueHeld)

        {       
            if(breakable==false){
                     _player.GetComponent<MainPlayerController>()._isHooked=true;
                    _player.GetComponent<MainPlayerController>()._animator.SetBool("Hanging",true);
                     _spriteRenderer.enabled=true;
                    _spriteRenderer.sprite=_openMouth;
        
                    if (grappleRope.enabled)
                    {
                        RotateGun(grapplePoint, false);
                    }
                    else
                    {
                //Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
                //RotateGun(mousePos, true);
                    }

                    if (launchToPoint && grappleRope.isGrappling)
                    {
                    if (launchType == LaunchType.Transform_Launch)
                    {
                    Vector2 firePointDistnace = firePoint.position - gunHolder.localPosition;
                    Vector2 targetPos = grapplePoint - firePointDistnace;
                    gunHolder.position = Vector2.Lerp(gunHolder.position, targetPos, Time.deltaTime * launchSpeed);
                    }
                }
            }

            else if(breakable){
                _player.GetComponent<MainPlayerController>()._isHooked=false;
                      _spriteRenderer.enabled=true;
                        _spriteRenderer.sprite=_openMouth;
                         if (grappleRope.enabled)
                        {
                         RotateGun(grapplePoint, false);
                        }
                        else
                        {
                //Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
                //RotateGun(mousePos, true);
                        }

                        if (launchToPoint && grappleRope.isGrappling)
                        {
                         if (launchType == LaunchType.Transform_Launch)
                        {
                        Vector2 firePointDistnace = firePoint.position - gunHolder.localPosition;
                        Vector2 targetPos = grapplePoint - firePointDistnace;
                        gunHolder.position = Vector2.Lerp(gunHolder.position, targetPos, Time.deltaTime * launchSpeed);
                        breakingtimer+=Time.deltaTime;

                        if(breakingtimer>=1f)
                        {
                            breakingtimer=0f;
                        _player.GetComponent<MainPlayerController>()._isTongueHeld=false;
                        
                        }
                        }
            }
                        

            }
           
           
        }
        else if (_player.GetComponent<MainPlayerController>()._isTongueHeld==false)
        {    _player.GetComponent<MainPlayerController>()._isHooked=false;
         _player.GetComponent<MainPlayerController>()._animator.SetBool("Hanging",false);


         _spriteRenderer.enabled=false;
            grappleRope.enabled = false;
            m_springJoint2D.enabled = false;
            m_rigidbody.gravityScale = 1;
        }
        else
        {
            //Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            //RotateGun(mousePos, true);
        }
        }
    }

    void RotateGun(Vector3 lookPoint, bool allowRotationOverTime)
    {
        Vector3 distanceVector = lookPoint - gunPivot.position;

        float angle = Mathf.Atan2(distanceVector.y, distanceVector.x) * Mathf.Rad2Deg;
        if (rotateOverTime && allowRotationOverTime)
        {
            gunPivot.rotation = Quaternion.Lerp(gunPivot.rotation, Quaternion.AngleAxis(angle, Vector3.forward), Time.deltaTime * rotationSpeed);
        }
        else
        {
            gunPivot.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    void SetGrapplePoint()
    {
        

        //RaycastHit2D _proof = Physics2D.CircleCast(gunPivot.position,maxDistnace,new Vector2(0,1),9);
        //Debug.Log("the collider name is: "+_proof.transform.name);
        if(Physics2D.OverlapCircle(gunPivot.position,maxDistnace,GrapplingLayer))
        {
                     Collider2D other = Physics2D.OverlapCircle(gunPivot.position,maxDistnace,GrapplingLayer);
       
        Vector2 distanceVector = other.gameObject.transform.position-firePoint.position;
        //Vector2 distanceVector = m_camera.ScreenToWorldPoint(Input.mousePosition) - gunPivot.position;

                                if(other.gameObject.tag=="Lamp")
                                {
                                    breakable=true;
                                }
                                else{
                                    breakable=false;
                                }

                            if (other.gameObject.layer == grappableLayerNumber)
            {    
                
                 
                
                if (Vector2.Distance(other.gameObject.transform.position, firePoint.position) <= maxDistnace || !hasMaxDistance)
                {       Debug.Log("The distance is "+Vector2.Distance(other.gameObject.transform.position, firePoint.position));
                    grapplePoint = other.gameObject.transform.position;
                    Debug.Log("The hitpoint is "+other.gameObject.transform.position);
                    grappleDistanceVector = grapplePoint - (Vector2)gunPivot.position;
                    grappleRope.enabled = true;
                     if(other.gameObject.tag=="Lamp")
                {
                      other.gameObject.GetComponent<LampBehavior>().broken=true;
                }
                    
                }
            }



                if (Physics2D.Raycast(firePoint.position, distanceVector.normalized,maxDistnace,grappableLayerNumber))
        {                Debug.Log("hitting");
            
            RaycastHit2D _hit = Physics2D.Raycast(firePoint.position, distanceVector.normalized);
                                 

            if (_hit.transform.gameObject.layer == grappableLayerNumber)
            {    

                
                if (Vector2.Distance(_hit.point, firePoint.position) <= maxDistnace || !hasMaxDistance)
                {       Debug.Log("The distance is "+Vector2.Distance(_hit.point, firePoint.position));
                    grapplePoint = _hit.point;
                    Debug.Log("The hitpoint is "+_hit.transform.gameObject.tag);
                    if(_hit.transform.gameObject.tag=="Lamp")
                {
                        _hit.transform.gameObject.GetComponent<LampBehavior>().broken=true;
                }
                    grappleDistanceVector = grapplePoint - (Vector2)gunPivot.position;
                    grappleRope.enabled = true;
                    
                }
            }
        }

        }

        else {Debug.Log("No Grappling Point");}
       



        
        

        
    }

    public void Grapple()
    {

        if(breakable==false){

                 m_springJoint2D.autoConfigureDistance = false;
        if (!launchToPoint && !autoConfigureDistance)
        {
            m_springJoint2D.distance = targetDistance;
            m_springJoint2D.frequency = targetFrequncy;
        }
        if (!launchToPoint)
        {
            if (autoConfigureDistance)
            {
                m_springJoint2D.autoConfigureDistance = true;
                m_springJoint2D.frequency = 0;
            }

            m_springJoint2D.connectedAnchor = grapplePoint;
            m_springJoint2D.enabled = true;
        }
        else
        {
            switch (launchType)
            {
                case LaunchType.Physics_Launch:
                    m_springJoint2D.connectedAnchor = grapplePoint;

                    Vector2 distanceVector = firePoint.position - gunHolder.position;

                    m_springJoint2D.distance = distanceVector.magnitude;
                    m_springJoint2D.frequency = launchSpeed;
                    m_springJoint2D.enabled = true;
                    break;
                case LaunchType.Transform_Launch:
                    m_rigidbody.gravityScale = 0;
                    m_rigidbody.velocity = Vector2.zero;
                    break;
            }
        }
        }
       
    }

    private void OnDrawGizmos()
    {
        if (firePoint != null && hasMaxDistance)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(firePoint.position, maxDistnace);
        }
    }

}
