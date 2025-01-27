using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    // Скорость движения объекта вперед
    [SerializeField] private float speed;

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Перемещает объект вперед с постоянной скоростью
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
