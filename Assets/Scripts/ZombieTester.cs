using UnityEngine;

public class ZombieTester : MonoBehaviour
{
    private Zombie zombieRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ������� ����� � �����
        zombieRef = FindObjectOfType<Zombie>();

        //�������� ������ �����
        zombieRef.Move();
        zombieRef.TakeDamage(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
