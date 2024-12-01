using System.Data;

public class TemperatureSensor : ISensor {

    private double temperature;

    public bool Status() {
       return true;
    }
    private double ReadRawTemp() {
        Random random = new Random();
        double randomTemp = random.Next(86, 110) + random.NextDouble();
        return randomTemp;
    }

    public void UpdateTemp() {
        double temp = ReadRawTemp();
        double tempInCel = (temp - 32) * 5/9;
        temperature = tempInCel; 
    }  

    public double GetTemperature() {
        return temperature;
    }
}
