using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construction_Controller : MonoBehaviour {

    float max_employed = 2;

    //Returns the local max_employment
    public float Get_Local_Max_Employed()
    {
        return max_employed;
    }

    int local_employed = 0;

    //Returns the local_employment
    public int Get_Local_Employed()
    {
        return local_employed;
    }

    //Allow you to change the local_employment
    public void Change_Local_Employed(int amount_changed)
    {
        local_employed += amount_changed;
    }

    //Amount of time between building tick
    float next_time = 3;
    float add_time = 3;

    //Reference to the building tab
    public GameObject building;
    //Reference to the construction tab
    public GameObject construction;
    //Reference to the parent objects which holds them both
    public GameObject parent_object;

    int building_time = 0;

    void FixedUpdate()
    { 
        //Check if there is and local jobs available and if there is any workers available 
        if (local_employed < max_employed && data_manager_script.Check_Employer_Slots(4) > 0)
        {
            //Subtracts that worker from the employer slots
            data_manager_script.Change_Employer_Slots(4, -1);
            //Add a worker to the local_employed
            local_employed += 1;}

        //Checks if there is a local worker and that the employer slots are negative
        if (local_employed > 0 && data_manager_script.Check_Employer_Slots(4) < 0)
        {
            //Adds a worker to the employer slots
            data_manager_script.Change_Employer_Slots(4, 1);
            //Subtracts a worker to the local_employed
            local_employed -= 1;}

        //While no one is building increase the next_time variable
        if (local_employed == 0 && building_time < 6)
        {
            next_time = Time.time + add_time;}

        //Checks if the time sice this script stated is greater that current_time
        if (Time.time * local_employed > next_time)
        {
            //sets next_time equalt to Time.time multiplies by the number of employed
            //It is offset by the add_time variable
            next_time = Time.time * local_employed + add_time;
            //Adds one to the building_time variable
            building_time += 1;}

        //When building_time get to 6
        if (building_time == 6)
        {
            //Switch it to 7 so this constion only plays once
            building_time += 1;
            //Remove the jobs
            data_manager_script.Change_Jobs(4, -max_employed);
            //Remove the employed
            data_manager_script.Change_Total_Employed(4, -local_employed);
            //Turn the building tab on so it is visable
            building.SetActive(true);
            //Destroy the constructions tab and its content
            Destroy(construction);}}

    Data_Manager data_manager_script;
    GameObject Center_Object;

    //Refferences the Center_Object and the Data_Manager on it
    void Start()
    {
        Center_Object = GameObject.FindGameObjectWithTag("Center_Object");
        data_manager_script = Center_Object.GetComponent<Data_Manager>();

        //Adds jobs to the jobs list
        data_manager_script.Change_Jobs(4, max_employed);
    }
}
