using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using expressmedia.robots.sdk;
using expressmedia.workers;
using NUnit.Framework;

namespace expressmedia.sdk.tests
{
    [TestFixture]
    public class RobotTest
    {
        /// <summary>
        /// Main test functions
        /// </summary>
        [Test]
        public void TestRobots()
        {
            WorkerStorage storage = new WorkerStorage();
            
            // creates a set of operations
            Worker worker = new Worker("Operation Set 1");    
            worker.RegisterCommand(new RobotCommand[]
            {
                new RobotBeepCommand(), 
                new RobotMoveCommand(1.0),
                new RobotTurnCommand(2.0),  
            });
            storage.RegisterWorker(worker);

            Assert.That(storage.GetWorker("Operation Set 1").Name, Is.EqualTo(worker.Name));

            worker = new Worker("Operation Set 2");
            worker.RegisterCommand(new RobotCommand[]
            {
                new RobotMoveCommand(1.0),
                new RobotBeepCommand(),
                new RobotTurnCommand(2.0),
                new RobotBeepCommand(),
                new RobotMoveCommand(3.0),
                new RobotMoveCommand(4.0),
                new RobotTurnCommand(5.0),
                new RobotBeepCommand()
            });
            storage.RegisterWorker(worker);

            Assert.That(storage.GetWorker("Operation Set 2").Name, Is.EqualTo(worker.Name));

            worker = new Worker("Operation Set 3");
            worker.RegisterCommand(new RobotCommand[]
            {
                new RobotBeepCommand(),
                new RobotMoveCommand(5.0),
                new RobotBeepCommand(),
                new RobotTurnCommand(4.0),
                new RobotBeepCommand(),
                new RobotMoveCommand(3.0),
                new RobotBeepCommand(),
                new RobotMoveCommand(2.0),
                new RobotBeepCommand(),
                new RobotTurnCommand(1.0),
                new RobotBeepCommand()
            });
            storage.RegisterWorker(worker);

            Assert.That(storage.GetWorker("Operation Set 5"), Is.EqualTo(null));

            // creates a set of robots and run operations
            List<IRobot> robots = new List<IRobot>();
            robots.AddRange(new IRobot[]
            {
                RobotFactory.CreateRobot("Robot1"),
                RobotFactory.CreateRobot("Robot2"),
                RobotFactory.CreateRobot("Robot3")
            });

            // run operations for robots
            List<Worker> operations = storage.GetWorkers();
            operations.ForEach(operation =>
            {
                robots.ForEach(operation.SendToRobot);
            });
        }


    }
}
