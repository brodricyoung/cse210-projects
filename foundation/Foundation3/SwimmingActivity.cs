
public class SwimmingActivity : Activity {
    private float _laps;

    public SwimmingActivity(string date, string name, float length, float laps) : base(date, name, length) {
        _laps = laps;
    }

    public override float GetDistance() {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed() {
        return (GetDistance() / GetLength()) * 60;
    }

    public override float GetPace() {
        return 60 / GetSpeed();
    }
}