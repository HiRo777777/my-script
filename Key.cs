using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject enemy;
    public bool unlock = false;
    [SerializeField] DoorScript m_doorScript = default;
    public void OnClickObj()
    {
        
        Debug.Log("OnClickObj");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            unlock = true;
            m_doorScript.m_unlock = true;
            Debug.Log("unlock"); 
            // 敵が出現する
            enemy.SetActive(true);
            Destroy(this.gameObject);
        }
        
    }


}

