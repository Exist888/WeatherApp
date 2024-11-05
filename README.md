# __Filip's Weather App__
C# console application for viewing current, location-specific weather stats.

<img src="https://github.com/user-attachments/assets/05d812ef-3017-4a2d-8561-c4e91942bfec" alt="Project Hero Image" width="350">

## __☀️ Features__
- Retrieves live weather data from Open Weather Map API.
- Prompts users to enter zip code to view real-time weather stats in their chosen area.
- Uses interpolation to enable user input in to modify live URL for REST API. 
- Uses selection statements and try-catch statements to manage all possible zip code entry errors and keep the app functioning smoothly.
- Hides API key and all sensitive information using .gitignore. 
<br/> <br/>

## __📱 How To Use My App__
### 1) Fork my GitHub repository to your own account
  - Click the "Fork" button on the top-right of the repository page.
### 2) Clone this repository to your local machine
  - Click the green "Code" button on the page that appears after forking.
  - Copy the URL provided by clicking on the copy icon.
  - Use Command Prompt to navigate to your local folder of choice.
  - Type the "git clone" command into Command Prompt.
  - Paste the URL you have just copied next to the "git clone" command and hit ENTER.
### 3) Register for your free API key
  - Visit <a href="https://openweathermap.org">__OpenWeatherMap.org__</a>.
  - Click "API" in the navigation bar.
  - Subscribe to the 1000 Free API Call Per Day option.
  - This will generate a free API key for you. Please keep it handy and safe.
### 4) Securely set up your API key
  - My program currently hides the API key in the appsettings.json file, which will not appear in your cloned version.
  - To keep your API key secure, please ensure that the .gitignore file contains "appsettings.json".
  - Create a new "appsettings.json" file, and ensure the file name is identical to the file name hidden in .gitignore.
  - Make sure your appsettings.json file looks exactly like this: <br/>
    <img src="https://github.com/user-attachments/assets/c56c52dc-bcee-4e85-aa67-227e12ea91b6" alt="API Key Instructions" width="300">
  - Replace your_api_key_goes_here with your actual API key.
### 5) Restore dependencies and run the application
  - Visual Studio Code will likely automatically restore any necessary dependencies.
  - You can run the app from within Visual Studio Code at this point, or you can follow the remaining instructions to run the app from Command Prompt. 
  - If you are using Command Prompt, navigate the the repository for this cloned app.
  - Type "dotnet restore" and hit ENTER to restore Nuget packages.
  - Type "dotnet run" and hit ENTER to run the application.
<br/> <br/>

##
### __Thank you for checking out my application. I hope you enjoy it!__
Let's connect on <a href="https://www.linkedin.com/in/filip-herbst/">__LinkedIn!__</a>
