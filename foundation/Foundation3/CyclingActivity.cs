
public class CyclingActivity : Activity {
    private float _speed;

    public CyclingActivity(string date, string name, float length, float speed) : base(date, name, length) {
        _speed = speed;
    }

    public override float GetDistance() {
        return _speed * (GetLength() / 60);
    }

    public override float GetSpeed() {
        return _speed;
    }

    public override float GetPace() {
        return 60 / _speed;
    }
}