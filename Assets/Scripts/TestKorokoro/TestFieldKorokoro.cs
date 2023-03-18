using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>�e�X�g�V�[���̃t�B�[���h���X��������</summary>
public class TestFieldKorokoro : MonoBehaviour
{
    [SerializeField] private Transform _field = default;
    [SerializeField] private float _rotateDuration = 0.3f;

    void Start()
    {

    }

    void Update()
    {

        //WASD�ł��邭�邷��
        if (Input.GetKey(KeyCode.W))
        {
            //���ɌX����
            //_field.localEulerAngles = new Vector3(30, 0, 0);
            //_field.DORotate(new Vector3(30, 0, 0), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(30, 0, 0), true, false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //��O�ɌX����
            //_field.localEulerAngles = new Vector3(-30, 0, 0);
            //_field.DORotate(new Vector3(-30, 0, 0), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(-30, 0, 0), true, false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //���ɌX����
            // _field.localEulerAngles = new Vector3(0, 0, 30);
            //_field.DORotate(new Vector3(0, 0, 30), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(0, 0, 30), false, true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //�E�ɌX����
            //_field.localEulerAngles = new Vector3(0, 0, -30);
            //_field.DORotate(new Vector3(0, 0, -30), _rotateDuration).SetEase(Ease.Linear).SetAutoKill();
            RotateField(new Vector3(0, 0, -30), false, true);
        }
        else
        {
            //���ɖ߂�
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
