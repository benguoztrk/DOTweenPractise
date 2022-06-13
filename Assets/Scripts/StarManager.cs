using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StarManager : MonoBehaviour
{

    public Transform[] stars;

   
    void Start()
    {
        //Bad way
        //stars[0].DOMoveX(5, Random.Range(1f, 2f)).OnComplete(() =>
        //{
        //    stars[1].DOMoveX(5, Random.Range(1f, 2f)).OnComplete(() =>
        //    {
        //        stars[2].DOMoveX(5, Random.Range(1f, 2f)).OnComplete(() => {
        //            foreach (var star in stars)
        //            {
        //                star.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
        //            }

        //        });
        //    });

        //});





        //good way


        var sequence = DOTween.Sequence();

        foreach (var star in stars)
        {
            sequence.Append(star.DOMoveX(5, Random.Range(1f, 2f)));
        }




        sequence.OnComplete(() =>
        {

            foreach (var star in stars)
            {
                star.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
            }


        });












    }

}
