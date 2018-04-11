# uwpWeatherApp

I am a third year Software development student at GMIT and this repo is for my Mbile Applications project.

# Aims

  - The main aim of this project is to develop an app through c# and upload it to the microsoft store. 
  - The app should demonstrate the knowledge I have gained in this module.

# Running the app

The app is available from the windows store and can be found through searching for uwpWeatherApp or clicking on this link : link will be here

You can also clone this repo :
  - Clone the project to your computer
  - Open project in Visual Studio 2015 or 2017 (App was built in 2015)
  - Click build on local machine
# About the App 
The app makes use of the openweathermap API to give a user the current weather for their location. It does this by getting the user's current position from their device by using location services and storing the longitude and latitude. 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Once the app has the user's longitude and latitude it builds a URL which gets sent back to openweathermap that includes longitude, latitude and an app id. Openweathermap then returns the current weather for the locaion which was provided.

# Code

#### MainPage.xaml 

> The main design of the app takes place here. There is a piviot to move between two pages, the GetWeather page and About page.
>Inside that piviot I have a grid which I use to split the home screen up into different sections.

#### MainPage.xaml

> The code for to deal with the fuctions of the main page. The button displayed to the user on the main page to get the weather is handled here. When the user clicks on the button a class is made to OpenWeatherMapProxy.cs to getWeather with the devices positon. The results are then displayed in textblocks.

#### OpenWeatherMapProxy.cs

>This class deals with creating the URL which must be passed to OpenWeatherMap to generate the weather for the location.
>GetWeather uses string builder to build the URL that will be sent as there will be different data sent each time so it cannot be hard coded.
> The data comes back from OpenWeatherMap as Json data so I used json2csharp.com to convert that data for use in this application. 


#### LocationManager.cs
> This class is used to ask the user's device for access to the geo locator.
> I had to enable this feature in the package manifest.
> User must grant permission to the app for weather to be returned.



### Technologies used

| Tech | Link |
| ------ | ------ |
| Openweathermap API | https://openweathermap.org/api |
| json2csharp | http://json2csharp.com/ |
| dillinger | https://dillinger.io/ |

## Resources used :
| Resource | Link |
| ------ | ------ |
| channel9's Video tutorial on implementing openweather API | https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-057-UWP-Weather--Introductioni |
| EDMT Dev's tutorial on implementing openweather API |https://www.youtube.com/watch?v=7XeIJ3EiQm8|
|Layout Design Microsoft docs | https://docs.microsoft.com/en-us/windows/uwp/design/layout/grid-tutorial|

  
Author: Thomas Duffy, GMIT
