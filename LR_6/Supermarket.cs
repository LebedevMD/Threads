using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace LR_6
{
    public partial class Supermarket : Form
    {
        Thread QueueThread; //Поток очереди
        Thread Cashbox_1; //Поток 1 касса
        Thread Cashbox_2; //Поток 2 касса
        Thread Cashbox_3; //Поток 3 касса
        Thread Routing; //Поток маршрутизации людей
        Thread refresh; //Поток счётчика покупателей

        int CountServed; //Счётчик кол-ва обслуженных гостей
        Stopwatch Stopwatch; //Секундомер работы программы

        public Supermarket()
        {
            InitializeComponent();
        }

        private void Supermarket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.startWindow.Close();
            Stopwatch.Stop();
            if (QueueThread.IsAlive) QueueThread.Abort();
            if (Routing.IsAlive) Routing.Abort();
            if (refresh.IsAlive) refresh.Abort();
            if (Cashbox_1.IsAlive) Cashbox_1.Abort();
            if (Cashbox_2.IsAlive) Cashbox_2.Abort();
            if (Cashbox_3.IsAlive) Cashbox_3.Abort();
        }

        private void Supermarket_Load(object sender, EventArgs e)
        {
            CountServed = 0;
            InitializeCashboxes(); //Инициализация касс
            GoQueue(); //Запуск работы очереди
            GoRoutingVisitors(); //Запуск маршрутизации по кассам            

            //Запуск секундомера
            Stopwatch = new Stopwatch();
            Stopwatch.Start();
            timer1.Start(); //Запуск обновления счётчика времени
        }

        //Запуск очереди
        private void GoQueue()
        {
            QueueThread = new Thread(new ThreadStart(() => 
            {
                while (true)
                {
                    string Name = GetVisitorName();
                    Action action = () => listBoxQueue.Items.Add(Name);
                    Invoke(action);
                    RefreshCountQueue();
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(1000, 3000));
                }
            }));
            QueueThread.Start();
        }

        //Генерация имени нового посетителя
        private string GetVisitorName()
        {
            string[] Names = { "Александр", 
                "Павел", "Егор", "Максим", "Алёна", 
                "Ирина", "Григорий", "Михаил", "Милана", 
                "Мария", "Марина", "Илья", "Татьяна", 
                "Ольга", "Елизавета", "Арина",
                "Кирилл", "Константин", "Алексей"};
            Random rnd = new Random();
            string visitorName = string.Format("{0} ({1})", Names[rnd.Next(Names.Length)], rnd.Next(1000));
            return visitorName;
        }

        //Запуск первой кассы
        private void GoFirstCashbox(string Visitor)
        {
            Cashbox_1 = new Thread(new ThreadStart(() =>
            {
                if (Visitor != null)
                {
                    Action action = () =>
                    {
                        labelVisitorFirstCash.Text = Visitor;
                    };
                    Invoke(action);
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(1000, 10000));
                    RefreshCountServed();
                    action = () => labelVisitorFirstCash.Text = "Свободно";
                    Invoke(action);
                }
            }
            ));
            Cashbox_1.Start();
        }

        //Запуск второй кассы
        private void GoSecondCashbox(string Visitor)
        {
            Cashbox_2 = new Thread(new ThreadStart(() =>
            {
                if (Visitor != null)
                {
                    Action action = () =>
                    {
                        labelVisitorSecondCash.Text = Visitor;
                    };
                    Invoke(action);
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(1000, 10000));
                    RefreshCountServed();
                    action = () => labelVisitorSecondCash.Text = "Свободно";
                    Invoke(action);
                }
            }
            ));
            Cashbox_2.Start();
        }

        //Запуск третьей кассы
        private void GoThirdCashbox(string Visitor)
        {
            Cashbox_3 = new Thread(new ThreadStart(() =>
            {
                if (Visitor != null)
                {
                    Action action = () =>
                    {
                        labelVisitorThirdCash.Text = Visitor;
                    };
                    Invoke(action);
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(1000, 10000));
                    RefreshCountServed();
                    action = () => labelVisitorThirdCash.Text = "Свободно";
                    Invoke(action);
                }
            }
            ));
            Cashbox_3.Start();
        }

        //Обновление счётчика обсуженных покупателей
        private void RefreshCountServed()
        {
            refresh = new Thread(new ThreadStart(() => 
            {
                Action action = () =>
                {
                    CountServed++;
                    labelCountServed.Text = CountServed.ToString();
                };
                Invoke(action);
            }));
            refresh.Start();
        }

        //Инициализация потоков
        private void InitializeCashboxes()
        {
            GoFirstCashbox(null);
            GoSecondCashbox(null);
            GoThirdCashbox(null);
            RefreshCountServed();
        }

        //Запуск маршрутизации очереди
        private void GoRoutingVisitors()
        {        
            Routing = new Thread(new ThreadStart(() =>
            {
                while (true)
                    if (listBoxQueue.Items.Count > 0)
                    {
                        string Visitor = "";
                        Action action = () =>
                        {
                            Visitor = listBoxQueue.Items[0].ToString();
                        };
                        Invoke(action);
                        while (true)
                        {
                            if (!Cashbox_1.IsAlive)
                            {
                                GoFirstCashbox(Visitor);
                                break;
                            }     
                            if (!Cashbox_2.IsAlive)
                            {
                                GoSecondCashbox(Visitor);
                                break;
                            }
                            if (!Cashbox_3.IsAlive)
                            {
                                GoThirdCashbox(Visitor);
                                break;
                            }
                        }
                        action = () =>
                        {
                            listBoxQueue.Items.RemoveAt(0);
                        };
                        Invoke(action);
                        RefreshCountQueue();
                    }       
            }));
            Routing.Start();
        }

        //Обновление счётчика очереди
        private void RefreshCountQueue()
        {
            Action action= () => labelCountQueue.Text = listBoxQueue.Items.Count.ToString();
            Invoke(action);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelWorkTime.Text = string.Format("{0:00}:{1:00}", Stopwatch.Elapsed.Minutes, Stopwatch.Elapsed.Seconds);
        }
    }
}