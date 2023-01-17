using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lower_House_Controller : MonoBehaviour {

    Data_Manager data_manager_script;
    House_Upgrader house_upgrader_script;
    GameObject Center_Object;

    void Start()
    {
        //References the Center_Object and the Data_Manager on it
        Center_Object = GameObject.FindGameObjectWithTag("Center_Object");
        data_manager_script = Center_Object.GetComponent<Data_Manager>();
        house_upgrader_script = Center_Object.GetComponent<House_Upgrader>();

        //Adds beds to the bed list
        data_manager_script.Change_Beds(0, 4);
        //Adds building to the buildings list
        data_manager_script.Change_Building(0, 1);
        //Adds one lower class house to the house _class array
        data_manager_script.Change_House_Class(0, 1);
    }

    public GameObject middle_class_house;
    GameObject new_gameobject;

    void FixedUpdate()
    {
        //If there is an oppitunity to upgrade house
        if (house_upgrader_script.Check_Lower_Middle_Upgrade() == 1)
        {
            //Remove one oppitunity to upgrade
            house_upgrader_script.Change_Lower_Middle_Upgrade();

            //Changes 4 lower class beds for 4 middle class beds
            data_manager_script.Change_Beds(0, -4);
            data_manager_script.Change_Beds(1, 4);
            //Changes a lower class house for a middle class house
            data_manager_script.Change_House_Class(0, -1);
            data_manager_script.Change_House_Class(1, 1);
            //Changes 4 lower class people for 4 middle class people
            data_manager_script.Change_Pop(0, -4);
            data_manager_script.Change_Pop(1, 4);;

            //Instansiates middle class buildings
            new_gameobject = Instantiate(middle_class_house, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
            //Matched the roation of this new building with the old one
            new_gameobject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            //Destroys lower class buildings
            Destroy(gameObject);
        }
    }
}
