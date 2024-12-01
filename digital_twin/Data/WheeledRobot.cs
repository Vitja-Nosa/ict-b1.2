using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

public class WheeledRobot {

    private TemperatureSensor temperatureSensor;

    public WheeledRobot() {
        this.temperatureSensor = new TemperatureSensor();
    }

    public double MeasureTemperature() {
        this.temperatureSensor.UpdateTemp(); 
        return this.temperatureSensor.GetTemperature();
    }

    public string ReadHeartRatePerMin() {
        return "60/min";
    }

    public double ReadLightSensor() {
        return 1.1;
    }
}