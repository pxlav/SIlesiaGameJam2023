using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEquip : MonoBehaviour
{   
    /*
    public GameObject itemObj;
    public GameObject pressFWindow;
    public EquipmentDataBase m_equipmentDataBase;
    
    void Start()
    {
        pressFWindow.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Item")
        {   
            pressFWindow.SetActive(true);
            itemObj = other.gameObject;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Item")
        {
            pressFWindow.SetActive(false);
            itemObj = null;
        }
    }
    void Update()
    {
        if(itemObj != null && Input.GetKeyDown(KeyCode.F))
        {
            m_equipmentDataBase.itemCounter[itemObj.GetComponent<Item>().itemId] += 1;
            Destroy(itemObj);
        }
    }
    */
}
