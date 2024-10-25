
public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points) {
        _target = target;
        _bonus = bonus;
    }

    public void SetAmountCompleted(int amount) {
        _amountCompleted = amount;
    }

    public override int RecordEvent() {
        _amountCompleted += 1;
        if (IsComplete()) {
            return GetPoints() + _bonus;
        }
        else {
            return GetPoints();
        }
    }

    public override bool IsComplete() {
        if (_amountCompleted >= _target) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string GetGoalDisplay() {
        return $"{GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";   
    }

    public override string GetGoalFileDisplay() {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}