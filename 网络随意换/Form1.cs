using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Management;
using System.Collections;
using System.Net.Sockets;
using System.Xml;

namespace 网络随意换
{
    public partial class Main : Form
    {
        public NetworkInterface[] adapters;
        public NetworkInterface adapterPublic;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetProjectInfo();
            GetNetWorkCardList();
            GetProxyInfo();
        }

        /// <summary>
        /// 获取Project信息  从config.xml文件中
        /// </summary>
        private void GetProjectInfo()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("config.xml");
            DataTable dt = ds.Tables["Record"];

            foreach (DataRow dr in dt.Rows)
            {
                lsbProjectList.Items.Add(dr["NAME"].ToString());
            }


            //XmlDocument doc = new XmlDocument();
            //doc.Load("config.xml");
            //XmlElement root = doc.DocumentElement;

            //XmlDocument dom = new XmlDocument();
            //dom.Load("config.xml");//装载XML文档 
            ////遍历所有节点 
            //int num = 0;
            //foreach (XmlElement birthday in dom.DocumentElement.ChildNodes)
            //{
            //    //读取数据 
            //    string type = birthday.SelectSingleNode("type").InnerText;
            //    string date = birthday.SelectSingleNode("date").InnerText;
            //    string title = birthday.SelectSingleNode("title").InnerText;
            //    string name = birthday.SelectSingleNode("name").InnerText;
            //    string text = name + ":" + title;//节点文字 
            //    string image = type;//节点图片 
            //    string data = num.ToString();//节点对应数据 
            //    num++;

            //    lsbProjectList.Items.Add(type);

            //}
           
        }

        /// <summary>
        /// 获取代理服务器信息
        /// </summary>
        private void GetProxyInfo()
        {
            string strProxyEnable;
             //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);
            strProxyEnable=rk.GetValue("ProxyEnable").ToString();
            if (strProxyEnable == "1")//启用代理
            {
                ckbProxy.Checked = true;

                string strProxyInfo=rk.GetValue("ProxyServer").ToString();
                txtProxyServer.Text = strProxyInfo.Split(':')[0].ToString();
                txtProxyServerPort.Text = strProxyInfo.Split(':')[1].ToString();
            }
            else
            {
 
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取网卡列表
        /// </summary>
        public void GetNetWorkCardList()
        {
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                //显示网络适配器描述信息、名称、类型、速度、MAC 地址   
                cmbNetworkCard.Items.Add(adapter.Description);
            }

        }

        private void cmbNetworkCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Description == cmbNetworkCard.SelectedItem.ToString())
                {                 
                    ShowNetworkInfo(adapter);
                    break;
                }
            }           
        }

        /// <summary>
        /// 显示当前网卡的网络配置信息
        /// </summary>
        private void ShowNetworkInfo(NetworkInterface adapter)
        {
            adapterPublic = adapter;

            IPInterfaceProperties ip = adapterPublic.GetIPProperties(); //IP配置信息  
            UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
            foreach (UnicastIPAddressInformation ipadd in ipCollection)
            {
                if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)//取IPV4地址
                {
                    txtIP.Text = ipadd.Address.ToString();//IP地址  
                    txtSubMark.Text = ipadd.IPv4Mask.ToString();//子网掩码  

                    txtDNS1.Text = ip.DnsAddresses[0].ToString(); //主DNS  
                    txtDNS2.Text = ip.DnsAddresses[1].ToString(); //备用DNS地址 
                }
            }
            if (ip.GatewayAddresses.Count > 0)
            {
                txtGateWay.Text = ip.GatewayAddresses[0].Address.ToString();//默认网关  
            }

      
            //int DnsCount = ip.DnsAddresses.Count;
            //if (DnsCount > 0)
            //{
            //    try
            //    {
            //        txtDNS1.Text = ip.DnsAddresses[0].ToString(); //主DNS  
            //        txtDNS2.Text = ip.DnsAddresses[1].ToString(); //备用DNS地址  
            //    }
            //    catch ()
            //    {
            //        //throw er;
            //    }
            //}
        }

        /// <summary>
        /// 设置代理服务器信息  向注册表中写入
        /// </summary>
        public void SetProxyInfo()
        {
            //打开注册表键 
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", true);

            if (ckbProxy.Checked == true)
            {
                //设置代理可用 
                rk.SetValue("ProxyEnable", 1);
                //设置代理IP和端口 
                rk.SetValue("ProxyServer", txtProxyServer.Text.ToString() + ":" + txtProxyServerPort.Text.ToString());
                rk.Close();
            }
            else
            {
                //设置代理不可用 
                rk.SetValue("ProxyEnable", 0);
            }


        }

        private void btnApplyProject_Click(object sender, EventArgs e)
        {
            SetProxyInfo();
        }    
    
    }
}
