using System;

namespace mainProject
{
	public interface IEngine
	{
		uint MaxThrottle {get;}
		uint Throttle {set; get;} 
	}

	public class GasEngine : IEngine
	{
		private uint _currthrottle = 0; 
		private uint _maxthrottle = 0;

		public GasEngine(uint maxthrottle) {
				_maxthrottle = maxthrottle;
			}

		public uint MaxThrottle {
			get { return _maxthrottle; } 
		}

		public uint Throttle {
			set { _currthrottle = value; }
			get { return _currthrottle; } 
		}
	}

	public class DieselEngine : IEngine
	{
		private uint _currthrottle = 0; 
		private uint _maxthrottle = 0;
		
		public DieselEngine(uint maxthrottle) {
			_maxthrottle = maxthrottle;
		}
		
		public uint MaxThrottle {
			get { return _maxthrottle; } 
		}
		
		public uint Throttle {
			set { _currthrottle = value; }
			get { return _currthrottle; } 
		}
	}

	public class MotorBike
	{
		private IEngine _engine = null;
		public MotorBike(IEngine engine)
		{
			_engine = engine;
		}
		public void RunAtHalfSpeed() {
			_engine.Throttle = _engine.MaxThrottle / 2;
		}
	}
}