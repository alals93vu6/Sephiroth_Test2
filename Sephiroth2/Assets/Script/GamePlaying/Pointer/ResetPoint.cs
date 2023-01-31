﻿using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class ResetPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pointer")
        {
            EventBus.Post(new NewRoundDetected());
        }
    }
}
