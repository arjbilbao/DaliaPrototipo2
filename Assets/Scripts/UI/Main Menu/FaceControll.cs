using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceControll : MonoBehaviour
{       

    public SpriteRenderer _spRenderer1, _spRenderer2, _spriteRenderer3;
    public Sprite _mouthClosed, _faceClosed, _faceOpened,_mouthOpened;
    // Start is called before the first frame update


    public void CloseMouth()
    {
        _spRenderer1.sprite = _mouthClosed;
         _spRenderer1.sprite = _faceClosed;
    }
    public void OpenMouth()
    {
        _spRenderer1.sprite = _mouthOpened;
        _spRenderer2.sprite = _faceOpened;
        _spriteRenderer3.enabled=true;
    }
}
