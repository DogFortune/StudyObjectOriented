﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    public class QuickHandle: Handle
    {
        public override void Right()
        {
            // ハンドルを右に切った時の処理を書く。
            Console.WriteLine("右に曲がります。");
        }

        public override void Left()
        {
            // ハンドルを左に切った時の処理を書く。
            Console.WriteLine("左に曲がります。");
        }
    }
}
