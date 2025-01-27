using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // Массив префабов мячей, которые будут создаваться
    [SerializeField] private GameObject[] ballPrefabs;

    // Границы по оси X для случайного создания мячей
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    // Позиция по оси Y для создания мячей
    private float spawnPosY = 30;

    // Задержка перед первым созданием мяча
    private float startDelay = 1.0f;
    // Интервал времени между созданиями мячей
    private float spawnInterval = 4.0f;

    // Метод, который вызывается перед первым обновлением кадра
    void Start()
    {
        // Создает случайный мяч
        SpawnRandomBall();
    }

    // Метод для создания случайного мяча в случайной позиции по оси X в верхней части игрового поля
    void SpawnRandomBall()
    {
        // Генерирует случайную позицию для создания мяча
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Выбирает случайный индекс из массива префабов мячей
        int idx = Random.Range(0, ballPrefabs.Length);

        // Создает мяч в случайной позиции с ориентацией, заданной в префабе
        Instantiate(ballPrefabs[idx], spawnPos, ballPrefabs[idx].transform.rotation);

        // Генерирует случайную задержку перед следующим созданием мяча
        float delay = Random.Range(3f, 5f);
        // Запускает метод SpawnRandomBall с задержкой
        Invoke("SpawnRandomBall", delay);
    }
}
