﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

<<<<<<< HEAD:Final Epic Shooter Unity Project/Assets/_Script/Slot.cs
public class Slot : MonoBehaviour
=======
<<<<<<< Updated upstream:Final Epic Shooter Unity Project/Assets/_Script/EquipItems.cs
public class Items : MonoBehaviour
=======
public class Slot : MonoBehaviour , IPointerClickHandler
>>>>>>> Stashed changes:Final Epic Shooter Unity Project/Assets/_Script/Slot.cs
>>>>>>> austinBranch:Final Epic Shooter Unity Project/Assets/_Script/EquipItems.cs
{
    public int ID;
    public string type;
    public string description;
    public bool empty;
    public Texture2D icon;
    // Start is called before the first frame update
    public void OnPointerClick (PointerEventData pointerEventData)
	{
        useItem();
        Debug.Log("clicked" + transform.name);
	}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void useItem()
	{
        for (int i = 0; i < 10; i++)
        {
            if (transform.name == "slot(" + (i + 1) + ")")
            {
                Player.E.EA = i;
            }
        }
    }
}