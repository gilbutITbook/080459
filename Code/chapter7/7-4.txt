using UnityEngine;
using UnityEngine.InputSystem;  // 입력을 감지하는 데 필요!

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 200, 2000));
        }
    }
}
