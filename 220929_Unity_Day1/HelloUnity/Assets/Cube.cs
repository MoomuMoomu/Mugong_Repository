using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [HideInInspector] public GameObject cube;
    // Inspector 창에서 보이지 않게함
    // 기능 공유 시, 파일 내부에서는 작업이 필요 없을 때 사용
    // (가독성 문제로 가려줌)

    [SerializeField] private GameObject cube2;
    // 직렬화(Serialization) : 특정 개체를 바이트의 나열로 바꿔서 Stream이 가능하게 해줌
    // 사용하는 프로그램 내에서는 검색이 가능하게 해줌
    // 외부에서는 접근이 안됨

    public bool isCheck;
    [Range (0,10)] public float speed;
    public int number;
    public List<GameObject> cubeList = new List<GameObject>();
    public GameObject[] cubeList2 = new GameObject[4];
    // Array 와 List 는 Editor 의 Inspector 에서는 추가/삭제에 차이가 없다
    // Array 는 Editor 에서 Size Over 될 때 Index 오류 날 듯
    // List 메모리 최적화 문제로, 공부할 때 List, 실무에서는 Array 쓸지도?

    // 스크립트 값과 Unity Editor 에서 설정한 Unity Engine 값이 다를 경우,
    // Unity Engine 값 우선 처리

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
