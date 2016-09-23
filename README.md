# Fitness-Pal
This is a team project for Deakin University unit SIT313 Mobile Computing. The project is a fitness app developed exclusively for Android and made using xamarin forms.

The team consists of:

Avishrant Shrestha - 214194208
Stephen Pilakis - 213142452
Brandon Knipler - 213362619

User guide:
To open the application:
*Please make sure that Visual Studio 15 and the Xamarin Plugin are up to date!
*Runs on an emulator but won't count steps unless it's run on an android device (emulators can't simulate the correct sensors)
1. Open StepCounter.sln
2. Go Build -> Rebuild and allow the program to download the necessary packages (Shows progress at the buttom of VS - Usually take 1-2 minutes) ** (If this works go to step 5) **
3. If you get embedding errors restart VS, they should be cleared.
4. If the option to Debug the app on the emulator does not show up, please follow these steps
    4.1 Close VS and in the main folder enabled viewing hidden folders
    4.2 Copy the file in VSReplace to .vs -> StepCounter -> v14
    4.3 Override the file that is currently there
    4.4 Program should work on restart
5. Once loaded ran the project using Debug (ensure the android emulator or device you are using is above API 19)
6. The app should now run inside of the emulator, but if you have any errors please follow these next steps
    6.1 Delete the packages folder 
    6.2 Rebuild the project so it grabs all the packages it needs 
    6.3 Update only the xamarin.forms package (right click solution -> nugat manager) 
    6.4 Clean solution

Using the Application
1. The opening screen displays the amount of steps taken and the goal steps, as well as the amount of calories and goal calories(Only the step count will ever display a different value, the other values are not link up yet)
2. To access the menu swipe from left to right on the screen
3. Click a menu item to go to that page
4. The other pages operate as stated in the interface information

Interface Information:

The project uses several interfaces to display its information. The interfaces are implemented using the MVVM structure.

The interfaces are:

Main Interface: Allows the user to see how many steps they have taken that day, see how many calories they have consumed/burned and compare these to the goals they set for themselves.

Menu Interface: This interface appears when the user slides right to left on the Main Interface. This shows the other interfaces the user can access, clicking on one will take the user to that page. The users goes back to the Main Interface by click the Home button on the Interface and can then access the menu again.

(Not added) Calorie Counter Interface: Allows the user to calculate the amount of calories, fats and carbohydrates a user has consumed in a day, it lets them select a common food from a list or manually input the values.

Health Indicator Interface: This interface takes personal information from the user and uses it to assess their health and recommend the amount of exercise they need to do to remain healthy.

Health Tips Interface: This interface allows the user to view several tips relating to healthy eating habits, dietary tips, quick and easy exercises and how to perform these exercises.

Goals Interface: Allows the user to set their personal goals or copy them from what the Health Indicator Interface recommends.

(Not added) Profile Interface: Displays the last 3 days steps and compares them to the goal.

                    ******************************************************************************
                    
The Fitness Pal project contains:

In StepCounter:
App.cs
StepCountDependency.cs - Used to get the amount of steps from native android to Xamarin.Forms.
Models
  Models.cs - Nothing in here yet (Removed update #2)
  Goal.cs - Create goal (Added update #2)
  Human.cs - Create human (Added update #2)
ViewModels
  MasterViewModel.cs - Menu Interface binding (Added update #2)
  GoalsViewModel.cs - Goals Interface binding (Completed update #2)
  ProfileViewModel.cs - Profile Interface binding (Removed update #2)
  BMIViewModel.cs - Health Indicator Interface binding (Added update #2)
  FitnessTipsViewModel.cs - Fitness Tips Interface binding (Added update #2)
  StepCountViewModel.cs - Main Interface binding
Views
  Goals.xaml - Goals Interface (Completed update #2)
  Goals.xaml.cs - code behind
  Master.xaml - Menu interface (and the interface that is called when the app opens) (Completed update #2)
  Master.xaml.cs - code behind (code is binded as of update #2)
  Profile.xaml - Profile Interface (Removed update #2)
  Profile.xaml.cs - code behind (Removed update #2)
  rand.xaml - test page (Removed update #2)
  rand.xaml.cs - code behind (Removed update #2)
  StepCountPage.xaml - Main Interface
  StepCountPage.xaml.cs - code behind
  FitnessTips.xaml - Main Interface (Added update #2)
  FitnessTips.xaml.cs - code behind (Added update #2)
  HealthIndicator.xaml - Main Interface (Added update #2)
  HealthIndicator.xaml.cs - code behind (Added update #2)
  
In StepCounter.Droid:
MainActivity.cs - useless - should be deleted.
StepCountSensors.cs - code that activiates and uses the sensors for the step counter.
StepCountDependency.cs - Used to send the step count to Xamarin.Forms.
Utils.cs - has some code to ensure the user is using android APi 19 or above (needed for sensors).
SplashActivity.cs - Main launcher - displays splash screen then moves to StepCountSensor.cs (Added update #1)
Resources
  drawable
  banner.png - banner for program.
  demo.gif - placeholder (Removed update #1)
  demo2.gif - placeholder 2 (Removed update #1)
  flame.png - Used on Main Interface to show calories
  footsteps.png = Used to show steps
  icon.png - (Updated in update #2)
  splashscreen.png - splash screen image (Added update #1)
  SplashScreen.xml - code used to formate splash screen image  (Added update #1)
  values
    style.xml - Theme added for splashscreen(Added update #1)
  
Update #1

Added a splash screen (Added SplashActivity.cs and made it the main launcher, this activity displays the splash screen the goes to StepCountSensor.cs once the app is loaded. Added the splashscreen image and xml code in android drawable and created a custom theme to display the splash screen.

Replace default icon with new one.

Replaced place holder images with proper images

Update #2

Added new Interfaces - Goals, Health Indicator and Fitness Tips (These all have View and ViewModel files).

Removed Profile Interface (View and ModelView) since it was not implemted in this update.

Added new model Goal and Human to help with Goals and Health Indicator Interface's retrospectively.

Removed Models from Model folder as it was not needed

Added a view model for Master Interface and binded buttons that switch interfaces when clicked

Changed icon to one that was correct size
