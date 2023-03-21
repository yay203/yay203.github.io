using System;
using System.ComponentModel.DataAnnotations;
namespace MvcModel
{
    public class commentData
    {
        private int m_Id;
        private string m_moduel;
        private string m_mid;
        private string m_userid;
        private string m_thedate;
        private string m_thescore;
        private string m_thecon;

        public int Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string moduel
        {
            get { return this.m_moduel; }
            set { this.m_moduel = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string mid
        {
            get { return this.m_mid; }
            set { this.m_mid = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string userid
        {
            get { return this.m_userid; }
            set { this.m_userid = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string thedate
        {
            get { return this.m_thedate; }
            set { this.m_thedate = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string thescore
        {
            get { return this.m_thescore; }
            set { this.m_thescore = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string thecon
        {
            get { return this.m_thecon; }
            set { this.m_thecon = value; }
        }
    }
}
