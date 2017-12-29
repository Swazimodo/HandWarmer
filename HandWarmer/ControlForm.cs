using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace HandWarmer
{
    public partial class ControlForm : Form
    {
        Stack<Tuple<Task, CancellationTokenSource>> _tasks = new Stack<Tuple<Task, CancellationTokenSource>>();

        public ControlForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// update slider bar based on current core count
        /// </summary>
        private void ControlForm_Load(object sender, EventArgs e)
        {
            lMax.Text = Environment.ProcessorCount.ToString();
            tbLevel.Maximum = Environment.ProcessorCount;
        }

        /// <summary>
        /// update CPU work load
        /// </summary>
        private async void tbLevel_Scroll(object sender, EventArgs e)
        {
            if(tbLevel.Value > _tasks.Count)
            {
                //add more cancellable tasks
                var ts = new CancellationTokenSource();
                CancellationToken ct = ts.Token;
                Task t = Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        //Check if cancel was requested
                        if (ct.IsCancellationRequested)
                            break;
                    }
                }, ct);

                _tasks.Push(new Tuple<Task, CancellationTokenSource>(t, ts));
            }
            else if(tbLevel.Value < _tasks.Count)
            {
                //cancel tasks
                Tuple<Task, CancellationTokenSource> workItem = _tasks.Pop();
                workItem.Item2.Cancel();
                await workItem.Item1;
            }
        }
    }
}
