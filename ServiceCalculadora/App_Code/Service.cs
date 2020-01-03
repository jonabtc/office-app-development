using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public double AddNumbers(double number1, double number2)
    {
        double result = number1 + number2;
        return result;
    }
    public double SubstractNumbers(double number1, double number2)
    {
        double result = number1 - number2;
        return result;
    }
    public double MultiplyNumbers(double number1, double number2)
    {
        double result = number1 * number2;
        return result;
    }
    public double DivisionNumbers(double number1, double number2)
    {
        double result = number1 / number2;
        return result;
    }
}
