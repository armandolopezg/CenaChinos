using cenafilosofos;
using System.Threading;

namespace cenafilofos
{
    public partial class Form1 : Form
    {
        static sticks[] p = new sticks[5]; //creacion de arreglos

       static int comidas1 = 0;
       static int comidas2 = 0;
       static int comidas3 = 0; //declaracion de variables para los enumerar las comidas
       static int comidas4 = 0;
       static int comidas5 = 0;


        static Semaphore knuckles = new Semaphore (2,3); //declaracion de semaforo
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new sticks(); //creacion de funcion del for, esto establece el funcionamiento del programa
                p[i].id = i + 1;

            }

            ACenaLeFascina();
        }

        private void ACenaLeFascina()
        {
            Thread thread1 = new Thread(TeAmoDrake1);
            thread1.Start();

            Thread thread2 = new Thread(TeAmoDrake2);
            thread2.Start();

            Thread thread3 = new Thread(TeAmoDrake3); //creacion de hilos
            thread3.Start();

            Thread thread4 = new Thread(TeAmoDrake4);
            thread4.Start();


            Thread thread5 = new Thread(TeAmoDrake5);
            thread5.Start();


        }

        private void TeAmoDrake1()
        {

            knuckles.WaitOne(); //el semaforo queda en espera
            if (comidas1 == 5)  //se declara el numero de comidas que puede ingerir el filsofo
            {
              
                Invoke(new MethodInvoker(() =>
                {
                    lbl1.Text = "El filosofo se la comio"; //se hace el cambio de texto una vez que el filosofo llego a las 5 comidas
                }));
            }

            else
            {
                if (palillo1.ForeColor == Color.Black && palillo5.ForeColor == Color.Black) //si el palillo no se esta utilizando este cambia a color negro
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo1.ForeColor = Color.Red; //Cuando el palillo se ocupe este cambia a color rojo
                        palillo5.ForeColor = Color.Red;

                    }));

                    comidas1++; //cada que se inicie el proceso este registrara el numero de comidas +1
                    Thread.Sleep(5000); //tiempo que tardara el hilo en ser ejecutado, esto es de 5 seg
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo1.ForeColor = Color.Black;
                        palillo5.ForeColor = Color.Black; //si el palillo no se esta ocupando este cambiara a ser de color negro
                        lbl1.Text = comidas1.ToString();
                    }));
                }
         
            } knuckles.Release();//el semaforo se libera y hace su proceso
        }

        //Los mismos comentarios aplican para las funciones "TeAmoDrake2-5"
        private void TeAmoDrake2()
        {

            knuckles.WaitOne();
            if (comidas2 == 5)
            {

                Invoke(new MethodInvoker(() =>
                {
                    lbl2.Text = "El filosofo se la comio";
                }));
            }

            else
            {
                if (palillo2.ForeColor == Color.Black && palillo1.ForeColor == Color.Black)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo2.ForeColor = Color.Blue;
                        palillo1.ForeColor = Color.Blue;

                    }));

                    comidas2++;
                    Thread.Sleep(5000);
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo2.ForeColor = Color.Black;
                        palillo1.ForeColor = Color.Black;
                        lbl2.Text = comidas2.ToString();
                    }));
                }

            } knuckles.Release();
        }


        private void TeAmoDrake3()
        {

            knuckles.WaitOne();
            if (comidas3 == 5)
            {

                Invoke(new MethodInvoker(() =>
                {
                    lbl3.Text = "El filosofo se la comio";
                }));
            }

            else
            {
                if (palillo3.ForeColor == Color.Black && palillo2.ForeColor == Color.Black)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo3.ForeColor = Color.Green;
                        palillo2.ForeColor = Color.Green;

                    }));

                    comidas3++;
                    Thread.Sleep(5000);
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo3.ForeColor = Color.Black;
                        palillo2.ForeColor = Color.Black;
                        lbl3.Text = comidas3.ToString();
                    }));
                }

            } knuckles.Release();
        }

        private void TeAmoDrake4()
        {

            knuckles.WaitOne();
            if (comidas4 == 5)
            {

                Invoke(new MethodInvoker(() =>
                {
                    lbl4.Text = "El filosofo se la comio";
                }));
            }

            else
            {
                if (palillo4.ForeColor == Color.Black && palillo3.ForeColor == Color.Black)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo4.ForeColor = Color.Yellow;
                        palillo3.ForeColor = Color.Yellow;

                    }));

                    comidas4++;
                    Thread.Sleep(5000);
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo4.ForeColor = Color.Black;
                        palillo3.ForeColor = Color.Black;
                        lbl4.Text = comidas4.ToString();
                    }));
                }

            } knuckles.Release();
        }


        private void TeAmoDrake5()
        {

            knuckles.WaitOne();
            if (comidas5 == 5)
            {

                Invoke(new MethodInvoker(() =>
                {
                    lbl5.Text = "El filosofo se la comio";
                }));
            }

            else
            {
                if (palillo5.ForeColor == Color.Black && palillo4.ForeColor == Color.Black)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo5.ForeColor = Color.Violet;
                        palillo4.ForeColor = Color.Violet;

                    }));

                    comidas5++;
                    Thread.Sleep(5000);
                    Invoke(new MethodInvoker(() =>
                    {
                        palillo5.ForeColor = Color.Black;
                        palillo4.ForeColor = Color.Black;
                        lbl5.Text = comidas5.ToString();
                    }));
                }

            } knuckles.Release();
        }

    }
}

//