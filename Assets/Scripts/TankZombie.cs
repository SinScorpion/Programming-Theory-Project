using UnityEngine;

//���� ����� ��������� ��� �������� � ������ �����
public class TankZombie : Zombie
{
    public override void Move()
    {
        Debug.Log("TankZombie stomps forward slowly but surely...");
    }
}
