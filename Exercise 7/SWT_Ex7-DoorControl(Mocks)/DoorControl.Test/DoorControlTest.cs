using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using DoorControlSystem;

namespace DoorControlTest
{
	// Test Fixture for the main (sunny-day) scenario
	[TestFixture]
	class RequestEntrySucceededTests 
	{
		//private MockDoor _mockDoor;
		//private MockBeeper _mockBeeper;
		//private MockAlarm _mockAlarm;
		//private MockCardDb _mockCardDb;
		private DoorControl _uut;

//		[SetUp]
//		public void Setup()
//		{
//			_mockDoor = new MockDoor();
//
//			_uut = new DoorControl(_mockFactory);
//		}


		[Test]
		public void RequestEntrySucceededTests_RequestingEntry_RequestAccepted()
		{	
			var _stubDoor = MockRepository.GenerateMock<IDoor>();
			var _stubBeeper = MockRepository.GenerateMock<IBeeper>();
			var _mockCardDb = MockRepository.GenerateMock<ICardDB>();

			_mockCardDb.Expect(
				x => x.ValidateEntryRequest(2)).Return(true);

			var d = new DoorControl(_mockCardDb, _stubDoor, _stubBeeper);
			d.RequestEntry(1);
			
			Assert.AreEqual(true, d.Request);
		}

//		[Test]
//		public void RequestEntrySucceededTests_RequestingEntry_DoorCloseNotCalled ()
//		{
//			_uut.RequestEntry(1);
//			Assert.AreEqual(_mockDoor.WasOpenCalled, true);
//		}





		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World! TEST");
		}
	}
}
