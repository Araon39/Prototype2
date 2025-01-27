using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Метод, который вызывается при входе другого коллайдера в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Уничтожает текущий объект
        Destroy(gameObject);
        // Уничтожает другой объект, который вошел в триггер
        Destroy(other.gameObject);
    }
}
