using UnityEngine;
using TMPro;    // TextMeshProを使うために必要!

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car_0");
        this.flag = GameObject.Find("flag_0");
        this.distance = GameObject.Find("distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}