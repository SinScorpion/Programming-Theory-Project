using UnityEngine;

public class ZombieTester : MonoBehaviour
{
    private Zombie zombieRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var zombies = FindObjectsOfType<Zombie>();
        foreach (var z in zombies)
        {
            z.Move();
        }
        // Находим зомби в сцене
        zombieRef = FindObjectOfType<Zombie>();

        ////Вызываем методы зомби
        //zombieRef.Move();
        //zombieRef.TakeDamage(20);
        Debug.Log("Zombie health is: " + zombieRef.Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
