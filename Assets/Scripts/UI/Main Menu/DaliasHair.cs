using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaliasHair : MonoBehaviour
{
    public int length;
    public LineRenderer lineRend;
    public Vector3 [] segmentPoses;
    public Vector3[] segmentV;
    public Transform targetDir,dot;
    public float targetDist;
    public float smoothSpeed;

    private void Start() 
    {
        lineRend.positionCount = length;
        segmentPoses = new Vector3[length];
        segmentV= new Vector3[length];
    }

    private void Update() 
    {
        segmentPoses[0] =dot.position;
         segmentPoses[1] =targetDir.position;
        for(int i =2;i< segmentPoses.Length;i++)
        {
                segmentPoses[i]=Vector3.SmoothDamp(segmentPoses[i], segmentPoses[i-1]+ targetDir.right*targetDist, ref segmentV[i],smoothSpeed);
        }
        lineRend.SetPositions(segmentPoses);
    }
}
