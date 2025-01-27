using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // Границы, за которые объект будет уничтожен
    private static float bottomLimit = -10;
    private static float leftLimit = -60;

    // Метод, который вызывается каждый кадр
    void Update()
    {
        Debug.Log("Update " + gameObject.name);

        // Уничтожает объекты, если их позиция по оси X меньше левой границы
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }

        // Уничтожает объекты, если их позиция по оси Y меньше нижней границы
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
