using UnityEngine;
using UnityEngine.InputSystem;  // 입력을 감지하는 데 필요!!

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 스와이프 길이를 구한다
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // 마우스를 클릭한 좌표
            this.startPos = Mouse.current.position.value;
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Mouse.current.position.value;
            float swipeLength = endPos.x - this.startPos.x;

            // 스와이프 길이를 처음 속도로 변환한다
            this.speed = swipeLength / 500.0f;

            // 효과음을 재생
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                    // 감속
    }
}