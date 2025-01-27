using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Массив объектов, которые будут создаваться
    [SerializeField] private GameObject[] gameObjects = new GameObject[0];
    // Начальная позиция для создания объектов
    [SerializeField] private Vector3 spawnLocation = new Vector3();
    // Диапазон случайного смещения от начальной позиции
    [SerializeField] private Vector3 spawnRange = new Vector3();

    // Интервал времени между созданиями объектов
    [SerializeField] private float spawnInterval = 1.5f;

    // Метод, который вызывается перед первым обновлением кадра
    void Start()
    {
        // Запускает метод SpawnRandomAnimal с интервалом spawnInterval
        InvokeRepeating("SpawnRandomAnimal", 0, spawnInterval);
    }

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Если нажата клавиша S, создается случайный объект
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    // Метод для создания случайного объекта из массива gameObjects
    void SpawnRandomAnimal()
    {
        // Выбирает случайный индекс из массива gameObjects
        int idx = Random.Range(0, gameObjects.Length);

        // Проверяет, что объект по выбранному индексу не равен null
        if (gameObjects[idx] != null)
        {
            // Вычисляет случайную позицию для создания объекта
            Vector3 spawnPos = spawnLocation + new Vector3(
                Random.Range(-Mathf.Abs(spawnRange.x), Mathf.Abs(spawnRange.x)),
                Random.Range(-Mathf.Abs(spawnRange.y), Mathf.Abs(spawnRange.y)),
                Random.Range(-Mathf.Abs(spawnRange.z), Mathf.Abs(spawnRange.z))
            );
            // Создает объект в вычисленной позиции с его исходной ориентацией
            Instantiate(gameObjects[idx], spawnPos, gameObjects[idx].transform.rotation);
        }
    }
}
