using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Префаб собаки, который будет создаваться
    [SerializeField] private GameObject dogPrefab;
    // Минимальная задержка между созданиями собак
    [SerializeField] private float minDogSpawnDelay = 1;

    // Время последнего создания собаки
    private float lastDogSpawn = 0;

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // При нажатии пробела и если прошло достаточно времени с последнего создания собаки
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastDogSpawn > minDogSpawnDelay)
        {
            // Создает собаку в позиции игрока с ориентацией, заданной в префабе
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Обновляет время последнего создания собаки
            lastDogSpawn = Time.time;
        }
    }
}
