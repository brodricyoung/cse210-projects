
public class Activity {
    private string _date;
    private string _name;
    private float _length;

    public Activity(string date, string name, float length) {
        _date = date;
        _name = name;
        _length = length;
    }

    public virtual float GetDistance() {
        return 0;
    }

    public virtual float GetSpeed() {
        return 0;
    }

    public virtual float GetPace() {
        return 0;
    }

    public float GetLength() {
        return _length;
    }

    public string GetSummary() {

        return $"{_date} {_name} ({_length} min) -- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}