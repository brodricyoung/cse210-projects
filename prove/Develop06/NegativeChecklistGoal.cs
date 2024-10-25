
public class NegativeChecklistGoal : Goal {
    private int _timesDone;
    private int _negativeTarget;
    private int _malus;

    public NegativeChecklistGoal(string name, string description, int negativePoints, int negativeTarget, int malus)
    : base(name, description, negativePoints) {
        _negativeTarget = negativeTarget;
        _malus = malus;
    }

    public void SetTimesDone(int amount) {
        _timesDone = amount;
    }

    public override int RecordEvent() {
        _timesDone += 1;
        if (IsComplete()) {
            return GetPoints() - _malus;
        }
        else {
            return GetPoints();
        }
    }

    public override bool IsComplete() {
        if (_timesDone >= _negativeTarget) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string GetGoalDisplay() {
        return $"{GetName()} ({GetDescription()}) -- Current progress: {_timesDone}/{_negativeTarget}";   
    }

    public override string GetGoalFileDisplay() {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_timesDone},{_negativeTarget},{_malus}";
    }
}