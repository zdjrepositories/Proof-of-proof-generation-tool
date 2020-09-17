using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace 在校证明生成工具
{
    public partial class Form1 : Form
    {
        String path = System.IO.Directory.GetCurrentDirectory();//获取当前文件路径
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "\\学生数据库.mdb"); //Jet OLEDB:Database Password=
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\学生数据库.mdb
            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = " select count(*) from 学生表 where 学号='" + 学号.Text + "' ";
            int num = Convert.ToInt32(cmd.ExecuteScalar());
            if (num == 1)
            {
                cmd.CommandText = " select 姓名,班级  from 学生表 where 学号='" + 学号.Text + "';";
                OleDbDataReader myReader = cmd.ExecuteReader();
                myReader.Read();
                this.姓名.Text = Convert.ToString(myReader[0]);
                String str = null;
                if (Convert.ToString(myReader[1]).IndexOf("1") != -1)
                    str = Convert.ToString(myReader[1]).Substring(0, Convert.ToString(myReader[1]).IndexOf("1"));
                if (str.IndexOf("2") != -1)
                    str = str.Substring(0, str.IndexOf("2"));
                if (str.IndexOf("3") != -1)
                    str = str.Substring(0, str.IndexOf("3"));
                if (str.IndexOf("4") != -1)
                    str = str.Substring(0, str.IndexOf("4"));
                this.专业.Text = str;
                String stuID = 学号.Text;
                年级.Text = stuID.Substring(0, 4);
                if (stuID.Substring(4, 2).Equals("07"))
                {
                    系别.Text = "信息工程";
                }
                if (系别.Text.Equals("信息工程"))
                {
                    字.Text = "信工";
                }
                if (File.Exists(@path + "\\在校证明" + "\\拟稿"))
                {
                    System.IO.StreamReader s = File.OpenText(@path + "\\在校证明" + "\\拟稿"); //要打开的文本文件，如果跟程序不在一个目录，要包括路径
                    拟稿.Text = s.ReadLine();//读取一行，存放在变量read中
                    s.Close();
                }
                if (File.Exists(@path + "\\在校证明" + "\\班级"))
                {
                    System.IO.StreamReader s = File.OpenText(@path + "\\在校证明" + "\\班级"); //要打开的文本文件，如果跟程序不在一个目录，要包括路径
                    班级.Text = s.ReadLine();//读取一行，存放在变量read中
                    s.Close();
                }
                if (File.Exists(@path + "\\在校证明" + "\\签发"))
                {
                    System.IO.StreamReader s = File.OpenText(@path + "\\在校证明" + "\\签发"); //要打开的文本文件，如果跟程序不在一个目录，要包括路径
                    签发.Text = s.ReadLine();//读取一行，存放在变量read中
                    s.Close();
                }
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
            }
            else
            {
                MessageBox.Show("该学生不存在，请检查学号是否正确！");
            }
            if (this.编号.Text == null || this.编号.Text.Equals(""))
            {
                MessageBox.Show("请检查编号是否正确！");
            }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            yulan();
        }
        private void yulan()
        {
            String[] year = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
            String[] mooth = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二" };
            String[] day = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "十二", "十三", "十四", "十五", "十六", "十七", "十八", "十九", "二十", "二十一", "二十二", "二十三", "二十四", "二十五", "二十六", "二十七", "二十八", "二十九", "三十", "三十一" };
            String[] num = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
            String 学号 = this.学号.Text;
            String 姓名 = this.姓名.Text;
            String 系别 = this.系别.Text;
            String 专业 = this.专业.Text;
            String 年级 = this.年级.Text;
            String 班级 = this.班级.Text;
            String 字 = this.字.Text;
            String 拟稿 = this.拟稿.Text;
            String 签发 = this.签发.Text;
            int month=monthCalendar1.SelectionStart.Month;
            int year1=monthCalendar1.SelectionStart.Year;
            int day1 = monthCalendar1.SelectionStart.Day;
            String 时间 = year[year1%10] + "    " + mooth[month] + "    " + day[day1];
            String 编号 = this.编号.Text;
            int len = 编号.Length;
            int numid = Convert.ToInt32(编号);
            StringBuilder sb = new StringBuilder();
            while (numid != 0)
            {
                sb.Append(num[numid % 10]);
                numid = numid / 10;
            }
            char[] arrid = sb.ToString().ToCharArray();
            sb = new StringBuilder(); ;
            int x = arrid.Length;
            while (len != x)
            {
                sb.Append("零\r\n");
                x++;
            }
            for (int i = arrid.Length - 1; i >= 0; i--)
            {
                sb.Append(arrid[i] + "\r\n");
            }
            string 编号2 = sb.ToString();
            if (!Directory.Exists(path + "\\在校证明"))
            {
                Directory.CreateDirectory(path + "\\在校证明");

            }
            CreateImage(学号, 姓名, 系别, 专业, 班级, 年级, 时间, 编号, 编号2, 字, 拟稿, 签发);


        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (File.Exists(@path + "\\在校证明" + "\\" + this.学号.Text + this.编号.Text + ".jpg"))
            {
                PrintDialog MyPrintDg = new PrintDialog();
                MyPrintDg.Document = printDocument1;
                if (MyPrintDg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument1.DefaultPageSettings.Landscape = true;
                        printDocument1.Print();
                    }
                    catch
                    {   //停止打印
                        printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
                    }
                }

                if (!File.Exists(@path + "\\在校证明" + "\\拟稿"))
                {

                    FileStream fs1 = new FileStream(@path + "\\在校证明" + "\\拟稿", FileMode.Create, FileAccess.Write);//创建写入文件
                    StreamWriter sw1 = new StreamWriter(fs1);
                    sw1.WriteLine(this.拟稿.Text.Trim());//开始写入值
                    sw1.Close();
                    fs1.Close();

                }
                else
                {
                    FileStream fs1 = new FileStream(@path + "\\在校证明" + "\\拟稿", FileMode.Open, FileAccess.Write);
                    StreamWriter sr1 = new StreamWriter(fs1);
                    sr1.WriteLine(this.拟稿.Text.Trim());//开始写入值
                    sr1.Close();
                    fs1.Close();
                }

                if (!File.Exists(@path + "\\在校证明" + "\\签发"))
                {

                    FileStream fs2 = new FileStream(@path + "\\在校证明" + "\\签发", FileMode.Create, FileAccess.Write);//创建写入文件
                    StreamWriter sw2 = new StreamWriter(fs2);
                    sw2.WriteLine(this.签发.Text.Trim());//开始写入值
                    sw2.Close();
                    fs2.Close();

                }
                else
                {
                    FileStream fs2 = new FileStream(@path + "\\在校证明" + "\\签发", FileMode.Open, FileAccess.Write);
                    StreamWriter sr2 = new StreamWriter(fs2);
                    sr2.WriteLine(this.签发.Text.Trim());//开始写入值
                    sr2.Close();
                    fs2.Close();
                }
                if (!File.Exists(@path + "\\在校证明" + "\\班级"))
                {

                    FileStream fs3 = new FileStream(@path + "\\在校证明" + "\\班级", FileMode.Create, FileAccess.Write);//创建写入文件
                    StreamWriter sw3 = new StreamWriter(fs3);
                    sw3.WriteLine(this.班级.Text.Trim());//开始写入值
                    sw3.Close();
                    fs3.Close();

                }
                else
                {
                    FileStream fs3 = new FileStream(@path + "\\在校证明" + "\\班级", FileMode.Open, FileAccess.Write);
                    StreamWriter sr3 = new StreamWriter(fs3);
                    sr3.WriteLine(this.班级.Text.Trim());//开始写入值
                    sr3.Close();
                    fs3.Close();
                }



                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "\\学生数据库.mdb"); //Jet OLEDB:Database Password=
                //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\学生数据库.mdb
                OleDbCommand cmd1 = conn.CreateCommand();
                conn.Open();
                cmd1.CommandText = " select count(*) from 在校证明表 where 编号='" + this.编号.Text + "' ";
                int num = Convert.ToInt32(cmd1.ExecuteScalar());
                if (num == 1)
                {
                    MessageBox.Show("该编号已存在，请检查编号是否正确！");

                }
                else
                {
                    string sql = " INSERT INTO 在校证明表(编号,学号,姓名,班级)  VALUES( '" + this.编号.Text + "' , '" + this.学号.Text + "' , '" + this.姓名.Text + " ', '" + this.班级.Text + " ') ";
                    cmd1 = new OleDbCommand(sql, conn);
                    Console.WriteLine(sql);
                    int i = cmd1.ExecuteNonQuery();

                }
                cmd1.Dispose();
                conn.Close();
                conn.Dispose();
            }
           
        }
        int x = 3508;//
        int y = 2497;
        private void CreateImage(string 学号, string 姓名, string 系别, string 专业, string 班级, string 年级, string 时间, string 编号, string 编号2, string 字, string 拟稿, string 签发)
        {
            //判断字符串不等于空和null
            //f (content == null || content.Trim() == String.Empty)
            //  return;
            //创建一个位图对象
            Bitmap image = new Bitmap(3508, 2479);//2479x3508生成图片
            image.SetResolution(300, 300);

            //创建Graphics
            Graphics g = Graphics.FromImage(image);
            try
            {//清空图片背景颜色
                g.Clear(Color.White);
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Black, Color.DarkRed, 1.2f, true);

                Font font = new Font("楷体", 26f, (FontStyle.Bold));
                g.DrawString("在校证明", font, brush, x * 0.121f, y * 0.209f);

                font = new Font("方正小标宋简体", 24f, (FontStyle.Bold));
                g.DrawString("在 校 证 明", font, brush, x * 0.592f, y * 0.209f);

                font = new Font("仿宋_GB2312", 15f, (FontStyle.Bold));
                g.DrawString("兹有", font, brush, x * 0.06f, y * 0.352f);
                g.DrawString("系我院", font, brush, x * 0.19f, y * 0.352f);
                g.DrawString("系", font, brush, x * 0.14f, y * 0.422f);

                g.DrawString("级", font, brush, x * 0.24f, y * 0.422f);
                g.DrawString("专业", font, brush, x * 0.20f, y * 0.492f);
                g.DrawString("班学生。", font, brush, x * 0.15f, y * 0.562f);
                g.DrawString("（学号：", font, brush, x * 0.04f, y * 0.632f);
                g.DrawString("）", font, brush, x * 0.24f, y * 0.632f);
                //Font font = new Font("楷体", 27.5f, (FontStyle.Bold));

                font = new Font("仿宋_GB2312", 15f, (FontStyle.Bold));
                g.DrawString("兹有", font, brush, x * 0.46f, y * 0.352f);
                g.DrawString("系我院", font, brush, x * 0.64f, y * 0.352f);
                g.DrawString("系", font, brush, x * 0.84f, y * 0.352f);
                g.DrawString("级", font, brush, x * 0.49f, y * 0.422f);
                g.DrawString("专业", font, brush, x * 0.69f, y * 0.422f);
                g.DrawString("班", font, brush, x * 0.89f, y * 0.422f);
                g.DrawString("学生,（学号:", font, brush, x * 0.44f, y * 0.492f);
                g.DrawString("）。", font, brush, x * 0.70f, y * 0.492f);
                g.DrawString("特此证明！", font, brush, x * 0.44f, y * 0.632f);


                font = new Font("华文行楷", 36f, (FontStyle.Bold));
                g.DrawString(编号2, font, brush, x * 0.315f, y * 0.380f);

                font = new Font("楷体", 16f, (FontStyle.Bold));
                g.DrawString(姓名, font, brush, x * 0.120f, y * 0.353f);
                g.DrawString(姓名, font, brush, x * 0.523f, y * 0.353f);
                g.DrawString(系别, font, brush, x * 0.05f, y * 0.422f);
                g.DrawString(系别, font, brush, x * 0.700f, y * 0.352f);
                g.DrawString(班级, font, brush, x * 0.06f, y * 0.562f);
                g.DrawString(班级, font, brush, x * 0.79f, y * 0.422f);
                if (专业.Length > 8)
                {
                    font = new Font("楷体", 12f, (FontStyle.Bold));
                    专业 = 专业.Substring(0, 专业.Length / 2) + "\r\n" + 专业.Substring(专业.Length / 2, 专业.Length / 2);
                    g.DrawString(专业, font, brush, x * 0.045f, y * 0.494f);
                    g.DrawString(专业, font, brush, x * 0.525f, y * 0.420f);
                    font = new Font("楷体", 16f, (FontStyle.Bold));
                }
                else
                {
                    g.DrawString(专业, font, brush, x * 0.040f, y * 0.494f);
                    g.DrawString(专业, font, brush, x * 0.525f, y * 0.420f);
                }
                g.DrawString(年级, font, brush, x * 0.185f, y * 0.420f);
                g.DrawString(年级, font, brush, x * 0.450f, y * 0.423f);
                g.DrawString(学号, font, brush, x * 0.115f, y * 0.632f);
                g.DrawString(学号, font, brush, x * 0.580f, y * 0.490f);
                g.DrawString(拟稿, font, brush, x * 0.091f, y * 0.709f);
                g.DrawString(签发, font, brush, x * 0.185f, y * 0.709f);


                font = new Font("楷体", 12f, (FontStyle.Bold));
                g.DrawString(时间, font, brush, x * 0.128f, y * 0.808f);
                g.DrawString(时间, font, brush, x * 0.727f, y * 0.808f);
                g.DrawString(字, font, brush, x * 0.120f, y * 0.880f);
                g.DrawString(字, font, brush, x * 0.714f, y * 0.880f);
                g.DrawString(编号, font, brush, x * 0.211f, y * 0.880f);
                g.DrawString(编号, font, brush, x * 0.804f, y * 0.880f);

                //画图片的边框线
                image.Save(@path + "\\在校证明" + "\\" +this.学号.Text+this.编号.Text + ".jpg");
                pictureBox1.Load(@path + "\\在校证明" + "\\" +this.学号.Text+this.编号.Text + ".jpg");

            }
            catch (Exception exception)
            {

            }
            finally
            {
                image.Dispose();
                g.Dispose();
                image.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Dock != DockStyle.Fill)
            {
                pictureBox1.Dock = DockStyle.Fill;
            }
            else
            {
                pictureBox1.Dock = DockStyle.None;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap image = new Bitmap(@path + "\\在校证明" + "\\" +this.学号.Text+this.编号.Text + ".jpg");
            //e.Graphics.DrawImage(image, 3508, 2479);
            try
            {
                if (image != null)
                {
                    e.Graphics.DrawImage(image, 0, 0);
                    e.HasMorePages = false;
                }
            }
            catch (Exception exception)
            {

            }
        }

       

        private void 打开根目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@path);
            }
            catch
            {
                MessageBox.Show("打开失败，请检查软件是否完整！");
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            System.Environment.Exit(0);
        }

        private void 重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定重启？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.Environment.Exit(0);
            }
        }

       





    }
}
