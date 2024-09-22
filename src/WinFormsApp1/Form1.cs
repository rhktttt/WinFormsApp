namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Queue<LogBase> _logBuff;
        private static object _lock = new();

        private Task<bool> _logTask;
        private CancellationTokenSource _logCancel;

        public Form1()
        {
            InitializeComponent();

            _logBuff = [];
            _logCancel = new CancellationTokenSource();
            _logTask = Task.Run(() => LogTask(_logCancel.Token));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f = dgvActLog.DefaultCellStyle.Font;

            dgvActLog.DefaultCellStyle.Font = new Font(f.FontFamily, 9, f.Style);
            dgvActLog.RowHeadersVisible = false;
            dgvActLog.RowTemplate.Height = 20;

            dgvCommLog.DefaultCellStyle.Font = new Font(f.FontFamily, 9, f.Style);
            dgvCommLog.RowHeadersVisible = false;
            dgvCommLog.RowTemplate.Height = 20;

            AddLog("アプリケーション起動");
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logCancel.Cancel();
            _ = await _logTask;
        }

        private void AddLog(string message)
        {
            var log = new ActLog
            {
                Time = DateTime.Now,
                Message = message
            };

            lock (_lock)
            {
                _logBuff.Enqueue(log);
                //_logBuff.Add(log);
            }
        }

        private void AddLog(CommType type, string srcAddr, int srcPort, string dstAddr, int dstPort, string data)
        {
            var log = new CommLog
            {
                Time = DateTime.Now,
                CommType = type,
                SrcAddr = srcAddr,
                SrcPort = srcPort,
                DstAddr = dstAddr,
                DstPort = dstPort,
                Data = data
            };

            lock (_lock)
            {
                _logBuff.Enqueue(log);
                //_logBuff.Add(log);
            }
        }

        private LogBase? GetLog()
        {
            LogBase? log = null;
            _logBuff.TryDequeue(out log);
            return log;
#if false
            if (_logBuff.Count == 0)
            {
                return null;
            }

            LogBase? log = null;

            lock (_lock)
            {
                log = _logBuff.Dequeue();
                //log = _logBuff[0];
                //_logBuff.RemoveAt(0);
            }

            return log;
#endif
        }

        private void ShowLog(LogBase log)
        {
            if (log is ActLog actLog)
            {
                dgvActLog.Rows.Add(
                    dgvActLog.Rows.Count + 1,
                    actLog.Time.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                    actLog.Message
                );
            }

            if (log is CommLog commLog)
            {
                dgvCommLog.Rows.Add(
                    dgvCommLog.Rows.Count + 1,
                    commLog.Time.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                    commLog.CommType == CommType.Tx ? "送信" : "受信",
                    commLog.SrcAddr,
                    commLog.SrcPort,
                    commLog.DstAddr,
                    commLog.DstPort,
                    commLog.Data
                );

                var foreColor = commLog.CommType == CommType.Rx ? Color.Red : Color.Blue;
                dgvCommLog.Rows[dgvCommLog.Rows.Count - 1].DefaultCellStyle.ForeColor = foreColor;

                dgvActLog.Rows.Add(
                    dgvActLog.Rows.Count + 1,
                    commLog.Time.ToString("yyyy/MM/dd hh:mm:ss.fff"),
                    commLog.CommType == CommType.Rx ? "データ受信" : "データ送信"
                );
            }
        }

        private async Task<bool> LogTask(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    do
                    {
                        var log = GetLog();
                        if (log is null)
                        {
                            break;
                        }

                        Invoke(new Action(() => ShowLog(log)));

                    } while (true);
                }
                catch (Exception ex)
                {
                    AddLog($"{ex.StackTrace}");
                }

                await Task.Delay(100);
            }

            return true;
        }

        private void btnTx_Click(object sender, EventArgs e)
        {
            AddLog(CommType.Tx,
                    "2001:0000:1111:2222:3333:4444:5555:6666",
                    65535,
                    "2001:0000:1111:2222:3333:4444:5555:ABDD",
                    50000,
                    "12345678888888888888888888888888888888888888.");
        }

        private void btnRx_Click(object sender, EventArgs e)
        {
            AddLog(CommType.Rx,
                    "2001:0000:1111:2222:3333:4444:5555:6666",
                    65535,
                    "2001:0000:1111:2222:3333:4444:5555:ABDD",
                    50000,
                    "12345678888888888888888888888888888888888888.");
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            AddLog(txtLog.Text);
        }
    }
}
