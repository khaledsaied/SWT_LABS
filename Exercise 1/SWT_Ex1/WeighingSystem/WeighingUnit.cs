
namespace WeighingSystem
{
    public class WeighingUnit
    {
        public WeighingUnit(Weight w)
        {
			Weight = w;
        }

        public double GetWeight()
        {
			switch(unit_)
			{
			case UnitKg: return ;
				break;
			case UnitLb: unit_ = UnitLb;
				break;
			case UnitOunces: unit_ = UnitOunces;
				break;
			case UnitGrams: unit_ = UnitGrams;
				break;
			default: unit_ = UnitGrams;
			}

            return 0.0;
        }

        public const uint UnitKg = 1, UnitLb = 2, UnitOunces = 3, UnitGrams = 4;

		public const uint unit_;

        public void SetUnit(uint unit)
        {
			switch(unit)
			{
				case UnitKg: unit_ = UnitKg;
					break;
				case UnitLb: unit_ = UnitLb;
					break;
				case UnitOunces: unit_ = UnitOunces;
					break;
				case UnitGrams: unit_ = UnitGrams;
					break;
				default: unit_ = UnitGrams;
			}
        }

        public uint GetUnit()
        {
            return unit_;
        }
    }
}
