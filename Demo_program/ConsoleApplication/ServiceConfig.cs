using System;
using System.ComponentModel;
//using AIS.PAY.Framework.Util.WindowsServices.Configuration;

namespace ConsoleApplication
{
    [Serializable]
	public class ServiceConfig //: SqlServerTcpServiceConfiguration
    {
        private int m_HoursStart;
        private int m_MinutesStart;
        private int m_debugLevel;
        private string m_kkmType;
        private string m_kkmTypeConnect;
        private string m_kkmIPAddress;
        private int m_kkmPort;
        private int m_kkmTimeout;
        private int m_kkmTypeProtokol;

        private string m_url;
        private string m_login;
        private string m_password;
        private string m_codeGroup;
        private string m_inn;
        private string m_paymentAddr;
        private string m_emailCompany;
        private string m_nameServices;
	    private string m_callBackUrl;


        [Category("�������� �������� �����")]
        [Description("������ ���������. ���")]
        public int HoursStart
        {
            get { return m_HoursStart; }
            set { m_HoursStart = value; }
        }

        [Category("�������� �������� �����")]
        [Description("������ ���������. ������")]
        public int MinutesStart
        {
            get { return m_MinutesStart; }
            set { m_MinutesStart = value; }
        }

        [Category("���")]
        [Description("��� ���")]
        public string kkmType
        {
            get { return m_kkmType; }
            set { m_kkmType = value; }
        }

        [Category("���")]
        [Description("��� �����������")]
        public  string kkmTypeConnect // COM //TCP
        {
            get { return m_kkmTypeConnect; }
            set { m_kkmTypeConnect = value; }
        }


        [Category("���")]
        [Description("IP ����� ���")]
        public string kkmIPAddress
        {
            get { return m_kkmIPAddress; }
            set { m_kkmIPAddress = value; }
        }

        [Category("���")]
        [Description("���� ���")]
        public int kkmPort
        {
            get { return m_kkmPort; }
            set { m_kkmPort = value; }
        }

        [Category("���")]
        [Description("������� ���")]
        public int kkmTimeout
        {
            get { return m_kkmTimeout; }
            set { m_kkmTimeout = value; }
        }

        [Category("���")]
        [Description("��� ��������� ���")]
        public int kkmTypeProtokol
        {
            get { return m_kkmTypeProtokol; }
            set { m_kkmTypeProtokol = value; }
        }

        [Category("����-������")]
        [Description("URL")]
        public string url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        [Category("����-������")]
        [Description("Login")]
        public string login
        {
            get { return m_login; }
            set { m_login = value; }
        }

        [Category("����-������")]
        [Description("Password")]
        public string password
        {
            get { return m_password; }
            set { m_password = value; }
        }

        [Category("����-������")]
        [Description("��� ������")]
        public string codeGroup
        {
            get { return m_codeGroup; }
            set { m_codeGroup = value; }
        }

        [Category("����-������")]
        [Description("���")]
        public string inn
        {
            get { return m_inn; }
            set { m_inn = value; }
        }

        [Category("����-������")]
        [Description("����� ��������")]
        public string paymentAddr
        {
            get { return m_paymentAddr; }
            set { m_paymentAddr = value; }
        }

        [Category("����-������")]
        [Description("����� ��������")]
        public string emailCompany
        {
            get { return m_emailCompany; }
            set { m_emailCompany = value; }
        }

        [Category("����-������")]
        [Description("�������� ������")]
        public string nameServices
        {
            get { return m_nameServices; }
            set { m_nameServices = value; }
        }
    
        [Category("����-������")]
        [Description("Callback Url")]
        public string callBackUrl
        {
            get { return m_callBackUrl; }
            set { m_callBackUrl = value; }
        }

        [Category("����-������")]
        [Description("�������")]
        public int debugLevel
        {
            get { return m_debugLevel; }
            set { m_debugLevel = value; }
        }
    }
}