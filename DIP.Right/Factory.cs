﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Right
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IProject CreateProject()
        {
            return new Project(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter();
        }
    }
}
