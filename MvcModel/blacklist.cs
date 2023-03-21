using System;
using System.ComponentModel.DataAnnotations;

namespace MvcModel
{
    public class blacklistData
    {
        private int m_Id;
        private string m_thestr;
        private string m_thetime;

        public int Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string thestr
        {
            get { return this.m_thestr; }
            set { this.m_thestr = value; }
        }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string thetime
        {
            get { return this.m_thetime; }
            set { this.m_thetime = value; }
        }
    }
}
