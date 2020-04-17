using System;
using UnityEngine;

namespace Behavioral.Visitor
{
    public class Client: MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                IRobotPart robot = new Robot();
                robot.Accept(new RobotPartActivateVisitor());
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                IRobotPart robot = new Robot();
                robot.Accept(new RobotPartShutdownVisitor());
            }
        }
    }
}