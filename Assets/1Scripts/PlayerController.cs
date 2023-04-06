using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float m_MvX = 0.0f;         // 이동 계산용 변수
    float m_MvSpeed = 7.0f;     // 이동 속도


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 화살이 눌렸을 때
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //transform.Translate(-3, 0, 0); // 왼쪽으로 [3] 움직인다
            m_MvX = Time.deltaTime * (-1.0f * m_MvSpeed);
            transform.Translate(m_MvX, 0.0f, 0.0f);
        }

        // 오른쪽 화살이 눌렸을 떄
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //transform.Translate(3, 0, 0); // 오른쪽으로 [3] 움직인다
            m_MvX = Time.deltaTime * m_MvSpeed;
            transform.Translate(m_MvX, 0.0f, 0.0f);
        }

        // 캐릭터가 게임 배경 화면을 벗어나지 못하게 막는 처리
        Vector3 a_vPos = transform.position;
        if(8.0f < a_vPos.x)
            a_vPos.x = 8.0f;

        if (a_vPos.x < -8.0f)
            a_vPos.x = -8.0f;
        transform.position = a_vPos;
        // 캐릭터가 게임 배경 화면을 벗어나지 못하게 막는 처리

    }

    public void LButton()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButton()
    {
        transform.Translate(3, 0, 0);
    }
}
