using UnityEngine;

public class Zombie : MonoBehaviour
{
    protected int health = 100; // Здоровье зомби - защищенное поле

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
