using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    public class JetEngine: Engine
    {
        public JetEngine()
        {

        }

        public override void On()
        {
            // ジェットエンジンをオンにする為に必要な処理を書く。
        }

        public override void Off()
        {
            // ジェットエンジンを安全にオフにできる処理を書く。
        }

        public override int RotationalSpeed { get; }
    }
}
