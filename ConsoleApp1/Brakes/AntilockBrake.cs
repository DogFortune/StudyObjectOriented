using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    public class AntilockBrake: Brake
    {
        public override void On()
        {
            // ブレーキを作動させるための処理を書く。
            Console.WriteLine("ロックしないようにブレーキをかけます。");
        }

        public override void Off()
        {
            // ブレーキを離した時の処理を書く。
            Console.WriteLine("ブレーキを解除します。");
        }
    }
}
