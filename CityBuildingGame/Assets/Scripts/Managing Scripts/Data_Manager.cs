using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Manager : MonoBehaviour {

    public Economics_Manager economics_manager_script;
    public Resource_Change resource_change_script;
    public Population_Change population_change_script;

    void Start()
    {
        Change_Resources(0, 400);
        Change_Resources(1, 400);
        Change_Resources(2, 400);
        Change_Resources(3, 200);
        Change_Resources(4, 400);

        Change_Pop(0, 10);

        Change_Prices(1, 10);
        Change_Prices(2, 10);
        Change_Prices(3, 10);
        Change_Prices(4, 10);

    }


    //LEGEND - resource amounts and prices
    //0 = gold
    //1 = wood
    //2 = stone
    //3 = food
    //4 = iron 

    //RESOURCE AMOUNTS
    float[] resource_amounts = new float[5];

    //Returns a value based off of the amount of a paticular resource.
    public float Check_Resources(int resource_key)
    {
        //Makes sure the input is within range
        if (resource_key < 5 && resource_key >= 0)
        {
            return resource_amounts[resource_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Resource Key");
            return 0;
        }
    }
    //Change the amount of a resource stored based off a key and the amount changed.
    public void Change_Resources(int resource_key, float resource_change)
    {
        //Makes sure the input is within range
        if (resource_key < 5 && resource_key >= 0)
        {
            resource_amounts[resource_key] += resource_change;
        }
        //If not prints message
        else
        {
            print("Invalid Resource Key");
        }
    }

    //RESOURCE PRICES
    float[] resource_prices = new float[5];

    //Returns the price of the resource
    public float Check_Prices(int resource_key)
    {
        //Makes sure the input is within range
        if (resource_key < 5 && resource_key >= 1)
        {
            return resource_prices[resource_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Price Key");
            return 0;
        }
    }
    //Change the price of a resource stored based off a key and the amount changed.
    public void Change_Prices(int resource_key, float price_change)
    {
        //Makes sure the input is within range
        if (resource_key < 5 && resource_key >= 1)
        {
            resource_prices[resource_key] += price_change;
        }
        //If not prints message
        else
        {
            print("Invalid Price Key");
        }
    }

    //LEGEND - buildings
    //0 = house
    //1 = forestry
    //2 = mine
    //3 = market stall
    //4 = warehouse
    //5 = farm
    //6 = church
    //7 = hospital
    //8 = police station
    //9 = fire station

    //BUILDINGS
    float[] building_amounts = new float[10];

    //Returns an integer based off of the numberof a paticular building there is.
    public float Check_Building(int building_key)
    {
        //Makes sure the input is within range
        if (building_key < 10 && building_key >= 0)
        {
            return building_amounts[building_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Building Key");
            return 0;
        }
    }
    //Change the amount of a type of building stored based off a key and the amount changed.
    public void Change_Building(int building_key, int building_change)
    {
        //Makes sure the input is within range
        if (building_key < 10 && building_key >= 0)
        {
            building_amounts[building_key] += building_change;
        }
        //If not prints message
        else
        {
            print("Invalid Buildings Key");
        }
    }

    //Legend - house class
    //0 = lower
    //1 = middle
    //2 = upper

    //HOUSING
    float[] house_class = new float[3];

    //Returns the amount of houses in that class
    public float Check_House_Class(int class_key)
    {
        //Makes sure the input is within range
        if (class_key < 3 && class_key >= 0)
        {
            return house_class[class_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid House Class Key");
            return 0;
        }
    }

    //Changes the amount of houses in that class
    public void Change_House_Class(int class_key, float amount_changed)
    {
        //Makes sure the input is within range
        if (class_key < 3 && class_key >= 0)
        {
            house_class[class_key] += amount_changed;
        }
        //If not prints message
        else
        {
            print("Invalid House Class Key");
        }
    }

    //LEGEND - Jobs, Employed and Employer Slots
    //0 = forester
    //1 = miner
    //2 = farmer
    //3 = trader
    //4 = builder

    //JOBS
    float[] job_amounts = new float[5];

    //return a float which is the number of jobs depending on what key is given
    public float Check_Jobs(int job_key)
    {
        //Makes sure the input is within range
        if (job_key < 5 && job_key >= 0)
        {
            return job_amounts[job_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Jobs Key");
            return 0;
        }
    }
    //Adds or subtracts an amount from the jobs depending on the key given
    public void Change_Jobs(int job_key, float job_change)
    {
        //Makes sure the input is within range
        if (job_key < 5 && job_key >= 0)
        {
            job_amounts[job_key] += job_change;
        }
        //If not prints message
        else
        {
            print("Invalid Jobs Key");
        }
    }

    //EMPLOYED
    float[] employer_amounts = new float[6];

    //return a value which is the number of employed depending on what key is given
    public float Check_Total_Employed(int employed_key)
    {
        //Makes sure the input is within range
        if (employed_key < 5 && employed_key >= 0)
        {
            return employer_amounts[employed_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid employed Key");
            return 0;
        }
    }
    //Adds or subtracts an amount from the employed depending on the key given
    public void Change_Total_Employed(int employed_key, float employed_change)
    {
        //Makes sure the input is within range
        if (employed_key < 5 && employed_key >= 0)
        {
            employer_amounts[employed_key] += employed_change;
        }
        //If not prints message
        else
        {
            print("Invalid employed Key");
        }
    }

    //EMPLOYER SLOTS
    float[] employer_slots_amounts = new float[5];

    //return a value which is the number of employer slots depending on what key is given
    public float Check_Employer_Slots(int employed_key)
    {
        //Makes sure the input is within range
        if (employed_key < 5 && employed_key >= 0)
        {
            return employer_slots_amounts[employed_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid employer slot Key");
            return 0;
        }
    }
    //Adds or subtracts an amount from the employer slots depending on the key given
    public void Change_Employer_Slots(int employed_key, float employed_change)
    {
        //Makes sure the input is within range
        if (employed_key < 5 && employed_key >= 0)
        {
            employer_slots_amounts[employed_key] += employed_change;
        }
        //If not prints message
        else
        {
            print("Invalid employer slot Key");
        }
    }

    //LEGEND - Popualtion and Beds
    //0 = lower class
    //1 = middle class
    //2 = upper class

    //POPULATION
    float[] pop_class = new float[3];

    //return an value which is the total population
    public float Check_Pop_Total()
    {
        //Adds all classes together and returns value
        return Check_Pop_Class(0) + Check_Pop_Class(1) + Check_Pop_Class(2);
    }

    //return an value which is the population of each class
    public float Check_Pop_Class(int class_key)
    {
        //Makes sure the input is within range
        if (class_key <= 2 && class_key >= 0)
        {
            return pop_class[class_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Population Class Key");
            return 0;
        }
    }
    //Adds or subtracts an amount from the population of each class
    public void Change_Pop(int class_key, float pop_change)
    {
        //Makes sure the input is within range
        if (class_key <= 2 && class_key >= 0)
        {
            pop_class[class_key] += pop_change;
        }
        //If not prints message
        else
        {
            print("Invalid Population Class Key");
        }
    }

    //BEDS
    float[] beds_class = new float[3];

    //return an value which is the total number of beds 
    public float Check_Beds_Total()
    {
        //Add all the beds from all of the classes
        return Check_Beds_Class(0) + Check_Beds_Class(1) + Check_Beds_Class(2);
    }

    //return an value which is the beds of each class
    public float Check_Beds_Class(int class_key)
    {
        //Makes sure the input is within ranges
        if(class_key <= 2 && class_key >= 0)
        {
            return beds_class[class_key];
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Beds Class Key");
            return 0;
        }
    }
    //Adds or subtracts an amount from the total beds for each class
    public void Change_Beds(int class_key, int beds_change)
    {
        //Makes sure the input is within ranges
        if (class_key <= 2 && class_key >= 0)
        {
            beds_class[class_key] += beds_change;
        }
        //If not prints message
        else
        {
            print("Invalid Beds Class Key");
        }
    }

    //MAX STORAGE
    int max_storage = 1000;

    public int Get_Max_Storage()
    {
        //returns the variable max_storage
        return max_storage;
    }

    public void Change_Max_Storage(int amount_changed)
    {
        //Changes the variable max_storage
        max_storage += amount_changed;
    }

    //RESOURCE COLLECTORS
    int collector_change = 1;
     
    public int Get_Collector_Change()
    {
        //Returns Variable collector_change
        return collector_change;
    }

    public void Change_Collector_Amount(int amount_change)
    {
        //Changes variable collector_change
        collector_change += amount_change;
    }

    //UNEMPLOYED
    public float Get_Unemployed()
    {
        //Works out the number of unemployed people
        return (Check_Pop_Total() - (Check_Total_Employed(0) + Check_Total_Employed(1) + Check_Total_Employed(2) + Check_Total_Employed(3) + Check_Total_Employed(4)));
    }

    //HOMELESS
    float homeless;

    public float Get_Homeless()
    {
        //Calculates the difference between people and beds
        homeless = Check_Pop_Total() - Check_Beds_Total();
        //If this difference is less that zero
        if(homeless < 0)
        {
            //Make homeless zero
            homeless = 0;
        }
        //Return variable homeless
        return homeless;
    }
}
