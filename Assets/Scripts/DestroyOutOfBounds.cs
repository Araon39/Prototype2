using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Верхняя граница, за которую объект будет уничтожен
    public static float topBound = 30;
    // Нижняя граница, за которую объект будет уничтожен
    public static float bottomBound = -20;

    // Метод, который вызывается перед первым обновлением кадра
    void Start()
    {
        // Здесь можно инициализировать любые начальные параметры
    }

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Проверяет, если объект вышел за верхнюю границу
        if (transform.position.z > topBound)
        {
            // Уничтожает объект
            Destroy(gameObject);
        }
        // Проверяет, если объект вышел за нижнюю границу
        else if (transform.position.z < bottomBound)
        {
            // Уничтожает объект
            Destroy(gameObject);
            // Выводит сообщение в консоль
            Debug.Log("!!! Game Over !!!");
        }
    }
}
