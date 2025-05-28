using UnityEngine;

public class Zombie : MonoBehaviour
{
    private int health = 100; 

    //��������� �������� ��� ������ ��������
    public int Health
    {
        get { return health; }
    }
    //������� ����� ��������
    public virtual void Move()
    {
        Debug.Log("Zombie shuffles forward...");
    }

    // ����� ��������� �����
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Zombie took damage! Health: " + health);
    }
}
