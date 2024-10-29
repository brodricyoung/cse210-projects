
public class RunningActivity : Activity {
    private float _distance;

    public RunningActivity(string date, string name, float length, float distance) : base(date, name, length) {
        _distance = distance;
    }

    public override float GetDistance() {
        return _distance;
    }

    public override float GetSpeed() {
        return (_distance / GetLength()) * 60;
    }

    public override float GetPace() {
        return 60 / GetSpeed();
    }
}