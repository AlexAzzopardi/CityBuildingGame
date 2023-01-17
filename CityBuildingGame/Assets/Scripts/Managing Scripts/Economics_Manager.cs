using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economics_Manager : MonoBehaviour {

    public Data_Manager data_manager_script;
    public UI_Manager ui_manager_script;

    //Amount of time between resource collection
    float next_time = 3;
    float add_time = 3;

    void FixedUpdate()
    {
        //Checks if the time sice this scritpt stated is greater that current_time
        if (Time.time > next_time)
        {
            //Calls method
            Normalise_Market_Prices();

            //Add the current time to varible add_time
            next_time = Time.time + add_time;
        }
    }

    float[] tax_modifier = new float[3] { 15, 15, 15 };

    public float Check_Tax_Modifier(int class_key)
    {
        //Return the tax modifier of the correct class
        if (class_key <= 2 && class_key >= 0)
        {
            return tax_modifier[class_key];
        }
        //Runs if input is not valid
        else
        {
            print("Invalid Class Key");
            return 0;
        }
    }

    public void Change_Tax_Modifier(int class_key, float tax_change)
    {
        //Changes the tax modifier of the correct class
        if (class_key <= 2 && class_key >= 0)
        {
            tax_modifier[class_key] += tax_change;
        }       
        //Runs if input is invalid
        else
        {
            print("Invalid Class Key");
        }
    }

    public void Increase_Tax(int class_key)
    {
        //Alls method to be run only once when the button is pressed
        if (ui_manager_script.Get_Button_Pressed() == false)
        {
            //Makes sure tax isnt greater than 100%
            if (Check_Tax_Modifier(class_key) + 1 <= 100)
            {
                //Adds 1% to the correct tax class
                Change_Tax_Modifier(class_key, 1);
            }
            //Changes bool to true
            ui_manager_script.Change_Button_Pressed(true);
        }
    }

    public void Decrease_Tax(int class_key)
    {
        //Alls method to be run only once when the button is pressed
        if (ui_manager_script.Get_Button_Pressed() == false)
        {
            //Makes sure tax is greater than 0%
            if (Check_Tax_Modifier(class_key) - 1 >= 0)
            {
                //Removes 1% to the correct tax class
                Change_Tax_Modifier(class_key, -1);
            }
            //Changes bool to true
            ui_manager_script.Change_Button_Pressed(true);
        }
    }

    float[] filled_beds = new float[3];

    public float Get_Tax(int class_key)
    {
        //Makes sure the input is in range
        if (class_key <= 2 && class_key >= 0)
        {
            //If there are more or the same number of bed than people in thhis class
            if (data_manager_script.Check_Beds_Class(class_key) >= data_manager_script.Check_Pop_Class(class_key))
            {
                //Filled beds of that class equals the population in that class
                filled_beds[class_key] = data_manager_script.Check_Pop_Class(class_key);
            }
            //If the are more people than beds for that class
            else
            {
                //Filled beds in that class equals the number of beds in that class
                filled_beds[class_key] = data_manager_script.Check_Beds_Class(class_key);
            }
            //Returns the amount of tax for that class
            return Mathf.Ceil(filled_beds[class_key] * (Check_Tax_Modifier(class_key) / 10));
        }
        //If not prints message and returns 0
        else
        {
            print("Invalid Class Key");
            return 0;
        }
    }

    float maintenance;

    public float Get_Maintenance()
    {
        //Maintance equals 1 times the number of forestries, 1 time the number of mines, 3 time the number of warehouse
        maintenance = (1 * data_manager_script.Check_Building(1)) + (1 * data_manager_script.Check_Building(2)) + (3 * data_manager_script.Check_Building(4));
        //Returns maintenance
        return maintenance;
    }

    //INCOME AND EXPENCES
    public float Get_Income()
    {
        //Calculates income
        return Get_Tax(0) + Get_Tax(1) + Get_Tax(2) + (data_manager_script.Check_Total_Employed(3) * 3);
    }

    public float Get_Expenses()
    {
        //Calculates expenses by getting the maintenace
        return Get_Maintenance();
    }

    public float Check_Total_Income()
    {
        //Calcuates the total income by subtracting the expenses from the income
        return Get_Income() - Get_Expenses();
    }

    void Normalise_Market_Prices()
    {
        //Cycles through all of the resources
        for (int i = 1; i < 5; i++)
        {
            //If the price is greater than 10
            if(data_manager_script.Check_Prices(i) > 10)
            {
                //Reduce price by 1
                data_manager_script.Change_Prices(i, -1);
            }
            //If the price is less than 10
            else if (data_manager_script.Check_Prices(i) < 10)
            {
                //Increase price by 1
                data_manager_script.Change_Prices(i, 1);
            }
        }
    }
}
