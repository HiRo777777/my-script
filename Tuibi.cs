using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuibi : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject obj;
    [SerializeField] float m_Speed = 1;
    void Start()
    {
        obj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 playerPotition = obj.transform.position;

        //gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, playerPotition, m_Speed);
        gameObject.transform.LookAt(obj.transform);

        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, m_Speed);
        gameObject.transform.position += velocity;

    }
}
