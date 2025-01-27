using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Скорость движения игрока
    [SerializeField] private float speed = 0;
    // Границы движения игрока по оси X
    [SerializeField] private float boundsX = 0;

    // Префаб объекта еды, который будет создаваться
    [SerializeField] private GameObject foodPrefab = null;

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Получает горизонтальный ввод от пользователя (стрелки или A/D)
        float hInput = Input.GetAxis("Horizontal");

        // Двигает игрока влево или вправо в зависимости от ввода
        transform.Translate(Vector3.right * speed * Time.deltaTime * hInput);

        // Ограничивает движение игрока по оси X в пределах boundsX
        if (transform.position.x < -boundsX)
        {
            transform.position = new Vector3(-boundsX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > boundsX)
        {
            transform.position = new Vector3(boundsX, transform.position.y, transform.position.z);
        }

        // Создает объект еды при нажатии пробела, если префаб еды не равен null
        if (Input.GetKeyDown(KeyCode.Space) && foodPrefab != null)
        {
            // Создает объект еды в позиции игрока с ориентацией, заданной в префабе
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
