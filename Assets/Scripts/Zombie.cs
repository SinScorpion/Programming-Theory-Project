using UnityEngine;

public class Zombie : MonoBehaviour
{
    protected int health = 100; // �������� ����� - ���������� ����

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
