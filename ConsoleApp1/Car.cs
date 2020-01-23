using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    public class Car
    {
        public Car(Engine engine, Handle handle, Brake brake)
        {
            Engine = engine;
            Handle = handle;
            Brake = brake;
        }

        /// <summary>
        ///     車を動かせる状態にする。
        /// </summary>
        public void Start()
        {
            // ブレーキを解除する。
            Brake.Off();

            // エンジンをかける。
            Engine.On();
        }
        
        /// <summary>
        ///     右に曲がる。
        /// </summary>
        public void TurnLight()
        {
            Handle.Right();
        }

        /// <summary>
        ///     左に曲がる。
        /// </summary>
        public void TurnLeft()
        {
            Handle.Left();
        }

        /// <summary>
        ///     車を止める。
        /// </summary>
        public void Stop()
        {
            Brake.On();
            Engine.Off();
        }

        public Engine Engine { get; }
        public Handle Handle { get; }
        public Brake Brake { get; }

    }
}
