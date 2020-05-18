using ByteBank.Employees;

namespace ByteBank
{
    public class BonusManager
    {
        private double _totalBonus;

        public void Record(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }
        
        public double GetTotalBonus()
        {
            return _totalBonus;
        }

    }
}
