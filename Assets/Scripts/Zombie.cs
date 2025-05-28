using UnityEngine;

public class Zombie : MonoBehaviour
{
    private int health = 100; 

    //Публичное свойство для чтения здоровья
    public int Health
    {
        get { return health; }
    }
    //Базовый метод движения
    public virtual void Move()
    {
        Debug.Log("Zombie shuffles forward...");
    }

    // Метод получения урона
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Zombie took damage! Health: " + health);
    }
}
