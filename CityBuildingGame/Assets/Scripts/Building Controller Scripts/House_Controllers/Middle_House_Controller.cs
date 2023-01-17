using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle_House_Controller : MonoBehaviour
{

    Data_Manager data_manager_script;
    House_Upgrader house_upgrader_script;
    GameObject Center_Object;

    void Start()
    {
        //References the Center_Object and the Data_Manager on it
        Center_Object = GameObject.FindGameObjectWithTag("Center_Object");
        data_manager_script = Center_Object.GetComponent<Data_Manager>();
        house_upgrader_script = Center_Object.GetComponent<House_Upgrader>();
    }

    public GameObject lower_class_house;
    public GameObject upper_class_house;
    GameObject new_gameobject;

    void FixedUpdate()
    {
        //If there is an oppitunity to upgrade house
        if (house_upgrader_script.Check_Middle_Upper_Upgrade() == 1)
        {
            print("oay");
            //Removes oppitunity to upgrade
            house_upgrader_script.Change_Middle_Upper_Upgrade();

            //Changes 4 middle class beds to 4 upper class beds
            data_manager_script.Change_Beds(1, -4);
            data_manager_script.Change_Beds(2, 4);
            //Changes a middle class house to an upper class house
            data_manager_script.Change_House_Class(1, -1);
            data_manager_script.Change_House_Class(2, 1);
            //Changes 4 middle class people to 4 upper class people
            data_manager_script.Change_Pop(1, -4);
            data_manager_script.Change_Pop(2, 4);

            //Instantiates upper class buildings
            new_gameobject = Instantiate(upper_class_house, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
            //Matched the rotation of this new building with the old one
            new_gameobject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            //Destroys middle class buildings
            Destroy(gameObject);
        }

        //If there is an oppitunity to downgrade the house
        if (house_upgrader_script.Check_Middle_Lower_Downgrade() == 1)
        {
            //Removes oppitunity to downgrade
            house_upgrader_script.Change_Middle_Lower_Downgrade();

            //Subtracts beds to the bed array
            data_manager_script.Change_Beds(1, -4);
            //Subtracts house to the buildings array
            data_manager_script.Change_Building(0, -1);
            //Subtracts one middle class house to the house_class array
            data_manager_script.Change_House_Class(1, -1);

            //Changes 4 middle class people to lower class people
            data_manager_script.Change_Pop(1, -4);
            data_manager_script.Change_Pop(0, 4);

            //Instantiates lower class buildings
            new_gameobject = Instantiate(lower_class_house, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, transform.rotation.y, 0));
            //Matched the rotation of this new building with the old one
            new_gameobject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            //Destroys middle class buildings
            Destroy(gameObject);
        }
    }
}
