using UnityEngine;

//������� ����� ��������� ��� �������� � ������ �����
public class FastZombie : Zombie
{
    //�������������� ��������� ��������
    public override void Move()
    {
        Debug.Log("FastZombie sprints at lightning speed!");
    }
}
