using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital_Controller : MonoBehaviour {

    Data_Manager data_manager_script;
    GameObject Center_Object;

    void Start()
    {
        //References the Center_Object and the Data_Manager on it
        Center_Object = GameObject.FindGameObjectWithTag("Center_Object");
        data_manager_script = Center_Object.GetComponent<Data_Manager>();

        //Adds a building to the Data Manager
        data_manager_script.Change_Building(7, 1);
    }
}
