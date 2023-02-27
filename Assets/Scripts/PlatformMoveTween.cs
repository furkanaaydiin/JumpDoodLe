using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMoveTween : MonoBehaviour
{

    public Transform positionaralık; 
    public GameObject metor; 
    private void Awake() 
    { 
        metor.transform.DOMove(positionaralık.position , 2).SetLoops(-1,LoopType.Yoyo); 
    }
}
