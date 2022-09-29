using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [HideInInspector] public GameObject cube;
    // Inspector â���� ������ �ʰ���
    // ��� ���� ��, ���� ���ο����� �۾��� �ʿ� ���� �� ���
    // (������ ������ ������)

    [SerializeField] private GameObject cube2;
    // ����ȭ(Serialization) : Ư�� ��ü�� ����Ʈ�� ������ �ٲ㼭 Stream�� �����ϰ� ����
    // ����ϴ� ���α׷� �������� �˻��� �����ϰ� ����
    // �ܺο����� ������ �ȵ�

    public bool isCheck;
    [Range (0,10)] public float speed;
    public int number;
    public List<GameObject> cubeList = new List<GameObject>();
    public GameObject[] cubeList2 = new GameObject[4];
    // Array �� List �� Editor �� Inspector ������ �߰�/������ ���̰� ����
    // Array �� Editor ���� Size Over �� �� Index ���� �� ��
    // List �޸� ����ȭ ������, ������ �� List, �ǹ������� Array ������?

    // ��ũ��Ʈ ���� Unity Editor ���� ������ Unity Engine ���� �ٸ� ���,
    // Unity Engine �� �켱 ó��

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1);
    }
}
