using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    // Вектор скорости, с которой объект будет двигаться
    [SerializeField] private Vector3 speed = new Vector3();

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Перемещает объект с постоянной скоростью
        transform.Translate(speed * Time.deltaTime, Space.World);
    }
}
