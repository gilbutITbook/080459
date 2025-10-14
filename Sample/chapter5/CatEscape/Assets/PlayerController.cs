using UnityEngine;
using UnityEngine.InputSystem;  // 입력을 감지하는 데 필요!!

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 왼쪽 화살표를 눌렀을 때
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            transform.Translate(-3, 0, 0);  // 왼쪽으로 3 움직인다
        }

        // 오른쪽 화살표를 눌렀을 때
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            transform.Translate(3, 0, 0);   // 오른쪽으로 3 움직인다
        }
    }
}