using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_Upgrader : MonoBehaviour {

    public Data_Manager data_manager_script;

    int lower_middle_upgrade = 0;
    public int Check_Lower_Middle_Upgrade(){
        //Returns Variable lower_middle_upgrade
        return lower_middle_upgrade;}
    public void Change_Lower_Middle_Upgrade(){
        //Subtracts 1 from lower_middle_upgrade
        lower_middle_upgrade -= 1;}

    int middle_upper_upgrade = 0;
    public int Check_Middle_Upper_Upgrade(){
        //Returns Variable middle_upper_upgrade
        return middle_upper_upgrade;}
    public void Change_Middle_Upper_Upgrade(){
        //Subtracts 1 from middle_upper_upgrade
        middle_upper_upgrade -= 1;}

    int middle_lower_downgrade = 0;
    public int Check_Middle_Lower_Downgrade(){
        //Returns Variable middle_lower_downgrade
        return middle_lower_downgrade;}
    public void Change_Middle_Lower_Downgrade(){
        //Subtracts 1 from middle_lower_downgrade
        middle_lower_downgrade -= 1;}

    int upper_middle_downgrade = 0;
    public int Check_Upper_Middle_Downgrade(){
        //Returns Variable upper_middle_downgrade
        return upper_middle_downgrade;}
    public void Change_Upper_Middle_Downgrade(){
        //Subtracts 1 from upper_middle_downgrade
        upper_middle_downgrade -= 1;}

    void FixedUpdate ()
    {
        //If there is enough lower class houses and there is enough lower class houses compared to middle class houses and happiness is greater or equal to 4.
        if (data_manager_script.Check_House_Class(0) > 40 && data_manager_script.Check_House_Class(0) > data_manager_script.Check_House_Class(1) && data_manager_script.Check_Pop_Class(0) > data_manager_script.Check_Pop_Class(1))
        {
            //Increase lower_middle_upgrade by 1
            lower_middle_upgrade = 1;
        }

        //If there is more middle class houses than lower class houses or the population of the lower class plus 8 is smaller than the middle class.
        if (data_manager_script.Check_House_Class(0) + 1 < data_manager_script.Check_House_Class(1) || data_manager_script.Check_Pop_Class(0) + 8 < data_manager_script.Check_Pop_Class(1))
        {
            //Increase middle_lower_downgrade by 1
            middle_lower_downgrade = 1;
        }

        //If there is enough middle class houses and there is enough middle class houses compared to upper class houses and happiness is greater or equal to 4
        if (data_manager_script.Check_House_Class(1) > 30 && data_manager_script.Check_House_Class(1) > data_manager_script.Check_House_Class(2) && data_manager_script.Check_Pop_Class(1) > data_manager_script.Check_Pop_Class(2) && Check_Happiness() >= 4)
        {
            //Increase middle_upper_upgrade by 1
            middle_upper_upgrade = 1;
        }

        //If there is more upper class houses than middle class houses or the population of the middle class plus 8 is smaller than the upper class.
        if (data_manager_script.Check_House_Class(1) + 1 < data_manager_script.Check_House_Class(2) || data_manager_script.Check_Pop_Class(1) + 8 < data_manager_script.Check_Pop_Class(2))
        {
            //Increase upper_middle_downgrade by 1
            upper_middle_downgrade = 1;
        }
    }

    public int Check_Happiness()
    {        
        //Resets the mappiness to zero every time the method is run
        int happiness = 0;

        //Check the amount of Churches in the city to calculate the cities happinenss
        if (data_manager_script.Check_Building(6) >= data_manager_script.Check_Pop_Total() / 50){
            happiness += 2;}
        else if (data_manager_script.Check_Building(6) >= data_manager_script.Check_Pop_Total() / 200){
            happiness += 1;}

        //Check the amount of Hospitals in the city to calculate the cities happinenss
        if (data_manager_script.Check_Building(7) >= data_manager_script.Check_Pop_Total() / 50){
            happiness += 2;}
        else if (data_manager_script.Check_Building(7) >= data_manager_script.Check_Pop_Total() / 200){
            happiness += 1;}

        //Check the amount of Police Stations in the city to calculate the cities happinenss
        if (data_manager_script.Check_Building(8) >= data_manager_script.Check_Pop_Total() / 50){
            happiness += 2;}
        else if (data_manager_script.Check_Building(8) >= data_manager_script.Check_Pop_Total() / 200){
            happiness += 1;}

        //Check the amount of Fire Stations in the city to calculate the cities happinenss
        if (data_manager_script.Check_Building(9) >= data_manager_script.Check_Pop_Total() / 50){
            happiness += 2;}
        else if (data_manager_script.Check_Building(9) >= data_manager_script.Check_Pop_Total() / 200){
            happiness += 1;}

        //Returns the happiness
        return happiness;
    }
}

