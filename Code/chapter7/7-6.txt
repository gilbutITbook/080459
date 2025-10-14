using UnityEngine;
using UnityEngine.InputSystem;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.value);
            bamsongi.GetComponent<BamsongiController>().Shoot(ray.direction * 2000);
        }
    }
}