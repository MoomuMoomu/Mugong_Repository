using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Canvas ȯ���� UI �� ���� �۾��� �� �߰�
using System;

public class LifeCycleTest : MonoBehaviour
{
    public Text message;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        message.text = "Start!";

        Debug.Log("[Start] ���α׷��� ���۵Ǿ����ϴ�." + DateTime.Now); 
        // �ܼ�â �α� ���

        // Ctrl + d :  �� �� ����, ���� ���� ����
        // Alt + ȭ��ǥ ��/�Ʒ� : �ڵ� ��ġ �̵�
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        message.text = score.ToString();
        Debug.Log("[Update] ���α׷��� �������Դϴ�." + DateTime.Now); 
    }
}
