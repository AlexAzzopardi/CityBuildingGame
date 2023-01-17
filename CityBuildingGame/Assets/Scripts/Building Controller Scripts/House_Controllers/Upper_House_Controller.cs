using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upper_House_Controller : MonoBehaviour {

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

    public GameObject middle_class_house;
    GameObject new_gameobject;

    void FixedUpdate()
    {
        //If there is an oppitunity to downgrade a house to middle class
        if (house_upgrader_script.Check_Upper_Middle_Downgrade() == 1)
        {
            //Removes oppitunity to downgrade
            house_upgrader_script.Change_Upper_Middle_Downgrade();

            //Changes 4 upper class beds to 4 middle class beds
            data_manager_script.Change_Beds(2, -4);
            data_manager_script.Change_Beds(1, 4);
            //Changes an upper class house to a middle class house
            data_manager_script.Change_House_Class(2, -1);
            data_manager_script.Change_House_Class(1, 1);
            //Changes 4 upper class people to 4 middle class people
            data_manager_script.Change_Pop(2, -4);
            data_manager_script.Change_Pop(1, 4);

            //Instansiates middle class buildings
            new_gameobject = Instantiate(middle_class_house, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 0));
            //Matched the roation of this new building with the old one
            new_gameobject.transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
            //Destroys upper class buildings
            Destroy(gameObject);
        }
    }
}
