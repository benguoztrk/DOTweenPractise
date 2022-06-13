using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenPractiseShape : MonoBehaviour
{
     public Transform innerShape, outerShape;
     public float time = 2f;



    void Start()
    {
        transform.DOMove(new Vector3(10, 0, 0), time).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
       
        innerShape.DORotate(new Vector3(0, 360, 0), time * 0.5f,RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);

        //innerShape.DOMove(new Vector3(0, -5, 0), time * 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo); //Use DOLocalMove instead. That way it moves according to parent's position


        innerShape.DOLocalMove(new Vector3(-14.62345f, -10,-6.31f),time).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);


    }


}
