using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Net.Sockets;
using System.Xml.Linq;
using static System.Windows.Forms.Design.AxImporter;
using Timer = System.Windows.Forms.Timer;


namespace aiearn
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            textBox4.TextChanged += (s, e) => { aiearn.Settings.Default.textBox4 = textBox4.Text;aiearn.Settings.Default.Save(); }; 
            textBox4.Text = aiearn.Settings.Default.textBox4;
            textBox3.Text = aiearn.Settings.Default.textBox3;
            textBox2.Text = aiearn.Settings.Default.textBox2;
            textBox1.Text = aiearn.Settings.Default.textBox1;
    
            textBox3.TextChanged += (s, e) => { aiearn.Settings.Default.textBox3 = textBox3.Text;aiearn.Settings.Default.Save(); }; 
            textBox2.TextChanged += (s, e) => { aiearn.Settings.Default.textBox2 = textBox2.Text;aiearn.Settings.Default.Save(); }; 
            textBox1.TextChanged += (s, e) => { aiearn.Settings.Default.textBox1 = textBox1.Text;aiearn.Settings.Default.Save(); };
          

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;

            lblTime.Text = "Thời gian đã chạy: " + elapsedTime.ToString(@"hh\:mm\:ss");

        }
        bool mtk = false;
        private Task seleniumTask;
        private IWebDriver driver;
        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;

            if (seleniumTask != null && !seleniumTask.IsCompleted)
            {
                MessageBox.Show("Luồng Selenium đang chạy!");
                return;
            }

            Random r = new Random();
            seleniumTask = Task.Run(async () =>
            {
            
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = "Bắt đầu chạy";
                    lblClick.Text = "Số khiên đã click: 0";
                    lblStartScore.Text = "Điểm ban đầu: 0";
                    lblAchieved.Text = "Điểm đã đạt: 0";
                    lblTime.Text = "Thời gian đã chạy: 00:00:00";
                }));
            oke:
                bool miz = false;
                mtk = true;
                try
                {
                    var account = File.ReadAllText("Input\\acc.txt");
                    string tk = account.Split('|')[0]??"", mk = account.Split('|')[1]??"";
                    if (1 == 1)
                    {
                        var chromeOptions = new ChromeOptions();
                        var chromeDriverService = ChromeDriverService.CreateDefaultService();
                        chromeDriverService.HideCommandPromptWindow = true;
                        chromeOptions.AddArgument("--disable-notifications");
                        chromeOptions.AddExcludedArgument("enable-automation");
                        chromeOptions.AddArgument("--disable-blink-features=BlockCredentialedSubresources");
                        chromeOptions.AddArgument("--mute-audio");
                        chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
                        chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 2);
                        chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.media_stream", 2);
                        chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.popups", 0);
                        chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                        chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
                        chromeOptions.AddArgument("--disable-infobars");
                        chromeOptions.AddArgument("--force-device-scale-factor=0.6");
                        chromeOptions.AddArgument("--use-fake-ui-for-media-stream");
                        chromeOptions.AddArgument("--use-fake-device-for-media-stream");
                        chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
                        chromeOptions.AddArgument("--use-gl=egl");
                        chromeOptions.AddArgument("--disable-images");
                        chromeOptions.AddAdditionalOption("useAutomationExtension", false);
                        chromeOptions.AddArgument("--disk-cache-size=0");
                        try
                        {
                            chromeOptions.AddArgument("--disable-features=DisableLoadExtensionCommandLineSwitch");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Lỗi khi thêm argument disable-features: " + ex.Message);
                        }
                        try
                        {
                            chromeOptions.AddExtension(Path.Combine(Application.StartupPath, "canvas.crx"));
                        }
                        catch { }
                        try
                        {
                            chromeOptions.AddExtension(Path.Combine(Application.StartupPath, "WbRTC.crx"));
                        }
                        catch { }
                        string userDataDir = Application.StartupPath + @"Profile";
                        //string userDataDir = @"C:\Users\manhc\AppData\Local\Google\Chrome\User Data\";
                        string profileDir = "Profile "+tk;
                        chromeOptions.AddArgument($@"--user-data-dir={userDataDir}");
                        chromeOptions.AddArgument($@"--profile-directory={profileDir}");
                        chromeOptions.AddArgument("--lang=en");
                        driver = new ChromeDriver(chromeDriverService, chromeOptions);
                    }
                    else
                    {
                        //string chromePath = GetChromePath(); string driverDir = System.IO.Path.GetDirectoryName(Application.StartupPath);

                        //string userDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google", "Chrome", "User Data");
                        //string profileDir = "Profile 2";
                        //string args = $"--remote-debugging-port=40461 " +
                        //              $"--user-data-dir=\"{userDataDir}\" " +
                        //              $"--profile-directory=\"{profileDir}\" " +
                        //              "--disable-notifications " +
                        //              "--disable-infobars " +
                        //              "--mute-audio " +
                        //              "--disable-blink-features=AutomationControlled";
                        //var process = Process.Start(new ProcessStartInfo
                        //{
                        //    FileName = chromePath,
                        //    Arguments = args,
                        //    UseShellExecute = false,
                        //    CreateNoWindow = true,
                        //    RedirectStandardOutput = true, // Chặn output console
                        //    RedirectStandardError = true // Chặn error console
                        //});
                        //var chromeDriverService = ChromeDriverService.CreateDefaultService(driverDir, "chromedriver.exe");
                        //chromeDriverService.HideCommandPromptWindow = true;
                        //chromeDriverService.SuppressInitialDiagnosticInformation = true;
                        //var chromeOptions = new ChromeOptions();
                        //chromeOptions.DebuggerAddress = "127.0.0.1:40461";
                        //chromeOptions.AddArgument("--remote-debugging-port=40461");
                        //chromeOptions.AddAdditionalOption("useAutomationExtension", false);
                        
                        //try {

                        //// 6️⃣ Attach Selenium driver
                        //var driver = new ChromeDriver(chromeDriverService, chromeOptions);

                        //MessageBox.Show("Đã kết nối với Chrome đang chạy. Vui lòng đảm bảo rằng Chrome đã được mở với các tùy chọn cần thiết.");

                        //// 7️⃣ Thử mở 1 trang web
                        //driver.Navigate().GoToUrl("https://www.google.com");
                        //}
                        //catch { }
                        //return;
                        //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                    }
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    driver.Navigate().GoToUrl("https://www.aiearn.co/");
                    while (true)
                    {
                        if (driver.Url == "https://www.aiearn.co/home/guess")
                        {
                            goto b1;
                        }
                        try
                        {
                            var masasas = driver.FindElement(By.XPath("//button[@id=\"menu-button-:r4:\"]/span/div/img")).GetAttribute("src");
                            if (masasas == "https://www.aiearn.co/img/flags/vi.svg")
                            {
                                break;
                            }
                            driver.FindElements(By.XPath("//button[@id='menu-button-:r4:']"))[0].Click();
                            _ = Task.Delay(r.Next(1000, 3500));
                            driver.FindElements(By.XPath("//img[@src=\"/img/flags/vi.svg\"]"))[0].Click();
                            _ = Task.Delay(r.Next(1000, 3500));
                            break;
                        }
                        catch { }
                        _ = Task.Delay(r.Next(1000, 3500));
                    }
                    while (true)
                    {
                        try
                        {
                            driver.FindElement(By.XPath("//button[text()='Bắt đầu']")).Click();
                            _ = Task.Delay(r.Next(1000, 3500));
                            break;
                        }
                        catch { }
                        _ = Task.Delay(r.Next(1000, 3500));
                    }
                    IWebElement usernameField = null;
                    while (usernameField == null)
                    {
                        try { usernameField = driver.FindElement(By.Name("username")); break; } catch { }
                        _ = Task.Delay(r.Next(1000, 3500));
                    }
                    foreach(var item in tk)
                    {
                        usernameField.SendKeys(item.ToString());
                        _ = Task.Delay(r.Next(100, 500));
                    }
             
                    _ = Task.Delay(r.Next(1000, 3500));
                    IWebElement passwordField = driver.FindElement(By.Name("password"));
                    foreach (var item in mk)
                    {
                        passwordField.SendKeys(item.ToString());
                        _ = Task.Delay(r.Next(100, 500));
                    }
                   
                    _ = Task.Delay(r.Next(2000, 3500));
                    IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Đăng nhập']"));
                    loginButton.Click();
                b1:
                    while (true)
                    {
                        try
                        {
                            foreach (var item in driver.FindElements(By.XPath("//button[@aria-label=\"Close\"]")))
                            {
                                try
                                {
                                    item.Click();
                                }
                                catch { }
                            }
                        }
                        catch { }
                        try
                        {
                            driver.FindElement(By.XPath("//img[@src=\"/img/noactivity.svg\"]")).Click();
                            _ = Task.Delay(r.Next(1000, 3500));
                            break;
                        }
                        catch { }
                        if (driver.Url == "https://www.aiearn.co/home/guess")
                        {
                            break;
                        }
                        _ = Task.Delay(r.Next(1000, 3500));
                    }
                    int dem = 2;
                    int dem1 = 0;
                b5:
                    driver.Navigate().GoToUrl("https://www.aiearn.co/home/vip");
                    while (true)
                    {
                        try
                        {
                            driver.FindElement(By.XPath("//div[@class='css-5ehbpw']"));
                            _ = Task.Delay(r.Next(1000, 3500));
                            break;
                        }
                        catch { }
                        _ = Task.Delay(r.Next(1000, 3500));
                        try
                        {
                            foreach (var item in driver.FindElements(By.XPath("//button[@aria-label=\"Close\"]")))
                            {
                                try { item.Click(); } catch { }
                            }
                        }
                        catch { }
                    }
                    try
                    {
                        foreach (var item in driver.FindElements(By.XPath("//button[@aria-label=\"Close\"]")))
                        {
                            try { item.Click(); } catch { }
                        }
                    }
                    catch { }
                    var xucu = driver.FindElement(By.XPath("//div[@style=\"line-height: 1;\"]")).Text.Replace("\r\n(0)", "");
                    try {
                        var m = int.Parse(xucu);
                    } catch {
                        Task.Delay(5000);
                        try {
                        xucu = driver.FindElement(By.XPath("//div[@style=\"line-height: 1;\"]/div")).Text;
                            var m = int.Parse(xucu);
                        }
                        catch { goto b5; }
                    }
                    this.Invoke((Action)(() =>
                    {
                        lblStartScore.Text = "Điểm ban đầu: " + xucu;
                        lblAchieved.Text = "Điểm đã đạt: 0";
                        lblTime.Text = "Thời gian đã chạy: 00:00:00";
                    }));
                    Invoke(new Action(() =>
                    {
                        stopwatch = new Stopwatch();
                        stopwatch.Start();
                        timer.Start();
                    }));
                    try { driver.FindElement(By.XPath("//div[@class=\"css-5ehbpw\"]")).Click(); } catch { }
                    try { driver.FindElement(By.XPath("//td[@class=\"css-g3rg8x\"]")).Click(); } catch { }
                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                    _ = Task.Delay(r.Next(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
                    driver.FindElement(By.XPath("//div[@aria-label=\"kích thước trang\"]")).Click();

                    while (true)
                    {
                        try
                        {
                            driver.FindElement(By.XPath("//div[text()='100 / trang']")).Click();
                            break;
                        }
                        catch (Exception)
                        {


                        }
                    }


                    while (mtk)
                    {
                        int min=int.Parse(textBox1.Text);
                        int max= int.Parse(textBox2.Text);
                        int m1= int.Parse(textBox3.Text);
                        int m2= int.Parse(textBox4.Text);
                        try { driver.FindElement(By.XPath("//div[@class=\"css-5ehbpw\"]")).Click(); } catch { }
                        try { driver.FindElement(By.XPath("//td[@class=\"css-g3rg8x\"]")).Click(); } catch { }
                        try { driver.FindElement(By.XPath("//div[@class=\"css-qarrqj\"]")).Click(); } catch { }
                        try { driver.FindElements(By.XPath("//img[@src=\"/assets/lightning-f6b8ee5c.svg\"]"))[1].Click(); } catch { }
                        try
                        {
                            if (driver.FindElement(By.XPath("//li[@class=\"ant-pagination-total-text\"]")).Text == "0 Tổng số hồ sơ")
                            {
                                this.Invoke(new Action(() =>
                                {
                                    lblStatus.Text = "Mất kết nối";
                                }));
                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    lblStatus.Text = "Bắt đầu";
                                }));
                            }
                        }
                        catch
                        {
                            if (driver.FindElement(By.XPath("//li[@class=\"antdark-pagination-total-text\"]")).Text == "0 Tổng số hồ sơ")
                            {
                                this.Invoke(new Action(() =>
                                {
                                    lblStatus.Text = "Mất kết nối";
                                }));
                            }
                            else
                            {
                                this.Invoke(new Action(() =>
                                {
                                    lblStatus.Text = "Bắt đầu";
                                }));
                            }
                        }
                        List<IWebElement> listelement = new List<IWebElement>();
                    b345:
                        js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                        var m = driver.FindElements(By.XPath("//div[@class='css-5ehbpw' and @style='filter: none;']"));
                        foreach (var item in m)
                        {
                        b2:
                            try
                            {
                                if (listelement.Contains(item))
                                {
                                    continue;
                                }
                                item.Click();
                                _=Task.Delay(r.Next(100, 500));
                                js.ExecuteScript("arguments[0].setAttribute('style', 'filter: grayscale(100%);')", item);
                                listelement.Add(item);
                                this.Invoke(new Action(() =>
                                {
                                    lblClick.Text = "Số khiên đã click: " + (dem1++).ToString();
                                }));
                            }
                            catch
                            {
                                js.ExecuteScript("arguments[0].scrollIntoView(false);", item);
                                try
                                {
                                    try
                                    {
                                        int offset = 80;
                                        js.ExecuteScript($"window.scrollBy(0, arguments[0].getBoundingClientRect().top - {offset});", item);
                                    }
                                    catch { }

                                    //js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", item);

                                }
                                catch { }

                                goto b2;
                            }
                            await Task.Delay(r.Next(min, max));
                        }
                        m = null;
                        m = driver.FindElements(By.XPath("//div[@class='css-5ehbpw' and @style='filter: none;']"));
                        if (m.Count > 0)
                        {
                            foreach (var item in m)
                            {
                                if (listelement.Contains(item))
                                {
                                    js.ExecuteScript("arguments[0].setAttribute('style', 'filter: grayscale(100%);')", item);
                                }
                            }
                            m = driver.FindElements(By.XPath("//div[@class='css-5ehbpw' and @style='filter: none;']"));
                            if (m.Count > 0)
                            {
                                goto b345;
                            }
                            else { }
                        }
                        js.ExecuteScript("window.scrollTo(0, 0);");
                        try
                        {
                            try { driver.FindElement(By.XPath("//div[@class=\"css-qarrqj\"]")).Click(); } catch { }

                            try
                            { 
                                if(driver.FindElement(By.XPath("//div[@class=\"css-5ehbpw\"]")).GetAttribute("style")== "filter: none;")
                                {
                                    js.ExecuteScript("window.scrollTo(0, 0);");
                                    await Task.Delay(r.Next(100, 3500));
                                    driver.FindElement(By.XPath("//div[@class=\"css-5ehbpw\"]")).Click();
                                    try { driver.FindElement(By.XPath("//div[@class=\"css-qarrqj\"]")).Click(); } catch { }
                                    try { driver.FindElements(By.XPath("//img[@src=\"/assets/lightning-f6b8ee5c.svg\"]"))[1].Click(); } catch { }
                                }
                            
                            } catch { }
                            try {
                                if (driver.FindElement(By.XPath("//div[@class=\"css-5ehbpw\"]")).GetAttribute("style") == "filter: none;") 
                                {
                                    js.ExecuteScript("window.scrollTo(0, 0);");
                                    await Task.Delay(r.Next(1000, 3500));
                                    driver.FindElement(By.XPath("//td[@class=\"css-g3rg8x\"]")).Click();
                                    try { driver.FindElement(By.XPath("//div[@class=\"css-qarrqj\"]")).Click(); } catch { }
                                    try { driver.FindElements(By.XPath("//img[@src=\"/assets/lightning-f6b8ee5c.svg\"]"))[1].Click(); } catch { }
                                }
                            } catch { }
                            var xumoia = driver.FindElement(By.XPath("//div[@style=\"line-height: 1;\"]")).Text.Replace("\r\n(0)", "");
                            int maa = int.Parse(xumoia) - int.Parse(xucu.Replace("\r\n(0)", ""));
                            this.Invoke(new Action(() =>
                            {
                                label1.Text = "Điểm sau khi chạy:" + xumoia;
                                lblAchieved.Text = "Điểm đã đạt: " + maa;

                            }));
                        }
                        catch { }
                        js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
                        await Task.Delay(r.Next(m1, m2));
                        try
                        {
                            js.ExecuteScript("arguments[0].scrollIntoView(false);", driver.FindElement(By.XPath($"//li[@title='{dem}']")));
                            driver.FindElement(By.XPath($"//li[@title='{dem}']")).Click();

                            dem++;
                        }
                        catch { dem = 1; }
                     
                    }
                    js.ExecuteScript("window.scrollTo(0, 0);");
                    try { driver.FindElement(By.XPath("//div[@class=\"css-qarrqj\"]")).Click(); } catch { }
                    try { driver.FindElements(By.XPath("//img[@src=\"/assets/lightning-f6b8ee5c.svg\"]"))[1].Click(); } catch { }
                    var xumoi = driver.FindElement(By.XPath("//div[@style=\"line-height: 1;\"]")).Text.Replace("\r\n(0)", "");
                    int ma = int.Parse(xumoi) - int.Parse(xucu.Replace("\r\n(0)", ""));
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = "Điểm sau khi chạy: " + xumoi;
                        lblAchieved.Text = "Điểm đã đạt: " + ma;

                    }));
     
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "Lỗi: " + ex.Message;
                    }));
                    File.AppendAllText("log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Lỗi: " + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine);
                    //MessageBox.Show("Lỗi: " + ex.Message+"===>"+ex.StackTrace);
                    miz = true;
                   
                }
                if (miz)
                {
                    try
                    {
                        using (Process process = Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            Arguments = "/C Taskkill /F /IM chrome.exe /T & Taskkill /F /IM chromedriver.exe /T",
                            RedirectStandardOutput = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }))
                        {
                            string value = process.StandardOutput.ReadToEnd();
                            process.WaitForExit();
                            Console.WriteLine(value);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Không thể kill các process. Lỗi: " + ex.Message);
                    }
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "Chạy lại";
                    }));
                    goto oke;
                }
            });

        }
        string GetChromePath()
        {
            var paths = new[]
            {
        @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe",
        @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe"
    };

            using (var key = Registry.LocalMachine.OpenSubKey(paths[0]))
            {
                if (key?.GetValue("") is string path1 && File.Exists(path1))
                    return path1;
            }

            using (var key = Registry.CurrentUser.OpenSubKey(paths[1]))
            {
                if (key?.GetValue("") is string path2 && File.Exists(path2))
                    return path2;
            }

            return null;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                mtk = false;
                timer.Stop(); stopwatch.Stop();
                lblStatus.Text = "Đã dừng";
            }
            catch { }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss"); // Hiển thị giờ:phút:giây
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
