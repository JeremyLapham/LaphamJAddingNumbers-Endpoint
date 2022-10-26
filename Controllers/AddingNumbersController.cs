//Jeremy Lapham
//10-25-22
//Adding numbers endpoint
//This program will have the user add two numbers and says the total to them
//peer review by: Jasmine Leek - code is clean, API works under all tested conditions including numbers and letters. good work

using Microsoft.AspNetCore.Mvc;

namespace LaphamJAddingNumbers_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumbersController : ControllerBase
{

    [HttpGet]
    [Route("Adding/{number1}/{number2}")]

    public string Math(string number1, string number2)
    {
        string text = "";
        bool validNum1 = true;
        bool validNum2 = true;
        int needNumber1 = 0;
        int needNumber2 = 0;
        validNum1 = Int32.TryParse(number1, out needNumber1);
        validNum2 = Int32.TryParse(number2, out needNumber2);
        if (validNum1 == true && validNum2 == true)
        {
            int total = needNumber1 + needNumber2;
            text = $"Your total is {total}";
        }
        else
        {
            text = "Those aren't numbers my guy";
        }
        return text;
    }
}
