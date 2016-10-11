using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces101
{
    public interface IPencil
    {
        bool IsSharp { get; }
        string Message { get; set; }
        void OnSharpened();
        void Write();
    }
    public interface IPencilSharpener
    {
        void Sharpen(IPencil pencil);
    }
    public interface IUnderwaterBreathingAparatus
    {
    }
    public interface IOneShotGun
    {
        void Shoot();
    }
}