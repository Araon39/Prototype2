using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotationController : MonoBehaviour
{
    // Вектор скорости вращения
    [SerializeField] private Vector3 speed = new Vector3();
    // Флаг, указывающий, нужно ли рандомизировать скорость вращения
    [SerializeField] private bool HasRandomizedSpeed = false;

    // Вектор скорости вращения для текущего экземпляра
    private Vector3 instanceSpeed;

    // Метод, который вызывается перед первым обновлением кадра
    void Start()
    {
        // Если флаг HasRandomizedSpeed установлен, задает случайную скорость вращения
        if (HasRandomizedSpeed)
        {
            instanceSpeed = new Vector3(
                Random.Range(-Mathf.Abs(speed.x), Mathf.Abs(speed.x)),
                Random.Range(-Mathf.Abs(speed.y), Mathf.Abs(speed.y)),
                Random.Range(-Mathf.Abs(speed.z), Mathf.Abs(speed.z))
            );
        }
        // Иначе использует заданную скорость вращения
        else
        {
            instanceSpeed = speed;
        }
    }

    // Метод, который вызывается каждый кадр
    void Update()
    {
        // Вращает объект с постоянной скоростью
        transform.Rotate(instanceSpeed * Time.deltaTime, Space.World);
    }
}
