using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Canvas 환경의 UI 에 대한 작업할 때 추가
using System;

public class LifeCycleTest : MonoBehaviour
{
    public Text message;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        message.text = "Start!";

        Debug.Log("[Start] 프로그램이 시작되었습니다." + DateTime.Now); 
        // 콘솔창 로그 기록

        // Ctrl + d :  한 줄 복사, 범위 지정 복사
        // Alt + 화살표 위/아래 : 코드 위치 이동
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        message.text = score.ToString();
        Debug.Log("[Update] 프로그램이 진행중입니다." + DateTime.Now); 
    }
}
