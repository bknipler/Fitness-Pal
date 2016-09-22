# Fitness-Pal
This is a team project for Deakin University unit SIT313 Mobile Computing. The project is a fitness app developed exclusively for Android and made using xamarin forms.

The team consists of:

Avi Shreshtha
Stephen Pilakis - 21314252
Brandon Knipler - 213362619

The project uses several interfaces to display its information. The interfaces are implemented using the MVVM structure.

The interfaces are:

Main Interface: Allows the user to see how many steps they have taken that day, see how many calories they have consumed/burned and compare these to the goals they set for themselves.

Menu Interface: This interface appears when the user slides right to left on the Main Interface. This shows the other interfaces the user can access, clicking on one will take the user to that page. The users goes back to the Main Interface by click the back button on there android device and can then access the menu again.

Calorie Counter Interface: Allows the user to calculate the amount of calories, fats and carbohydrates a user has consumed in a day, it lets them select a common food from a list or manually input the values.

Health Indicator Interface: This interface takes personal information from the user and uses it to assess their health and recommend the amount of exercise they need to do to remain healthy.

Health Tips Interface: This interface allows the user to view several tips relating to healthy eating habits, dietary tips, quick and easy exercises and how to perform these exercises.

Goals Interface: Allows the user to set their personal goals or copy them from what the Health Indicator Interface recommends.

Profile Interface: Displays the last 3 days steps and compares them to the goal.

                    ******************************************************************************
                    
The initial files uploaded contains:

In StepCounter:
App.cs
StepCountDependency.cs - Used to get the amount of steps from native android to Xamarin.Forms.
Models
  Models.cs - Nothing in here yet.
ViewModels
  GoalsViewModel.cs - Goals Interface binding, incomplete
  ProfileViewModel.cs - Profile Interface binding, incomplete
  StepCountViewModel.cs - Main Interface binding, complete
Views
  Goals.xaml - Goals Interface, incomplete
  Goals.xaml.cs - code behind
  Master.xaml - Menu interface (and the interface that is called when the app opens), incomplete
  Master.xaml.cs - code behind (Button code location)
  Profile.xaml - Profile Interface incomplete
  Profile.xaml.cs - code behind
  rand.xaml - test page - should be deleted
  rand.xaml.cs - code behind
  StepCountPage.xaml - Main Interface, complete
  StepCountPage.xaml.cs - code behind
  
In StepCounter.Droid:
MainActivity.cs - useless - should be deleted.
StepCountSensors.cs - Main launcher and code they activiates and uses the sensors for the step counter.
StepCountDependency.cs - Used to send the step count to Xamarin.Forms.
Utils.cs - has some code to ensure the user is using android APi 19 or above (needed for sensors).
Resources
  drawable
  banner.png - banner for program.
  demo.gif - placeholder
  demo2.gif - placeholder 2
  flame.png - Used on Main Interface to show calories (should be in demo2.gif's spot)
  footsteps.png = Should be in demo.gif's spot
  icon.png - Needs to be replaces with current icon.
  

