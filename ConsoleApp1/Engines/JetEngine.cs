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
            Console.WriteLine("ジェットエンジンを起動しました。");
        }

        public override void Off()
        {
            // ジェットエンジンを安全にオフにできる処理を書く。
            Console.WriteLine("ジェットエンジンを安全に止められました。");
        }

        public override int RotationalSpeed { get; }
    }
}
