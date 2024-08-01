using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIoCContainer
{
    public class Car
    {
        public Car(IEngine engine)
        {
            this.Engine = engine;
        }
        public IEngine Engine { get; set; }
    }
}
