# NumericSequenceCalculator
Numeric Sequence Calculator

Introduction: This project enables the user to enter a number in a textbox, and then it shows the 4 kinds of series when user hit the Submit button.

This project is using ASP.Net Core with MVC design, AgularJs, and Bootstrap for responsive webpage.(Visual Studio 2015 Update 3)I actually i turned the design into MVVM so that i could use ViewModels along with the Views, Controllers and Models.

I have also used the Dependency Injection using the interface and configured the service to get the results of my numeric series from the Services folder.

All the calculations performed in the Services folder, So that it will be easier when working with Unit Testing. Unit Testing is yet to be done.

I have total 5 methods in my service, and i am calling those methods from my HomeController through the _service field.

The method only accepts integer number. So it wont show result for any negative or decimal numbers.

When you run the project, the StatUp_Page points to the layout_Page, which has the Angular and Bootstrap files from the lib folder in the header. And the @RendarBody shows the code results written in the Index Page. The whole project has just one ViewPage. And IndexViewModel has the fields/prop for example: 

public IEnumerable<MyNumberModel> AllNumbers { get; set; } 

So that i could show the list of numbers on the Screen. And the same way, my functions in Services folder, have the same return type:

  IEnumerable<MyNumberModel> GetAll(int num);   
  
And project.json file has neccesary packages. (included StaticFiles, and Mvc)
The web page is responsive as bootstrap used. In medium and large screens, you can see all the numeric series will be one row and in 4 columns, and in small to extra small screens its 2 rows and 2 colums in each of the row.

If the user Enters Multiple of Number 5, or Multiple of Number 3, or Multiple of Number 5 and 3, then it returns the message string respectivelly, C, E, and Z as well.


To get this project in your Visual Studio,
Simply Download the Zip file, or just copy the Url of the git Repository, open Visual Studio->View Menu->Team explorer-> Clone, Paste the URL here, Click Clone. You will see the NumericSequenceCalculator, double click that, and you will find the Solution named "CodingTask", just open the solution and run the project. You can enter any integer and you will get the result as different series according to the inputed number.







