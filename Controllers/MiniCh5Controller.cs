//Brandon Le
//10-25-22
//Mini Challenge 5 - Greater Than or Less Than
//Web API project that will take the users input in the URL and compare the two numbers.
//It will print out whether the 2 numbers are greater than, less than, or equal to one another.
//Peer Review: Andrew Nilsson - All inputs worked in postman. returns a string, great job at making that one string look like 2 different ones. All 3 >, <, and = comparisons work.



using Microsoft.AspNetCore.Mvc;

namespace MiniCh5GreaterThanOrLessThanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh5Controller : ControllerBase
{
    [HttpGet]
    [Route("Compare/{number1}/{number2}")]
    public string Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2); 

        if(convertNum1 > convertNum2)
    {   
        return $"{convertNum1} is greater than {convertNum2} \n {convertNum2} is less than {convertNum1}";
    }
    else if (convertNum1 < convertNum2)
    {
        return $"{convertNum2} is greater than {convertNum1} \n {convertNum1} is less than {convertNum2}";
    }
    else
        return $"{convertNum1} is equal to {convertNum2}";
    }
}