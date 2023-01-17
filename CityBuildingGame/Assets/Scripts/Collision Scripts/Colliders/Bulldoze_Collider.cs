using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulldoze_Collider : MonoBehaviour
{
    //Runs when it collides with another collider
    void OnTriggerEnter(Collider object_collider)
    {
        //If the player is left clicking and the tag on the object is "forestry"
        if (object_collider.tag == "forestry" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject forestry = object_collider.gameObject;
            Forestry_Wood_Collection forestry_wood_collection_script = forestry.GetComponent<Forestry_Wood_Collection>();
            Construction_Controller construction_controller_script = forestry.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts the correct amount of jobs from the jobs lists
            data_manager_script.Change_Jobs(0, -forestry_wood_collection_script.Get_Local_Max_Employed());
            //Subtracts the amount that was employed by the building from the employed list
            data_manager_script.Change_Total_Employed(0, -forestry_wood_collection_script.Get_Local_Employed());
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(1, -1);
        }

        //If the player is left clicking and the tag on the object is "mine"
        if (object_collider.tag == "mine" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject mine = object_collider.gameObject;
            Mine_Stone_Iron_Collection mine_stone_collection_script = mine.GetComponent<Mine_Stone_Iron_Collection>();
            Construction_Controller construction_controller_script = mine.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts the correct amount of jobs from the jobs lists
            data_manager_script.Change_Jobs(1, -mine_stone_collection_script.Get_Local_Max_Employed());
            //Subtracts the amount that was employed by the building from the employed list
            data_manager_script.Change_Total_Employed(1, -mine_stone_collection_script.Get_Local_Employed());
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(2, -1);
        }

        //If the player is left clicking and the tag on the object is "market_stall"
        if (object_collider.tag == "market_stall" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject market_stall = object_collider.gameObject;
            Market_Stall_Gold_Collection market_stall_gold_collection_script = market_stall.GetComponent<Market_Stall_Gold_Collection>();
            Construction_Controller construction_controller_script = market_stall.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts the correct amount of jobs from the jobs lists
            data_manager_script.Change_Jobs(3, -market_stall_gold_collection_script.Get_Local_Max_Employed());
            //Subtracts the amount that was employed by the building from the employed list
            data_manager_script.Change_Total_Employed(3, -market_stall_gold_collection_script.Get_Local_Employed());        
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(3, -1);
        }

        //If the player is left clicking and the tag on the object is "farm"
        if (object_collider.tag == "farm" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject farm = object_collider.gameObject;
            Farm_Food_Collection farm_food_collection_script = farm.GetComponent<Farm_Food_Collection>(); 
            //Destroys the building
            Destroy(farm);
            //Subtracts the correct amount of jobs from the jobs lists
            data_manager_script.Change_Jobs(2, -farm_food_collection_script.Get_Local_Max_Employed());
            //Subtracts the amount that was employed by the building from the employed list
            data_manager_script.Change_Total_Employed(2, -farm_food_collection_script.Get_Local_Employed());
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(5, -1);
        }

        //If the player is left clicking and the tag on the object is "lower_house"
        if (object_collider.tag == "lower_house" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject house = object_collider.gameObject;
            Construction_Controller construction_controller_script = house.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);     
            //Subtracts beds from beds list
            data_manager_script.Change_Beds(0, -4);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(0, -1);
            //Subtracts one lower class house from the house_class array
            data_manager_script.Change_House_Class(0, -1);
        }

        //If the player is left clicking and the tag on the object is "middle_house"
        if (object_collider.tag == "middle_house" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject house = object_collider.gameObject;
            //Destroys the building
            Destroy(house);
            //Subtracts beds from beds list
            data_manager_script.Change_Beds(1, -4);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(0, -1);
            //Subtracts one lower class house from the house_class array
            data_manager_script.Change_House_Class(1, -1);
            //Changes 4 middle class people for 4 lowerclass people
            data_manager_script.Change_Pop(1, -4);
            data_manager_script.Change_Pop(0, 4);
        }

        //If the player is left clicking and the tag on the object is "upper_house"
        if (object_collider.tag == "upper_house" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject house = object_collider.gameObject;
            //Destroys the building
            Destroy(house);
            //Subtracts beds from beds list
            data_manager_script.Change_Beds(2, -4);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(0, -1);
            //Subtracts one lower class house from the house_class array
            data_manager_script.Change_House_Class(2, -1);
            //Changes 4 upper class people for 4 lowerclass people
            data_manager_script.Change_Pop(2, -4);
            data_manager_script.Change_Pop(0, 4);
        }

        if (object_collider.tag == "construction" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject construction = object_collider.gameObject;
            Construction_Controller construction_controller_script = construction.GetComponentInParent<Construction_Controller>();
            //Destroys the construction site
            Destroy(construction_controller_script.parent_object);
            //Subtracts the correct amount of jobs from the jobs lists
            data_manager_script.Change_Jobs(4, -construction_controller_script.Get_Local_Max_Employed());
            //Subtracts the amount that was employed by the building from the employed list
            data_manager_script.Change_Total_Employed(4, -construction_controller_script.Get_Local_Employed());
        }

        //If the player is left clicking and the tag on the object is "warehouse"
        if (object_collider.tag == "warehouse" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject warehouse = object_collider.gameObject;
            Construction_Controller construction_controller_script = warehouse.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts 1000 from the max storage
            data_manager_script.Change_Max_Storage(-1000);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(4, -1);
        }

        //If the player is left clicking and the tag on the object is "church"
        if (object_collider.tag == "church" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject church = object_collider.gameObject;
            Construction_Controller construction_controller_script = church.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(6, -1);
        }

        //If the player is left clicking and the tag on the object is "hospital"
        if (object_collider.tag == "hospital" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject hospital = object_collider.gameObject;
            Construction_Controller construction_controller_script = hospital.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(7, -1);
        }

        //If the player is left clicking and the tag on the object is "police_station"
        if (object_collider.tag == "police_station" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject police_station = object_collider.gameObject;
            Construction_Controller construction_controller_script = police_station.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(8, -1);
        }

        //If the player is left clicking and the tag on the object is "fire_station"
        if (object_collider.tag == "fire_station" && Input.GetMouseButtonDown(0))
        {
            //References the unique script on the prefab
            GameObject fire_station = object_collider.gameObject;
            Construction_Controller construction_controller_script = fire_station.GetComponentInParent<Construction_Controller>();
            //Destroys the building
            Destroy(construction_controller_script.parent_object);
            //Subtracts one of this building from the buildings amount list
            data_manager_script.Change_Building(9, -1);
        }

        //If the player is left clicking and the tag on the object is "road"
        if (object_collider.tag == "road" && Input.GetMouseButtonDown(0))
        {
            //Destroys the gameobject        
            Destroy(object_collider.gameObject);
        }
    }

    GameObject Center_Object;
    Data_Manager data_manager_script;

    //References the Center_Object and the Data_Manager on it
    void Start()
    {
        Center_Object = GameObject.FindGameObjectWithTag("Center_Object");
        data_manager_script = Center_Object.GetComponent<Data_Manager>();
    }
}
