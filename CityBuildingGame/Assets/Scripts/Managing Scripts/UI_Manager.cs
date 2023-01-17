using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    //Reference to scripts
    public Data_Manager data_manager_script;
    public Game_Manager game_manager_script;
    public Economics_Manager economics_manager_script;

    //Reference to tabs and their states
    public GameObject general_buildings_tab;
    public GameObject utility_buildings_tab;
    public GameObject resource_buildings_tab;
    public GameObject resource_collection_tab;
    bool general_buildings_tab_active = false;
    bool utility_buildings_tab_active = false;
    bool resource_buildings_tab_active = false;
    bool resource_collection_tab_active = false;

    public GameObject market_trade_tab;
    public GameObject politics_tab;
    public GameObject data_tab;
    public GameObject inventory_tab;
    bool market_trade_tab_active = false;
    bool politics_tab_active = false;
    bool data_tab_active = false;
    bool inventory_tab_active = false;

    public GameObject pause_tab;
    bool pause_tab_active = false;

    //Reference to text
    public Text text_wood;
    public Text text_stone;
    public Text text_iron;

    public Text text_income;
    public Text text_gold;
    public Text text_food;
    public Text text_population;
    public Text text_homeless;

    public Text text_unemployed;
    public Text text_builder;
    public Text text_forester;
    public Text text_miner;
    public Text text_farmer;
    public Text text_trader;

    public Text text_wood_inventory;
    public Text text_stone_inventory;
    public Text text_iron_inventory;
    public Text text_food_inventory;

    public Text text_lower_tax;
    public Text text_middle_tax;
    public Text text_upper_tax;

    public Text text_wood_price;
    public Text text_stone_price;
    public Text text_iron_price;
    public Text text_food_price;

    public Text text_income_data;
    public Text text_expenses_data;
    public Text text_total_income_data;
    public Text text_population_data;
    public Text text_unemployed_data;
    public Text text_homeless_data;
    public Text text_beds_data;
    public Text text_houses_data;
    public Text text_forestries_data;
    public Text text_mines_data;
    public Text text_market_stalls_data;
    public Text text_farms_data;
    public Text text_fire_stations_data;
    public Text text_police_stations_data;
    public Text text_hospitals_data;
    public Text text_churches_data;
    public Text text_warehouses_data;
    public Text text_max_storage_data;
    public Text text_population_growth_data;

    //Reference to buttons
    public Button general_buildings_button;
    public Button utility_buildings_button;
    public Button resource_buildings_button;
    public Button resource_collection_button;
    public Button market_trade_button;
    public Button politics_button;

    public Button button_house;
    public Button button_road;
    public Button button_market_stall;
    public Button button_warehouse;

    public Button button_hospital;
    public Button button_police_station;
    public Button button_fire_station;
    public Button button_church;

    public Button button_forestry;
    public Button button_mine;
    public Button button_farm;

    public Button button_collect_all;
    public Button button_collect_wood;
    public Button button_collect_stone;
    public Button button_collect_iron;

    public Button button_Wood_Buy;
    public Button button_Wood_Sell;
    public Button button_Stone_Buy;
    public Button button_Stone_Sell;
    public Button button_Iron_Buy;
    public Button button_Iron_Sell;
    public Button button_Food_Buy;
    public Button button_Food_Sell;

    public Button button_lower_increace_tax;
    public Button button_middle_increace_tax;
    public Button button_upper_increase_tax;
    public Button button_lower_decrease_tax;
    public Button button_middle_decrease_tax;
    public Button button_upper_decrease_tax;

    public Button button_inventory;
    public Button button_data;
    public Button button_bulldoze;
    public Button button_pause;

    public Button button_back;
    public Button button_exit;

    public Button button_increase_builder;
    public Button button_decrease_builder;
    public Button button_increase_forester;
    public Button button_decrease_forester;
    public Button button_increase_miner;
    public Button button_decrease_miner;
    public Button button_increase_farmer;
    public Button button_decrease_farmer;
    public Button button_increase_trader;
    public Button button_decrease_trader;

    bool button_pressed = false;
    public bool Get_Button_Pressed(){
        return button_pressed;}

    public void Change_Button_Pressed(bool button_change){
        button_pressed = button_change;}

    void Update()
    {
        //If you are not clicking then button_pressed equals false
        if (Input.GetMouseButton(0) == false){
            button_pressed = false;}

        //Calls methods if buttons are pressed
        general_buildings_button.onClick.AddListener(General_Buildings_Button);
        utility_buildings_button.onClick.AddListener(Utility_Buildings_Button);
        resource_buildings_button.onClick.AddListener(Resource_Buildings_Button);
        resource_collection_button.onClick.AddListener(Resource_Collection_Button);
        market_trade_button.onClick.AddListener(Market_Trade_Button);
        politics_button.onClick.AddListener(Politics_Button);

        button_house.onClick.AddListener(House_Button);
        button_road.onClick.AddListener(Road_Button);
        button_warehouse.onClick.AddListener(Warehouse_Button);
        button_market_stall.onClick.AddListener(Market_Stall_Button);

        button_church.onClick.AddListener(Church_Button);
        button_hospital.onClick.AddListener(Hospital_Button);
        button_police_station.onClick.AddListener(Police_Station_Button);
        button_fire_station.onClick.AddListener(Fire_Station_Button);

        button_forestry.onClick.AddListener(Forestry_Button);
        button_mine.onClick.AddListener(Mine_Button);
        button_farm.onClick.AddListener(Farm_Button);

        button_collect_all.onClick.AddListener(Collect_All_Button);
        button_collect_wood.onClick.AddListener(Collect_Wood_Button);
        button_collect_stone.onClick.AddListener(Collect_Stone_Button);
        button_collect_iron.onClick.AddListener(Collect_Iron_Button);

        button_Wood_Buy.onClick.AddListener(Wood_Buy_Button);
        button_Wood_Sell.onClick.AddListener(Wood_Sell_Button);
        button_Stone_Buy.onClick.AddListener(Stone_Buy_Button);
        button_Stone_Sell.onClick.AddListener(Stone_Sell_Button);
        button_Iron_Buy.onClick.AddListener(Iron_Buy_Button);
        button_Iron_Sell.onClick.AddListener(Iron_Sell_Button);
        button_Food_Buy.onClick.AddListener(Food_Buy_Button);
        button_Food_Sell.onClick.AddListener(Food_Sell_Button);

        button_lower_increace_tax.onClick.AddListener(Lower_Tax_Increase);
        button_middle_increace_tax.onClick.AddListener(Middle_Tax_Increase);
        button_upper_increase_tax.onClick.AddListener(Upper_Tax_Increase);
        button_lower_decrease_tax.onClick.AddListener(Lower_Tax_Decrease);
        button_middle_decrease_tax.onClick.AddListener(Middle_Tax_Decrease);
        button_upper_decrease_tax.onClick.AddListener(Upper_Tax_Decrease);

        button_inventory.onClick.AddListener(Inventory_Button);
        button_data.onClick.AddListener(Data_Button);
        button_bulldoze.onClick.AddListener(Bulldoze_Button);
        button_pause.onClick.AddListener(Pause_Button);

        button_back.onClick.AddListener(Back_Button);
        button_exit.onClick.AddListener(Exit_Button);

        button_increase_builder.onClick.AddListener(Builder_Increase_Button);
        button_decrease_builder.onClick.AddListener(Builder_Decrease_Button);
        button_increase_forester.onClick.AddListener(Forester_Increase_Button);
        button_decrease_forester.onClick.AddListener(Forester_Decrease_Button);
        button_increase_miner.onClick.AddListener(Miner_Increase_Button);
        button_decrease_miner.onClick.AddListener(Miner_Decrease_Button);
        button_increase_farmer.onClick.AddListener(Farmer_Increase_Button);
        button_decrease_farmer.onClick.AddListener(Farmer_Decrease_Button);
        button_increase_trader.onClick.AddListener(Trader_Increase_Button);
        button_decrease_trader.onClick.AddListener(Trader_Decrease_Button);

        //Changes Text to the type plus the amount in storage
        //Converts the data obtained to a string       
        text_wood.text = ("Wood: " + data_manager_script.Check_Resources(1));
        text_stone.text = ("Stone: " + data_manager_script.Check_Resources(2));
        text_iron.text = ("Iron: " + data_manager_script.Check_Resources(4));

        text_income.text = ("Income: " + economics_manager_script.Check_Total_Income());
        text_gold.text = ("Gold: " + data_manager_script.Check_Resources(0));
        text_food.text = ("Food: " + data_manager_script.Check_Resources(3));
        text_population.text = ("Population: " + data_manager_script.Check_Pop_Total());
        text_homeless.text = ("Homeless: " + data_manager_script.Get_Homeless());

        //Get the total number of citizens without jobs
        text_unemployed.text = ("Unemployed: " + data_manager_script.Get_Unemployed());
        //Changes the text to total employed / total jobs for each specific job
        text_builder.text = ("Builder: " + (data_manager_script.Check_Total_Employed(4) + "/" + data_manager_script.Check_Jobs(4)));
        text_forester.text = ("Forester: " + data_manager_script.Check_Total_Employed(0) + "/" + data_manager_script.Check_Jobs(0));
        text_miner.text = ("Miner: " + data_manager_script.Check_Total_Employed(1) + "/" + data_manager_script.Check_Jobs(1));
        text_farmer.text = ("Farmer: " + data_manager_script.Check_Total_Employed(2) + "/" + data_manager_script.Check_Jobs(2));
        text_trader.text = ("Trader: " + data_manager_script.Check_Total_Employed(3) + "/" + data_manager_script.Check_Jobs(3));

        //Changes the text to match the data
        text_wood_inventory.text = ("Wood: " + data_manager_script.Check_Resources(1));
        text_stone_inventory.text = ("Stone: " + data_manager_script.Check_Resources(2));
        text_iron_inventory.text = ("Iron: " + data_manager_script.Check_Resources(4));
        text_food_inventory.text = ("Food: " + data_manager_script.Check_Resources(3));

        //Changes the text to match the data
        text_income_data.text = ("Income: " + economics_manager_script.Get_Income());
        text_expenses_data.text = ("Expenses: " + economics_manager_script.Get_Expenses());
        text_total_income_data.text = ("Total Income: " + economics_manager_script.Check_Total_Income());
        text_population_data.text = ("Population: " + data_manager_script.Check_Pop_Total());
        text_unemployed_data.text = ("Unemployed: " + data_manager_script.Get_Unemployed());
        text_homeless_data.text = ("Homeless: " + data_manager_script.Get_Homeless());
        text_beds_data.text = ("Beds: " + data_manager_script.Check_Beds_Total());
        text_houses_data.text = ("Houses: " + data_manager_script.Check_Building(0));
        text_forestries_data.text = ("Forestries: " + data_manager_script.Check_Building(1));
        text_mines_data.text = ("Mines: " + data_manager_script.Check_Building(2));
        text_market_stalls_data.text = ("Markets Stalls: " + data_manager_script.Check_Building(3));
        text_farms_data.text = ("Farms: " + data_manager_script.Check_Building(5));
        text_fire_stations_data.text = ("Fire Stations: " + data_manager_script.Check_Building(9));
        text_police_stations_data.text = ("Police Stations: " + data_manager_script.Check_Building(8));
        text_hospitals_data.text = ("Hospitals: " + data_manager_script.Check_Building(7));
        text_churches_data.text = ("Churches: " + data_manager_script.Check_Building(6));
        text_warehouses_data.text = ("Warehouses: " + data_manager_script.Check_Building(4));
        text_max_storage_data.text = ("Max Storage: " + data_manager_script.Get_Max_Storage());
        text_population_growth_data.text = ("Population Growth: " + data_manager_script.population_change_script.Get_Population_Growth());

        //Changes the text to the corrct percentage
        text_lower_tax.text = ("Lower Class                " + economics_manager_script.Check_Tax_Modifier(0) + "%");
        text_middle_tax.text = ("Middle Class               " + economics_manager_script.Check_Tax_Modifier(1) + "%");
        text_upper_tax.text = ("Upper Class                " + economics_manager_script.Check_Tax_Modifier(2) + "%");

        //Chnges the text which shows the price of each item
        text_wood_price.text = (data_manager_script.Check_Prices(1).ToString());
        text_stone_price.text = (data_manager_script.Check_Prices(2).ToString());
        text_iron_price.text = (data_manager_script.Check_Prices(4).ToString());
        text_food_price.text = (data_manager_script.Check_Prices(3).ToString());
    }

    void End_Task()
    {
        //Calls the correct end task method depending on what task was taking place
        if (game_manager_script.Get_Current_Task_Key() == 1)
        {
            game_manager_script.road_builder_script.End_Road_Builder();
        }
        else if (game_manager_script.Get_Current_Task_Key() == 2)
        {
            game_manager_script.building_placer_script.End_Building_Placer();
        }
        else if (game_manager_script.Get_Current_Task_Key() == 3)
        {
            game_manager_script.farm_placer_script.End_Farm_Placing();
        }
        else if (game_manager_script.Get_Current_Task_Key() == 4)
        {
            game_manager_script.resource_collection_script.End_Resource_Collection();
        }
        else if (game_manager_script.Get_Current_Task_Key() == 5)
        {
            game_manager_script.bulldozer_script.End_Bulldozer();
        }
        //Checks if there is no task
        else if (game_manager_script.Get_Current_Task_Key() == 0) { }
        //Creates validation
        else
        {
            print("current_task_key Invalid");
        }
    }

    //MISC BUTTONS
    void Road_Button()
    {
        //Only runs once every time the button is pressed
        if (button_pressed == false)
        {
            //Calls function to end all tasks
            End_Task();
            //Says that the button is being pressed
            button_pressed = true;
            //Calls function to change task to "Road_Builder"
            game_manager_script.Change_Task(1);
        }
    }
    void Farm_Button()
    {
        //Only runs once every time the button is pressed
        if (button_pressed == false)
        {
            //Calls method to end all tasks
            End_Task();
            //Says that the button is being pressed
            button_pressed = true;
            //Calls function to change task to "Road_Builder"
            game_manager_script.Change_Task(3);
        }
    }
    void Bulldoze_Button()
    {
        //Only runs once every time the button is pressed
        if (button_pressed == false)
        {
            //Calls function to end all tasks
            End_Task();
            //Says that the button is being pressed
            button_pressed = true;
            //Calls function to change task to "Building_Placer"
            game_manager_script.Change_Task(5);
        }
    }    

    //BUILDING BUTTONS
    void UI_Building_Placer_Controller(int building_key)
    {
        //Only runs once every time the button is pressed
        if (button_pressed == false)
        {
            //Validates input
            if (building_key >= 0 && building_key < 9)
            {
                //Calls method to end all tasks
                End_Task();

                if (game_manager_script.Get_Current_Task_Key() == 2 && game_manager_script.building_placer_script.Get_Current_Building_Key() == building_key)
                {
                    //Calls function to change task to "Building_Placer"
                    game_manager_script.Change_Task(2);
                }
                else if (game_manager_script.Get_Current_Task_Key() == 2 && game_manager_script.building_placer_script.Get_Current_Building_Key() != building_key)
                {
                    //Selects the correct building
                    game_manager_script.building_placer_script.Building_Selector(building_key);
                }
                else if (game_manager_script.Get_Current_Task_Key() != 2)
                {
                    //Calls function to change task to "Building_Placer"
                    game_manager_script.Change_Task(2);
                    //Selects the correct building
                    game_manager_script.building_placer_script.Building_Selector(building_key);
                }
                //Says that the button is being pressed
                button_pressed = true;
            }
            //Prints if key is out of range
            else { print("Invalid building_key"); }
        }
    }
    //Calls method with correct input for the building
    void House_Button()
    {
        UI_Building_Placer_Controller(0);
    }
    void Forestry_Button()
    {
        UI_Building_Placer_Controller(1);
    }
    void Mine_Button()
    {       
        UI_Building_Placer_Controller(2);
    }
    void Market_Stall_Button()
    {
        UI_Building_Placer_Controller(3);
    }
    void Warehouse_Button()
    {
        UI_Building_Placer_Controller(4);
    }
    void Church_Button()
    {
        UI_Building_Placer_Controller(5);
    }
    void Hospital_Button()
    {
        UI_Building_Placer_Controller(6);
    }
    void Police_Station_Button()
    {
        UI_Building_Placer_Controller(7);
    }
    void Fire_Station_Button()
    {
        UI_Building_Placer_Controller(8);
    }

    //COLLECTOR BUTTONS
    void UI_Resource_Collector_Controller(int collector_key)
    {
        //Only runs once every time the button is pressed
        if (button_pressed == false)
        {
            //Makes sure the input is within a certain range.
            if (collector_key >= 0 && collector_key < 4)
            {
                //Calls method to end the correct task
                End_Task();
                //Call if you are running a different task or are using the same collector
                if (game_manager_script.Get_Current_Task_Key() != 4 || game_manager_script.resource_collection_script.Get_Current_Collector_Key() == collector_key)
                {
                    //Calls the function to change the task
                    game_manager_script.Change_Task(4);
                }
                //Call the function to change the collector
                game_manager_script.resource_collection_script.Change_Resource_Collection(collector_key);
                //Says that the button is being pressed
                button_pressed = true;
            }
            //Validates the method
            else { print("Invalid collector_key"); }
        }
    }

    void Collect_All_Button()
    {
        //Calls method with 0 as an input
        UI_Resource_Collector_Controller(0);
    }
    void Collect_Wood_Button()
    {
        //Calls method with 0 as an input
        UI_Resource_Collector_Controller(1);
    }
    void Collect_Stone_Button()
    {
        //Calls method with 0 as an input
        UI_Resource_Collector_Controller(2);
    }
    void Collect_Iron_Button()
    {
        //Calls method with 0 as an input
        UI_Resource_Collector_Controller(3);
    }

    //GENERAL_BUILDINGS
    void General_Buildings_Button()
    {
        if (button_pressed == false)
        {
            //If tabs is closed
            if (general_buildings_tab_active == false)
            {
                //Open tab and close every other tab
                general_buildings_tab_active = true;
                utility_buildings_tab_active = false;
                resource_buildings_tab_active = false;
                resource_collection_tab_active = false;
                general_buildings_tab.SetActive(true);
                utility_buildings_tab.SetActive(false);
                resource_buildings_tab.SetActive(false);
                resource_collection_tab.SetActive(false);
            }
            //If tabs is open
            else if (general_buildings_tab_active == true)
            {
                //Close tab
                general_buildings_tab_active = false;
                general_buildings_tab.SetActive(false);
            }
            button_pressed = true;
        }
    }
    //UTILITY_BUILDINGS
    void Utility_Buildings_Button()
    {
        if (button_pressed == false)
        {
            //If tabs is closed
            if (utility_buildings_tab_active == false)
            {
                //Open tab and close every other tab
                general_buildings_tab_active = false;
                utility_buildings_tab_active = true;
                resource_buildings_tab_active = false;
                resource_collection_tab_active = false;
                general_buildings_tab.SetActive(false);
                utility_buildings_tab.SetActive(true);
                resource_buildings_tab.SetActive(false);
                resource_collection_tab.SetActive(false);
            }
            //If tabs is open
            else if (utility_buildings_tab_active == true)
            {
                //Close tab
                utility_buildings_tab_active = false;
                utility_buildings_tab.SetActive(false);
            }
            button_pressed = true;
        }
    }
    //RESOURCE_BUILDINGS
    void Resource_Buildings_Button()
    {
        if (button_pressed == false)
        {
            //If tabs is closed
            if (resource_buildings_tab_active == false)
            {
                //Open tab and close every other tab
                general_buildings_tab_active = false;
                utility_buildings_tab_active = false;
                resource_buildings_tab_active = true;
                resource_collection_tab_active = false;
                general_buildings_tab.SetActive(false);
                utility_buildings_tab.SetActive(false);
                resource_buildings_tab.SetActive(true);
                resource_collection_tab.SetActive(false);
            }
            //If tabs is open
            else if (resource_buildings_tab_active == true)
            {
                //Close tab
                resource_buildings_tab_active = false;
                resource_buildings_tab.SetActive(false);
            }
            button_pressed = true;
        }
    }
    //RESOURCE_COLLECTION
    void Resource_Collection_Button()
    {
        if (button_pressed == false)
        {
            //If tabs is closed
            if (resource_collection_tab_active == false)
            {
                //Open tab and close every other tab
                general_buildings_tab_active = false;
                utility_buildings_tab_active = false;
                resource_buildings_tab_active = false;
                resource_collection_tab_active = true;
                general_buildings_tab.SetActive(false);
                utility_buildings_tab.SetActive(false);
                resource_buildings_tab.SetActive(false);
                resource_collection_tab.SetActive(true);
            }
            //If tabs is open
            else if (resource_collection_tab_active == true)
            {
                //Close tab
                resource_collection_tab_active = false;
                resource_collection_tab.SetActive(false);
            }
            button_pressed = true;
        }
    }

    void UI_Increase_Buttons(int job_key)
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            //If the number of employed in this job is less that the number of this type of jobs
            if (data_manager_script.Check_Total_Employed(job_key) < data_manager_script.Check_Jobs(job_key) && data_manager_script.Get_Unemployed() > 0)
            {
                //Adds 1 from the employment slots
                data_manager_script.Change_Employer_Slots(job_key, 1);
                //Add 1 to the total employed in a specific job
                data_manager_script.Change_Total_Employed(job_key, 1);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }
    void UI_Decrease_Button(int job_key)
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            //If the number of employed in the job is greater then zero
            if (data_manager_script.Check_Total_Employed(job_key) > 0)
            {
                //Subtracts 1 from the employment slots
                data_manager_script.Change_Employer_Slots(job_key, -1);
                //Subtracts 1 to the total employed in a specific job
                data_manager_script.Change_Total_Employed(job_key, -1);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }

    //Calls the methods to run the method with the correct input
    void Builder_Increase_Button()
    {
        UI_Increase_Buttons(4);
    }
    void Builder_Decrease_Button()
    {
        UI_Decrease_Button(4);
    }
    void Forester_Increase_Button()
    {
        UI_Increase_Buttons(0);
    }
    void Forester_Decrease_Button()
    {
        UI_Decrease_Button(0);
    }
    void Miner_Increase_Button()
    {
        UI_Increase_Buttons(1);
    }
    void Miner_Decrease_Button()
    {
        UI_Decrease_Button(1);
    }
    void Farmer_Increase_Button()
    {
        UI_Increase_Buttons(2);
    }
    void Farmer_Decrease_Button()
    {
        UI_Decrease_Button(2);
    }
    void Trader_Increase_Button()
    {
        UI_Increase_Buttons(3);
    }
    void Trader_Decrease_Button()
    {
        UI_Decrease_Button(3);
    }

    void Market_Trade_Button()
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            if (market_trade_tab_active == false)
            {
                //Opens and Closes tab
                market_trade_tab_active = true;
                market_trade_tab.SetActive(true);

                pause_tab_active = false;
                pause_tab.SetActive(false);
                politics_tab_active = false;
                politics_tab.SetActive(false);
                inventory_tab_active = false;
                inventory_tab.SetActive(false);
                data_tab_active = false;
                data_tab.SetActive(false);
            }
            else if (market_trade_tab_active == true)
            {
                //Close tab
                market_trade_tab_active = false;
                market_trade_tab.SetActive(false);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }

    void Politics_Button()
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            if (politics_tab_active == false)
            {
                //Opens and Closes tab
                politics_tab_active = true;
                politics_tab.SetActive(true);

                pause_tab_active = false;
                pause_tab.SetActive(false);
                market_trade_tab_active = false;
                market_trade_tab.SetActive(false);
                inventory_tab_active = false;
                inventory_tab.SetActive(false);
                data_tab_active = false;
                data_tab.SetActive(false);
            }
            else if (politics_tab_active == true)
            {
                //Close tab
                politics_tab_active = false;
                politics_tab.SetActive(false);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }

    void Inventory_Button()
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            if (inventory_tab_active == false)
            {
                //Opens and Closes tab
                inventory_tab_active = true;
                inventory_tab.SetActive(true);

                pause_tab_active = false;
                pause_tab.SetActive(false);
                market_trade_tab_active = false;
                market_trade_tab.SetActive(false);
                politics_tab_active = false;
                politics_tab.SetActive(false);
                data_tab_active = false;
                data_tab.SetActive(false);
            }
            else if (inventory_tab_active == true)
            {
                //Close tab
                inventory_tab_active = false;
                inventory_tab.SetActive(false);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }

    void Data_Button()
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            if(data_tab_active == false)
            {
                //Opens and Closes tab
                data_tab_active = true;
                data_tab.SetActive(true);

                pause_tab_active = false;
                pause_tab.SetActive(false);
                market_trade_tab_active = false;
                market_trade_tab.SetActive(false);
                politics_tab_active = false;
                politics_tab.SetActive(false);
                inventory_tab_active = false;
                inventory_tab.SetActive(false);
            }
            else if(data_tab_active == true)
            {
                //Close tab
                data_tab_active = false;
                data_tab.SetActive(false);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }
    void Pause_Button()
    {
        //Alls method to be run only once when the button is pressed
        if (button_pressed == false)
        {
            if (pause_tab_active == false)
            {
                //Opens and Closes tab
                pause_tab_active = true;
                pause_tab.SetActive(true);

                data_tab_active = false;
                data_tab.SetActive(false);
                market_trade_tab_active = false;
                market_trade_tab.SetActive(false);
                politics_tab_active = false;
                politics_tab.SetActive(false);
                inventory_tab_active = false;
                inventory_tab.SetActive(false);
            }
            else if (pause_tab_active == true)
            {
                //Close tab
                pause_tab_active = false;
                pause_tab.SetActive(false);
            }
            //Changes bool to true
            button_pressed = true;
        }
    }

    //Runs Function to buy and sell correct resource with correct amount
    void Wood_Buy_Button()
    {
        data_manager_script.resource_change_script.Buy_Button(1, 10);
    }
    void Stone_Buy_Button()
    {
        data_manager_script.resource_change_script.Buy_Button(2, 10);
    }
    void Iron_Buy_Button()
    {
        data_manager_script.resource_change_script.Buy_Button(4, 10);
    }
    void Food_Buy_Button()
    {
        data_manager_script.resource_change_script.Buy_Button(3, 10);
    }
    void Wood_Sell_Button()
    {
        data_manager_script.resource_change_script.Sell_Button(1, 10);
    }
    void Stone_Sell_Button()
    {
        data_manager_script.resource_change_script.Sell_Button(2, 10);
    }
    void Iron_Sell_Button()
    {
        data_manager_script.resource_change_script.Sell_Button(4, 10);
    }
    void Food_Sell_Button()
    {
        data_manager_script.resource_change_script.Sell_Button(3, 10);
    }

    //Calls function using the correct Input
    void Lower_Tax_Increase()
    {
        economics_manager_script.Increase_Tax(0);
    }
    void Middle_Tax_Increase()
    {
        economics_manager_script.Increase_Tax(1);
    }
    void Upper_Tax_Increase()
    {
        economics_manager_script.Increase_Tax(2);
    }
    void Lower_Tax_Decrease()
    {
        economics_manager_script.Decrease_Tax(0);
    }
    void Middle_Tax_Decrease()
    {
        economics_manager_script.Decrease_Tax(1);
    }
    void Upper_Tax_Decrease()
    {
        economics_manager_script.Decrease_Tax(2);
    }

    void Back_Button()
    {
        //Load level "Game_Level"
        Application.LoadLevel("Main_Menu");
    }

    void Exit_Button()
    {
        //Exits the game
        Application.Quit();
        print("Exits Game");
    }
}