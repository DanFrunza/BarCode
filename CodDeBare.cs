using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodDeBare
{
    internal class CodDeBare
    {
        public String s;
        public String sFinal;
        Color c=Color.Black;
        Color f=Color.White;
        int C;

        public CodDeBare(string s,Color c)
        {
            this.s = s;
            this.c = c;
            if(this.c==Color.White)
            {
                this.f = Color.Black;
            }
        }

        public void deseneaza(Graphics g)
        {
            Point x = new Point(100, 10);
            Point y = new Point(100, 100);
            int simpar = 0;
            int spar = 0;
            int c;

            for (int i=0;i<s.Length;i++)
            {
                if(i%2==1)
                {
                    String cc = null;
                    cc += s[i];
                    simpar+=int.Parse(cc);
                }

                if (i % 2 == 0)
                {
                    String cc = null;
                    cc += s[i];
                    spar += int.Parse(cc);
                }

                spar *= 3;

                int suma = spar + simpar;
                for(int j=0;i<=9;i++)
                {
                    if((suma+i)%10==0)
                    {
                       this.C = i;
                        break;
                    }
                }

            }
            this.sFinal = "0" + this.s + this.C.ToString();
            g.Clear(this.f);
            for(int i=0;i<sFinal.Length;i++)
            {
                String gg = null;
                gg += sFinal[i];
                int n= int.Parse(gg);


                switch (n)
                {
                    case 0:
                        deseneaza0(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 1:
                        deseneaza1(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 2:
                        deseneaza2(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 3:
                        deseneaza3(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 4:
                        deseneaza4(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 5:
                        deseneaza5(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 6:
                        deseneaza6(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 7:
                        deseneaza7(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 8:
                        deseneaza8(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;
                    case 9:
                        deseneaza9(g, x, y);
                        x.X += 30;
                        y.X += 30;
                        break;




                }




            }


           


        }

        public void deseneaza0(Graphics g,Point x,Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);

        }

        public void deseneaza1(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);

        }

        public void deseneaza3(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);

        }

        public void deseneaza2(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);

        }

        public void deseneaza4(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);

        }

        public void deseneaza5(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);

        }

        public void deseneaza6(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);

        }

        public void deseneaza7(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);

        }

        public void deseneaza8(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);
            x.X += 5;
            y.X += 5;
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);

        }

        public void deseneaza9(Graphics g, Point x, Point y)
        {
            Pen pen1 = new Pen(this.c, 2);
            Pen pen2 = new Pen(this.c, 5);
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7; 
            g.DrawLine(pen1, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen2, x, y);
            x.X += 7;
            y.X += 7;
            g.DrawLine(pen1, x, y);

        }

    }
}
