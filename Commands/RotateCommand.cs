using System;
using System.Globalization;

namespace MarcoAerlicRobotWars.Commands
{
    public class RotateCommand : InterfaceCommand
    {
        private const string rightCommand = "R";
        private const string leftCommand = "L";

        public bool Execute(char command, InterfaceWarRobot robot)
        {
            if (!this.IsValid(command))
            {
                return false;
            }

            this.ProcessCommand(command, robot);
            return true;
        }

        private void ProcessCommand(char command, InterfaceWarRobot robot)
        {
            string commandAsString = command.ToString(CultureInfo.InvariantCulture);
            if (this.IsLeftCommand(commandAsString))
            {
                robot.Rotate(false);
            }

            if (this.IsRightCommand(commandAsString))
            {
                robot.Rotate(true);
            }
        }

        private bool IsRightCommand(string command)
        {
            return command.Equals(rightCommand, StringComparison.InvariantCultureIgnoreCase);
        }

        private bool IsLeftCommand(string command)
        {
            return command.Equals(leftCommand, StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IsValid(char command)
        {
            string commandAsString = command.ToString(CultureInfo.InvariantCulture);
            return this.IsLeftCommand(commandAsString) 
                || this.IsRightCommand(commandAsString);
        }
    }
}