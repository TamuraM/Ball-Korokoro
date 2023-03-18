using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>テストシーンのフィールドを傾かせるやつ</summary>
public class TestFieldKorokoro : MonoBehaviour
{
    [SerializeField] private Transform _field = default;
    [SerializeField] private float _rotateDuration = 0.3f;

    void Start()
    {

    }

    void Update()
    {

        //WASDでくるくるする
        if (Input.GetKey(KeyCode.W))
        {
            //奥に傾ける
            //_field.localEulerAngles = new Vector3(30, 0, 0);
            //_field.DORotate(new Vector3(30, 0, 0), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(30, 0, 0), true, false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //手前に傾ける
            //_field.localEulerAngles = new Vector3(-30, 0, 0);
            //_field.DORotate(new Vector3(-30, 0, 0), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(-30, 0, 0), true, false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //左に傾ける
            // _field.localEulerAngles = new Vector3(0, 0, 30);
            //_field.DORotate(new Vector3(0, 0, 30), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(0, 0, 30), false, true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //右に傾ける
            //_field.localEulerAngles = new Vector3(0, 0, -30);
            //_field.DORotate(new Vector3(0, 0, -30), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(0, 0, -30), false, true);
        }
        else
        {
            //元に戻す
            //_field.localEulerAngles = new Vector3(0, 0, 0);
            //_field.DORotate(new Vector3(0, 0, 0), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(0, 0, 0), true, true);
        }

    }

    private void RotateField(Vector3 angle, bool isVertical, bool isHorizontal)
    {
        Vector3 rotateAngle = _field.localEulerAngles;

        if(isVertical)
        {
            rotateAngle.x = angle.x;
        }
        
        if(isHorizontal)
        {
            rotateAngle.z = angle.z;
        }
        
        _field.DORotate(rotateAngle, _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
    }
}
