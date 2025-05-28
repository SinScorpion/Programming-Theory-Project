using UnityEngine;

//Быстрый зомби наследует все свойства и методы зомби
public class FastZombie : Zombie
{
    //Переопределяем поведение движения
    public override void Move()
    {
        Debug.Log("FastZombie sprints at lightning speed!");
    }
}
