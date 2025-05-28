using UnityEngine;

//танк зомби наследует все свойства и методы зомби
public class TankZombie : Zombie
{
    public override void Move()
    {
        Debug.Log("TankZombie stomps forward slowly but surely...");
    }
}
