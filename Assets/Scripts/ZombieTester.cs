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
        //// ������� ����� � �����
        //zombieRef = FindObjectOfType<Zombie>();

        ////�������� ������ �����
        //zombieRef.Move();
        //zombieRef.TakeDamage(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
