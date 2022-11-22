using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(0.4f, 1f).SetRelative(true).SetEase(Ease.InOutBack);
        new WaitForSeconds(50f);
        transform.DOMoveX(-0.4f, 2f).SetRelative(true).SetEase(Ease.InOutBack);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.DOMoveX(0.5f, 2f).SetRelative(true).SetEase(Ease.InOutBounce);
    }
}
