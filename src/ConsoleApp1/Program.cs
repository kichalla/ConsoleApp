using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.Runtime;

namespace ConsoleApp1
{
    public class Program
    {
        private readonly IApplicationEnvironment _appEnv;

        public Program(IApplicationEnvironment appEnv)
        {
            _appEnv = appEnv;
        }

        public void Main(string[] args)
        {
            Console.WriteLine("Hello World!. Runtime:{0}", _appEnv.RuntimeFramework.ToString());
        }
    }
}
