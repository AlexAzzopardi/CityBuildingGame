using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource_Change : MonoBehaviour {

    public Data_Manager data_manager_script;
    public UI_Manager ui_manager_script;
    public Economics_Manager economics_manager_script;

    //Amount of time between resource collection
    float next_time = 10;
    float add_time = 10;

    public void Buy_Button(int resource_key, int amount)
    {
        //Alls method to be run only once when the button is pressed
        if (ui_manager_script.Get_Button_Pressed() == false)
        {
            //If you have enough money and enough storage
            if (data_manager_script.Check_Resources(0) >= data_manager_script.Check_Prices(resource_key) && data_manager_script.Check_Resources(resource_key) + amount <= data_manager_script.Get_Max_Storage())
            {
                //Add the resource and subtract the money
                data_manager_script.Change_Resources(resource_key, amount);
                data_manager_script.Change_Resources(0, -data_manager_script.Check_Prices(resource_key));
                //Increase the price of the resource on the market.
                data_manager_script.Change_Prices(resource_key, 1);                          
            }
            //Changes bool to true
            ui_manager_script.Change_Button_Pressed(true);
        }
    }
    public void Sell_Button(int resource_key, int amount)
    {
        //Alls method to be run only once when the button is pressed
        if (ui_manager_script.Get_Button_Pressed() == false)
        {
            //If you have enough of that resource
            if (data_manager_script.Check_Resources(resource_key) - amount >= 0)
            {
                //Subtract the resource and add the money
                data_manager_script.Change_Resources(resource_key, -amount);
                data_manager_script.Change_Resources(0, data_manager_script.Check_Prices(resource_key));
                //Makes sure that the price of the resource is above 5
                if (data_manager_script.Check_Prices(resource_key) > 5)
                {
                    //Decreases the price of the resource on the market.
                    data_manager_script.Change_Prices(resource_key, -1);
                }
            }
            //Changes bool to true
            ui_manager_script.Change_Button_Pressed(true);
        }
    }

    void FixedUpdate()
    {
        //Checks if the time sice this scritpt stated is greater that current_time
        if (Time.time > next_time)
        {
            //Adds gold equal to the number of citizens with beds
            data_manager_script.Change_Resources(0, economics_manager_script.Get_Tax(0) + economics_manager_script.Get_Tax(1) + economics_manager_script.Get_Tax(2));

            //Removes the amount of gold propotional to the maintenance
            data_manager_script.Change_Resources(0, -economics_manager_script.Get_Maintenance());

            //If maintenance goes below zero make it equal to zero
            if(data_manager_script.Check_Resources(0) < 0)
            {
                data_manager_script.Change_Resources(0, -data_manager_script.Check_Resources(0));
            }

            //Takes away resources from inventory
            data_manager_script.Change_Resources(3, -Mathf.Floor(data_manager_script.Check_Pop_Total() / 3));

            //If the ammount of food goes below 0
            if (data_manager_script.Check_Resources(3) < 0)
            {
                //Remove population proptional to a quarter of the deficit of food
                data_manager_script.Change_Pop(0, Mathf.Floor(data_manager_script.Check_Resources(3) / 4));
                //Change the amount of food back to zero
                data_manager_script.Change_Resources(3, -data_manager_script.Check_Resources(3));
            }

            //Add the current time to varible add_time
            next_time = Time.time + add_time;
        }
    }
}
