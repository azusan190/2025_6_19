using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nejikocontroller : MonoBehaviour
{
    // Start is called before the first frame update

    //1.�v���C���[�̃L�[���͂��󂯎��
    //2.�L�[���͂̕����Ɉړ�����    
    //3.�ړ������ɍ��킹�ăA�j���[�V�������Đ�����

    CharacterController controller;
    Vector3 moveDirection = Vector3.zero;
    public float speed = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") > 0.0f)
        {
            moveDirection.z = Input.GetAxis("Vertical") * speed;
        }
        else
        {
            moveDirection.z = 0.0f;
        }

        Vector3 globalDirection = transform.TransformDirection(moveDirection);

        controller.Move(globalDirection);
    }
}


    // Update is called once per fram