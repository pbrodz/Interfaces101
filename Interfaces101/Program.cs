using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Interfaces101
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHuman foo = new MyHuman();
            Console.WriteLine(foo.MethodToOverride());
            Console.WriteLine(foo.IsIntelligent());
            Console.ReadLine();
            
            //IPencil p = new Pencil(20);
            //p.Message = "This pencil should not be dulled any time soon";
            //p.Write();
            //if (!p.IsSharp)
            //{
            //    PencilSharpener ps = new PencilSharpener();
            //    ps.Sharpen(p);
            //}
            //p.Message = "That's better";
            //p.Write();

            //if (p is BondPencil) Console.WriteLine("Mr Bond"); else Console.WriteLine("Mr Ordinary");

            //if (null != p as BondPencil) Console.WriteLine("Nope!");

            Human h = new Human();
            Console.WriteLine(h.IsIntelligent());

            Ostrich o = new Ostrich();
            Console.WriteLine(o.Flies());

            Console.ReadLine();

        }
    }

    public class MyHuman : BaseHuman
    {
        public override bool MethodToOverride()
        {
            return false;
        }
    }

    public class Pencil : IPencil
    {
        public Pencil(int countBeforeDull)
        {
            m_countBeforeDull = countBeforeDull;
            m_message = string.Empty;
            m_charsUsed = 0;
        }
        
        private string m_message;
        private int m_countBeforeDull;
        private int m_charsUsed;

        public string Message
        {
            get { return m_message; }
            set { m_message = value; }
        }
        public bool IsSharp
        {
            get { return m_countBeforeDull > m_charsUsed; }
        }
        public void Write()
        {
            foreach (char c in m_message)
            {
                if (IsSharp)
                    Console.Write(c);
                else
                    Console.Write('#');
                m_charsUsed++;
            }
            Console.WriteLine();
        }
        public void OnSharpened()
        {
            this.m_charsUsed = 0;
        }
    }
    public class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.OnSharpened();
        }
    }
    public class BondPencil : IPencil, IUnderwaterBreathingAparatus, IOneShotGun
    {
        private Pencil m_pencil;
        public BondPencil(Pencil pencil)
        {
            m_pencil = pencil;
        }
        public string Message
        {
            get { return m_pencil.Message; }
            set { m_pencil.Message = value; }
        }
        public bool IsSharp
        {
            get { return m_pencil.IsSharp; }
        }
        public void Write()
        {
            m_pencil.Write();
            if (!IsSharp) Console.WriteLine("Blows up killing the bad guy!");
        }
        public void OnSharpened()
        {
            m_pencil.OnSharpened();
        }
        public void Shoot()
        {
            Console.WriteLine("You shot the bad guy!!");
        }
    }
}