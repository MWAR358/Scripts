using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 100;
    public float speed = 10;
    int level = 1;

    void Start()
    {
        health += level;
        print("Здоровье игрока:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
